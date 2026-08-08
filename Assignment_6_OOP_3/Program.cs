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

    }
}


