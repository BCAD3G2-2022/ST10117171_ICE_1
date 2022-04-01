using System;
using BurgerAPI.Factory;

namespace BurgerAPI.SoftDrinks
{
  public class SoftDrinkFactory
{

    public ISoftDrink returnSoftDrink ;

    public ISoftDrink getDrink(String drinkType)
    {
       switch(drinkType)
       {
           case("coke"):
           returnSoftDrink = new Coke();
           break;
           case("fanta"):
           returnSoftDrink = new Fanta();
            break;


       }

        return returnSoftDrink;


    }
    
}
}
