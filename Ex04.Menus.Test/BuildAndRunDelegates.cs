namespace Ex04.Menus.Test
{
    internal class BuildAndRunDelegates
    {
        public static Delegates.MainMenu m_DelegatesMainMenu;
        public static void Run()
        {
            m_DelegatesMainMenu = new Delegates.MainMenu("Delegates Main Menu");
            Delegates.SubMenu firstSubMenu = new Delegates.SubMenu("Version and Capitals");
            Delegates.SubMenu secondSubMenu = new Delegates.SubMenu("Show Date/Time");
            Delegates.LeafNode countCapitals = new Delegates.LeafNode("Count Capitals");
            Delegates.LeafNode showVersion = new Delegates.LeafNode("Show Version");
            Delegates.LeafNode showDate = new Delegates.LeafNode("Show Date");
            Delegates.LeafNode showTime = new Delegates.LeafNode("Show Time");
            countCapitals.AttachObserver(new Methods.CountCapitals().Execute);
            showVersion.AttachObserver(new Methods.ShowVersion().Execute);
            showTime.AttachObserver(new Methods.ShowTime().Execute);
            showDate.AttachObserver(new Methods.ShowDate().Execute);
            m_DelegatesMainMenu.SubMenuList.AddMenuNode(firstSubMenu);
            m_DelegatesMainMenu.SubMenuList.AddMenuNode(secondSubMenu);
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);
            m_DelegatesMainMenu.Show();

        }
    }
}
