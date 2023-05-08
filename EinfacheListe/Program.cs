namespace EinfacheListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<string> list = new SimpleList<string>();

            list.Enqueue("a");
            list.Enqueue("b");
            list.Enqueue("c");
            list.Enqueue("d");

            Console.WriteLine(list.Count());
            Console.WriteLine(list.Search("c"));
            Console.WriteLine(list.Search("z"));

            string[] arr = new string[list.Count()];
            arr = list.Array();
            Console.WriteLine(arr[1]);

            list.Dequeue("d");
            Console.WriteLine(list.Count());

            try
            {
                Console.WriteLine(list[1]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}