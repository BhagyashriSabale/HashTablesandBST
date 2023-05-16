namespace HashTablesandBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Hashtable and BST Programming");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index values: " + hash5);
        }
    }
}