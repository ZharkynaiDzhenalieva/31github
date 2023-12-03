using System;
using System.Reflection;

namespace Pizza_Sample
{
	public class Validator
	{
        public bool CheckFantasyName(object o)
        {
            var typeInfo = o.GetType();
            var propertyInfo = typeInfo.GetProperty("FantasyName");
            var attribute = propertyInfo.GetCustomAttribute<FantasyNameValidatorAttribute>();

            if(attribute is null)
            {
                throw new ArgumentException("The property or the attribute does not exist");
            }
            string value = (string)propertyInfo.GetValue(o);

            return value.Contains(attribute.Character)
                && value.Length >= attribute.Length;
        }

    }
}

