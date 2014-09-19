using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace item_database
{
    class Item
    {
        private String _name = "";
        private int _category = 0;
        private List<Item> _recipeItems = new List<Item>(); 

        public Item(String name, int category, List<Item> preItems)
        {
            this._name = name;
            this._category = category;
            this._recipeItems = preItems;
        }

        public void SetName(String newName)
        {
            _name = newName;
        }

        public String GetName()
        {
            return _name;
        }

        public void SetCategory(int newCat)
        {
            _category = newCat;
        }

        public int GetCategory()
        {
            return _category;
        }

        public void SetRecipeItems(List<Item> recipeItems)
        {
            this._recipeItems = recipeItems;
        }

        public void addToRecipeItems(Item item)
        {
            this._recipeItems.Add(item);
        }

        public List<Item> GetRecipeItems()
        {
            return _recipeItems;
        }

    }
}
