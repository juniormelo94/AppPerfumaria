using ZXing;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace AppPerfumaria;

public partial class CameraPage : ContentPage
{
    private CancellationTokenSource? _focusTimerCancellation;

    public CameraPage()
	{
		InitializeComponent();

        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.OneDimensional,
            AutoRotate = true,
            Multiple = true
        };

        cameraBarcodeReaderView.IsTorchOn = !cameraBarcodeReaderView.IsTorchOn;
        StartAutoFocusTimer();
    }

    private TaskCompletionSource<BarcodeResult[]> scanTask = new TaskCompletionSource<BarcodeResult[]>();
    public Task<BarcodeResult[]> WaitForResultAsync()
    {
        return scanTask.Task;
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        cameraBarcodeReaderView.IsTorchOn = false;
        StopAutoFocusTimer();

        Application.Current.MainPage.Navigation.PopModalAsync();

        scanTask.TrySetResult(e.Results);
    }

    private void StartAutoFocusTimer()
    {
        _focusTimerCancellation = new CancellationTokenSource();

        Dispatcher.StartTimer(TimeSpan.FromSeconds(5), () =>
        {
            if (_focusTimerCancellation == null)
            {
                return false;
            }

            cameraBarcodeReaderView.AutoFocus();
            return true;
        });
    }

    private void StopAutoFocusTimer()
    {
        _focusTimerCancellation?.Cancel();
        _focusTimerCancellation?.Dispose();
        _focusTimerCancellation = null;
    }

    private void StopCamera(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopModalAsync();

        Dispatcher.Dispatch(() =>
        {
            cameraBarcodeReaderView.IsTorchOn = false;
            cameraBarcodeReaderView.IsDetecting = false;
            StopAutoFocusTimer();
            cameraBarcodeReaderView.Handler?.DisconnectHandler();
        });
    }

    private void OnFlash(object sender, EventArgs e)
    {
        cameraBarcodeReaderView.IsTorchOn = !cameraBarcodeReaderView.IsTorchOn;
    }

    private void OnLocation(object sender, EventArgs e)
    {
        cameraBarcodeReaderView.IsTorchOn = false;

        cameraBarcodeReaderView.CameraLocation
        = cameraBarcodeReaderView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        Dispatcher.Dispatch(() =>
        {
            cameraBarcodeReaderView.IsTorchOn = false;
            cameraBarcodeReaderView.IsDetecting = false;
            StopAutoFocusTimer();
            cameraBarcodeReaderView.Handler?.DisconnectHandler();
        });
    }
}