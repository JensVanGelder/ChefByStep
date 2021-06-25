﻿using ChefByStep.ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefByStep.ASP.ViewModels
{
    public class RecipeCreateViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string CreatedByUser { get; set; }
        public int PrepTimeInMin { get; set; }
        public int CookTimeInMin { get; set; }

        public List<Step> Steps { get; set; }

        public List<RecipeIngredient> Ingredients { get; set; }
        public ApiUser CreatedBy { get; set; }

    }
}