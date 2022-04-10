using System;

namespace SingleLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singly = new SinglyLinkedList();
            InsertFornt(singly, 2);
            InsertFornt(singly, 3);
            InsertFornt(singly, 4);

            InsertLast(singly, 5);
            DeleteNodebyKey(singly, 3);
            DeleteNodebyKey(singly, 4);

        }

        public class Node
        {
            internal int Data;
            internal Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class SinglyLinkedList
        {
            internal Node Head;
        }

        public static void InsertFornt(SinglyLinkedList singlyLinked, int newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = singlyLinked.Head;
            singlyLinked.Head = newNode;
        }

        public static void InsertLast(SinglyLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.Head == null)
            {
                singlyList.Head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.Next = new_node;
        }

        public static Node GetLastNode(SinglyLinkedList singlyList)
        {
            Node temp = singlyList.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public static void DeleteNodebyKey(SinglyLinkedList singlyList, int key)
        {
            Node temp = singlyList.Head;
            Node prev = null;
            if (temp != null && temp.Data == key)
            {
                singlyList.Head = temp.Next;
                return;
            }
            while (temp != null && temp.Data != key)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return;
            }
            prev.Next = temp.Next;
        }
    }
}
