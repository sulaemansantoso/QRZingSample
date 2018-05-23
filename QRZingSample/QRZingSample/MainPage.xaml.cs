using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QRZingSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ScanButton.Clicked += ScanButton_Clicked;
		}

        private async void ScanButton_Clicked(object sender, EventArgs e)
        {
            var result = DependencyService.Get<Services.IScanInterface>();
            EScan.Text = await result.ScanAsync() ;


        }
    }
}
