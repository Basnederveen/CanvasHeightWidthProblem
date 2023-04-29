using Avalonia;
using DynamicData;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Olsthoorn.DesktopUI.ViewModels
{
    public class CanvasPageViewModel : ViewModelBase
    {
        public CanvasPageViewModel()
        {
            Lines = new ObservableCollection<LineViewModel>()
            {
                new LineViewModel(new Point(0,0), new Point(10000,10000))
            };
        }

        public ObservableCollection<LineViewModel> Lines { get; set; }

        public IEnumerable<double> GetXCoordinates(ObservableCollection<LineViewModel> lines)
        {
            return lines.Select(x => x.Start.X).Concat(Lines.Select(y => y.End.X));
        }

        public IEnumerable<double> GetYCoordinates(ObservableCollection<LineViewModel> lines)
        {
            return lines.Select(x => x.Start.Y).Concat(Lines.Select(y => y.End.Y));
        }


        public double Width { get => (GetXCoordinates(Lines).Max() + CanvasOffset); }
        public double Height { get => (GetYCoordinates(Lines).Max() + CanvasOffset); }

        public int CanvasOffset { get; set; } = 50;
        public double Scale { get; set; } = 0.1;
    }
}
