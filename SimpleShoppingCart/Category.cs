using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;

namespace SimpleShoppingCart
{
    public class Category:MainTable
    {
        DB db = new DB();
        private string _CatNo;
        private string _CatName;
        private string _Description;
        private Product _Pro;

        public string CatNo
        {
            get
            {
                return _CatNo;
            }
            set
            {
                _CatNo = value;
            }
        }

        public string CatName
        {
            get
            {
                return _CatName;
            }
            set
            {
                _CatName = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }

        public Product Product
        {
            get
            {
                return  _Pro;
            }
            set
            {
                _Pro = value;
            }
        }



        public override bool LoadProperties2List(string TypeOfOperation, SortedList[] Para)
        {
            SortedList SL = new SortedList();
            SL.Add("@Check", TypeOfOperation);
            SL.Add("@CatNo", CatNo);
            SL.Add("@CatName", CatName);
            SL.Add("@Description", Description);
            ProcedureName = "ManageCategory";
            db.RunProcedure(ProcedureName, SL);
            return true;
        }

    }
}
