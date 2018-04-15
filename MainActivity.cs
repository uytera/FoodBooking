using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;

namespace FoodBooking
{
    [Activity(Label = "Кафе", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView listView1;

        List<string> list;

        List<string> list5;

		List<int> intList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            list = new List<string>();

            list.AddRange(new string[] { "Lul", "Lmao", "笑", "攻撃", "射撃", "爆弾", "零"});

            listView1 = FindViewById<ListView>(Resource.Id.listView1);

            Adapter adapter = new Adapter(this, list);

            listView1.Adapter = adapter;

            listView1.ItemClick += delegate
            {
                Intent intent = new Intent(this, typeof(Cafe1));
                StartActivity(intent);
            };
        }
    }
}

