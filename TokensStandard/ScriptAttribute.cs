using System;

namespace TokensStandard
{
    /// <summary>
    /// Method and class for this is generated from script on tokens
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ScriptAttribute : Attribute
    {
        // Если класс имеет данный атрибут, то когда мы будем использовать библиотеку
        // с этим классом в Mino (другом языке, который компилируется в токены), то мы
        // сможем использовать методы этого класса без его вызова
        /* For example: 
         * ```csharp
         * [Script]
         * public static MyClass {
         * static void Hello() => Console.WriteLine("Hello");
         * }
         * ```
         * ```mino
         * include MyLib;
         * Hello(); //so work
         * ```
         * OUTPUT: Hello
         */
    }
}
