using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node top;
       
        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }





        public void Add(int value)
        {
            if (top == null)
            {
                Node NewNode = new Node(value);
                top = NewNode;
                return;
            }
            Node Currentnode = top;
            bool added = false;
            do
            {
                if (value<Currentnode.value)
                {
                    if (Currentnode.left==null)
                    {
                        Node NewNode = new Node(value);
                        Currentnode.left = NewNode;
                        added = true;
                    }else
                    {
                        Currentnode = Currentnode.left;
                    }
                }
                if (value>=Currentnode.value)
                {
                    if (Currentnode.right==null)
                    {
                        Node newNode = new Node(value);
                        Currentnode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        Currentnode = Currentnode.right;
                    }
                }

            } while (!added);
        }
        public void AddRC(int value)
        {
            AddR(ref top, value);

        }
        private void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node NewNode = new Node(value);
                N = NewNode;
                return;
            }
            if (value<N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            if (value >= N.value)
            {
                AddR(ref N.right,value);
                return;
            }

        }



        public void DisplayTree(Node N ,ref string s)
        {
            if (N == null) { N = top; }
            if (N.left !=null)
            {
                DisplayTree(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }else
            {
                s = s + N.value.ToString().PadLeft(3);
            }
            if (N.right !=null)
            {
                DisplayTree(N.right, ref s);
            }
           
        }













    }
}
