using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class APIController : Controller
    {
        public List<APIModel> GetPeople()
        {
            // URL to call this is https://localhost:44390/API/GetPeople
            // Because the Controller is APIController (drops the controller bit in the URL)
            // GetPeople is the name of the fuction, once it created from APIModel
            
            List<APIModel> PersonList = new List<APIModel>();
            // List used in place of a database backend, just to playwith
            // Here is the list being created and data added.
            APIModel Person = new APIModel();
                Person.age = 21;
                Person.gender = "Male";
                Person.id = 1;
                Person.name = "Tony";
                PersonList.Add(Person);
            return PersonList;
        }
    }
}
