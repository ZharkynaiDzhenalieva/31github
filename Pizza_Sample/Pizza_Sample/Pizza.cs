using System;
using System.Reflection;

namespace Pizza_Sample
{
    public class Pizza : IPizza
    {
        [ToString]
        public string Type { get; set; }
        [ToString]
        public int Size { get; set; }
        [ToString]
        public int PastaThickness { get; set; }
        [ToString]
        public int NumberOfToppings { get; set; }
        [ToString]
        public double Price { get; set; }
        [ToString]
        public bool IsVIP { get; set; }
        [ToString]
        [FantasyNameValidator('$', 10)]
        public string FantasyName { get; set; }

        public override string ToString()
        {
            string s = "";
            Type type = GetType();

            foreach (var prop in type.GetProperties())
            {
                var attrib = prop.GetCustomAttribute<ToStringAttribute>();
                if (attrib is not null)
                {
                    s += $"{prop.Name}: {prop.GetValue(this)}";
                }

            }
            return s;
            
        }
    }
}

