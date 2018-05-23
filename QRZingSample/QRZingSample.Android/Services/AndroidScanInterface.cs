using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ZXing.Mobile;
using QRZingSample.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly:Dependency(typeof(QRZingSample.Droid.Services.AndroidScanInterface))]

namespace QRZingSample.Droid.Services
{
  
    public class AndroidScanInterface : IScanInterface
    {
        public AndroidScanInterface() 
        {

        }

        public async Task<string> ScanAsync()
        {
            String resultString = "";
            try
            {
                //setting option for the mobile barcode 
                var scanOption = new MobileBarcodeScanningOptions();
                scanOption.AutoRotate = true;
                scanOption.PossibleFormats = new List<ZXing.BarcodeFormat>()
                {
                    ZXing.BarcodeFormat.CODE_39,
                    ZXing.BarcodeFormat.CODE_93,
                    ZXing.BarcodeFormat.CODE_128,
                    ZXing.BarcodeFormat.EAN_13,
                    ZXing.BarcodeFormat.QR_CODE
                };


                //create the scanner
                var scanner = new MobileBarcodeScanner()
                {
                    TopText = "Scan QR here",
                    BottomText = "EHEHHEHEHE"
                };
                //scan for result
                var result = await scanner.Scan(scanOption);
                //voila
                resultString = result.ToString();
            }
            catch(Exception ex)
            {
                resultString = ex.Message;
            }
            return resultString;
        }
    }
}