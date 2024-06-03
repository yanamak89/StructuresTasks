namespace Task2;

// Потрібно: 
// Описати структуру з ім'ям Train, що містить такі поля: 
// назву пункту призначення, 
// номер поїзда, 
// час відправлення. 
//
//Написати програму, яка виконує такі дії:
//введення з клавіатури даних до масиву,
//що складається з восьми елементів типу Train 
//(записи мають бути впорядковані за номерами поїздів); 
//виведення на екран інформації про поїзд, номер якого введено з клавіатури
//(якщо таких поїздів немає, вивести відповідне повідомлення). 

public struct Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }

    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public override string ToString()
    {
        return $"Train Number: {TrainNumber}, Destination: {Destination}" +
               $"DepartureTime: {DepartureTime}";
    }
}

public class TrainSchedule
{
    private Train[] trains;

    public TrainSchedule(int size)
    {
        trains = new Train[size];
    }

    public void AddTrain(int index, Train train)
    {
        if (index >= 0 && index < trains.Length)
        {
            trains[index] = train;
        }
    }

    public void SortTrainsByNumber()
    {
        for (int i = 0; i < trains.Length - 1; i++)
        {
            for (int j = 0; j < trains.Length - i - 1; j++)
            {
                if (trains[j].TrainNumber > trains[j + 1].TrainNumber)
                {
                    // Swap trains[j] and trains[j + 1]
                    Train temp = trains[j];
                    trains[j] = trains[j + 1];
                    trains[j + 1] = temp;
                }
            }
        }
    }

    public Train? SearchTrainByNumber(int trainNumber)
    {
        foreach (var train in trains)
        {
            if (train.TrainNumber == trainNumber)
            {
                return train;
            }
        }
        return null;
    }

    public void DisplayTrains()
    {
        foreach (var train in trains)
        {
            Console.WriteLine(train.ToString());
        }
    }
}