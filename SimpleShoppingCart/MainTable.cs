using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Collections;

namespace SimpleShoppingCart
{
    public abstract class MainTable
    {

       protected string ProcedureName;
       protected DB db = new DB();
        public virtual bool LoadProperties2List(string TypeOfOperation, SortedList[] Para)
        {

            return false;
        
        }

        public bool Add(SortedList[] Para)
        {
            return
            LoadProperties2List("Add", Para);
        }

        public bool Delete(SortedList[] Para)
        {
            return
         LoadProperties2List("Delete", Para);
        }

        public bool Update(SortedList[] Para)
        {
            return
          LoadProperties2List("Update", Para);
        }
    }
}
