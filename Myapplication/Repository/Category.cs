using Myapplication.Model;

namespace Myapplication.Repository
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public System.Collections.Generic.List<item> items { get; set; }
    }
}