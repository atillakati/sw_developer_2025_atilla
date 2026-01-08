namespace Beispiel_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[]
            {
                "Gandalf",
                "Eomer",
                "Sauron",
                "Legolas"
            };

            Adresse[] myAdressList = new Adresse[5];

            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
                nameList[i] = "NoName";
            }

            foreach(string name in nameList)
            {
                //name = string.Empty;  //SCHREIBGESCHÜTZT!

                Console.WriteLine(name);
            }
            
            foreach (Adresse adr in myAdressList)
            {
                //adr.Wohnort = "Dornbirn";  //SCHREIBGESCHÜTZT!
            }

        }
    }
}
