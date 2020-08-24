using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula11_AppGuiaDev
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.Inicial)));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.Contato)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.BancoDeDados)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.ProgramacaoWeb)));
                IsPresented = false;

            } catch(Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.ProgramacaoMobile)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void btn_so_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.SistemasOperacionais)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.Redes)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.Inicial)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
