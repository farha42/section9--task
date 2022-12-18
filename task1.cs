using System;
public class Person{
private string _Name;
private string _name;   
public string Name
{
    get 
    {
        return _name;
    } 
    set
    {
    if(value == null || value=="" || value.Length>=32)
    {
        throw new Exception("invalid name");
    } 
        _name=value;
    }
}
private int _Age;
public Person(string name,int age)
{
public Person(string name,int age)
    Console.WriteLine("invalid age");
    return;
} 
_Name=name;
Name=name;
_Age =age;
}
public string Getname( ) =>_Name;

public int Getage() =>_Age;
public void Setname(string name)
{
    if(name == null || name=="" || name.Length>=32)
{
    throw new Exception("invalid name");
} 
    _Name=name;
}


public virtual  void Print()
    {
    Console.WriteLine($"My name is {_Name}, my age is {_Age}");
    Console.WriteLine($"My name is {Name}, my age is {_Age}");
    }

}

public class Student :  Person
{
    public int Year;
    public float Gpa;
    private int _Year;
    public int Year
    {
    get 
    {
        return _Year;
    } 
    set
    {
        _Year=value;
    }   
    }
    private float _Gpa;
    public float Gpa
    {
    get 
    {
        return _Gpa;
    } 
    set
    {
        _Gpa=value;
    }      
    }
    public Student(string name,int age,int year,float gpa ):base(name, age)
    {
        if (year>1 ||year<5)
public Student(string name,int age,int year,float gpa ):base(name, age)
    }
    public override void Print()
    {
        Console.WriteLine($"my name is{Getname()},my age is {Getage()},and my gpa is{Gpa}");
        Console.WriteLine($"my name is{Name},my age is {Getage()},and my gpa is{Gpa}");
    }
}
public class Stuff :Person 
{
    public int JoinYear;
    public double Salary;
    private int _JoinYear;
    public int JoinYear
    {
    get 
    {
        return _JoinYear;
    } 
    set
    {
        _JoinYear=value;
    }   
    }
    private double _Salary;
    public double Salary
    {
        get 
    {
        return _Salary;
    } 
    set
    {
        _Salary=value;
    }   
    }
    public Stuff(string name,int age,int joinyear,double salary ):base(name, age)

    {
public Stuff(string name,int age,int joinyear,double salary ):base(name, age)
    }
    public override void Print()
    {
        Console.WriteLine($"my name is{Getname()},my age is {Getage()},and my salary is{Salary}");
        Console.WriteLine($"my name is{Name},my age is {Getage()},and my salary is{Salary}");
    }
}
public class Database{

private int _current =0;   
public Person [] Peple =new Person [50]; 
public void Addperson (Person person)
{
  // if (_current==49) return; 
Peple[_current++]=person; 
}
public void Addstudent (Student student)
{
  // if (_current==49) return; 
Peple[_current++]=student; 
}
public void Addstuff (Stuff stuff)
{
  // if (_current==49) return; 
Peple[_current++]=stuff; 
}
public void PrintAll()
{
     for(var i = 0 ; i <_current; i++)
    {
        Peple[i].Print();
    }
  } 
}
public class program{
    private static void Main() 
    {
    Console.Write("enter numberfrom 1 to 4:");
    var number=Convert.ToInt32( Console.ReadLine());
    if (number==1)
    {
    var database= new Database();
    Console.Write("name:");
    var name=Console.ReadLine();
    Console.Write("age:");
    var age=Convert.ToInt32( Console.ReadLine());
    Console.Write("year:");
    var year=Convert.ToInt32( Console.ReadLine());
    Console.Write("gpa:");
    var gpa=Convert.ToSingle( Console.ReadLine());
    try
    {
    Student student=new Student(name,age,year,gpa);
    database.Addstudent(student);
    }
    catch
    {
    Console.WriteLine("invalid input"); 
    }
    
    }
    else if(number==2)
    {
    var database= new Database();
    Console.Write("name:");
    var name=Console.ReadLine();
    Console.Write("age:");
    var age=Convert.ToInt32( Console.ReadLine());
    Console.Write("joinyear:");
    var joinyear=Convert.ToInt32( Console.ReadLine());
    Console.Write("slasry:"); 
        var salary=Convert.ToDouble( Console.ReadLine());
    try
{
    var stuff=new Stuff (name,age,joinyear,salary);
    database.Addstuff(stuff);  
    }
    catch
    {
        Console.WriteLine("invalid input");      
    }
    }
    else if(number==3)
    {
    {
    var database= new Database();
    Console.Write("name:");
    var name=Console.ReadLine();
    Console.Write("age:");
    var age=Convert.ToInt32( Console.ReadLine());
    try
    {
    var person=new Person (name,age);
    database.Addperson(person);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    }
    else 
    {
    var database= new Database();
    database.PrintAll();  
    }
}
}