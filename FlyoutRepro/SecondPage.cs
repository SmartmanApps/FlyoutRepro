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
            Label titleViewLabel=new Label{Text="Page 2 TitleView Label"};
//// setting Title works
//// SetTitleView on Windows in 8.0.6-7 causes "Element is already the child of another element" crash
            NavigationPage.SetTitleView(this,titleViewLabel);
//            Title="Page 2 Title";
            Label secondpageLabel = new Label { 
                Text =$"{appInfo.Name} {appInfo.Version.Major}.{appInfo.Version.Minor}.{appInfo.Version.Build} Page 2",
                };
            secondpageLabel.HorizontalTextAlignment=TextAlignment.Center;
            secondpageLabel.VerticalTextAlignment=TextAlignment.Center;
            Content=secondpageLabel;
            }
        }
    }