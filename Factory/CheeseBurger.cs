using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerAPI.Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Factory
{
public class CheeseBurger : IBurger{


public string getBun()
{
return "Rye";

}

public string getPatty()
{
 return "Beef";

}

public string getCheese()
{
return "Cheese";
}

}
}
