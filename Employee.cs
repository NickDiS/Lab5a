using System;
class Employee {

    //Fields
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;
    private bool inactive;

    //Defult Constructor
    public Employee()
    {
      Firstname="Unknown";
      Lastname="Unknown";
      Id="Unknown";
      Age=0;
    }
    //Constructor with 4 parameters
    public Employee(string firstname, string lastname, string id, int age, double yearlysalary)
    {
      Firstname = firstname;
      Lastname = lastname;
      Id = id;
      Age = age;
      Yearlysalary = yearlysalary;
      employmentstatus = "active";
    }


    //Properties
    public string Firstname{get; set;}
    public string Lastname {get; set;}
    public int Age {
      get{ return age; }
      set{
        if (value>=18)
          age = value;
        else
        {
          //age must at least be 18
          age = 18;
        }          
      }
    }
    public double Yearlysalary{
      get{ return yearlysalary; }
      set{
        if (value>1000)
        yearlysalary = value;
        else
        {
          //cannot be less than 1000
          yearlysalary = 1000;
        }
      }
    }
    public string Id{get; set;}
    public string Employmentstatus{get; set;}



    //Methods    
    public void Intro()
    {
      Console.WriteLine("First name: " + Firstname);
      Console.WriteLine("Last name: " + Lastname);
      Console.WriteLine("Age: " + Age);
      Console.WriteLine("Id: " + Id);
      Console.WriteLine("Yearly Salary: " + yearlysalary);
      }

    public void IncreaseSalary(double Percent)
    {
      if (Percent>0) 
      {
      Yearlysalary = Yearlysalary + (Yearlysalary * Percent);
      Console.WriteLine("Yearly salary updated to " + Yearlysalary);
      }
      else
      {
        Console.WriteLine("invalid input. Yearly Salary not updated");
      }
    }

    public void RemoveEmployee()
    {
      if (inactive)
      {
        Console.WriteLine("Employee already inactive");
      }
      else
      {
        inactive=true;
        Console.WriteLine("Employee removed");
      }

    }
}