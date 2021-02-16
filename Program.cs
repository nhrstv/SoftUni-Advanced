using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(songs);
            string command = Console.ReadLine();
            while(true)
            {
                if (songsQueue.Count <= 0)
                {
                    Console.WriteLine("No more songs!");
                    break;

                }
                string[] cmdArgs = command.Split();
                if(cmdArgs[0]=="Play")
                {
                    songsQueue.Dequeue();
                }
                if(cmdArgs[0]=="Add")
                {
                    if(!songsQueue.Contains(cmdArgs[1]))
                    {
                        songsQueue.Enqueue(cmdArgs[1]);
                    }
                }
                else
                {
                    Console.WriteLine($"{cmdArgs[1]} is already contained!");
                }
                if(cmdArgs[0]=="Show")
                {
                    Console.WriteLine(String.Join(", ",songsQueue.ToArray()));
                }
              
                command = Console.ReadLine();

            }
        }
    }
}
