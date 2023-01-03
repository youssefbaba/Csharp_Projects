namespace Exercise_Two
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fiche fiche1 = new Fiche("Amanda Byrd", "(214)771-4611", "info@juvanew.com");
            Fiche fiche2 = new Fiche("Rekha Bhakta", "(903)519-9882", "texaslaserhair@gmail.com");
            Fiche fiche3 = new Fiche("Ida Cassaretto", "(210) 584-3731", "idacassaretto@gmail.com");
            Fiche fiche4 = new Fiche("Teresa L. Babb", "(242) 142-2546", "info@blushaestheticsandskincare.com");

            PhoneBook phoneBook = new PhoneBook();
            phoneBook.DictionaryPhoneBook.Add(fiche1.Name, fiche1);
            phoneBook.DictionaryPhoneBook.Add(fiche2.Name, fiche2);
            phoneBook.DictionaryPhoneBook.Add(fiche3.Name, fiche3);
            phoneBook.DictionaryPhoneBook.Add(fiche4.Name, fiche4);

            phoneBook.FindFicheByName("Ida Cassaretto");
            Console.WriteLine();
            phoneBook.FindFicheByName("Id Cassaretto");

            phoneBook.AddFicheByName("Eileen Andrews"); // "Eileen Andrews", "(512) 891- 0420", "eileenandrews@yahoo.com"
            phoneBook.AddFicheByName("Ida Cassaretto"); // "Ida Cassaretto", "(210) 584-2020", "newname@gmail.com"
            Console.WriteLine();

            Console.WriteLine($"{phoneBook}");
        }
    }
}