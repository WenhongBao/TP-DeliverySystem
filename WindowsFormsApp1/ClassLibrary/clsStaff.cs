using ClassLibrary;
using System;

namespace ClassLibrary1
{
    public class clsStaff
    {
        //private data member
        private Int32 mStaffNo;
        private string mEmail;
        private string mFirstName;
        private string mLastName;
        private string mSection;
        private string mTelephone;
        private string mTitle;

        public int Staff { get; set; }

        public string Customer { get; set; }
        public int StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public string Section
        {
            get
            {
                return mSection;
            }
            set
            {
                mSection = value;
            }
        }

        public string Telephone
        {
            get
            {
                return mTelephone;
            }
            set
            {
                mTelephone = value;
            }
        }

        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }

        public string Valid(int someStaffNo, string someEmail, string someFirstName, string someLastName, string someSection, string someTelephone, string someTitle)
        {
            //create a string variable to store the error
            String Error = "";
            //if the first name is blank
            if (someFirstName == "")
            {
                //record the error
                Error = Error + "The first name may no be blank: ";
            }
            //if the first name is greater than 20 characters
            if (someFirstName.Length > 20)
            {
                //record the error
                Error = Error + "The first name must be less than 20 characters: ";
            }
            //if the someStaffNo is 0
            if (someStaffNo == 0)
            {
                //record the error
                Error = Error + "The someStaffNo must be greater than 0: ";
            }
            //if the someStaffNo greater than 2147483647
            if (someStaffNo > 2147483647)
            {
                //record the error
                Error = Error + "The someStaffNo must be lesser than 2147483647: ";
            }
            //if the last name is blank
            if (someLastName == "")
            {
                //record the error
                Error = Error + "The last name may no be blank: ";
            }
            //if the last name is greater than 10 characters
            if (someLastName.Length > 20)
            {
                //record the error
                Error = Error + "The last name must be less than 20 characters: ";
            }
            //if the email is blank
            if (someEmail == "")
            {
                //record the error
                Error = Error + "The email may no be blank: ";
            }
            //if the email is greater than 20 characters
            if (someEmail.Length > 20)
            {
                //record the error
                Error = Error + "The email must be less than 20 characters: ";
            }
            //if the section is blank
            if (someSection == "")
            {
                //record the error
                Error = Error + "The someSection may no be blank: ";
            }
            //if the Section is greater than 10 characters
            if (someSection.Length > 10)
            {
                //record the error
                Error = Error + "The someSection must be less than 10 characters: ";
            }
            //if the someTelephone is blank
            if (someTelephone == "")
            {
                //record the error
                Error = Error + "The someTelephone may no be blank: ";
            }
            //if the someTelephone is greater than 11 characters
            if (someTelephone.Length > 20)
            {
                //record the error
                Error = Error + "The phone number must be less than 20 characters: ";
            }
            //if the someTitle is blank
            if (someTitle == "")
            {
                //record the error
                Error = Error + "The someTitle may no be blank: ";
            }
            //if the someTitle is greater than 11 characters
            if (someTitle.Length > 10)
            {
                //record the error
                Error = Error + "The someTitle must be less than 10 characters: ";
            }
            //return the messeage
            return Error;
        }

        public bool Find(int someStaffNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", someStaffNo);
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            if (DB.Count == 1)
            {
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mSection  = Convert.ToString(DB.DataTable.Rows[0]["Section"]);
                mTelephone = Convert.ToString(DB.DataTable.Rows[0]["Telephone"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(string someEmail, string someFirstName, string someLastName, string someTelephone, string someTitle)
        {
            //adds a new record to the database based on the values of thisTutor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@Email", someEmail);
            DB.AddParameter("@FirstName", someFirstName);
            DB.AddParameter("@LastName", someLastName);
            DB.AddParameter("@Telephone", someTelephone);
            DB.AddParameter("@Title", someTitle);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}