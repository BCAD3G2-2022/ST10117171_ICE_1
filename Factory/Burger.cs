using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;

namespace BurgerAPI.Factory
{
  public class Burger
     {
         public string Bun { get; set; }
         public string patty { get; set; }
         public string extras { get; set; }

     }

}