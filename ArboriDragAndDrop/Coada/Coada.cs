using ArboriDragAndDrop.Coada.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Coada
{
    public class Coada<T> : ICoada<T> where T : IComparable<T>
    {

        private Node<T> head = null;

        public Node<T> getHead() { return head; }

        public void pop()
        {
            Node<T> aux = head;

            while (aux.Next.Next != null)
            {

                aux = aux.Next;

            }

            aux.Next = null;

        }

        public void push(T value)
        {

            if (head == null)
            {
                head = new Node<T>();

                head.Value = value;
                head.Next = null;
            }
            else
            {

                Node<T> nou = new Node<T>();

                nou.Value = value;
                nou.Next = head;
                head = nou;
            }

        }

        public bool empty()
        {
            if (head == null) return true;
            return false;
        }

        public T top()
        {
            Node<T> aux = head;

            while (aux.Next != null)
            {
                aux = aux.Next;
            }

            return aux.Value;

        }

        public void afisare()
        {
            Node<T> aux = head;

            while (aux != null)
            {
                Console.WriteLine(aux.Value.ToString());
                aux = aux.Next;
            }

        }

    }
}
