namespace Exercise_Two
{
    public class PhoneBook
    {
        // Properties
        public Dictionary<string, Fiche> DictionaryPhoneBook { get; }


        // Constructors
        public PhoneBook()
        {
            DictionaryPhoneBook = new Dictionary<string, Fiche>();
        }


        // Methods
        public void FindFicheByName(string name)
        {
            if (name != null)
            {
                Fiche fiche;
                if (DictionaryPhoneBook.TryGetValue(name, out fiche))
                {
                    Console.WriteLine($"{fiche}");
                }
                else
                {
                    Console.WriteLine("This fiche doesn't exist.");
                }
            }
        }
        public void AddFicheByName(string name)
        {
            if (name != null)
            {
                if (!DictionaryPhoneBook.ContainsKey(name))
                {
                    Console.Write("Please enter a valid phone : ");
                    string phone = Console.ReadLine();
                    Console.Write("Please enter a valid address : ");
                    string address = Console.ReadLine();
                    Fiche fiche = new Fiche(name , phone, address); 
                    DictionaryPhoneBook.Add(fiche.Name, fiche);
                }
                else
                {
                    Console.Write("Please you want to modify or not the values of the fiche of the corresponding key ? : YES/NO  ");
                    string choice = Console.ReadLine();
                    while (choice.ToUpper() != "YES" && choice.ToUpper() != "NO")
                    {
                        Console.Write("Please try to enter a valid value again : YES/NO  ");
                        choice = Console.ReadLine();
                    }
                    if (choice.ToUpper() == "YES")
                    {
                        Console.Write("Please enter a new valid phone : ");
                        string phone = Console.ReadLine();
                        Console.Write("Please enter a new valid address : ");
                        string address = Console.ReadLine();
                        Fiche fiche = new Fiche(name, phone, address);
                        DictionaryPhoneBook[name] = fiche;
                    }
                }
            }
        }
        public override string ToString()
        {
            string result = string.Empty;
            foreach (Fiche fiche in DictionaryPhoneBook.Values)
            {
                result += $"{fiche}\n";
            }
            return result;
        }
    }
}