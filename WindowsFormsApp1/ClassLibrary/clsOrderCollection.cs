using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class clsOrderCollection
    {
        //private data member for the list
        private List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisTutor
        clsOrder mThisOrder = new clsOrder();

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByDateCreated(string DateCreated)
        {
            //filters the records based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@DateCreated", DateCreated);
            //execte the stored procedure
            DB.Execute("sproc_tblOrder_FilterByDateCreated");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByDestinationPostcodeAndCustomerNo(string DestinationPostcode,Int32 CustomerNo)
        {
            //filters the records based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@DestinationPostcode", DestinationPostcode);
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execte the stored procedure
            DB.Execute("sproc_tblOrder_FilterByDestinationPostcodeAndCustomerNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.CollectionPostcode = Convert.ToString(DB.DataTable.Rows[Index]["CollectionPostcode"]);
                AnOrder.DestinationCountry = Convert.ToString(DB.DataTable.Rows[Index]["DestinationCountry"]);
                AnOrder.DestinationPostcode = Convert.ToString(DB.DataTable.Rows[Index]["DestinationPostcode"]);
                AnOrder.DateCreated = Convert.ToString(DB.DataTable.Rows[Index]["DateCreated"]);
                AnOrder.ParcelSize = Convert.ToString(DB.DataTable.Rows[Index]["ParcelSize"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                //add the record to the private data mamber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public void FilterByCustomerNo(int customerNo)
        {
            //filters the records based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@CustomerNo", customerNo);
            //execte the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        

        public int Add()
        {
            //adds a new record to the database based on the values of thisTutor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@CollectionPostcode", mThisOrder.CollectionPostcode);
            DB.AddParameter("@DestinationCountry", mThisOrder.DestinationCountry);
            DB.AddParameter("@DestinationPostcode", mThisOrder.DestinationPostcode);
            DB.AddParameter("@DateCreated", mThisOrder.DateCreated);
            DB.AddParameter("@ParcelSize", mThisOrder.ParcelSize);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of thisTutor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@CollectionPostcode", mThisOrder.CollectionPostcode);
            DB.AddParameter("@DestinationCountry", mThisOrder.DestinationCountry);
            DB.AddParameter("@DestinationPostcode", mThisOrder.DestinationPostcode);
            DB.AddParameter("@DateCreated", mThisOrder.DateCreated);
            DB.AddParameter("@ParcelSize", mThisOrder.ParcelSize);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

    }
}