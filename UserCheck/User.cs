using System;
using System.Xml.Linq;

namespace UserCheck
{
	public class User
	{
		public string Name { get; set; }
        public string Password { get; set; }

        public User()
		{
            AccountCreate();
        }

		public virtual void AccountCreate()
		{
			Console.WriteLine("Hello, write your user name please");
			Name = Console.ReadLine();
            Console.WriteLine("Yep, name was saved.");

            Console.WriteLine("Now time for your password(must be eight symbols min).");
            string code = Console.ReadLine();

            while (code.Length < 8)
            {
                Console.WriteLine("Password must be eight symbols min, write your password again please");


                if (code.Length >= 8)
                {
                    Console.WriteLine("Great, confrim password please.");
                    string confrim = Console.ReadLine();

                    while (confrim != code)
                    {
                        Console.WriteLine("Code not right, try again:(");
                        confrim = Console.ReadLine();

                        if (confrim == code)
                        {
                            confrim = Password;
                            Console.WriteLine("Great, your password saved!.");
                            break;
                        }
                    }

                }
            }
        }
	}
}

