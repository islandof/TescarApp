using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace VehicleManageApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void VisualElement_OnFocused(object sender, FocusEventArgs e)
        {
            Username.Text = "admin";
            Password.Text = "123";
        }
    }
}
