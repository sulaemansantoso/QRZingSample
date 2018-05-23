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
            //README 
            //First install nuget ZXing.Mobile
            //Create Interface on Main solution (in this case my IScanInterface)
            //Create class that implements interface on Android solution (my AndroidScanInterface)
            //Init the ZXingMobile Scanner on the mainActivity ( line 22)
            //implement scanning method on AndroidScanInterface

            var result = DependencyService.Get<Services.IScanInterface>();
            EScan.Text = await result.ScanAsync() ;
        }
    }
}
