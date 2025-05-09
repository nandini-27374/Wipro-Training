using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Emplloyee is working.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is supervising.");
    }
}

class Program
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.Work();//calls base method

        Manager mgr = new Manager();
        mgr.Work();//calls overriden method

        //Polymorphism
        Employee polyEmp = new Manager();
        polyEmp.Work();//Calls overridden method
    }
}