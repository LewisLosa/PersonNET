using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace PersonNET.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    public IEnumerable<ISeries> Series { get; set; }
    public IEnumerable<Axis> XAxes { get; set; }
    public IEnumerable<Axis> YAxes { get; set; }

    public HomePageViewModel()
    {
        Series = new ISeries[]
        {
            new LineSeries<double>
            {
                Values = new double[] { 0, 15, 13, 30, 28, 50, 43, 93 },
                Fill = new SolidColorPaint(SKColors.LightGray),
                Stroke = new SolidColorPaint(SKColors.Red),
                GeometryFill = new SolidColorPaint(SKColors.IndianRed), 
                GeometryStroke = new SolidColorPaint(SKColors.DarkSalmon)
            }
        };

        XAxes = new Axis[]
        {
            new Axis { Name = "Aylar", Labels = new[] { "Ocak", "Şubat", "Mart", "Nisan" , "Mayıs", "Haziran", "Temmuz", "Ağustos" } }
        };

        YAxes = new Axis[]
        {
            new Axis { Name = "Toplam Personel Sayısı" }
        };
    }
}