using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace prueba
{
    [Activity(Label = "prueba", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        TextView lblmensaje;
        EditText txtusuario;
        EditText txtclave;
        Button MyButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            lblmensaje = FindViewById<TextView>(Resource.Id.lblmensaje);
            txtusuario = FindViewById<EditText>(Resource.Id.txtusuario);
            txtclave = FindViewById<EditText>(Resource.Id.txtclave);
            MyButton = FindViewById<Button>(Resource.Id.MyButton);

        }
    }
}

