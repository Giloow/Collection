public interface ICollectionOperations
{
    void ListOperations(List<string> list);

    void DictionaryOperations(Dictionary<string, int> dictionary);

    void StackOperations(Stack<DateTime> stack);
}

public class Collection : ICollectionOperations
{
    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
        throw new NotImplementedException();
    }

    public void ListOperations(List<string> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException();
        }

        if (list.Count != 0)
        {
            list.RemoveAt(list.Count / 2);
        }

        if (list.Contains("mamas"))
        {
            list.Add(6.ToString());
        }

        if (list.IndexOf("course59") != -1 && list.IndexOf("course59") % 2 == 1)
        {
            list.Reverse();
        }

        if (list.Distinct<string>().Count() == 3)
        {
            list.InsertRange(2, new List<string>{ "2" , "3" , "4"});
        }
    }

    public void StackOperations(Stack<DateTime> stack)
    {
        throw new NotImplementedException();
    }
}

