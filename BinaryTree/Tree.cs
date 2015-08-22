using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Leaf
    {
        public Card Card;
        public Leaf Left;
        public Leaf Right;
        public Leaf(Card card)
        {
            this.Card = card;
            this.Left = null;
            this.Right = null;
        }
    }
    class Tree
    {
        private Leaf root;
        private int counter;
        public Tree()
        {
            this.root = null;
            this.counter = 0;
        }
        public void Add(Leaf leaf)
        {
            if(this.IsEmpty())
            {
                this.root = leaf;
                return;            
            }

            Leaf current = this.root;
            Leaf previous = null;

            while(current != null)
            {
                previous = current;

                if (leaf.Card.Name.CompareTo(current.Card.Name) > 0)
                    current = current.Right;
                else
                    current = current.Left;
            }

            if (leaf.Card.Name.CompareTo(previous.Card.Name) > 0)
                previous.Right = leaf;
            else
                previous.Left = leaf;
        }
        private Leaf Search(Leaf leaf, String name)
        {
            this.counter++;
            if (leaf == null)
                return leaf;
            if (leaf.Card.Name == name)
                return leaf;
            if (leaf.Card.Name.CompareTo(name) > 0)
                return this.Search(leaf.Left, name);
            if (leaf.Card.Name.CompareTo(name) < 0)
                return this.Search(leaf.Right, name);
            return null;
        }
        public Leaf Search(String name)
        {
            this.counter = 0;
            return this.Search(this.root, name);
        }
        private void InOrder(Leaf leaf)
        {
            if(leaf != null)
            {
                this.InOrder(leaf.Left);
                leaf.Card.Write();
                this.InOrder(leaf.Right);
            }
        }
        public void InOrder()
        {
            this.InOrder(this.root);
        }
        public Boolean IsEmpty()
        {
            return this.root == null;
        }

        public void Write()
        {
            Console.WriteLine(this.counter);
        }
    }
}
