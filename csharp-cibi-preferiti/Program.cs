// See https://aka.ms/new-console-template for more information
//Creo array dei miei cibi preferiti
string[] CibiPreferiti = { "Pizza", "Sushi", "Patate al Forno", "Hamburger", "Pasta al ragù"};

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

//BONUS stampo il cibo a metà classifica gestendo eventualità in cui il mio array contenga numero pari di elementi
if (CibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine($"I cibi che occupa la metà della mia classifica sono {CibiPreferiti[CibiPreferiti.Length / 2]} , {CibiPreferiti[CibiPreferiti.Length / 2 - 1]} ");
}
else
{
Console.WriteLine($"Il cibo che occupa la metà della mia classifica è {CibiPreferiti[CibiPreferiti.Length / 2]} ");

}
