using System;
namespace Pizza_Sample
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class FantasyNameValidatorAttribute : Attribute
	{
        public FantasyNameValidatorAttribute(char character, int length)
        {
            Character = character;
            Length = length;
        }

        public char Character { get; set; }
        public int Length { get; set; }

    }
}

