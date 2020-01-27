namespace DecisionTree.Core.Entitites
{
    public class DecisionTreeCondition
    {
        public DecisionTreeCondition(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }

        public bool IsLastCondition
        {
            get
            {
                return (this.Yes == null && this.No == null) ? true : false;
            }
        }

        public DecisionTreeCondition Yes { get; private set; }
        public DecisionTreeCondition No { get; private set; }

        public void AddSubConditions(DecisionTreeCondition yes, DecisionTreeCondition no)
        {
            Yes = yes;
            No = no;
        }
    }
}
