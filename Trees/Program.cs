namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(25);
            tree.Insert(22);
            tree.Insert(13);

            tree.Insert(32);
            tree.Insert(31);
            tree.Insert(35);
            tree.Insert(3);
            tree.Insert(1);
            Console.WriteLine(tree.DoesValueExist(3));
            Console.WriteLine(tree.DoesValueExist(9));
        }
    }
}
