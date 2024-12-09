namespace _6_linkedlist_length;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;

        foreach (int item in myLList)
        {
            count++;
        }
        return count;
    }
}
