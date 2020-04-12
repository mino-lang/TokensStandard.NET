using System;

namespace TokensStandart
{
    /// <summary>
    /// Target method was generated from tokens how constructor with name
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class NameConstructorAttribute : Attribute
    {
        public string Name { get; set; }

        public NameConstructorAttribute(string name)
        {
            Name = name;
        }
    }
}
