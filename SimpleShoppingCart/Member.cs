using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;

namespace SimpleShoppingCart
{
    public class Member:MainTable
    {
        #region Fields
        DB db = new DB();
        private string _Username;
        private string _Password;
        private string _Name;
        private string _Email;
        private string _Phone;
        private string _Gender;
        private Order _Ord;
        #endregion

        #region Properties
        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Eamil
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {

                _Phone = value;
            }
        }

        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        #endregion

        public Order Order
        {
            get
            {
                return _Ord;
            }
            set
            {
                _Ord = value;
            }
        }

        public string Register()
        {
            throw new System.NotImplementedException();
        }

        public string Register(string Username, string Password, string Name, string Email, string Phone, string Gender)
        {
            throw new System.NotImplementedException();
        }

        public string EditProfile()
        {
            throw new System.NotImplementedException();
        }

        public string EditProfile(string Username, string Password, string Name, string Email, string Phone, string Gender)
        {
            throw new System.NotImplementedException();
        }

        public Boolean Login()
        {
            throw new System.NotImplementedException();
        }

        public bool Login(string Username, string Password)
        {
            throw new System.NotImplementedException();
        }

        public bool ChangePassword(string Username, string NewPassword)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser(string Username)
        {
            throw new System.NotImplementedException();
        }

        public bool UsernameAvailability(string Username)
        {
            throw new System.NotImplementedException();
        }



        public override bool LoadProperties2List(string TypeOfOperation, SortedList[] Para)
        {
            SortedList SL = new SortedList();
            SL.Add("@Check", TypeOfOperation);
            SL.Add("@Username", Username);
            SL.Add("@Password", Password);
            SL.Add("@Name", Name);
            SL.Add("@Email",Eamil);
            SL.Add("@Phone", Phone);
            SL.Add("@Gender", Gender);
            ProcedureName = "ManageUsers";
            db.RunProcedure(ProcedureName, SL);
            return true;
        }

    }
}
