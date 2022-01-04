using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Methods
    {
        public class CountCapitals : IExecuteAction
        {
            public void Execute()
            {
                string userInput = string.Empty;
                int numOfCapitals;
                Console.WriteLine("Please Enter a sentence with capital letters:");
                userInput = Console.ReadLine();
                numOfCapitals = string.Concat(userInput.Where(c => c >= 'A' && c <= 'Z')).Length;
                Console.WriteLine("You have {0} Capital letters in your sentence", numOfCapitals);
            }
        }

        public class ShowVersion : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine("Version: 22.1.4.8930");
            }
        }

        public class ShowTime : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        public class ShowDate : IExecuteAction
        {
            public void Execute()
            {
                Console.WriteLine(DateTime.Today.ToString("dd-MM-yyyy"));
            }
        }
    }
}
