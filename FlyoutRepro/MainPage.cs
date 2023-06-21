using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
namespace FlyoutRepro
    {
    public class MainPage :ContentPage
        {
        public MainPage(IAppInfo appInfo)
            {
            Title="Main Page";
            Label mainpageLabel = new Label{
                Text=$"{appInfo.Name} {appInfo.Version.Major}.{appInfo.Version.Minor}.{appInfo.Version.Build} Main Page"
                };
            mainpageLabel.HorizontalTextAlignment=TextAlignment.Center;
            mainpageLabel.VerticalTextAlignment=TextAlignment.Center;
            Content=mainpageLabel;
            }
        }
    }