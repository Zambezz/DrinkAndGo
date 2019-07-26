using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.ViewModels
{
    public class ShoppingCartViewModel
    {
	    public ShoppingCart ShoppingCart { get; set; }
		public decimal ShoppingCartTotal { get; set; }
    }
}
