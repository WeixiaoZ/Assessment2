using Myapplication.Model;
using Myapplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapplication.Service
{
    public class ItemService
    {
        private static ItemRepository itemRepository = new ItemRepository();

        public ItemService()
        {

        }

        public List<Item> GetAllBooks()
        {
            return itemRepository.GetAllBooks();
        }

        public Item GetBookById(int itemId)
        {
            return itemRepository.GetBookById(itemId);
        }

        public List<Item> GetFavoriteBooks()
        {
            return itemRepository.GetFavoriteBooks();
        }

        public List<Category> GetAllCategoriesWithBooks()
        {
            return itemRepository.GetAllCategoriesWithBooks();
        }

        public List<Item> GetBooksByCategoryId(int categoryId)
        {
            return itemRepository.GetBooksByCategoryId(categoryId);
        }


    }
}
