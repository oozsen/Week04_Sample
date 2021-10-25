using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week04_Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Adding Bindingcontext 
            BindingContext = this;
        }

        public string Hello { get; set; } = "Hello Bim493";

        public string Hello2 { get; set; } = "Mobile Programming 1 Course";

        public string CengLink { get; set; } = "ceng.eskisehir.edu.tr";
    }
}
