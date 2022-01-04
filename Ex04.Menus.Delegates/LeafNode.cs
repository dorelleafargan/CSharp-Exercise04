namespace Ex04.Menus.Delegates
{
    public class LeafNode : MenuNode
    {
        public event Action m_Action;
        public LeafNode(string i_Title)
        {
            Title = i_Title;
        }

        public void AttachObserver(Action i_Action)
        {
            m_Action += i_Action;
        }

        public void DetachObserver(Action i_Action)
        {
            m_Action -= i_Action;
        }

        protected virtual void OnClick()
        {
            Console.Clear();
            if (m_Action != null)
            {
                m_Action.Invoke();
            }

            UserInteraction.PressAnyKeyToContinue();
        }

        public override void DoWhenClicked()
        {
            OnClick();
        }
    }
}
