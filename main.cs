using System;

class MainClass {
  public static void Main (string[] args) {

    Employee number1 = new Employee();
    number1.Intro();

    Employee number2 = new Employee("Robert", "Downey", "12321", 12, 100);
    number2.Intro();   
   
    Employee number3 = new Employee("John", "Smith", "S0089", 38, 50000);
    number3.Intro();
    number3.IncreaseSalary(-.02);
    number3.RemoveEmployee();

    Employee number4 = new Employee("Maria", "Lambert", "S0100", 26, 80000);
    number4.Intro();
    number4.IncreaseSalary(.07);
    number4.RemoveEmployee();
    number4.RemoveEmployee();
  
  }
}