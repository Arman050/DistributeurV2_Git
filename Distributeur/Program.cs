int stock1, stock2, stock3, choix;

stock1 = 5;
stock2 = 2;
stock3 = 0;

Console.WriteLine("Veuillez choisir une boisson : ");
Console.WriteLine("1 : Eau");
Console.WriteLine("2 : Coca");
Console.WriteLine("3 : Fanta");

choix = int.Parse(Console.ReadLine());

switch (choix) 
{
    case 1 : if (stock1 > 0) 
            {
            Console.WriteLine ("Vous avez choisi de l'eau");
            stock1--;
            }
            else
            {
                Console.WriteLine("il n'y a plus d'eau en stock");
            }
            break;
    case 2 : if (stock2 > 0) 
            {
            Console.WriteLine ("Vous avez choisi du coca");
            stock2--;
            }
            else
            {
                Console.WriteLine("il n'y a plus de coca en stock");
            }
            break;
    case 3 : if (stock3 > 0) 
            {
            Console.WriteLine ("Vous avez choisi du fanta");
            stock3--;
            }
            else
            {
                Console.WriteLine("il n'y a plus de fanta en stock");
            }
            break;
}