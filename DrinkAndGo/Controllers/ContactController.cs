﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class ContactController:Controller
    {
	    public ViewResult Index()
	    {
		    return View();
	    }
    }
}
