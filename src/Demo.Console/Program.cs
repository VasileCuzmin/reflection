using System.Reflection;

var currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
var typesFromCurrentAssembly = currentAssembly.GetTypes();
foreach (var type in typesFromCurrentAssembly)
{
    Console.WriteLine(type.Name);
}


var oneType = currentAssembly.GetType("Demo.Console.Person");

var externalAssembly = Assembly.Load("System.Text.Json");
var typesFromExternalAssembly = externalAssembly.GetTypes();
var oneTypeFromExternalAssembly = externalAssembly.GetType("System.Text.Json.JsonProperty");

var modulesFromExternalAssembly = externalAssembly.GetModules();

Console.ReadLine();