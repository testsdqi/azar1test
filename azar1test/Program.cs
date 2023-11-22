Console.Write("enter name:");
string str = Console.ReadLine();
Console.WriteLine("name:  "+str);




Console.WriteLine("plaese enter a name :");
string name = Console.ReadLine();
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"name is :{name}");
    Console.WriteLine($"number is :{i}");
}
