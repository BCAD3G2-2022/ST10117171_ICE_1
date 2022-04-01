using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Composite;

namespace BurgerAPI.Composite
{
     public class BurgerComposite: _IComponent
     { 

        /*  constructor not needed as we will add each part as leaf. If we have a part that evey composite must have then we can use constructor
          string part;
            public Composite(string part)
            {
                this.part = part;
            }
*/
    
             public List<_IComponent> comps = new List<_IComponent>();


            public string getPart()
            {
                string output = "";
                foreach (_IComponent item in comps)
                {
                   output+= item.getPart() +"-";
                }
                return output;
            } 
            
            public List<string> getParts()
            {
                List<string> output = new List<string>();
                foreach (_IComponent item in comps)
                {
                   output.Add(item.getPart()); 
                }
                return output;
            }

            public void addComponent(_IComponent part)
            {
                comps.Add(part);
            }
               public void addManyComponent(List<_IComponent> part)
            {
                comps.AddRange(part);
            }

            public void removeComponent(_IComponent part)
            {
                comps.Remove(part);
            }


     }

}