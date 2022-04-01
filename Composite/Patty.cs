using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;

namespace BurgerAPI.Composite
{
     public class Patty: _IComponent
     { 
         //returns patty parts of the burger
       public string getPart()
       {
           return "Patty";
       }

     }

}