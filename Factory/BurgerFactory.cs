using System;
using BurgerAPI.Factory;

namespace BurgerAPI.Factory
{
  public class BurgerFactory 
{

    public IBurger returnInstance ;

    public IBurger getBurger(String burgerType)
    {
       switch(burgerType)
       {
           case("chicken"):
           returnInstance = new ChickenBurger();
           break;
           case("plain"):
           returnInstance = new PlainBurger();
            break;
           case("cheese"):
           returnInstance = new CheeseBurger();
           break;

       }

        return returnInstance;


    }
    
}
}
