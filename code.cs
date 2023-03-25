using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
  abstract class Pizza
  { }
  class PizzaBananas : Pizza
  {
    string Name = "Bananas";
    int Size;
    string Ingridients;
  }

  class ChickenPesto : Pizza
  {
    string Name = "Курица с соусом песто";
    int Size;
    string Ingridients;
  }

  class HamAndMushrooms : Pizza
  {
    string Name = "Ветчина и грибы";
    int Size;
    string Ingridients;
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

  class Beercity : Pizzeria
  {
    public override Pizza FactoryMethod()
    {
      Pizza a = new PizzaBananas();
      return a;
    }
  }

  class Mnogopizza : Pizzeria
  {
    public override Pizza FactoryMethod()
    {
      Pizza a = new HamAndMushrooms();
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
