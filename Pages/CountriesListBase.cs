using Microsoft.AspNetCore.Components;
using PeopleManagement.Models;
using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.Web.Pages
{
    public class CountriesListBase : ComponentBase
    {
      
        public List<Country> Countries { get; set; }

        public CountriesListBase()
        {
            LoadCountries();
        }

        protected override Task OnInitializedAsync()
        {
            LoadCountries();
            return base.OnInitializedAsync();
        }

        private void LoadCountries()
        {
        }
        
    }
}
