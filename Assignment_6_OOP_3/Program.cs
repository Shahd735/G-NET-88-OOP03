namespace Assignment_6_OOP_3;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What is the difference between a class and a struct?
        // => A Class is a Reference Type, data stored in the Heap while Struct is a Value Type, data stored in the Stack

        // b) Why are classes more suitable than structs for large applications?
        // => Classes support inheritance and polymorphism, and structs wastes memory
        #endregion

        #region Question2
        // a) Which class is the parent class?
        // => Shipment is the parent class

        // b) Which class is the child class?
        // => ExpressShipment is the child class

        // c) What members are inherited by ExpressShipment?
        // => TrackingCode

        // d) Why is inheritance better than duplicating the same code in multiple classes?
        // => You write the code once in the parent class and reuse it in all child classes.
        #endregion

        #region Question3
        DeliveryCenter center = new DeliveryCenter();

        Console.WriteLine("Enter Delivery Center Name:");
        center.CenterName = Console.ReadLine();

        DeliveryAddress defaultAddress = new DeliveryAddress("Cairo", "Tahrir", 1);

        Console.WriteLine();

        center.AddShipment(new StandardShipment("SH001", "Laptop", 3m, 80m, defaultAddress));
        Console.WriteLine("Shipment Added Successfully.");

        center.AddShipment(new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, defaultAddress, 30m));
        Console.WriteLine("Shipment Added Successfully.");

        center.AddShipment(new InternationalShipment("SH003", "Television", 8m, 120m, defaultAddress, "Germany", 100m));
        Console.WriteLine("Shipment Added Successfully.");
        Console.WriteLine();

        Console.WriteLine("==================================================");
        Console.WriteLine($"Delivery Center : {center.CenterName}");
        Console.WriteLine("==================================================");

        for (int i = 0; i < 20; i++)
        {
            if (center[i] != null)
            {
                center[i].PrintShipment(); 
                Console.WriteLine("--------------------------------------------------");
            }
        }

        Console.WriteLine("\nEnter Tracking Code to Remove:");
        string codeToRemove = Console.ReadLine();

        if (center.RemoveShipment(codeToRemove))
        {
            Console.WriteLine("\nShipment Removed Successfully.\n");
        }

        Console.WriteLine("==================================================");
        Console.WriteLine("Remaining Shipments");
        Console.WriteLine("==================================================");

        for (int i = 0; i < 20; i++)
        {
            if (center[i] != null)
            {
                center[i].PrintShipment();
                Console.WriteLine("...");
            }
        }

        Console.ReadLine();

        #endregion

    }
}


