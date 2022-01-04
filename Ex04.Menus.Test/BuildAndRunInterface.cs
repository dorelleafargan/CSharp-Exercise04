namespace Ex04.Menus.Test
{
    public static class BuildAndRunInterface
    {
        private static Interfaces.MainMenu m_InterfaceMainMenu;
        public static void Run()
        {
            m_InterfaceMainMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.SubMenu firstSubMenu = new Interfaces.SubMenu("Version and Capitals");
            Interfaces.SubMenu secondSubMenu = new Interfaces.SubMenu("Show Date/Time");
            Interfaces.LeafNode countCapitals = new Interfaces.LeafNode("Count Capitals", new Methods.CountCapitals());
            Interfaces.LeafNode showVersion = new Interfaces.LeafNode("Show Version", new Methods.ShowVersion());
            Interfaces.LeafNode showDate = new Interfaces.LeafNode("Show Date", new Methods.ShowDate());
            Interfaces.LeafNode showTime = new Interfaces.LeafNode("Show Time", new Methods.ShowTime());
            m_InterfaceMainMenu.SubMenuList.AddMenuNode(firstSubMenu);
            m_InterfaceMainMenu.SubMenuList.AddMenuNode(secondSubMenu);
            firstSubMenu.AddMenuNode(countCapitals);
            firstSubMenu.AddMenuNode(showVersion);
            secondSubMenu.AddMenuNode(showTime);
            secondSubMenu.AddMenuNode(showDate);
            m_InterfaceMainMenu.Show();
        }
    }
}
