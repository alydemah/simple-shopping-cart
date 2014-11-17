using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace SimpleShoppingCart
{
    public class DB
    {

        SqlConnection conn;
        SqlCommand cmd;
        DataTable tbl;

        private void Intialize(CommandType CT, string DBCall) 
        {

           conn = new SqlConnection();
           cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            cmd.Connection = conn;
            cmd.CommandType = CT;
            cmd.CommandText = DBCall;
            conn.Open();
        }


        public int RunProcedure(string ProcedureName, SortedList ParaVal)
        {


            Intialize(CommandType.StoredProcedure, ProcedureName);

            for (int x = 0; x < ParaVal.Count; x++ )
            {
                cmd.Parameters.AddWithValue(ParaVal.GetKey(x).ToString(), ParaVal.GetByIndex(x).ToString());
               return RunUpdate();
            }


            
            

     
        
        }

        public int RunUpdate(string InsDelUpd)
        {
            Intialize(CommandType.Text, InsDelUpd);
            return RunUpdate();
        }
        private int RunUpdate()
        {

            try
            {
                int x = cmd.ExecuteNonQuery();
                conn.Close();
                return x;
            }

            catch (SqlException ex)
            {
                conn.Close();
                return ex.Number;
            }
        }

        public DataTable RunQuery(string Select)
        {

            Intialize(CommandType.Text, Select);
            tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            return tbl;
            
        }
            

    }
}