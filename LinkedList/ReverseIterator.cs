using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public bool hasPrevious()
        {
            return currentNode != null;
        }

        public int previous()
        {
            int data = currentNode.getData();

            currentNode = currentNode.getPrevious();

            return data;
        }

        Node getCurrentNode()
        {
            return currentNode;
        }
    }
}
