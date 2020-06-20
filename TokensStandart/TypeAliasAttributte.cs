using System;
using System.Collections.Generic;
using System.Text;

namespace TokensStandart
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Interface)]
    public class TypeAliasAttributte : Attribute
    {
    }
}
