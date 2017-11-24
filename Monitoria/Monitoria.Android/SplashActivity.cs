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

namespace Monitoria.Droid
{ // NoHistory serve para proibir o usuario de acessar o historico da app
    [Activity(Theme="@style/Theme.Splash", MainLauncher =true, NoHistory =true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Thread de sleep de 3s para visualizar melhor
            System.Threading.Thread.Sleep(3000);
            // aqui iniciamos a atividade principal
            StartActivity(typeof(MainActivity));
        }
    }
}