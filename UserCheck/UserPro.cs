using System;
namespace UserCheck
{
	public class UserPro : User
	{
		public string Email { get; set; }
		public int PostCode { get; set; }

		public UserPro() : base()
		{
			AccountCreate();
		}

        public override void AccountCreate()
        {
            base.AccountCreate();
			EmailCreate();
			PostCodeCreate();

        }

		public void EmailCreate()
		{
			Console.WriteLine("Wite your email, email adress which you want to connect to your account");
			string answer = Console.ReadLine();
			string dog = "@";
			string dot = ".";
 			while (!answer.Contains(dog) && !answer.Contains(dot)) 
			{
				Console.WriteLine("Usualy email have dots and '@' symbols, try to write email again");
                answer = Console.ReadLine();

                if (answer.Contains(dog) && answer.Contains(dot))
				{
                    Email = answer;
                    Console.WriteLine("Your email was saved.");
					break;
                }
            }
        }

		public void PostCodeCreate()
		{
            Console.WriteLine("Wite your postcode for shipping information");
            int answer = int.Parse(Console.ReadLine());

            while (answer.ToString().Length > 5 && answer.ToString().Length < 5)
			{
                Console.WriteLine("Try again, postcode have only 5 numbers.");
                answer = int.Parse(Console.ReadLine());

				if(answer.ToString().Length == 5)
				{
					PostCode = answer;
                    Console.WriteLine("Great, your postcode saved.");
                }
            }
        }
    }
}

