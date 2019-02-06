using System;

namespace ClassLibrary
{
    public class clsInvoice
    {
        //private data member
        private Int32 mInvoiceNo;
        private string mDateCreated;
        private double mPrice;
        private string mPostcode;
        private Int32 mOrderNo;

        public int InvoiceNo
        {
            get
            {
                return mInvoiceNo;
            }
            set
            {
                mInvoiceNo = value;
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

        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }

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

        public string Valid(int someInvoiceNo, string someDateCreated, double somePrice, string somePostcode, int someOrderNo)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;
            //if the someInvoiceNo is 0
            if (someInvoiceNo == 0)
            {
                //record the error
                Error = Error + "The someInvoiceNo must be greater than 0: ";
            }
            //if the someInvoiceNo greater than 2147483647
            if (someInvoiceNo > 2147483647)
            {
                //record the error
                Error = Error + "The someInvoiceNo must be lesser than 2147483647: ";
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
            //if the price is 0
            if (somePrice == 0)
            {
                //record the error
                Error = Error + "The price must be greater than 0: ";
            }
            //if the somePostcode is blank
            if (somePostcode == "")
            {
                //record the error
                Error = Error + "The somePostcode may no be blank: ";
            }
            //if the last name is greater than 10 characters
            if (somePostcode.Length > 10)
            {
                //record the error
                Error = Error + "The somePostcode must be less than 10 characters: ";
            }
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
            //return the messeage
            return Error;
        }

        public bool Find(int someInvoiceNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@InvoiceNo", someInvoiceNo);
            DB.Execute("sproc_tblInvoice_FilterByInvoiceNo");
            if (DB.Count == 1)
            {
                mInvoiceNo = Convert.ToInt32(DB.DataTable.Rows[0]["InvoiceNo"]);
                mDateCreated = Convert.ToString(DB.DataTable.Rows[0]["DateCreated"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(string someDateCreated, double somePrice, string somePostcode,Int32 someOrderNo)
        {
            // adds a new record to the database based on the values of thisTutor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DateCreated", someDateCreated);
            DB.AddParameter("@Price", somePrice);
            DB.AddParameter("@Postcode", somePostcode);
            DB.AddParameter("@OrderNo", someOrderNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblInvoice_Insert");
        }
    }
}