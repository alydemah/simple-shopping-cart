using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleShoppingCart
{
    public class Utility
    {




        public void CreateCookie(string CookieName, string[] Keys, string[] Values bool Expired)
            {
    

                HttpCookie c = new HttpCookie(CookieName);
        for (int x = 0; x < Keys.length; x++)
			{
			 c.Values.Add(Keys[x], Values[x])
			}

            if(!Expired)

            }


    }
}