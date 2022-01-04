namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu r_SubMenuList;

        public MainMenu(string i_MenuTitle)
        {
            r_SubMenuList = new SubMenu(i_MenuTitle);
        }

        public SubMenu SubMenuList
        {
            get { return r_SubMenuList; }
        }

        public void Show()
        {
            UserInteraction.Show(r_SubMenuList);
        }
    }
}
