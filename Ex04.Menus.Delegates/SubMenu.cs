namespace Ex04.Menus.Delegates
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

        public void RemoveMenuNode(MenuNode i_NodeToRemove) // CheckIfCorrect
        {
            if (r_MenuNodes != null)
            {
                if (r_MenuNodes.Contains(i_NodeToRemove))
                {
                    r_MenuNodes.Add(i_NodeToRemove);
                }
            }
        }

        public override void DoWhenClicked()
        {
            UserInteraction.Show(this);
        }
    }
}
