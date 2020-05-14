using Microsoft.AspNetCore.Components;
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
            Country c1 = new Country
            {
                NameCountry= "Philippines",
                CodeISO156A2="PH",
                TelephonePrefix ="63"


            };

            Country c2 = new Country
            {
                NameCountry = "France",
                CodeISO156A2 = "FR",
                TelephonePrefix = "33"
            };

            Country c3 = new Country
            {
                NameCountry = "Belgique",
                CodeISO156A2 = "BE",
                TelephonePrefix = "32"
            };


            Countries = new List<Country> { c3, c2, c1 };
        }
        
    }
}
