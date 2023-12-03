using System;
namespace Pizza_Sample
{
	interface IPizza
	{
         string Type { get; set; }
         int Size { get; set; }
         int PastaThickness { get; set; }
         int NumberOfToppings { get; set; }
         double Price { get; set; }
         bool IsVIP { get; set; }
    }
}

