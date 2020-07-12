using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class ListExercise
    {
        public static void Init()
        {
            List<string> users = new List<string> { };

            Boolean keepReading = true;
            do
            {
                Console.WriteLine("Please Enter Name");
                String n = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(n))
                {
                    keepReading = false;
                    break;
                }

                users.Add(n);
            } while (keepReading);

            Int32 userCount = users.Count;
            var uString = "";
            switch (userCount)
            {
                case 1:
                    uString = users[0];
                    break;
                case 2:
                    uString = String.Format("{0} and {1}", users[0], users[1]);
                    break;
                default:
                    uString = String.Format("{0}, {1} and {2} others", users[0], users[1], userCount - 2);
                    break;
            }

            Console.WriteLine(uString + " like your post");
        }
    }
}
