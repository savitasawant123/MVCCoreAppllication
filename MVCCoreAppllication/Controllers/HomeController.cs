﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreAppllication.Controllers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "Savita";
        }
    }
}