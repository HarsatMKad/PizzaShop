using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTypes
{
  abstract public class Pizza
  {
    public virtual string ShowIngredient()
    {
      return "";
    }

    public virtual int OutputSize()
    {
      return 0;
    }
    public virtual string OutputName()
    {
      return "";
    }
  }
  class Margarita : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Margarita(int Size, List<string> Ingredients)
    {
      this.Name = "Маргарита";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class Hunting : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Hunting(int Size, List<string> Ingredients)
    {
      this.Name = "Охотничья";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class HamAndMushrooms : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public HamAndMushrooms(int Size, List<string> Ingredients)
    {
      this.Name = "Ветчина и грибы";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class Philadelphia : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Philadelphia(int Size, List<string> Ingredients)
    {
      this.Name = "Филадельфия";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class FourSeasons : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public FourSeasons(int Size, List<string> Ingredients)
    {
      this.Name = "4 Сезона";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }
    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class Pepperoni : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Pepperoni(int Size, List<string> Ingredients)
    {
      this.Name = "Пепперони";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class Rustic : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Rustic(int Size, List<string> Ingredients)
    {
      this.Name = "Деревенская";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class TeriyakiChicken : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public TeriyakiChicken(int Size, List<string> Ingredients)
    {
      this.Name = "Цыпленок терияки";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class TomYum : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public TomYum(int Size, List<string> Ingredients)
    {
      this.Name = "Том ям";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class Cheeseburger : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Cheeseburger(int Size, List<string> Ingredients)
    {
      this.Name = "Чизбургер";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }
  
  class Meaty : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public Meaty(int Size, List<string> Ingredients)
    {
      this.Name = "Мясная";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }

  class FiveCheese : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public FiveCheese(int Size, List<string> Ingredients)
    {
      this.Name = "Пять сыров";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }
  
  class DoublePepperoni : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public DoublePepperoni(int Size, List<string> Ingredients)
    {
      this.Name = "Двойная Пепперони";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }
  
  class CosmoWithOnionFries : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public CosmoWithOnionFries(int Size, List<string> Ingredients)
    {
      this.Name = "Космо с луком фри";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }
  
  class BaconAndSalami : Pizza
  {
    public string Name;
    public int Size;
    List<string> Ingridients;

    public BaconAndSalami(int Size, List<string> Ingredients)
    {
      this.Name = "Бекон&салями";
      this.Size = Size;
      this.Ingridients = Ingredients;
    }

    public override string ShowIngredient()
    {
      string NoteIngridients = "";
      for (int IngredientNumber = 0; IngredientNumber < Ingridients.Count; ++IngredientNumber)
      {
        NoteIngridients += Ingridients[IngredientNumber] + " ";
      }
      return NoteIngridients;
    }

    public override int OutputSize()
    {
      return Size;
    }
    public override string OutputName()
    {
      return Name;
    }
  }
}
