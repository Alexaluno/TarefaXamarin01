using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_1
{
    public class MinhaPagina : ContentPage
    {
        public MinhaPagina()
        {
            Content = new StackLayout
            {
                BackgroundColor = Color.Red,
                Padding = 20,
                VerticalOptions = LayoutOptions.Start,
                Children = {
                    new Label{

                        HorizontalTextAlignment =TextAlignment.Start,
                        Text = "Digite seu nome",
                        TextColor = Color.Azure
                    }
                }
            };
        }
    }
}
