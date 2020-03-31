using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanko3
{
    class Dog : IDog<Dog>
    {
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; set; }

        public string getName()
        {
            return Name;
        }

        public int getAge()
        {
            return Age;
        }

        public void setAge(int age)
        {
            Age = age;
        }

        int IDog<Dog>.setAge(int age)
        {
            throw new NotImplementedException();
        }
    }

}
