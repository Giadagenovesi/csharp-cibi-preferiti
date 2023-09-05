// See https://aka.ms/new-console-template for more information
//Creo array dei miei cibi preferiti
string[] CibiPreferiti = { "Pizza", "Sushi", "Patate al Forno", "Hamburger", "Pasta al ragù" };

Console.WriteLine("Ciao sono Giada e i miei cibi preferiti sono " + CibiPreferiti.Length);

//Stampo la mia classifica dei cibi preferiti
for (int i = 0; i < CibiPreferiti.Length; i++) 
{
    Console.WriteLine(CibiPreferiti[i]);
}
//Stampo il mio cibo nella prima posizione della classifica
Console.WriteLine("Il piatto che preferisco è " + CibiPreferiti[0]);

//Stampo il mio cibo nell' ultima posizione della classifica
Console.WriteLine("Il piatto che mi piace meno tra i miei preferiti è " + CibiPreferiti[CibiPreferiti.Length -1]);


