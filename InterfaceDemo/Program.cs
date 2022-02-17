using System;
public interface Vehical //Creting the first interface Vehical 
{
    //abstract method start() which will be impleted by child class
    void start(); 
}
public interface Engine //Creating the second interface Engine
{
    //abstract method start() which will be impleted by child class
    void power(); 
}
class Car : Vehical, Engine // Multiple inheritance using Interface 
{
   public void start() //child class car is providing the body of start() method.
    {
        //body of method
        Console.WriteLine("Car start with key");
    }
   public  void power() ////child class car is providing the body of power() method.
    {
        //body of method
        Console.WriteLine(("car has power of 1500CC"));
    }

}
class Bike: Vehical, Engine // child2 implementing the interfaces
{
    public void start() // proving body of abstract method
    {
        Console.WriteLine("Bike starts with key");
    }
    public void power() // providing body of abstract mrthod
    {
        Console.WriteLine(("bike has power of 200CC"));
    }
}
class MainProgram
{
    public static void Main(String[] args)
    {
        //creating the object oF car class and calling the methods(). 
        Car c = new Car();
        c.start();
        c.power();

        //creating the object oF bike class and calling the methods(). 
        Bike b = new Bike();
        b.start();
        b.power();

    }
}

