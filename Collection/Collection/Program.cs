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
        if (dictionary == null)
        {
            throw new ArgumentNullException(nameof(dictionary));
        }

        if (dictionary.ContainsKey("scuba") && dictionary["scuba"] == 6)
        {
            dictionary.Add("diver", 6);
        }
    }

    public void ListOperations(List<string> list)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list.Count != 0 && list.Count % 2 == 1)
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
        if (stack == null)
        {
            throw new ArgumentNullException(nameof(stack));
        }

        if (stack.Count == 0 || stack.Peek() < DateTime.Now)
        {
            stack.Push(DateTime.Now);
        }
    }
}

