using System.Reflection;
using Demo.Console;

var personType = typeof(Person);
var publicPersonConstructor = personType.GetConstructors(); //only public constructors
var privatePersonConstructors = personType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
var privatePersonConstructor = personType
    .GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, [typeof(int), typeof(string)], null);


var personConstructors =
    personType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
var person1 = personConstructors[0].Invoke(null);
var person2 = personConstructors[1].Invoke(["Kevin"]);
var person3 = personConstructors[2].Invoke([12,"Vasile"]);
;


static void CodeFromSecondModule()
{
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
}