using System;
namespace Pizza_Sample
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class ToStringAttribute : Attribute
	{
		
	}
}

