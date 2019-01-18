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

        public int Count { get; set; }
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
            DB.Execute("sproc_tblTutor_SelectAll");
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

        }
    }