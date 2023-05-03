using Miscelaneous;

Console.WriteLine("UTILITIES");
var numbers = Utilities.Fill(1000, 0, 99);
Console.WriteLine(Utilities.ToString(numbers));
Console.WriteLine("MODA");
var modas = Utilities.GetModas(numbers);
Console.WriteLine(Utilities.ToString(modas));
