using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class DrinkRepository: IDrinkRepository
    {
	    private readonly AppDbContext _appDbContext;
	    public DrinkRepository(AppDbContext appDbContext)
	    {
		    _appDbContext = appDbContext;
	    }

	    public IEnumerable<Drink> Drinks =>_appDbContext.Drinks.Include(c => c.Category);

	    public IEnumerable<Drink> PreferredDrinks =>
		    _appDbContext.Drinks.Where(x => x.IsPreferredDrink).Include(c => c.Category);

	    public Drink GetDrinkById(int drinkId)
		    => _appDbContext.Drinks.FirstOrDefault(x => x.DrinkId == drinkId);
    }
}
