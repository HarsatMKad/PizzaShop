using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      int PizzaName = 0, PizzaSize;
      bool key = true;

      Singleton.Singleton.Instance.PizzaTypesInterface();

      while (key)
      {
        key = false;
        try
        {
          PizzaName = Convert.ToInt32(Console.ReadLine());
          if (PizzaName < 1 || PizzaName > 15)
          {
            throw new Exception("Такой пиццы нет");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine($"Ошибка: {e.Message}");
          key = true;
        }
      }

      Singleton.Singleton.Instance.PizzaSizeInterface();

      key = true;
      while (key) 
      {
        key = false;
        try
        { 
          PizzaSize = Convert.ToInt32(Console.ReadLine());
          if(PizzaSize < 1 || PizzaSize > 4)
          {
            throw new Exception("Такого размера нет");
          }
          PizzaTypes.Pizza Pizza = Singleton.Singleton.Instance.CreatePizza(PizzaSize * 10, PizzaName);
          Singleton.Singleton.Instance.ShowPizza(Pizza);
        }
        catch (Exception e)
        {
          Console.WriteLine($"Ошибка: {e.Message}");
          key = true;
        }
      }
      Console.ReadKey();

    }
  }
}
