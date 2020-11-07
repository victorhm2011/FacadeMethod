using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMethod
{
    public class Client
    {
        public DishFacade facade;
        public string name;
        public int price;

        public Client(string n,int p )
        {
            facade = new DishFacade();
            name = n;
            price = p;
        }

        public void MakeOrder()
        {
            facade.PrepareDish();
        }
    }
}
