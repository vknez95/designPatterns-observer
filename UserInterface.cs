using System;

namespace observer
{
    public class UserInterface
    {
        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine("Hey user, look at {0}", data.ToUpper());
        }
    }
}