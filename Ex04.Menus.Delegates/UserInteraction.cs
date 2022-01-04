namespace Ex04.Menus.Delegates
{
    public static class UserInteraction
    {
        private const string k_ExitMessage = "Exit";
        private const string k_BackMessage = "Back";
        private const string k_BackToPreviousMessage = "Back To Previous Menu";
        private const int k_ExitOrBack = 0;
        private const int k_MenuOffset = 1;

        private static void printMenu(SubMenu i_Menu)
        {
            int index = 1;
            Console.Clear();
            Console.WriteLine("**" + i_Menu.Title + "**");
            Console.WriteLine("_______________________" + Environment.NewLine);
            foreach (MenuNode node in i_Menu.MenuNodes)
            {
                Console.WriteLine("{0} -> {1}", index, node.Title);
                index++;
            }
            Console.WriteLine("0 -> {0}", i_Menu.ParentMenu == null ? k_ExitMessage : k_BackMessage);
            Console.WriteLine("Enter your request: ({0} to {1}, or '0' to {2}).", 1, index - 1, i_Menu.ParentMenu == null ? k_ExitMessage : k_BackToPreviousMessage); // Check Prints
        }

        private static int printManager(SubMenu i_Menu)
        {
            string userInput;
            int validInput;
            printMenu(i_Menu);
            userInput = Console.ReadLine();

            while (!IsValidMenuOption(userInput, i_Menu.MenuNodes.Count, out validInput))
            {
                Console.WriteLine("Invalid input, Try again."); // Check Print
                Thread.Sleep(2000);
                printMenu(i_Menu);
                userInput = Console.ReadLine();
            }

            return validInput;
        }

        private static bool IsValidMenuOption(string i_UserInput, int i_MenuLength, out int o_ValidInput)
        {
            return int.TryParse(i_UserInput, out o_ValidInput) && o_ValidInput >= k_ExitOrBack && o_ValidInput <= i_MenuLength;
        }

        public static void Show(SubMenu i_Menu)
        {
            int userChoice = -1;

            while (!userChoice.Equals(k_ExitOrBack))
            {
                userChoice = UserInteraction.printManager(i_Menu);

                if (!userChoice.Equals(k_ExitOrBack))
                {
                    i_Menu.MenuNodes[userChoice - k_MenuOffset].DoWhenClicked();
                }
            }
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
