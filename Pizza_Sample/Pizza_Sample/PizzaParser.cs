using System;
using System.Xml.Linq;

namespace Pizza_Sample
{
	public class PizzaParser
	{
        public IEnumerable<Pizza> ParsePizzas(string s)
        {
            List<Pizza> pizzas = new List<Pizza>();
            XDocument xDocument = XDocument.Load(s);
            foreach (var pizza in xDocument.Descendants("Pizza"))
            {
                Pizza pizzaObj = new Pizza
                {
                    FantasyName = pizza.Element("FantasyName").Value,
                    Type = pizza.Element("Type").Value,
                    Size = int.Parse(pizza.Element("Size").Value),
                    PastaThickness = int.Parse(pizza.Element("PastaThickness").Value),
                    NumberOfToppings = int.Parse(pizza.Element("NumberOfToppings").Value),
                    Price = double.Parse(pizza.Element("Price").Value),
                    IsVIP = pizza.Attribute("status")?.Value == "VIP",

                };
                pizzas.Add(pizzaObj);
            }
            
            return pizzas;
        }
    }
}

