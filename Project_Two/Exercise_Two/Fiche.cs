namespace Exercise_Two
{
    public class Fiche
    {
        // Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        // Constructors
        public Fiche(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }


        // Methods
        public override string ToString()
        {
            return $"Name = {Name}\nPhone = {Phone}\nAddress = {Address}";
        }
    }
}