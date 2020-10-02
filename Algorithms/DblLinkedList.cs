using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Algorithms
{

    public class DblLinkedList
    {
        private Node node;

        private DblLinkedList next;
        private DblLinkedList prev;


        public DblLinkedList(Node n)
        {
            this.node = n;
        }


        public Node getNode()
        {
            return node;
        }

        public void setNode(Node n)
        {
            this.node = n;
        }

        public DblLinkedList getNext()
        {
            return next;
        }

        public DblLinkedList getPrev()
        {
            return prev;
        }

        public void setNext(DblLinkedList n)
        {
            this.next = n;
        }

        public void setPrev(DblLinkedList n)
        {
            this.prev = n;
        }

    }
}
