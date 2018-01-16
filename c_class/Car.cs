namespace c_class
{
    class Car{
        public static int NumCars = 0;
    public string color;
    public double speed;
    public Car(string clr, double spd)
    {
        color=clr;
        this.speed=spd;
        NumCars++;
    }
    }
    // Inheritence for C#...works based on last model inherited
    // Inheritence requires definition of variables in new class and reference in base class (e.g. NewClass(required_attr1, optional_attr2) : baseclass(required attr1))
    // Inheritance must address required attributes before optional
       class IceTruck : Car
    {
        public int NumIceCreams;
        public IceTruck(string col, int spdd, int icecreams = 50 ) : base(col, spdd)
        {
            color = col;
            NumIceCreams = icecreams;
        }
    }
    class IceTruck2 : Car
    {
        public int NumIceCreams;
        // Inheritance attributes addressed in base class reference
        public IceTruck2(string col, int icecreams = 50) : base(col, 40.9)
        {
            color = col;
            NumIceCreams = icecreams;
        }
    }

}