using Grpc.Net.Client;
using GrpcService;

using var channel = GrpcChannel.ForAddress("https://localhost:7288");

var client = new Greeter.GreeterClient(channel);
Console.Write("Enter name: ");
var name = Console.ReadLine();

var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine("Server response: " + reply.Message);
Console.ReadKey();