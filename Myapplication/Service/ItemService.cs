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

        public Item GetItemById(int ItemId)
            {
            return itemRepository.GetItemById(ItemId);
            }


    }
}
