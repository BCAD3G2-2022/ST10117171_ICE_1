using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;




namespace BurgerAPI.Factory
{
 public interface IBurger
    {
      string getBun();
      string getPatty();
    }
}
   



