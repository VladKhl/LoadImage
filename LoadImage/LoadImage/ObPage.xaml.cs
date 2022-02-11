using LoadImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObPage : ContentPage
    {
        readonly ImageModel im;
        public ObPage(ImageModel im)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.im = im;
            name.Text = im.Name;
            img.Source = im.Image;
        }
    }
}