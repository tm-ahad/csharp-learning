/*  class is blueprint of a object
    object is a set of data structured by a class
*/

//storage class IdGenerator
public class IdGenerator {
    public static uint current = 0;

    public static uint genandUpdateId()
    {
        IdGenerator.current++;
        return IdGenerator.current;
    }
}

//defining a class
public class Student {
    //Class Field
    public uint Id;
    public uint Roll;
    public string Name;
    public uint Age;

    /*  constructor is a method
        that initiate a instance of a class
        using given parameters
    */

    //constructor
    public Student(string name, uint roll, uint Age)
    {
        //setting properties of a student object
        this.Name = name;
        this.Id = IdGenerator.genandUpdateId();
        this.Roll = roll;
        this.Age = Age;
    }

    //defining a method names print
    public void print()
    {
        Console.WriteLine(
            $"Student name: {this.Name}\n" +
            $"Student age: {this.Age}\n" +
            $"Student roll: {this.Roll}\n" +
            $"Student id: {this.Id}"
       );
    }
}

namespace Classes
{
    class Classes
    {
        static void Main()
        {
            Student student = new Student("TM Ahad", 9, 11);

            student.print();
        }
    }
}
