using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
//using SmartmanApps.Colours;
//using SmartmanApps.Controls;

namespace FlyoutRepro
    {
    public class SecondPage :ContentPage
        {
        public SecondPage(IAppInfo appInfo)
            {
            Title="Page 2";
            Label secondpageLabel = new Label { 
                Text =$"{appInfo.Name} {appInfo.Version.Major}.{appInfo.Version.Minor}.{appInfo.Version.Build} Page 2",
                };
            secondpageLabel.HorizontalTextAlignment=TextAlignment.Center;
            secondpageLabel.VerticalTextAlignment=TextAlignment.Center;
            Content=secondpageLabel;
            }
        }
    }