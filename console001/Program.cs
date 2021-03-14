using System;

namespace console001
{
    class Program
    {
        static void Main(string[] args)
        {
            Repyo repyo = new Repyo();
            string messageFromRepyo = repyo.EatPotechi();
            Console.WriteLine(messageFromRepyo);

            // messageFromRepyo = repyo.EatPotechi(10.5f);
            string result = repyo.EatPotechi(10.5f);
            Console.WriteLine(result);

            messageFromRepyo = repyo.EatPotechi(200, false);
            Console.WriteLine(messageFromRepyo);
        }
    }
}
