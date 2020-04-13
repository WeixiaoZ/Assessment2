using Myapplication.Model;
using System.Collections.Generic;

namespace Myapplication.Repository
{
    public class Category
    {
        public Category()
        {

        }

        public int CategoryId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<Item> Items
        {
            get;
            set;
        }
    }
}