using Myapplication.Model;

namespace Myapplication.Repository
{
    internal class item : Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone_number { get; set; }
    }
}