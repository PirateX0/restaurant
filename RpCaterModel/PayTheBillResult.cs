namespace RpCater.Model
{
    public class PayTheBillResult
    {
        private bool isUsingMemMoney;
        private bool updateDeskInfoResult;
        private bool updateMemberInfoResult;
        private bool updateOrderInfoResult;
        private bool updateROPResult;

        public bool IsUsingMemMoney
        {
            get { return isUsingMemMoney; }
            set { isUsingMemMoney = value; }
        }

        public bool UpdateDeskInfoResult
        {
            get { return updateDeskInfoResult; }
            set { updateDeskInfoResult = value; }
        }

        public bool UpdateMemberInfoResult
        {
            get { return updateMemberInfoResult; }
            set { updateMemberInfoResult = value; }
        }

        public bool UpdateOrderInfoResult
        {
            get { return updateOrderInfoResult; }
            set { updateOrderInfoResult = value; }
        }

        public bool UpdateROPResult
        {
            get { return updateROPResult; }
            set { updateROPResult = value; }
        }
    }
}