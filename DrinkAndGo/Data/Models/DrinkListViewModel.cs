using System.Collections.Generic;

namespace DrinkAndGo.Data.Models
{
	public class DrinksListViewModel
	{
		public IEnumerable<Drink> Drinks { get; set; }
		public string CurrentCategory { get; set; }
	}
}