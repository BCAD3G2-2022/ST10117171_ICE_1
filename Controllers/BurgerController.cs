using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;
using BurgerAPI.SoftDrinks;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurgerController : ControllerBase
    {
     
       /* BurgerFactory factory = new BurgerFactory();

        String selectedBurger = ""; 
         JOptionPane.showMessageDialog(null, "You orderded a burger with " + selectedBurgerType.getBun() + " and"  + selectedBurgerType.getPatty() + " and" + selectedBurgerType.getCondiments());

       

        */

        [HttpGet]
        public List<Burger> Get(string BurgerType="plain")
        {
         BurgerFactory burgerFactory = new BurgerFactory();
         IBurger Burger = burgerFactory.getBurger(BurgerType);
         List<Burger> returnedBurger = new List<Burger>();

         if (Burger is CheeseBurger)
         {
             CheeseBurger chBurger = (CheeseBurger)Burger;
             returnedBurger.Add(new Burger{patty= chBurger.getPatty(), Bun=chBurger.getBun(), extras = chBurger.getCheese()});
         }
         else
         {
             returnedBurger.Add(new Burger{patty= Burger.getPatty(), Bun=Burger.getBun(), extras = "none"});
         }
         
       //  returnedBurger.Add(new Burger{patty= Burger.getPatty(), Bun=Burger.getBun()});
           return returnedBurger;
        }


    }
}
