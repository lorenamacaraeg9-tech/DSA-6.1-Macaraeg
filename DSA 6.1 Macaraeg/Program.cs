/*
DSA Activity 6.1 - [Macaraeg, Lorena]
Queues
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> jobs = new Queue<string>();
        int choice;

        do
        {
            Console.WriteLine("\n===== JOB QUEUE SYSTEM =====");
            Console.WriteLine("1 - ADD JOB");
            Console.WriteLine("2 - PROCESS JOB");
            Console.WriteLine("3 - CHECK NEXT JOB");
            Console.WriteLine("4 - CURRENT JOB");
            Console.WriteLine("5 - DISPLAY ALL JOBS");
            Console.WriteLine("0 - EXIT");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter job name: ");
                    string job = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(job))
                    {
                        jobs.Enqueue(job);
                        Console.WriteLine("Job added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Job name cannot be empty.");
                    }
                    break;

                case 2:
                    if (jobs.Count > 0)
                    {
                        Console.WriteLine("Processed job: " + jobs.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("No jobs to process.");
                    }
                    break;

                case 3:
                    if (jobs.Count > 0)
                    {
                        Console.WriteLine("Next job: " + jobs.Peek());
                    }
                    else
                    {
                        Console.WriteLine("No jobs in the queue.");
                    }
                    break;

                case 4:
                    if (jobs.Count > 0)
                    {
                        Console.WriteLine("Current job: " + jobs.Peek());
                    }
                    else
                    {
                        Console.WriteLine("No current job.");
                    }
                    break;

                case 5:
                    if (jobs.Count > 0)
                    {
                        Console.WriteLine("\nAll Jobs:");

                        foreach (string item in jobs)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No jobs in the queue.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 0);
    }
}
