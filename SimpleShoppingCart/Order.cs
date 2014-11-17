using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;

namespace SimpleShoppingCart
{
    public class Order:MainTable
    {
        DB db = new DB();
        private OrderDetails _OrdDet;
        private int _OrdrNo;

        public int OrdrNo
        {
            get { return _OrdrNo; }
            set { _OrdrNo = value; }
        }
        private DateTime _OrderDate;
        private string _ShipName;

        public string ShipName
        {
            get { return _ShipName; }
            set { _ShipName = value; }
        }
        private string _ShipCity;

        public string ShipCity
        {
            get { return _ShipCity; }
            set { _ShipCity = value; }
        }
        private string _ShipArea;

        public string ShipArea
        {
            get { return _ShipArea; }
            set { _ShipArea = value; }
        }
        private string _ShipAddress;

        public string ShipAddress
        {
            get { return _ShipAddress; }
            set { _ShipAddress = value; }
        }
        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public OrderDetails OrderDetails
        {
            get
            {
                return _OrdDet;
            }
            set
            {

                _OrdDet = value;
            }
        }

        public override bool LoadProperties2List(string TypeOfOperation, SortedList[] Para)
        {
            SortedList SL = new SortedList();
            SL.Add("@Check", TypeOfOperation);
            SL.Add("@OrderNo", OrdrNo);
            SL.Add("@OrderDate", OrderDetails);
            SL.Add("@ShipName", ShipName);
            SL.Add("@ShipCity", ShipCity);
            SL.Add("@ShipAddress", ShipAddress);
            SL.Add("@ShipArea", ShipArea);
            ProcedureName = "ManageOrder";
            db.RunProcedure(ProcedureName, SL);
            return true;


        }

    }
}
