using System.Xml.Serialization;

namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void ShowCarList(string[] carsList)
    {
        Console.WriteLine("\nVoici la liste des voitures :\n");
        for (int i = 0; i < carsList.Length; i++)
        {
            Console.WriteLine(i + 1 + ": " + carsList[i]);
        }
    }
    static void Main(string[] args)
    {
        string[] cars = { "banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        string replay = " ";
        ShowCarList(cars);
        do
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\nChoisis une voiture à remplacer grâce à son numéro !");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > 5);
            Console.WriteLine("\nChoisis le nom du nouveau véhicule...");
            string newCar = Console.ReadLine();
            cars[choice - 1] = newCar;
            ShowCarList(cars);
            do
            {
                Console.WriteLine("\nVeux-tu changer une autre voiture ?");
                replay = Console.ReadLine();
            }while (replay != "oui" && replay != "non");
        } while (replay == "oui");
    }
}