using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myapplication.Model;

namespace Myapplication.Model
{
    public class Item
    {

        public Item()
        {

        }

        public int ItemId
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            set;
            get;
        }
        public string Phone_number
        {
            set;
            get;
        }

        public List<Item> items
        {
            get;
            set;
        }

      
    }
}
