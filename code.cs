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
      string PizzaName;
      int PizzaSize;

      Console.WriteLine("                   Приветствую вас в магазине пиццы");
      Console.WriteLine("              Выберите пиццу, которую вы хотите заказать:");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Маргарита(1)| Охотничья(2)| Ветчина и грибы(3)| Филадельфия(4)| 4 Сезона(5)");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");
      PizzaName = Convert.ToString(Console.ReadLine());
      Console.WriteLine("");

      Console.WriteLine("Укажите размер пиццы:");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Малений(1)| Средний(2)| Большой(3)| Экстра(4)");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
      PizzaSize = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");

      if (PizzaName == "1")
      {
        Creators.Creator Creator = new Creators.MargaritaCreator();
        PizzaTypes.Pizza pizza = Creator.FactoryMethod(PizzaSize);

        Console.WriteLine("Ваша пицца готова:");
        Console.WriteLine("");
        Console.WriteLine("Ингридиенты:" + pizza.OutputIngredient());
        Console.WriteLine("Размер: " + PizzaSize * 10);
        Console.WriteLine("Стоимость:" + PizzaSize * 149);
      }
      Console.ReadKey();
    }
  }
}
