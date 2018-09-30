using System;

namespace RpCater.Model
{
    public class MemberInfo
    {
        private int _DelFlag;

        private string _MemAddress;

        //MemberId, MemName, MemMobilePhone, MemAddress, MemType,
        //MemNum, MemGender, MemDiscount, MemMoney, DelFlag,
        //SubTime, MemIntegral, MemEndTime, MemBirthday
        private int _MemberId;

        private DateTime _MemBirthday;

        private float _MemDiscount;

        private DateTime _MemEndTime;

        private string _MemGender;

        private int _MemIntegral;

        private string _MemMobilePhone;

        private float _MemMoney;

        private string _MemName;

        private string _MemNum;

        private int _MemType;

        private DateTime _SubTime;

        public int DelFlag
        {
            get { return _DelFlag; }
            set { _DelFlag = value; }
        }

        public string MemAddress
        {
            get { return _MemAddress; }
            set { _MemAddress = value; }
        }

        public int MemberId
        {
            get { return _MemberId; }
            set { _MemberId = value; }
        }

        public DateTime MemBirthday
        {
            get { return _MemBirthday; }
            set { _MemBirthday = value; }
        }

        public float MemDiscount
        {
            get { return _MemDiscount; }
            set { _MemDiscount = value; }
        }

        public DateTime MemEndTime
        {
            get { return _MemEndTime; }
            set { _MemEndTime = value; }
        }

        public string MemGender
        {
            get { return _MemGender; }
            set { _MemGender = value; }
        }

        public int MemIntegral
        {
            get { return _MemIntegral; }
            set { _MemIntegral = value; }
        }

        public string MemMobilePhone
        {
            get { return _MemMobilePhone; }
            set { _MemMobilePhone = value; }
        }

        public float MemMoney
        {
            get { return _MemMoney; }
            set { _MemMoney = value; }
        }

        public string MemName
        {
            get { return _MemName; }
            set { _MemName = value; }
        }

        public string MemNum
        {
            get { return _MemNum; }
            set { _MemNum = value; }
        }

        public int MemType
        {
            get { return _MemType; }
            set { _MemType = value; }
        }

        public DateTime SubTime
        {
            get { return _SubTime; }
            set { _SubTime = value; }
        }
    }
}