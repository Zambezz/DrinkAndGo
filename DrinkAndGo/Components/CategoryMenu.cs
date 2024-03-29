﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Components
{
    public class CategoryMenu : ViewComponent
    {
	    private readonly ICategoryRepository _categoryRepository;

	    public CategoryMenu(ICategoryRepository categoryRepository)
	    {
		    _categoryRepository = categoryRepository;
	    }

	    public IViewComponentResult Invoke()
	    {
		    var categories = _categoryRepository.Categories.OrderBy(x => x.CategoryName);
		    return View(categories);
	    }
    }
}
