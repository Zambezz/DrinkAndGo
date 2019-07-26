using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.ViewModels
{
    public class HomeViewModel
    {
	    public IEnumerable<Drink> PrefferedDrinks {get;set;}
    }
    
}
