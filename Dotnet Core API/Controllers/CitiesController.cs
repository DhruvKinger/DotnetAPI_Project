using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.API.Controllers
{  
    [ApiController]
   public class CitiesController:ControllerBase
 {

        public JsonResult GetCities()
        {

            return new JsonResult(

                new List<Object>
                {
                    new{id=1,Name="Mlk"},
                    new{id=2,Name="Chandigarh"}
                }
            );
        }

 }

}
