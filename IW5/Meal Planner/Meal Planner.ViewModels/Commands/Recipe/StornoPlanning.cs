﻿using Meal_Planner.Model;
using Meal_Planner.ViewModels.Commands.Collection;
using Meal_Planner.ViewModels.Framework.Commands;
using Meal_Planner.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Planner.ViewModels.Commands.Recipe
{
    public class StornoPlanning : CommandBase<RecipiesViewModel>
    {
        private RecipiesViewModel _viewModel;

        public StornoPlanning(RecipiesViewModel viewModel)
            : base(viewModel)
        {
            _viewModel = viewModel;
        }


        public override void Execute(object parameter)
        {
            ViewModel.IsPlanning = false;
        }
    }
}
