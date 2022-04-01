using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Composite;

namespace BurgerAPI.SoftDrinkComposite
{
     public class SoftDrinkComposite: ISoftDrinkComponent
     { 

    
            List<ISoftDrinkComponent> comps = new List<ISoftDrinkComponent>();

            
            public string getPart()
            {
                string output = "";
                foreach (ISoftDrinkComponent item in comps)
                {
                   output += item.getPart() + "-"; 
                }
                return output;
            }

            public void addComponent(ISoftDrinkComponent part)
            {
                comps.Add(part);
            }

            public void removeComponent(ISoftDrinkComponent part)
            {
                comps.Remove(part);
            }


     }

}