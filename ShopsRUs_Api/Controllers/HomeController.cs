using Microsoft.AspNetCore.Mvc;
using ShopsRUs_Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult ResponseModel(ShopsRUsModel model)
        {
            if (model.IsGroseries == false)
            {
                if (model.IsStoreEmployee)
                {
                    double Total = Convert.ToDouble(model.Price)*(0.7);
                    model.Price = Convert.ToDecimal(Total);

                }
                else if ((DateTime.Now.Year - model.WorkDate.Year) > 2)
                {
                    double Total = Convert.ToDouble(model.Price) * (0.95);
                    model.Price = Convert.ToDecimal(Total);
                }
                else if (model.Price > 100)
                {
                    int mod = (int)(model.Price / 100);
                    double Total = Convert.ToDouble(model.Price) - (mod * 5);
                    model.Price = Convert.ToDecimal(Total);
                }
            }
            return Ok(model);
        }
    }
}

