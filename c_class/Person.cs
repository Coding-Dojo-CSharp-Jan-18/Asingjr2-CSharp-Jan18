namespace c_class
{
    // Creating Person Class
    // Static is something that is permanent for the class and not instance
class Person{
    // Static attributes equate to Class Variables
    public static string ClassName = "Person";
    public static int PersonCount = 0;
    public string name; 
    public string location;
    private string birthday;
    public string birthdayReadOnly{
        get { return birthday; }
        // set{ birthday = value;}
    }
    private int SSN;
    // Can create using this.name = name or change arguements
    public Person(string name, string location, string bday, int social){
        this.name = name;
        this.location=location;
        birthday=bday;
        SSN = social;
        PersonCount++;
    }

}

}