using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace APOD_UWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Цель портала API NASA - сделать данные НАСА, включая изображения, чрезвычайно доступными для разработчиков приложений.
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";

        //16 июня 1995 года: дата запуска APOD
        DateTime launchDate = new DateTime(1995, 6, 16);

        //Количество изображений, загруженных сегодня.
        int imageCountToday;

        public MainPage()
        {
            this.InitializeComponent();

            //Установите максимальную дату на сегодня, а минимальную дату на дату запуска APOD.
            MonthCalendar.MinDate = launchDate;
            MonthCalendar.MaxDate = DateTime.Today;
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            //Убедитесь, что доступен полный диапазон дат.
            LimitRangeCheckBox.IsChecked = false;

            //Это не будет загружать изображение, просто устанавливает календарь на дату запуска APOD
            MonthCalendar.Date = launchDate;
        }
    }
}
