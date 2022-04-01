using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Composite;

namespace BurgerAPI.Composite
{
     public class Tomato: _IComponent
     { 
         //returns tomato parts of the burger
       public string getPart()
       {
           return "Tomato";
       }

     }

}