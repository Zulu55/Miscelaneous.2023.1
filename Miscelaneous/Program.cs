using Miscelaneous;

Console.WriteLine("UTILITIES");
var changes = Utilities.Anagrams(
    new List<string>
    {
        "Los",
        "Perro",
        "Pan",
        "La vida es bella",
        "saroihdsrgpoigreu89er5wuyaesfoipwy4tyhdfgsalkjrsthjgdfasviouyergoihvdasiodfshñoasdifywoer9yhgadfrsjklñhdsbfljkys"
    },
    new List<string>
    {
        "Sol",
        "Gato",
        "Paz",
        "Bella es tu boca",
        "dpioujvdfkjdhrsgidsfhasrfgyiughjkdfgrliergiÁopaegrpegru´90we5tñvdfjlisrteuyp9gdfuadsofyvdsalkjhergwoiuyewsefiode"
    });
foreach (var change in changes)
{
    Console.WriteLine(change);
}

//var numbers = Utilities.Fill(1000, 0, 99);
//Console.WriteLine(Utilities.ToString(numbers));
//Console.WriteLine("MODA");
//var modas = Utilities.GetModas(numbers);
//Console.WriteLine(Utilities.ToString(modas));
