using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class APIController : ControllerBase
    {
        [HttpGet("{id}")]
        public List<APIPerson> GetPeople(int id)
        {
            // URL to call this is https://localhost:44390/API/GetPeople
            // Because the Controller is APIController (drops the controller bit in the URL)
            // GetPeople is the name of the fuction, once it created from APIModel
            
            List<APIPerson> PersonList = new List<APIPerson>();
            // List used in place of a database backend, just to playwith
            // Here is the list being created and data added.
            APIPerson Person = new APIPerson();
                Person.age = 21;
                Person.gender = "Male";
                Person.id = 1;
                Person.name = "Tony";
                PersonList.Add(Person);
            APIPerson Person2 = new APIPerson();
                Person2.age = 31;
                Person2.gender = "FeMale";
                Person2.id = 2;
                Person2.name = "Teresa";
                PersonList.Add(Person2);
            return PersonList;
        }


        public List<APICar> GetCars()
        {
            // URL to call this is https://localhost:44390/API/GetPeople
            // Because the Controller is APIController (drops the controller bit in the URL)
            // GetPeople is the name of the fuction, once it created from APIModel

            List<APICar> CarList = new List<APICar>();
            // List used in place of a database backend, just to playwith
            // Here is the list being created and data added.
            APICar Car = new APICar();
            Car.year = 1956;
            Car.make = "Ford";
            Car.id = 1;
            Car.model = "Capri";
            CarList.Add(Car);
            return CarList;
        }
    }
}
