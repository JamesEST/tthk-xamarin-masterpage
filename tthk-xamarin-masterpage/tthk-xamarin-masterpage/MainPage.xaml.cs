using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tthk_xamarin_masterpage.Models;
using Xamarin.Forms;
using tthk_xamarin_masterpage.Views.Toyota;
using tthk_xamarin_masterpage.Views.Audi;
using tthk_xamarin_masterpage.Views.Bmw;
using tthk_xamarin_masterpage.Views.Chevrolet;
using tthk_xamarin_masterpage.Views.Ford;
using tthk_xamarin_masterpage.Views.Home;
using tthk_xamarin_masterpage.Views.Lexus;
using tthk_xamarin_masterpage.Views.Mitsubishi;
using tthk_xamarin_masterpage.Views.Nissan;
using tthk_xamarin_masterpage.Views.Peugeot;
using tthk_xamarin_masterpage.Views.Renault;
using tthk_xamarin_masterpage.Views.Tesla;
using tthk_xamarin_masterpage.Views;
using tthk;

namespace tthk_xamarin_masterpage
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> MenuList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MenuList = new List<MasterPageItem>();
            var page1 = new MasterPageItem() { Id = 1, Title = "Tabbed", Icon = "bmw.png" };
            var page2 = new MasterPageItem() { Id = 1, Title = "Bmw", Icon = "bmw.png" };
            var page3 = new MasterPageItem() { Id = 2, Title = "Audi", Icon = "audi.png" };
            var page4 = new MasterPageItem() { Id = 3, Title = "Ford", Icon = "ford.png" };
            var page5 = new MasterPageItem() { Id = 4, Title = "Tesla", Icon = "tesla.png" };
            var page6 = new MasterPageItem() { Id = 5, Title = "Lexus", Icon = "lexus.png" };
            var page7 = new MasterPageItem() { Id = 6, Title = "Toyota", Icon = "toyota.png" };
            var page8 = new MasterPageItem() { Id = 7, Title = "Nissan", Icon = "nissan.png" };
            var page9 = new MasterPageItem() { Id = 8, Title = "Renault", Icon = "renault.png" };
            var page10 = new MasterPageItem() { Id = 9, Title = "Peugeot", Icon = "peugeot.png" };
            var page11 = new MasterPageItem() { Id = 10, Title = "Chevrolet", Icon = "chevrolet.png" };
            var page12 = new MasterPageItem() { Id = 11, Title = "Mitsubishi", Icon = "mitsubishi.png" };
            var page13 = new MasterPageItem() { Id = 12, Title = "Mersedes-Benz", Icon = "mercedesbenz.png" };

            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);
            MenuList.Add(page7);
            MenuList.Add(page8);
            MenuList.Add(page9);
            MenuList.Add(page10);
            MenuList.Add(page11);
            MenuList.Add(page12);
            MenuList.Add(page13);



            //Ставит все страницы в левое меню 
            navigationDrawerList.ItemsSource = MenuList;
            //Первая страница когда запускаем приложение
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        private async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            //When ever item is clicked then we are navigating to the details page
            // Сюда закидывать новые страницы
            var pageMyselecteditem = e.Item as MasterPageItem;
            switch (pageMyselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new TappedPage());
                    break;
                case 2:
                    await Navigation.PushAsync(new BmwPage());
                    break;
                case 3:
                    await Navigation.PushAsync(new AudiPage());
                    break;
                case 4:
                    await Navigation.PushAsync(new FordPage());
                    break;
                case 5:
                    await Navigation.PushAsync(new TeslaPage());
                    break;
                case 6:
                    await Navigation.PushAsync(new LexusPage());
                    break;
                case 7:
                    await Navigation.PushAsync(new ToyotaPage());
                    break;
                case 8:
                    await Navigation.PushAsync(new NissanPage());
                    break;
                case 9:
                    await Navigation.PushAsync(new RenaultPage());
                    break;
                case 10:
                    await Navigation.PushAsync(new PeugeotPage());
                    break;
                case 11:
                    await Navigation.PushAsync(new ChevroletPage());
                    break;
                case 12:
                    await Navigation.PushAsync(new MitsubishiPage());
                    break;
                case 13:
                    await Navigation.PushAsync(new MersedesBenzPage());
                    break;

            }
            ((ListView)sender).SelectedItem = null;
            IsPresented = false;
        }
    }
}
