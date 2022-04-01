using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;




namespace BurgerAPI.SoftDrinks
{
 public interface ISoftDrink
    {
      string getMl();
      string getBrand();
      string getFlavour();
    }
}
   


