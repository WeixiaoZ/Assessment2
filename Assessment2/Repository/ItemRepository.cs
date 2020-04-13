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
        public List<Item> GetAllBooks()
        {
            IEnumerable<Item> items =
                from itemCategory in itemCategories
                from item in itemCategory.Items
                select item;

            return items.ToList<Item>();
        }


        public Item GetBookById(int itemId)
        {
            IEnumerable<Item> items =
                from itemCategory in itemCategories
                from item in itemCategory.Items
                where item.ItemId == itemId
                select item;

            return items.FirstOrDefault();
        }

        public List<Item> GetFavoriteBooks()
        {
            IEnumerable<Item> items =
                from itemCategory in itemCategories
                from item in itemCategory.Items
                where item.IsFavorite
                select item;

            return items.ToList<Item>();
        }

        public List<Category> GetAllCategoriesWithBooks()
        {
            return itemCategories;
        }

        public List<Item> GetBooksByCategoryId(int categoryId)
        {
            IEnumerable<Item> items =
                from itemCategory in itemCategories
                from item in itemCategory.Items
                where itemCategory.CategoryId == categoryId
                select item;

            return items.ToList<Item>();
        }

        private static List<Category> itemCategories = new List<Category>()
        {
            new Category()
            {
                CategoryId = 1,
                Title = "Category A",
                ImagePath =  "",

                Items = new List<Item>()
                {
                    new Item()
                    {
                     ItemId = 1,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {
                     ItemId = 2,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {

                     ItemId = 3,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },


                }

            },

            new Category()
            {
                CategoryId = 2,
                Title = "Category B",
                ImagePath =  "",

                Items = new List<Item>()
                {
                    new Item()
                    {
                        ItemId = 4,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {
                        ItemId = 5,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {
                        ItemId = 6,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },
                }
             },

            new Category()
            {
                CategoryId = 3,
                Title = "Category C",
                ImagePath =  "",

                Items = new List<Item>()
                {
                    new Item()
                    {
                        ItemId = 7,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {
                        ItemId = 8,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },

                    new Item()
                    {
                        ItemId = 9,
                     Name = "dsgdsg",
                     Description = "dsgsdgsdg",
                     IsFavorite = true,
                     Price = 250,
                     Available = true,
                     Address = "213412",
                     Phone_number = "124124",
                    },


                }

            },




        };

    }
}
