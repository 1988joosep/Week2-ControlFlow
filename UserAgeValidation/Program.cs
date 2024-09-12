// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnamnime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome Mr.(kasutaja perekonnanimi)" / "Welcome Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Hello, Mr.{userLastName}!");

}
else if(userGender == 'f')
{
    Console.WriteLine($"Hello, Ms.{userLastName}!");
}
else
{
    Console.WriteLine("Welcome!");
}



Console.WriteLine($"Welcome, {userGender}");

