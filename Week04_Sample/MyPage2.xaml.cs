using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week04_Sample
{
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();
        }

        void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();                   
        }

        
    }
}
