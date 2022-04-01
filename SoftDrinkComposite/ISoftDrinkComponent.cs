using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;

namespace BurgerAPI.SoftDrinkComposite
{
     public interface ISoftDrinkComponent
     { 
         //returns different parts of the burger
       string getPart();

     }

}