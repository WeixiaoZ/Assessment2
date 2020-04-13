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
using Application.Adapter;

namespace Application.Fragments
{
    public class ListItemFragement : BaseFragment
    {

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            FindViews();
            HandleEvents();

            allitems = itemService.GetFavoriteBooks();
            itemlistview.Adapter = new ItemListAdapter(this.Activity, allitems);



        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}