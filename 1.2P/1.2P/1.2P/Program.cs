using System;

namespace _1._2P
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message MyMessage;
            String name;
            Message[] messages = new Message[5];
            // Print message to the screen
            MyMessage = new Message("Hello World ");

            MyMessage.Print();

            // Assign message[i] to the text

            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name ");
            messages[2] = new Message("Great name!");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("That is a silly name");

            Console.WriteLine("Enter name: ");
            
             name = Console.ReadLine();

           //name cases
            
            switch (name.ToLower())
            {
                case "mark":
                    messages[0].Print();
                    break;
                case "fred":
                    messages[1].Print();
                    break;
                case "wilma":
                    messages[2].Print();
                    break;
                case "alice":
                    messages[3].Print();
                    break;
                default:
                    messages[4].Print();
                    break;
            }
            Console.ReadLine();

            // Cases of possible name                 
            //switch (messages[i])
            //{
            //    case "Mark":
            //        MyMessage = new Message(a[i] + ", Welcome back!");
            //        break;
            //    case "Fred":
            //        MyMessage = new Message(a[i] + ", What a lovely name");
            //        break;
            //    case "Wilma":
            //        MyMessage = new Message(a[i] + ", Great name");
            //        break;
            //    case "Alice":
            //        MyMessage = new Message(a[i] + ", Oh hi!");
            //        break;
            //    default:
            //        MyMessage = new Message(a[i] + ", That is a silly name");
            //        break;





            //            name = Console.ReadLine();
            //// Split the array with space for counting length
            //            string[] a = name.Split(' ');
            //            int len = a.Length;
            //// For loop from 0 to len             
            //            for (int i = 0; i < len; i++)
            //            {
            //// Cases of possible name                 
            //                switch (a[i])
            //                {
            //                    case "Mark":
            //                        MyMessage = new Message(a[i] +", Welcome back!");
            //                        break;
            //                    case "Fred":
            //                        MyMessage = new Message(a[i] + ", What a lovely name");
            //                        break;
            //                    case "Wilma":
            //                        MyMessage = new Message(a[i] + ", Great name");
            //                        break;
            //                    case "Alice":
            //                        MyMessage = new Message(a[i] + ", Oh hi!");
            //                        break;
            //                    default:
            //                        MyMessage = new Message(a[i] + ", That is a silly name");
            //                        break;

            //                }
            //                Console.WriteLine();
            //                MyMessage.Print();

            //            }

            //            Console.ReadLine();
        }
    }
}

