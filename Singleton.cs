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
      Console.WriteLine("________________________________________________________________________________________________");
      Console.WriteLine("");
      Console.WriteLine("Маргарита(1) |  Охотничья(2)  |  Ветчина и грибы(3)   |    Филадельфия(4)     |  4 Сезона(5)");
      Console.WriteLine("Пепперони(6) | Деревенская(7) |  Цыпленок терияки(8)  |      Том ям(9)        |  Чизбургер(10)");
      Console.WriteLine(" Мясная(11)  | Пять сыров(12) | Двойная пепперони(13) | Космо с луком фри(14) | Бекон&салями(15) ");
      Console.WriteLine("________________________________________________________________________________________________");
      Console.WriteLine("");
    }

    public void PizzaSizeInterface()
    {
      Console.WriteLine("");
      Console.WriteLine("           Выберите размер пиццы:");
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

        case 6:
          Creators.Creator PepperoniCreator = new Creators.PepperoniCreator();
          PizzaTypes.Pizza PepperoniPizza = PepperoniCreator.FactoryMethod(PizzaSize);
          return PepperoniPizza;
          break;

        case 7:
          Creators.Creator RusticCreator = new Creators.RusticCreator();
          PizzaTypes.Pizza RusticPizza = RusticCreator.FactoryMethod(PizzaSize);
          return RusticPizza;
          break;

        case 8:
          Creators.Creator TeriyakiChickenCreator = new Creators.TeriyakiChickenCreator();
          PizzaTypes.Pizza TeriyakiChickenPizza = TeriyakiChickenCreator.FactoryMethod(PizzaSize);
          return TeriyakiChickenPizza;
          break;

        case 9:
          Creators.Creator TomYumCreator = new Creators.TomYumCreator();
          PizzaTypes.Pizza TomYumPizza = TomYumCreator.FactoryMethod(PizzaSize);
          return TomYumPizza;
          break;

        case 10:
          Creators.Creator CheeseburgerCreator = new Creators.CheeseburgerCreator();
          PizzaTypes.Pizza CheeseburgerPizza = CheeseburgerCreator.FactoryMethod(PizzaSize);
          return CheeseburgerPizza;
          break;

        case 11:
          Creators.Creator MeatyCreator = new Creators.MeatyCreator();
          PizzaTypes.Pizza MeatyPizza = MeatyCreator.FactoryMethod(PizzaSize);
          return MeatyPizza;
          break;

        case 12:
          Creators.Creator FiveCheeseCreator = new Creators.FiveCheeseCreator();
          PizzaTypes.Pizza FiveCheesePizza = FiveCheeseCreator.FactoryMethod(PizzaSize);
          return FiveCheesePizza;
          break;

        case 13:
          Creators.Creator DoublePepperoniCreator = new Creators.DoublePepperoniCreator();
          PizzaTypes.Pizza DoublePepperoniPizza = DoublePepperoniCreator.FactoryMethod(PizzaSize);
          return DoublePepperoniPizza;
          break;

        case 14:
          Creators.Creator CosmoWithOnionFriesCreator = new Creators.CosmoWithOnionFriesCreator();
          PizzaTypes.Pizza CosmoWithOnionFriesPizza = CosmoWithOnionFriesCreator.FactoryMethod(PizzaSize);
          return CosmoWithOnionFriesPizza;
          break;

        case 15:
          Creators.Creator BaconAndSalamiCreator = new Creators.BaconAndSalamiCreator();
          PizzaTypes.Pizza BaconAndSalamiPizza = BaconAndSalamiCreator.FactoryMethod(PizzaSize);
          return BaconAndSalamiPizza;
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
      Random OrderNumber = new Random();
      Console.WriteLine("");
      Console.WriteLine("Ваш заказ:");
      Console.WriteLine("Название: " + Pizza.OutputName());
      Console.WriteLine("Ингридиенты: " + Pizza.ShowIngredient());
      Console.WriteLine("Размер: " + Pizza.OutputSize() + "см");
      Console.WriteLine("Стоимость: " + Pizza.OutputSize() * 19);
      Console.WriteLine("Ваша пицца скоро будет готова");
      Console.WriteLine("Номер заказа: " + OrderNumber.Next(1000, 9999));
    }
    
    private Singleton() { }
    private static Singleton instance;
  }
}
