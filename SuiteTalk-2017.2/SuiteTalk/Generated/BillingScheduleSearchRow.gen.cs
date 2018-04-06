// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;

namespace SuiteTalk
{
    public partial class BillingScheduleSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<BillingScheduleSearchRowBasic>
    {
        public BillingScheduleSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public BillingScheduleSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new BillingScheduleSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<BillingScheduleSearchRowBasic> 
            ISearchAdvancedRow<BillingScheduleSearchRowBasic>.CreateBasic(Action<BillingScheduleSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public BillingScheduleSearchRow CreateBasic(Action<BillingScheduleSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return this;
        }

        SearchRowBasic ISearchAdvancedRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchAdvancedRow<BillingScheduleSearchRowBasic> 
            ISearchAdvancedRow<BillingScheduleSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public BillingScheduleSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        private static SearchRowBasic GetOrCreateJoin(BillingScheduleSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new BillingScheduleSearchRowBasic();
                    break;
                default:
                    throw new ArgumentException("BillingScheduleSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}