using Task2;

class Program
{
    static void Main(string[] args)
    {
        TrainSchedule scedule = new TrainSchedule(8);
        // Input data from keyboard
        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine($@"Enter details for train {i + 1}: ");
            
            Console.Write("Destination: ");
            string destination = Console.ReadLine();
            
            Console.Write("Train Number: ");
            int trainNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Departure Time (hh:mm): ");
            DateTime departureTime = DateTime.Parse(Console.ReadLine());

            Train train = new Train(destination, trainNumber, departureTime);
            scedule.AddTrain(i, train);
            
            Console.WriteLine();
        }
        
        // Sort the trains array by TrainNumber
        scedule.SortTrainsByNumber();
        
        // Display sorted train list
        Console.WriteLine("Sorted train lists: ");
        scedule.DisplayTrains();
        
        // Input the train number to search
        Console.Write("Enter train numebr to search: ");
        int searchNumber = int.Parse(Console.ReadLine());
        
        // Search for the train
        Train? foundTrain = scedule.SearchTrainByNumber(searchNumber);
        if (foundTrain != null)
        {
            Console.WriteLine($"Train found: {foundTrain}");
        }
        else
        {
            Console.WriteLine("No train found with the entered number.");
        }
    }
}