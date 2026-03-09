using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SON_QueueImplementation
{
    // Queue Class
    public class Queue
    {
        private Clothes front;
        private Clothes rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        // Enqueue
        public void Enqueue(string name, string brand)
        {
            Clothes newNode = new Clothes(name, brand);

            if (IsEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            Console.WriteLine($"Item '{name}' added to the queue.");
        }

        // Dequeue
        public string Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Error: Cannot dequeue from an empty queue.");
            }

            string data = front.Name;
            front = front.Next;

            if (front == null)
                rear = null;

            return data;
        }

        // Peek
        public string Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty.");
            }

            return front.Name;
        }

        // Display Queue
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Clothes current = front;

            Console.WriteLine("Queue Contents:");
            while (current != null)
            {
                Console.Write($"[{current.Name}-{current.Brand}] -> ");
                current = current.Next;
            }

            Console.WriteLine("NULL");
        }
    }
}