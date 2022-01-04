namespace Ex04.Menus.Interfaces
{
    public class LeafNode : MenuNode
    {
        private readonly IExecuteAction r_Action;
        public LeafNode(string i_Title, IExecuteAction i_Action)
        {
            Title = i_Title;
            r_Action = i_Action;
        }

        public override void DoWhenClicked()
        {
            Console.Clear();
            r_Action.Execute();
            UserInteraction.PressAnyKeyToContinue();
        }
    }
}
