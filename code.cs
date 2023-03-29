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
      int PizzaName, PizzaSize;
      bool key = true;

      Console.WriteLine("                   Приветствую вас в магазине пиццы");
      Console.WriteLine("              Выберите пиццу, которую вы хотите заказать:");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Маргарита(1)| Охотничья(2)| Ветчина и грибы(3)| Филадельфия(4)| 4 Сезона(5)");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");

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

      Console.WriteLine("");

      Console.WriteLine("Укажите размер пиццы:");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Малений(1)| Средний(2)| Большой(3)| Экстра(4)");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
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
            Creators.Creator Creator = new Creators.MargaritaCreator();
            PizzaTypes.Pizza pizza = Creator.FactoryMethod(PizzaSize);

            Console.WriteLine("");
            Console.WriteLine("Ваша пицца готова:");
            Console.WriteLine("Ингридиенты:" + pizza.OutputIngredient());
            Console.WriteLine("Размер: " + PizzaSize * 10);
            Console.WriteLine("Стоимость:" + PizzaSize * 149);
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
