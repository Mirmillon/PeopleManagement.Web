using Microsoft.AspNetCore.Components;
using PeopleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagement.Web.Pages
{
    public class PersonsListBase : ComponentBase
    {
        readonly CountriesListBase List = new CountriesListBase();

        public IEnumerable<Person> Persons { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadPersons);
          //  return base.OnInitializedAsync();
        }

        private void LoadPersons()
        {
            System.Threading.Thread.Sleep(3000);
            Person p1 = new Person
           {
                PersonId = 1,
                FirstName = "Rose-Ann",
                MiddleName = "Masayo",
                LastName = "Alecto",
                DateOfBirth = new DateTime ( 1991, 11, 12 ),
                Alive = 'Y',
                //Gender = Gender.Female,
                PicturePath = "images/mary.png",
                
            };

            Person p2 = new Person {
                PersonId = 2,
                FirstName = "  Xavier    Robert Gérard",
                MiddleName = null,
                LastName = "Compagnion",
                DateOfBirth = new DateTime(1954, 01, 08),
                Alive = 'Y',
                //Gender = Gender.Male,
                PicturePath = "images/Moi.jpg",
                
            };

            Person p3 = new Person {
                PersonId = 3,
                FirstName = "Christian",
                MiddleName = null,
                LastName = "Compagnion",
                DateOfBirth = new DateTime(1946, 04, 13),
                Alive = 'Y',
                //Gender = Gender.Male,
                PicturePath = "images/sam.jpg",
               
            };
            Person p4 = new Person {
                PersonId = 4,
                FirstName = "Sabine Marie Ghislaine  ",
                MiddleName = null,
                LastName = "Compagnion",
                DateOfBirth = new DateTime(1951, 11, 05),
                Alive = 'Y',
                //Gender = Gender.Female,
                PicturePath = "images/sara.png",
               
            };

            Persons = new List<Person> { p1, p2, p3, p4 };
        }
    }
}
