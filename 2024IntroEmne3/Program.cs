
/*
- eksempel med input 
- GitHub
- Skjelett med klasse og metode
*/

Console.Write("Hva heter du? ");
string name = Console.ReadLine();
Console.Write("I hvilket år er du født? ");
string birthYearStr = Console.ReadLine();
int birthYear = Convert.ToInt32(birthYearStr);
int age = 2024 - birthYear;
Console.Write("Har du hatt bursdag i år (j/n)? ");
string answer = Console.ReadLine();
char letter = answer[0];
if (letter == 'n')
{
    age--;
}

Console.WriteLine($"Hei, {name}!");
Console.WriteLine($"Du er {age} år gammel.");

