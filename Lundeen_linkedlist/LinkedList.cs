using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lundeen_linkedlist
{
    class LinkedList
    {
        private Node _head = null;
        private Node Current;

        public LinkedList() { }
        public LinkedList(Node H)
        { _head = H; }
        
        public Node getFirst()
        { // Returns a reference to the first node; if no first, return null
            return _head;
        }
        public void addFirst(Node newNode)
        {// Add a new node to the front of the list
            newNode.Next = _head;
            _head = newNode;
        }
        public Node Contains(string match)
        {// Returns a node with a matching item if no match, return null
            Current = _head;
            while (Current != null)
            {
                if(Current.Data.ToLower().Contains(match.ToLower()))
                { return Current; }
                Current = Current.Next;
            }
            return null;
        }
        public void Remove(string match)
        {// Removes node containing the item and links the two adjacent nodes together
            Current = _head;
            if(Current.Data.Contains(match))
            {
                if(Current.Next != null)
                {
                    _head = Current.Next;
                    return;
                } else
                {
                    _head = null;
                    return;
                }
            }
            while (Current.Next != null)
            {
                if (Current.Next.Data.ToLower().Contains(match.ToLower())) // very long
                {
                    if (Current.Next.Next == null)
                    {
                        Current.Next = null;
                    } else
                    {// should dereference what is originally in current.next, turning it to null would be hard
                        Current.Next = Current.Next.Next; 
                    }
                    return; // in case there are multiple
                }
                Current = Current.Next;
            }
            Program.Print("No nodes containing " + match + " were found.");
            Program.Wait();
            
        }
        public void Add(Node newNode)
        {// Adds a node to the end of the list
            Current = _head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode; 
        }
        public void PrintAllNodes()
        {// Prints the entire list front to back
            if(_head == null)
            {
                Program.Print("No nodes in list");
                Program.Wait();
                return;
            }
            Current = _head;
            int NodeCount = 1;

            while (Current != null)
            {
                Program.Print(NodeCount +": " + Current.Data);
                Current = Current.Next;
                NodeCount++;
            }
            Program.Wait();
        }
    }
}
