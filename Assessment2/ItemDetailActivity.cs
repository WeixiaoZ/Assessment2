using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Myapplication.Model;
using Myapplication.Service;


namespace Application
{
    [Activity(Label = "ItemDetailActivity")]
    public class ItemDetailActivity : Activity
    {
        private Item item;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ItemDetail);

            int itemId = Intent.GetIntExtra("SelectedBookId", 0);

            ItemService service = new ItemService();
            item = service.GetBookById(itemId);

            FindViews();

        }

        private void FindViews()
        {

            FindViewById<TextView>(Resource.Id.textBookName).Text = item.Name;
            FindViewById<TextView>(Resource.Id.textDescription).Text = item.Description;
            FindViewById<TextView>(Resource.Id.textPrice).Text = "Price: $" + item.Price;

        }
    }
}