using System;
using System.Collections.Generic;
using tthk_xamarin_masterpage.Models;
using Xamarin.Forms;
using Xamarin.Essentials;
using tthk_xamarin_masterpage.Views.Toyota;
using tthk_xamarin_masterpage.Views.Home;
using tthk_xamarin_masterpage.Views;
using Java.Lang;

namespace tthk_xamarin_masterpage
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> MenuList { get; set; }
        string temp;
        string[] MainTitle = new string[]
        {
            "Я",     
            "Алексей",
            "Арсений",
            "Карим",
            "Ростик",
            "Лев",
            "Максим",
            "Сергей",
            "Илья",
            "Миша"
        };
        public MainPage()
        {
           
            InitializeComponent();
            /* foreach (string listitem in MainTitle)
                   {
                       temp += listitem + ",";
                   }

                   Preferences.Set("NewTemp", temp);
            var myValue = Preferences.Get("NewTemp", "none");
            MainTitle = myValue.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);*/


            MenuList = new List<MasterPageItem>();
            
            var page1 = new MasterPageItem() { Id = 1, Title = MainTitle[0], Icon = "profile.png" };
            var page2 = new MasterPageItem() { Id = 2, Title = MainTitle[1], Icon = "profile.png" };
            var page3 = new MasterPageItem() { Id = 3, Title = MainTitle[2], Icon = "profile.png" };
            var page4 = new MasterPageItem() { Id = 4, Title = MainTitle[3], Icon = "profile.png" };
            var page5 = new MasterPageItem() { Id = 5, Title = MainTitle[4], Icon = "profile.png" };
            var page6 = new MasterPageItem() { Id = 6, Title = MainTitle[5], Icon = "profile.png" };
            var page7 = new MasterPageItem() { Id = 7, Title = MainTitle[6], Icon = "profile.png" };
            var page8 = new MasterPageItem() { Id = 8, Title = MainTitle[7], Icon = "profile.png" };
            var page9 = new MasterPageItem() { Id = 9, Title = MainTitle[8], Icon = "profile.png" };
            var page10 = new MasterPageItem() { Id = 10, Title = MainTitle[9], Icon = "profile.png" };

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
            




            //Ставит все страницы в левое меню 
            navigationDrawerList.ItemsSource = MenuList;
            //Первая страница когда запускаем приложение
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        private async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            
            // Сюда закидывать новые страницы

            var pageMyselecteditem = e.Item as MasterPageItem;
            MasterPageItem hi = new MasterPageItem();

            switch (pageMyselecteditem.Id)
            {
                case 1:
                    hi.TitleText = "Я";
                    
                    hi.Imagesrc = "avatar.jpg";
                    hi.NumberPhone = "+37258502248";
                    hi.EmailAdress = "Farges314@gmail.com";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 2:
                    hi.TitleText = "Алексей";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 3:
                    hi.TitleText = "Арсений";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 4:
                    hi.TitleText = "Карим";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 5:
                    hi.TitleText = "Ростик";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 6:
                    hi.TitleText = "Лев";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 7:
                    hi.TitleText = "Максим";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 8:
                    hi.TitleText = "Сергей";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 9:
                    hi.TitleText = "Илья";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
                case 10:
                    hi.TitleText = "Миша";
                    hi.Imagesrc = "profile.png";
                    hi.NumberPhone = "";
                    hi.EmailAdress = "";
                    await Navigation.PushAsync(hi.ReturnPage());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
            IsPresented = false;
        }
    }
}
