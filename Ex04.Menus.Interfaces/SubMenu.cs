namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuNode
    {
        private readonly List<MenuNode> r_MenuNodes;

        public SubMenu(string i_MenuTitle)
        {
            Title = i_MenuTitle;
            r_MenuNodes = new List<MenuNode>();
        }

        public List<MenuNode> MenuNodes
        {
            get { return r_MenuNodes; }
        }

        public void AddMenuNode(MenuNode i_NodeToAdd)
        {
            r_MenuNodes.Add(i_NodeToAdd);
            i_NodeToAdd.ParentMenu = this;
        }

        public override void DoWhenClicked()
        {
            UserInteraction.Show(this);
        }
    }
}
