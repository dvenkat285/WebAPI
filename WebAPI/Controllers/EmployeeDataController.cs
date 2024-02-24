using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        public string[] myEmployee = { "Adil", "Bilal", "Zain" };

        [HttpGet]
        public string[] GetEmployee()
        {
            return myEmployee;
        }


        [HttpGet("{id}")]
        public string GetEmployeeByIndex(int id)
        {
            return myEmployee[id];
        }



    }
}
