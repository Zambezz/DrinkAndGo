using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController: Controller
    {
	    private readonly ICategoryRepository _categoryRepository;
	    private readonly IDrinkRepository _drinkRepository;

	    public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
	    {
		    _categoryRepository = categoryRepository;
		    _drinkRepository = drinkRepository;
	    }

	    public ViewResult DrinkList(string category)
	    {
		    string _category = category;
		    IEnumerable<Drink> drinks;

		    string currentCategory = string.Empty;

		    if (string.IsNullOrEmpty(category))
		    {
				drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
		    }
		    else
		    {
			    drinks = string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase) ?
				    _drinkRepository.Drinks.Where(x => x.CategoryId % 2 ==0).OrderBy(x=> x.Name) 
				    : _drinkRepository.Drinks.Where(x => x.CategoryId % 2 == 1).OrderBy(x => x.Name);
			    currentCategory = _category;
		    }

		    var drinkListViewModel = new DrinkListViewModel()
		    {
			    Drinks = drinks,
			    CurrentCategory = currentCategory
		    };

		    return View(drinkListViewModel);
	    }
    }
}
