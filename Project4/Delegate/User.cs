using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Delegate
{
    public class User
    {
        public delegate string MyDelegate(string username);
        public string AcseptName(string name)
        {
            string n = "Ananta";
            Console.WriteLine(n.ToUpper());
            return n;

        }
        static void Main(string[] args)
        {
            User user = new User();
            MyDelegate myDelegate=new MyDelegate( user.AcseptName);
            string result = myDelegate.Invoke("Ananta");
            Console.WriteLine(result);
        }
        
        

    }
}
