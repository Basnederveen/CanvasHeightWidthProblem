using Avalonia;

namespace Olsthoorn.DesktopUI.ViewModels
{
    public class LineViewModel : ViewModelBase
    {
        public LineViewModel(Point start, Point end) : this()
        {
            Start = start;
            End = end;
        }

        public LineViewModel()
        {
        }

        public Point Start { get; set; }
        public Point End { get; set; }

    }
}
