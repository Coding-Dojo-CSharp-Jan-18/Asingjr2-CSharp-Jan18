namespace c_class
{
    class Vehicle
    {
        public int passengers = 5;
        public double distance = 0.0;
        public Vehicle(int val)
        {
            // adding this attribute back explicitely requires arguement for all builds
            passengers = val;
        }
        //  Adding public method
        public Vehicle Move(double miles)
        {
            distance += miles;
            return this;
        }
        public Vehicle Honk()
        {
            System.Console.WriteLine("Honking horn");
            return this;
        }
        // ****************************
        // Can overload methods and variable but altering arguements or return values if any and eg. Move take int vs double, or returning something vs not, or Vehicle taking float vs
    
    }
}