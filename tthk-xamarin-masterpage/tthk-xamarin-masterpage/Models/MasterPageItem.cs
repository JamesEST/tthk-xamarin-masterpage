using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace tthk_xamarin_masterpage.Models
{
    public class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }

        public string a { get; set; }
        public string b { get; set; }

        public ContentPage ReturnPage()
        {
            Image img = new Image();
            img.Source = a;
            Button btn = new Button();
            btn.Text = b;
            btn.Clicked += Btn_Clicked;
            StackLayout stack = new StackLayout();
            stack.Children.Add(img);
            ContentPage content = new ContentPage();
            content.Content = stack;

            return content;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "Hi":
                    break;
                default:
                    break;
            }
        }
    }
}
