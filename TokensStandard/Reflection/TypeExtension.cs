using System;
using System.Reflection;

namespace TokensStandard.Reflection
{
    public static class TypeExtension
    {
        public static bool IsTypeAlias(this Type type) => type.GetCustomAttribute<TypeAliasAttributte>() != null;
        public static bool IsNameConstructor(this Type type) => type.GetCustomAttribute<NameConstructorAttribute>() != null;
        public static bool IsScript(this Type type) => type.GetCustomAttribute<ScriptAttribute>() != null;
        public static bool IsScript(this MethodInfo method) => method.GetCustomAttribute<ScriptAttribute>() != null;
    }
}
