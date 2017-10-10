using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;

namespace Ofertas
{
    
    [Activity(Label = "Ofertas", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

          
        }
        
            public void startSecondActivity(View view)
            {
            var showSecond = FindViewById<Button>(Resource.Id.btnLogin);
            showSecond.Click += (sender, e) =>
            {
                StartActivity(typeof(SecondActivity));
            };
            }

                
                }
    }


