﻿using Aresak.Interfacify.Samples.ClassAttributeTest;
using Aresak.Interfacify.Samples.DifferentNamespace;
using Aresak.Interfacify.Samples.InterfaceAttributeTest;

namespace Aresak.Interfacify.Samples;

internal class Program
{
    static void Main(string[] args)
    {
        // This is just to make sure that the generated code compiles.

        // Generated properties for an existing class:
        TestClass testClass = new()
        {
            Email = "some-value"
        };

        // Generated a whole class from an interface:
        AutoGeneratedInterface testInterface = new()
        {
            Email = "some-value"
        };

        Console.WriteLine($"Generated enum value: {testClass.Enum}");
        testClass.Enum = TestEnum.Three;
        Console.WriteLine($"Set enum value: {testClass.Enum}");

        // Test the generated class implements the interface:
        TypeTest<AutoGeneratedInterface>();

        // Wow, it works!
        Console.WriteLine("Hello, World!");
    }

    static void TypeTest<T>() where T : IAutoGeneratedInterface
    {

    }
}
