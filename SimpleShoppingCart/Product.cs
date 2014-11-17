using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace SimpleShoppingCart
{
    public class Product
    {
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
        private string _ProName;

        public string ProName
        {
            get { return _ProName; }
            set { _ProName = value; }
        }
        private double _Price;

        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        private int _AvailabQuantity;

        public int AvailabQuantity
        {
            get { return _AvailabQuantity; }
            set { _AvailabQuantity = value; }
        }
        private DateTime _DateAdded;

        public DateTime DateAdded
        {
            get { return _DateAdded; }
            set { _DateAdded = value; }
        }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
