using System;

namespace ClassLibrary
{
    public class clsInvoice
    {
        //private data member
        private Int32 mInvoiceNo;
        private DateTime mDateCreated;
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

        public DateTime DateCreated
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

        public string Valid(int someInvoiceNo, DateTime someDateCreated, double somePrice, string somePostcode, int someOrderNo)
        {
            throw new NotImplementedException();
        }
    }
}