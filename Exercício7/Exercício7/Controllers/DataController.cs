using System;
using Microsoft.AspNetCore.Mvc;


namespace Exercício7.Controllers
{
    //This project is a simple API that gets the current date and time, and shows it in JSON format


    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        //this function returns a DataModel object
        [HttpGet]
        public DataModel GetClasse()
        {
            return (new DataModel()
            {
                currentDateTime = DateTime.Now //getting the current DateTime
            });

        }
    }
}
