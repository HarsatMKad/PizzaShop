using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
  abstract class Pizza
  {
    int CountIngridient1;
    int CountIngridient2;
    int CountIngridient3;
  }

  class PizzaBananas : Pizza
  {
    string Name = "Bananas";
    int Size;
    int CountIngridient4;
    int CountIngridient5;
    int CountIngridient6;
  }

  class ChickenPesto : Pizza
  {
    string Name = "Курица с соусом песто";
    int Size;
    int CountIngridient4;
    int CountIngridient7;
    int CountIngridient8;
  }

  abstract class Pizzeria
  {
    public abstract Pizza FactoryMethod();
  }

  class Pizzzashop : Pizzeria
  {
    public override Pizza FactoryMethod() 
    {
      Pizza a = new ChickenPesto();
      
      return a; 
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pizzeria dev = new Pizzzashop();
      Pizza pi = dev.FactoryMethod();

      Console.ReadKey();
    }
  }
}
