using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;

namespace AppPerfumaria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            cameraBarcodeReaderView.Options = new BarcodeReaderOptions
            {
                Formats = BarcodeFormats.OneDimensional,
                AutoRotate = true,
                Multiple = true
            };

            cameraBarcodeReaderView.IsTorchOn = !cameraBarcodeReaderView.IsTorchOn;

            cameraBarcodeReaderView.CameraLocation
            = cameraBarcodeReaderView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;


        }

        protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
        {
            foreach (var barcode in e.Results)
                Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
        }
    }
}
