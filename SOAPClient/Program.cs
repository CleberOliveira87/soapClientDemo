// See https://aka.ms/new-console-template for more information

using ServiceDemoSoapReference;

var client = new SOAPDemoSoapClient(SOAPDemoSoapClient.EndpointConfiguration.SOAPDemoSoap, "https://www.crcind.com/csp/samples/SOAP.Demo.CLS");

// Operação 1 (síncrono)

var resultOp1 = client.AddInteger(3, 2);

Console.WriteLine("###");
Console.WriteLine("Operação AddInteger(3, 2)");
Console.WriteLine("Resultado: " + resultOp1);
Console.WriteLine("###");

// Operação 2 (assíncrono)

var resultOp2 = await client.DivideIntegerAsync(6, 2);

Console.WriteLine("Operação DivideIntegerAsync(6, 2)");
Console.WriteLine("Resultado: " + resultOp2);
Console.WriteLine("###");

// Operação 3 (assíncrono)

var resultOp3 = await client.GetListByNameAsync("Adam");

Console.WriteLine("Operação GetListByNameAsync('Adam')");

foreach (var person in resultOp3)
{
    Console.WriteLine(person.ID + " "+ person.Name);
}

Console.WriteLine("###");
