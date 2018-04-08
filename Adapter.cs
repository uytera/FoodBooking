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

namespace FoodBooking
{
    class Adapter : BaseAdapter<string>
    {
        private List<string> list;

        private Context context;

        public Adapter(Context context, List<string> list)
        {
            this.list = list;

            this.context = context;
        }

        public override int Count
        {
            get
            {
                return list.Count;
            }
        }

        public override string this[int position]
        {
            get
            {
                return list[position];
            }
        }

        

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if(view == null)
            {
                view = LayoutInflater.From(context).Inflate(Resource.Layout.Cafe, null, false);

                TextView textView1 = view.FindViewById<TextView>(Resource.Id.textView1);
                textView1.Text = list[position];
            }
            return view;
        }
    }
}