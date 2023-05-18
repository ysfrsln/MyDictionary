namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Yusuf");
            myDictionary.Add(2, "Engin");
            myDictionary.Add(3, "Kemal");
            myDictionary.Add(4, "Mehmet");
            myDictionary.Add(5, "Osman");

            myDictionary.T1s();

            myDictionary.T2s();

            Console.WriteLine(myDictionary.Count);
        }
    }
}