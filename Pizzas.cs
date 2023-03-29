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
}
