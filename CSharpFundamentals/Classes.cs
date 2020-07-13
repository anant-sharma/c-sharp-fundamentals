using System;
namespace CSharpFundamentals
{
    public class Classes
    {
        public int Id;
        public string Name;

        //Default Constructor
        public Classes()
        {
        }

        // Overload Constructor
        public Classes(int id)
        {
            this.Id = id;
        }

        // Overload Constructor with exchange control flow
        // this(id) will call `public Classes(int id)`
        public Classes(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
