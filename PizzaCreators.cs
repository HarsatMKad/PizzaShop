using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creators

{
  abstract class Creator
  {
    public abstract PizzaTypes.Pizza FactoryMethod(int Size);
  }

  class MargaritaCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Базилик свежий");

      return new PizzaTypes.Margarita(Size, ingredients);
    }
  }

  class HuntingCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Охотничьи колбаски,");
      ingredients.Add("Корнишоны,");
      ingredients.Add("Красный лук");

      return new PizzaTypes.Hunting(Size, ingredients);
    }
  }
 
  class HamAndMushroomsCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Сыр чеддер,");
      ingredients.Add("Ветчина,");
      ingredients.Add("Шампиньоны,");
      ingredients.Add("Орегано");

      return new PizzaTypes.HamAndMushrooms(Size, ingredients);
    }
  }

  class PhiladelphiaCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Сыр творожный,");
      ingredients.Add("Лосось Слабосоленый");

      return new PizzaTypes.Philadelphia(Size, ingredients);
    }
  }
  
  class FourSeasonsCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Сыр творожный,");
      ingredients.Add("Cвежие томаты,");
      ingredients.Add("Пепперони,");
      ingredients.Add("Шампиньоны,");
      ingredients.Add("Оригано");

      return new PizzaTypes.FourSeasons(Size, ingredients);
    }
  }

  class PepperoniCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Пепперони");

      return new PizzaTypes.Pepperoni(Size, ingredients);
    }
  }
  
  class RusticCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Бекон,");
      ingredients.Add("Шампиньоны,");
      ingredients.Add("Золотистый картофель,");
      ingredients.Add("Дижонская горчица,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Красный лук");

      return new PizzaTypes.Rustic(Size, ingredients);
    }
  }

  class TeriyakiChickenCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус терияки,");
      ingredients.Add("Куриное филе,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Кунжут");

      return new PizzaTypes.TeriyakiChicken(Size, ingredients);
    }
  }

  class TomYumCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Фирменный соус том ям,");
      ingredients.Add("Королевские креветки,");
      ingredients.Add("Томаты Черри,");
      ingredients.Add("Шампиньоны,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Красный лук");

      return new PizzaTypes.TomYum(Size, ingredients);
    }
  }

  class CheeseburgerCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус чесночный,");
      ingredients.Add("Моцарелла,");
      ingredients.Add("Куриное филе,");
      ingredients.Add("Огурцы маринованные,");
      ingredients.Add("Томаты,");
      ingredients.Add("Лук фри");

      return new PizzaTypes.Cheeseburger(Size, ingredients);
    }
  }
  
  class MeatyCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Куриное филе,");
      ingredients.Add("Бекон,");
      ingredients.Add("Пепперони,");
      ingredients.Add("Ветчина");

      return new PizzaTypes.Meaty(Size, ingredients);
    }
  }
  
  class FiveCheeseCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Моцарелла,");
      ingredients.Add("Креметте,");
      ingredients.Add("Чеддер,");
      ingredients.Add("Пармезан,");
      ingredients.Add("Горгонзола");

      return new PizzaTypes.FiveCheese(Size, ingredients);
    }
  }
  
  class DoublePepperoniCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Моцарелла,");
      ingredients.Add("Пепперони");

      return new PizzaTypes.DoublePepperoni(Size, ingredients);
    }
  }
  
  class CosmoWithOnionFriesCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Соус барбекю,");
      ingredients.Add("Пепперони,");
      ingredients.Add("Куриное филе,");
      ingredients.Add("Хрустящий лук Фри");

      return new PizzaTypes.CosmoWithOnionFries(Size, ingredients);
    }
  }

  class BaconAndSalamiCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус томатный,");
      ingredients.Add("Сыр моцарелла,");
      ingredients.Add("Бекон,");
      ingredients.Add("Салями");

      return new PizzaTypes.BaconAndSalami(Size, ingredients);
    }
  }
}
