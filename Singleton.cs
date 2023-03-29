using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  public class Singleton
  {
    public static Singleton Instance
    {
      get
      {
        if (instance == null) instance = new Singleton();
        return instance;
      }
    }

    public void PizzaTypesInterface()
    {
      Console.WriteLine("                   Приветствую вас в магазине пиццы");
      Console.WriteLine("              Выберите пиццу, которую вы хотите заказать:");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Маргарита(1)| Охотничья(2)| Ветчина и грибы(3)| Филадельфия(4)| 4 Сезона(5)");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("            |             |                   |               |            ");
      Console.WriteLine("____________________________________________________________________________");
      Console.WriteLine("");
    }

    public void PizzaSizeInterface()
    {
      Console.WriteLine("");
      Console.WriteLine("Укажите размер пиццы:");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Малений(1)| Средний(2)| Большой(3)| Экстра(4)");
      Console.WriteLine("______________________________________________");
      Console.WriteLine("");
    }

    public PizzaTypes.Pizza CreatePizza(int PizzaSize, int PizzaName)
    {
      switch (PizzaName)
      {
        case 1:
          Creators.Creator MargaritaCreator = new Creators.MargaritaCreator();
          PizzaTypes.Pizza MargaritaPizza = MargaritaCreator.FactoryMethod(PizzaSize);
          return MargaritaPizza;
          break;

        case 2:
          Creators.Creator HuntingCreator = new Creators.HuntingCreator();
          PizzaTypes.Pizza HuntingPizza = HuntingCreator.FactoryMethod(PizzaSize);
          return HuntingPizza;
          break;

        case 3:
          Creators.Creator HamAndMushroomsCreator = new Creators.HamAndMushroomsCreator();
          PizzaTypes.Pizza HamAndMushroomsPizza = HamAndMushroomsCreator.FactoryMethod(PizzaSize);
          return HamAndMushroomsPizza;
          break;

        case 4:
          Creators.Creator PhiladelphiaCreator = new Creators.PhiladelphiaCreator();
          PizzaTypes.Pizza PhiladelphiaPizza = PhiladelphiaCreator.FactoryMethod(PizzaSize);
          return PhiladelphiaPizza;
          break;

        case 5:
          Creators.Creator FourSeasonsCreator = new Creators.FourSeasonsCreator();
          PizzaTypes.Pizza FourSeasonsPizza = FourSeasonsCreator.FactoryMethod(PizzaSize);
          return FourSeasonsPizza;
          break;

        default:
          Creators.Creator CreatorStandartPizza = new Creators.MargaritaCreator();
          PizzaTypes.Pizza StandartPizza = CreatorStandartPizza.FactoryMethod(PizzaSize);
          return StandartPizza;
          break;
      }
    }

    public void ShowPizza(PizzaTypes.Pizza Pizza)
    {
      Console.WriteLine("");
      Console.WriteLine("Ваша пицца готова:");
      Console.WriteLine("Название: " + Pizza.OutputName());
      Console.WriteLine("Ингридиенты: " + Pizza.ShowIngredient());
      Console.WriteLine("Размер: " + Pizza.OutputSize() + "см");
      Console.WriteLine("Стоимость: " + Pizza.OutputSize() * 19);
    }
    
    private Singleton() { }
    private static Singleton instance;
  }
}
