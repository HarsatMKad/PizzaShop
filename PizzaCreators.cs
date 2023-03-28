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

      ingredients.Add("Соус_томатный");
      ingredients.Add("Сыр_моцарелла");
      ingredients.Add("Базилик_свежий");

      return new PizzaTypes.Margarita(Size, ingredients);
    }
  }

  class HuntingCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус_томатный");
      ingredients.Add("Сыр_моцарелла");
      ingredients.Add("Охотничьи_колбаски");
      ingredients.Add("Корнишоны");
      ingredients.Add("Красный_лук");

      return new PizzaTypes.Hunting(Size, ingredients);
    }
  }
 
  class HamAndMushroomsCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус_томатный");
      ingredients.Add("сыр_моцарелла");
      ingredients.Add("сыр_чеддер");
      ingredients.Add("ветчина");
      ingredients.Add("шампиньоны");
      ingredients.Add("орегано");

      return new PizzaTypes.HamAndMushrooms(Size, ingredients);
    }
  }

  class PhiladelphiaCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус_томатный");
      ingredients.Add("Сыр_моцарелла");
      ingredients.Add("Сыр_творожный");
      ingredients.Add("Лосось_Слабосоленый");

      return new PizzaTypes.Philadelphia(Size, ingredients);
    }
  }

  class FourSeasonsCreator : Creator
  {
    public override PizzaTypes.Pizza FactoryMethod(int Size)
    {
      List<string> ingredients = new List<string>();

      ingredients.Add("Соус_томатный");
      ingredients.Add("Сыр_моцарелла");
      ingredients.Add("Сыр_творожный");
      ingredients.Add("Cвежие томаты");
      ingredients.Add("Пепперони");
      ingredients.Add("Шампиньоны");
      ingredients.Add("Оригано");

      return new PizzaTypes.FourSeasons(Size, ingredients);
    }
  }
}
