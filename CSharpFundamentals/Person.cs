using System;

namespace CSharpFundamentals
{
    public enum CustomerType
    {
        Bronze,
        Silver,
        Gold
    }

    class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    class PersonInit
    {
        public static void Do()
        {
            var type = (int)CustomerType.Bronze;
            Console.WriteLine(type);

            Console.WriteLine("Hello World!");

            Person person = new Person();
            person.FirstName = "Anant";
            person.LastName = "Sharma";

            person.Introduce();
        }
    }
}
