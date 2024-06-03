namespace Task5;

//Створіть структуру з ім'ям – Notebook. 
// Поля структури: 
// модель, 
// виробник, 
// вартість. 
// 
// У структурі має бути реалізований
// конструктор для ініціалізації полів та метод для виведення вмісту полів на екран.
public struct Notebook
{
    public string Model { get; set; }
    public string Producer { get; set; }
    public int Price { get; set; }

    public Notebook(string model, string producer, int price)
    {
        Model = model;
        Producer = producer;
        Price= price;
    }

    public void ShowNotebook()
    {
        Console.WriteLine($"Notebook model: {Model}, Notebook probucer: \"{Producer}\", Notebook price: {Price} USD.");
    }
}