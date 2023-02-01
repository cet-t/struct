using System;
using System.Collections.Generic;

class struct
{
    struct User
    {
        public int age;
        public double height;

        public User(int _age, double _height)
        {
            this.age = _age;
            this.height = _height;
        }
    }

    public static void Main()
    {
        User cet = new(18, 175.0);
        Console.WriteLine($"{cet.age}, {cet.height}");
    }
}