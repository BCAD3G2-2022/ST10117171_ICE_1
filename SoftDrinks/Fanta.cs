using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Factory;

namespace BurgerAPI.SoftDrinks
{

public class Fanta : ISoftDrink
{


public string getMl()
{
return "330";

}

public string getBrand()
{
 return "Fanta";

}

public string getFlavour()
{
 return "Orange";

}

}
}