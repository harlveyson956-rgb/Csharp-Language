using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_QueueImplementation
{
    internal class Program
    {
        // Main Program       
            static void Main(string[] args)
            {
                Queue myQueue = new Queue();
                int choice;

                Console.WriteLine("=== Simple Queue Management System ===");

                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Enqueue (Add Clothes)");
                    Console.WriteLine("2. Dequeue (Remove Clothes)");
                    Console.WriteLine("3. Peek (View Front)");
                    Console.WriteLine("4. Display Queue");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter choice: ");

                    try
                    {
                        if (!int.TryParse(Console.ReadLine(), out choice))
                            throw new Exception("Invalid number.");

                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter Clothes Name: ");
                                string name = Console.ReadLine();

                                Console.Write("Enter Brand: ");
                                string brand = Console.ReadLine();

                                myQueue.Enqueue(name, brand);
                                break;

                            case 2:
                                Console.WriteLine("Removed: " + myQueue.Dequeue());
                                break;

                            case 3:
                                Console.WriteLine("Front Item: " + myQueue.Peek());
                                break;

                            case 4:
                                myQueue.Display();
                                break;

                            case 5:
                                Console.WriteLine("Goodbye!");
                                return;

                            default:
                                Console.WriteLine("Choose between 1-5.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
