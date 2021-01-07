using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        

        public List<TestModel> GetPeople()
        {
           List<TestModel> PersonList = new List<TestModel>();

            TestModel Jay = new TestModel();
            Jay.age = 21;
            Jay.gender = "Male";
            Jay.id = 1;
            Jay.name = "Tony";

            PersonList.Add(Jay);
            return PersonList;
        }

    }
}
