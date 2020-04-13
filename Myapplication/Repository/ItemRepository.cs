using Myapplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapplication.Repository
{
    public class ItemRepository
    {
        
        public ItemRepository()
        {

        }

        internal Item GetItemById(int itemId)
        {
            IEnumerable<item> items =
         from itemCategory in itemCategories
         from item in itemCategory.items
         where item.ItemId == itemId
         select item;

            return items.FirstOrDefault();
        }

        

        private static List<Category> itemCategories = new List<Category>()
        {
            

        new Category()
            {
                CategoryId = 1,
                Title = "Category A",

                items = new List<item>()
                {
                    new item()
                    {
                     ItemId = 1,
                     Description = "dsgsdgsdg",
                     Price = 250,
                     Name = "dsgdsg",
                     Address = "",
                     Phone_number = ""

                    },

                    new item()
                    {
                     ItemId = 2,
                     Description = "dsgsdgsdg",
                     Price = 250,
                     Name = "dsgdsg",
                     Address = "",
                     Phone_number = ""

                    },

                    new item()
                    {

                     ItemId = 3,
                     Description = "dsgsdgsdg",
                     Price = 250,
                     Name = "dsgdsg",
                     Address = "",
                     Phone_number = ""

                    },


                }

            },




        };

    }
}
