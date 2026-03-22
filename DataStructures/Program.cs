using MyLinkedList;
using MyBinaryTree;

namespace MainProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(10);
            stack.Push(20);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());


            MyQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());


            // BINARY TREE
            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);

            Console.WriteLine("\nTree (InOrder):");
            foreach (var item in tree)
            {
                Console.Write(item + " ");
            }

            // Remove one element
            tree.Remove(3);

            Console.WriteLine("\nAfter remove:");
            foreach (var item in tree)
            {
                Console.Write(item + " ");
            }



        }
    }
}