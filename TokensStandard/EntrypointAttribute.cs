using System;

namespace TokensStandard
{
    [AttributeUsage(AttributeTargets.Method)]
    public class EntrypointAttribute : Attribute
    {
        public EntrypointAttribute() : base()
        {
        }
    }
}
