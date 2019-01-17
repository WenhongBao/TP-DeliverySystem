using ClassLibrary;
using System;

namespace ClassLibrary1
{
    public class clsOrder
    {
        //private data member
        private Int32 mOrderNo;
        private Boolean mActive;
        private string mCollectionPostcode;
        private string mDestinationCountry;
        private string mDestinationPostcode;
        private string mDateCreated;
        private string mParcelSize;
        private string mStatus;
        private Int32 mCustomerNo;

        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }

        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public string CollectionPostcode
        {
            get
            {
                return mCollectionPostcode;
            }
            set
            {
                mCollectionPostcode = value;
            }
        }

        public string DestinationCountry
        {
            get
            {
                return mDestinationCountry;
            }
            set
            {
                mDestinationCountry = value;
            }
        }

        public string DestinationPostcode
        {
            get
            {
                return mDestinationPostcode;
            }
            set
            {
                mDestinationPostcode = value;
            }
        }

        public string DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }

        public string ParcelSize
        {
            get
            {
                return mParcelSize;
            }
            set
            {
                mParcelSize = value;
            }
        }

        public string Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }

        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }

        public string Valid(int someOrderNo, bool someActive, string someCollectionPostcode, string someDestinationCountry, string someDestinationPostcode, string someDateCreated, string someParcelSize, string someStatus, int someCustomerNo)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;
            //if the someOrderNo is 0
            if (someOrderNo == 0)
            {
                //record the error
                Error = Error + "The someOrderNo must be greater than 0: ";
            }
            //if the someOrderNo greater than 2147483647
            if (someOrderNo > 2147483647)
            {
                //record the error
                Error = Error + "The someOrderNo must be lesser than 2147483647: ";
            }
            ////if the someActive no true
            //if (someActive != true || someActive != false)
            //{
            //    //record the error
            //    Error = Error + "The someActive must be true or false: ";
            //}
            //if the someCollectionPostcode is blank
            if (someCollectionPostcode == "")
            {
                //record the error
                Error = Error + "The someCollectionPostcode may no be blank: ";
            }
            //if the someCollectionPostcode is greater than 10 characters
            if (someCollectionPostcode.Length > 10)
            {
                //record the error
                Error = Error + "The someCollectionPostcode must be less than 10 characters: ";
            }
            //if the someDestinationCountry is blank
            if (someDestinationCountry == "")
            {
                //record the error
                Error = Error + "The someDestinationCountry may no be blank: ";
            }
            //if the last name is greater than 20 characters
            if (someDestinationCountry.Length > 20)
            {
                //record the error
                Error = Error + "The someDestinationCountry must be less than 10 characters: ";
            }
            //if the someDestinationPostcode is blank
            if (someDestinationPostcode == "")
            {
                //record the error
                Error = Error + "The someDestinationPostcode may no be blank: ";
            }
            //if the someDestinationPostcode is greater than 10 characters
            if (someDestinationPostcode.Length > 10)
            {
                //record the error
                Error = Error + "The someDestinationPostcode must be less than 10 characters: ";
            }
            try
            {
                //copy the dateCreated value to the DateTemp variable
                DateTemp = Convert.ToDateTime(someDateCreated);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }
            //if the someParcelSize is blank
            if (someParcelSize == "")
            {
                //record the error
                Error = Error + "The someParcelSize may no be blank: ";
            }
            //if the someParcelSize is greater than 10 characters
            if (someParcelSize.Length > 10)
            {
                //record the error
                Error = Error + "The someParcelSize must be less than 10 characters: ";
            }
            //if the someStatus is blank
            if (someStatus == "")
            {
                //record the error
                Error = Error + "The someStatus may no be blank: ";
            }
            //if the someStatus is greater than 10 characters
            if (someStatus.Length > 20)
            {
                //record the error
                Error = Error + "The someStatus must be less than 20 characters: ";
            }
            //if the someCustomerNo is 0
            if (someCustomerNo == 0)
            {
                //record the error
                Error = Error + "The someCustomerNo must be greater than 0: ";
            }
            //if the someCustomerNo greater than 2147483647
            if (someCustomerNo > 2147483647)
            {
                //record the error
                Error = Error + "The someCustomerNo must be lesser than 2147483647: ";
            }
            //return the messeage
            return Error;
        }

        public bool Find(int someOrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", someOrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCollectionPostcode = Convert.ToString(DB.DataTable.Rows[0]["CollectionPostcode"]);
                mDestinationCountry = Convert.ToString(DB.DataTable.Rows[0]["DestinationCountry"]);
                mDestinationPostcode = Convert.ToString(DB.DataTable.Rows[0]["DestinationPostcode"]);
                mDateCreated = Convert.ToString(DB.DataTable.Rows[0]["DateCreated"]);
                mParcelSize = Convert.ToString(DB.DataTable.Rows[0]["ParcelSize"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}