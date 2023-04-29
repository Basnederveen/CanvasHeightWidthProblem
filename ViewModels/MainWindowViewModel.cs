namespace Olsthoorn.DesktopUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public CanvasPageViewModel CanvasPage { get; set; }

        public MainWindowViewModel()
        {
            CanvasPage = new CanvasPageViewModel();
        }
    }
}
