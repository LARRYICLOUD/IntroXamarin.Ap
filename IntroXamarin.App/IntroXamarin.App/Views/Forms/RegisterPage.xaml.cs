using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
             bool required = false;
            if (string.IsNullOrEmpty(FirstName.Text)) required = true;
            {
                required = true;
                FirstName.BackgroundColor = Color.Red;
                FirstName.Opacity=50;
            }
            var firstName = FirstName.Text;
            var laststName = LastName.Text;
            var email = Email.Text;
            var telephone = int.Parse(Telephone.Text);
            var enrollmentDate = EnrollmentDate;

            var message = $"Register sucefull {FirstName} {LastName} .";
            DisplayAlert("Notify",message,"Cancel");
            Register.BackgroundColor = Color.DarkMagenta;
        }
    }
}