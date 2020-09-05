using ElmSharp;
using System;
using Xamarin.Forms;

namespace Hackton_Tizen_01
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            MainWindow.AvailableRotations = DisplayRotation.Degree_0;

            LoadApplication(new App());
            Tizen.Log.Debug("BT_TAG", "OnCreate");
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.Init(app);
            app.Run(args);
        }
    }
}
