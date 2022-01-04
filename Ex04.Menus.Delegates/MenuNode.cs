namespace Ex04.Menus.Delegates
{
    public abstract class MenuNode
    {
        private string m_Title;
        private SubMenu m_ParentMenu;
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public SubMenu ParentMenu
        {
            get { return m_ParentMenu; }
            set { m_ParentMenu = value; }
        }

        public abstract void DoWhenClicked();
    }
}
