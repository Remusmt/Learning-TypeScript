using System;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public BinaryTree Left { get; private set; }
        public BinaryTree Right { get; private set; }
        public int Data { get; private set; }
        public BinaryTree() { }
        public BinaryTree(int data)
        {
            Data = data;
        }
        public void Insert(int data)
        {
            if (Data > data)
            {
                //add to the left
                if (Left == null)
                {
                    //Create left node
                    Left = new BinaryTree(data);
                }
                else
                {
                    // Recursively add left node
                    Left.Insert(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinaryTree(data);
                }
                else
                {
                    Right.Insert(data);
                }
            }
        }

        public void PrintInOrder()
        {
            if (Left != null)
                Left.PrintInOrder();
            UInt32 ddd = 0;
            Console.WriteLine(Data.ToString());

            if (Right != null)
                Right.PrintInOrder();
        }
    }
}
