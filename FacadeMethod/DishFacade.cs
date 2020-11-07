using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMethod
{
    public class DishFacade
    {
        private DishAppetizer _appetizer;
        private DishFitting _fitting;
        private DishMeat _meat;
        private DishSalad _salad;

        public DishFacade()
        {
            _appetizer = new DishAppetizer();
            _fitting = new DishFitting();
            _meat = new DishMeat();
            _salad = new DishSalad();
        }

        public void PrepareDish()
        {
            Console.WriteLine("-------- Preparing a Dish --------\n");
            _appetizer.Serve();
            _fitting.Cook();
            _meat.Flavour();
            _salad.Prepare();

            Console.WriteLine("\n-------- Dish preparation complete -----------");
        }
    }
}
