namespace PassengerCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking the Driver Log");

            // sökväg till textfil
            //Const används för att låsa ett värde till variabel
            const string filePath = "log.txt";



            //Hämta data från StreamReader---------------------

            //Hämta data från fil
            StreamReader reader = new StreamReader(filePath);

            //-------------------------------------------------



            //Hämta data från File-----------------------------

            //Hämta data från textfil
            reader.ReadLine();

            string[] stations = File.ReadAllLines(filePath);

            //-------------------------------------------------

            //Initera variabler för uträkning
            int passengerCount = 0;
            const int maxPassenger = 40;


            //Oavsett vilket sätt att hämta data, måste det i en loop.
            //En loop för varje rad

            //LOOP
            // {

                //Exempel på värde: "15,0,0"

                //Börja med att splita strängen med .Split() metoden
                //Använd "," som parameter värde. Split() returnerar String[]

                //Convert string[] values till Int32 med Convert.ToInt32()

                //Valideringen:

                // 1. Släpper av passagaer som skall gå av tåget.
                // passengerCount -= <antalet som skall gå av> >= 0

                // 2. Släpper på nya passagere på tåget.
                // Kollar om PassegnerCount <= maxPassenger

                // 3. Om det finns personer kvar på stationen, kontrollera att passengerCount == maxPassenger

            // }

            // 4. Vid sista station, passengerCount == 0

        }
    }
}