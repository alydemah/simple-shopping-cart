using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace SimpleShoppingCart
{
    public class OrderDetails
    {
        private Product _Pro;
        private string _CatNo;

        public string CatNo
        {
            get { return _CatNo; }
            set { _CatNo = value; }
        }
        private string _ProID;

        public string ProID
        {
            get { return _ProID; }
            set { _ProID = value; }
        }
        private int _OrderNo;

        public int OrderNo
        {
            get { return _OrderNo; }
            set { _OrderNo = value; }
        }
        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        private double _SalePrice;

        public double SalePrice
        {
            get { return _SalePrice; }
            set { _SalePrice = value; }
        }
        private double _Discount;

        public double Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        public Product Product
        {
            get
            {
                return _Pro;
            }
            set
            {
                _Pro = value;
            }
        }
    }
}
