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
    public class SoftDrinkController : ControllerBase
    {
     
       /* BurgerFactory factory = new BurgerFactory();

        String selectedBurger = ""; 
         JOptionPane.showMessageDialog(null, "You orderded a burger with " + selectedBurgerType.getBun() + " and"  + selectedBurgerType.getPatty() + " and" + selectedBurgerType.getCondiments());

        */

      [HttpGet]
        public List<SoftDrink> GetDrinks(string drinkChoice="coke")
        {
         SoftDrinkFactory sdFactory = new SoftDrinkFactory();
         ISoftDrink sDrink = sdFactory.getDrink(drinkChoice);  


         List<SoftDrink> returnedSoftDrink = new List<SoftDrink>();
         returnedSoftDrink.Add(new SoftDrink{ml= sDrink.getMl(),brand = sDrink.getBrand(), flavour= sDrink.getFlavour()});     

           return returnedSoftDrink;
        }
        
    }
}
