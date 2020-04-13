using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using Myapplication.Model;
using Myapplication.Service;

namespace Application.Fragments
{
    public class BaseFragment : Fragment
    {
        protected ListView itemlistview;
        protected List<Item> allitems;
        protected ItemService itemService;


        public BaseFragment()
        {
            itemService = new ItemService();

        }

        protected void HandleEvents()
        {
            itemlistview.ItemClick += BooksListView_ItemClick;

        }

        protected void FindViews()
        {
            itemlistview = this.View.FindViewById<ListView>(Resource.Id.itemsListView);
        }

        private void BooksListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var item = allitems[e.Position];

            var intent = new Intent();
            intent.SetClass(this.Activity, typeof(ItemDetailActivity));
            intent.PutExtra("SelectedBookId", item.ItemId);
            StartActivityForResult(intent, 200);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}