using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class HomeController :Controller
    {
	    private readonly IDrinkRepository _drinkRepository;
	    public HomeController(IDrinkRepository drinkRepository)
	    {
		    _drinkRepository = drinkRepository;
	    }

	    public ViewResult Index()
	    {
		    var homeViewModel = new HomeViewModel()
		    {
			    PrefferedDrinks = _drinkRepository.PreferredDrinks
		    };
		    return View(homeViewModel);
	    }
    }
}
