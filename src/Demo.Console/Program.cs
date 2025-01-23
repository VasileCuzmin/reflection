using System.Reflection;

var currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
var typesFromCurrentAssembly = currentAssembly.GetTypes();
foreach (var type in typesFromCurrentAssembly)
{
    Console.WriteLine(type.Name);
}


var personType = currentAssembly.GetType("Demo.Console.Person");

foreach (var constructor in personType?.GetConstructors())
{
    Console.WriteLine(constructor);
}

foreach (var method in personType?.GetMethods())
{
    Console.WriteLine(method);
}

foreach (var method in personType?
    .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine(method);
}

foreach (var method in personType?
    .GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
{
    Console.WriteLine(method);
}

var externalAssembly = Assembly.Load("System.Text.Json");
var typesFromExternalAssembly = externalAssembly.GetTypes();
var oneTypeFromExternalAssembly = externalAssembly.GetType("System.Text.Json.JsonProperty");

var modulesFromExternalAssembly = externalAssembly.GetModules();

Console.ReadLine();