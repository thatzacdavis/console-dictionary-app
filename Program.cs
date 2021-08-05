using System;

namespace console_dictionary_app
{
    class Program
    {
        static void NotifyValidAction(string action) 
        {
            Console.WriteLine("Valid Action Entered: " + action);
        }

        static void NotifyNewAction(string action) 
        {
            Console.WriteLine("Enter a new action to proceed or EXIT to end your session..");
        }

        static void AcceptInput()
        {
            Console.WriteLine("Enter a valid action to proceed.");

            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            switch (inputs[0])
            {
                case "ADD":
                    NotifyValidAction(inputs[0]);
                    DataLayer.Add(inputs[1], inputs[2]);
                    AcceptInput();
                    break;
                case "KEYS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.Keys();
                    AcceptInput();
                    break;
                case "MEMBERS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.Members(inputs[1]);
                    AcceptInput();
                    break;
                case "REMOVE":
                    NotifyValidAction(inputs[0]);
                    DataLayer.Remove(inputs[1], inputs[2]);
                    AcceptInput();
                    break;
                case "REMOVEALL":
                    NotifyValidAction(inputs[0]);
                    DataLayer.RemoveAll(inputs[1]);
                    AcceptInput();
                    break;
                case "CLEAR":
                    NotifyValidAction(inputs[0]);
                    DataLayer.Clear();
                    AcceptInput();
                    break;
                case "KEYEXISTS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.KeyExists(inputs[1]);
                    AcceptInput();
                    break;
                case "MEMBEREXISTS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.MemberExists(inputs[1], inputs[2]);
                    AcceptInput();
                    break;
                case "EXIT":
                    NotifyValidAction(inputs[0]);
                    Console.WriteLine("Exiting application...");
                    break;
                default:
                    Console.WriteLine("Invalid Action Entered");
                    break;
            }
        }

        static void Main(string[] args)
        {
            AcceptInput();

            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true);

            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true);
        }
    }
}
