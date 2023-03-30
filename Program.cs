namespace BinarySearchTreeProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Hash Table and Bst problem*****");
            BinarySearchTree<int> obj = new BinarySearchTree<int>(56);
            obj.Add(30);
            obj.Add(70);
            obj.Display();
        }
    }
}