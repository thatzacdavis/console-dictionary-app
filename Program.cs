using System;

namespace ConsoleDictionaryApp
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
                    DataLayer.AddMemberByKey(inputs[1], inputs[2]);
                    AcceptInput();
                    break;
                case "KEYS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.GetAllKeys();
                    AcceptInput();
                    break;
                case "MEMBERS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.GetAllMembersByKey(inputs[1]);
                    AcceptInput();
                    break;
                case "REMOVE":
                    NotifyValidAction(inputs[0]);
                    DataLayer.RemoveMemberByKey(inputs[1], inputs[2]);
                    AcceptInput();
                    break;
                case "REMOVEALL":
                    NotifyValidAction(inputs[0]);
                    DataLayer.RemoveKey(inputs[1]);
                    AcceptInput();
                    break;
                case "CLEAR":
                    NotifyValidAction(inputs[0]);
                    DataLayer.ClearDictionary();
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
                case "ALLMEMBERS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.GetAllMembers(inputs[1]);
                    AcceptInput();
                    break;
                case "ITEMS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.GetAllItems();
                    AcceptInput();
                    break;
                case "COMMONMEMBERS":
                    NotifyValidAction(inputs[0]);
                    DataLayer.GetCommonMembersForKeys(inputs[1], inputs[2]);
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
        }
    }
}
