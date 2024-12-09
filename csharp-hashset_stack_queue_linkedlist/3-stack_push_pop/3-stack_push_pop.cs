using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
        {
            Console.WriteLine($"Top Item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains {search}: {containsSearch}");

        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            while (aStack.Count > 0)
            {
                string topItem = aStack.Pop();
                if (topItem == search)
                {
                    break;
                }
                tempStack.Push(topItem);
            }
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }
        aStack.Push(newItem);

        return aStack;
    }
}
