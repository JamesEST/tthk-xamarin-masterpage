using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace tthk_xamarin_masterpage.Models
{
    public class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }

        public string Imagesrc { get; set; }
        public string NumberPhone { get; set; }
        public string EmailAdress { get; set; }
        public string TitleText { get; set; }

        ImageButton PhoneBtn, Msgbtn, Emailbtn;
        Label Numberlbl, Emaillbl;
        Image Contactimg;

        public ContentPage ReturnPage()
        {
            ContentPage content = new ContentPage();
            
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition{ Height = new GridLength(300) },
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()
            },
                ColumnDefinitions =
            {
                new ColumnDefinition{ Width = new GridLength(44) },
                new ColumnDefinition(),
                new ColumnDefinition{ Width = new GridLength(44) }
            }
            };
            
            Contactimg = new Image()
            {
                Source = Imagesrc
            };
            grid.Children.Add(Contactimg, 1, 0);
            
            //Phone Button
            PhoneBtn = new ImageButton()
            {
                Source = "call.png",
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Transparent
            };
            PhoneBtn.Clicked += PhoneBtn_Clicked;
            grid.Children.Add(PhoneBtn, 0, 1);
            //Number Label
            Numberlbl = new Label()
            {
                Text = NumberPhone,
                VerticalOptions = LayoutOptions.Center
            };
            grid.Children.Add(Numberlbl, 1, 1);
            //Message Button
            Msgbtn = new ImageButton()
            {
                Source = "msg.png",

                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Transparent
            };
            Msgbtn.Clicked += Msgbtn_Clicked;
            grid.Children.Add(Msgbtn, 2, 1);

            //--------------------------------------------
            Emailbtn = new ImageButton()
            {
                Source = "email.png",
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Transparent
            };
            grid.Children.Add(Emailbtn, 0, 2);

            Emaillbl = new Label()
            {
                Text = EmailAdress,
                VerticalOptions = LayoutOptions.Center
            };
            Emailbtn.Clicked += Emailbtn_Clicked;
            grid.Children.Add(Emaillbl, 1, 2);




            content.Content = grid;
            content.Title = TitleText;
            return content;
        }

        private async void Emailbtn_Clicked(object sender, EventArgs e)
        {
            await Email.ComposeAsync("", "", Emaillbl.Text);
        }

        private async void Msgbtn_Clicked(object sender, EventArgs e)
        {
            await Sms.ComposeAsync(new SmsMessage(string.Empty, NumberPhone));
        }

        private void PhoneBtn_Clicked(object sender, EventArgs e)
        {
            if(NumberPhone != "")
            {
                PhoneDialer.Open(NumberPhone);
            }
           
            
        }
    }
}
