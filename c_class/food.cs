namespace c_class
{
    class Food
    {
        public int cal { get; set;}
        public string type { get; set; }
        public int feeds { get; set; }
        // public string _taste 
        // { 
        //     private set { this._taste = "wonderful";}
        //     get {return this._taste;}
        // }
        private string _taste = "wonderful";
        public string taste { get { return _taste;}}
        public Food(int cl, string ct, int fd) 
        {
            cal = cl;
            type = ct;
            feeds = fd;
        }

        public Food Info()
        {
            System.Console.WriteLine(this.cal);
            System.Console.WriteLine($"Calories:{this.cal} type: {this.type} feeds: {this.feeds}");
            return this;
    }
    }

}