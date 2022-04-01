using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;
using BurgerAPI.Composite;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomBurgerController : ControllerBase
    {
     
  

        [HttpGet]
        public _IComponent Get(bool tomato, bool patty,bool bun, bool lettuce, bool cheese)
        {
          _IComponent burgerBun = new Bun();
          _IComponent burgerPatty = new Patty();
          _IComponent burgerCheese = new Cheese();
          _IComponent burgerLettuce = new Lettuce();
          _IComponent burgerTomato = new Tomato();


       
          BurgerComposite returnBurger = new BurgerComposite();
         // returnBurger.addComponent(burgerPatty);
        

        if (tomato)
        {
          returnBurger.addComponent(burgerTomato);
        }

          if (patty)
        {
           returnBurger.addComponent(burgerPatty);
        }
          if (bun)
        {
           returnBurger.addComponent(burgerBun);
        }
          if (lettuce)
        {
           returnBurger.addComponent(burgerLettuce);
        }
          if (cheese)
        {
           returnBurger.addComponent(burgerCheese);
        }


          return returnBurger ; //.getParts();
        }

    
    }
}
