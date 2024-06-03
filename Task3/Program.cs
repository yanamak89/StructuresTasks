//У класі Program створіть два методи: 
// static void ClassTaker(MyClass myClass), 
// який надає полю change екземпляра myClass значення «змінено». 
// 
// static void StruktTaker(MyStruct myStruct), 
// який надає полю change екземпляра myStruct значення «змінено». 

using Task3;

class Program
{
    static void ClassTaker(MyClass myClass)
    {
        myClass.change = "Changed";
    }

    static void StruktTaker(MyStruct myStruct)
    {
        myStruct.change = "Changed";
    }
    
    //Продемонструйте різницю у використанні класів та структур, 
    // створивши у методі Main() екземпляри структури та класу. 
    // Змініть значення полів екземплярів на «не змінено», 
    // а потім викличте методи ClassTaker і StruktTaker. 

    static void Main()
    {
        // Create instances of MyClass and MyStruct
        MyClass myClassInstance = new MyClass();
        MyStruct myStructInstance = new MyStruct();
        
        // Assign initial values
        myClassInstance.change = "not changed";
        myStructInstance.change = "not changed";

        // Display initial values
        Console.WriteLine($"Initial value of myClassInstance.change: {myClassInstance.change}");
        Console.WriteLine($"Initial value of myStructInstance.change: {myStructInstance.change}");

        
        // Call methods to change the values
        ClassTaker(myClassInstance);
        StruktTaker(myStructInstance);
        
        // Display values after calling the methods
        Console.WriteLine($"Value of myClassInstance.change after ClassTaker: {myClassInstance.change}");
        Console.WriteLine($"Value of myStructInstance.change after StruktTaker: {myStructInstance.change}");

        Console.WriteLine("Analysis:");
        Console.WriteLine("The class instance's field 'change' was modified by ClassTaker method.");
        Console.WriteLine("The struct instance's field 'change' was not modified by StruktTaker method because structs are passed by value.");

    }
}