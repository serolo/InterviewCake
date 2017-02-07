/*
Exercise 24

Hooray! It's opposite day. Linked lists go the opposite way today.
Write a function for reversing a linked list ↴ . Do it in-place ↴ .

Your function will have one input: the head of the list.

Your function should return the new head of the list.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListNode list = new LinkedListNode(1);
            list.AppendToTail( 2 );
            list.AppendToTail( 3 );
            list.AppendToTail( 4 );
            list.AppendToTail( 5 );

            list.PrintElements();
            
            list = ReverseLinkedList( list );
            
            Console.WriteLine("---------------------");
            
            list.PrintElements();
        }

        /*
            Time Complexity: O(n^2)
            Space Complexity: O(1)
        */
        public static LinkedListNode ReverseLinkedList ( LinkedListNode headOfList ) {
            LinkedListNode next = null;
            LinkedListNode prev = null;
            
            while( headOfList != null ) {
                next = headOfList.Next;
                headOfList.Next = prev;
                prev = headOfList;
                
                headOfList = next;
            }

            return prev;
        }
    }

    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int d)
        {
            Value = d;
            Next = null;
        }

        public void AppendToTail( int d ) {
            LinkedListNode end = new LinkedListNode( d );
            LinkedListNode n = this;
            while( n.Next != null ) {
                n = n.Next;
            }
            n.Next = end;
        }

        public void PrintElements() {
            LinkedListNode n = this;
            while (n.Next != null) {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
            Console.WriteLine(n.Value);
        }
    }
}