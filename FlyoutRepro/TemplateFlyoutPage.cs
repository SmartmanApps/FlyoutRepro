using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace FlyoutRepro
    {
    public class TemplateFlyoutPage :FlyoutPage
        {
        IAppInfo AppInfo;
        TemplateFlyoutMenuPage Menu;
        NavigationPage HomePage;
        NavigationPage Page2;
        #region constructor
        public TemplateFlyoutPage(IAppInfo appInfo)
            {
            AppInfo=appInfo;
            #region assemble GUI
            HomePage=new NavigationPage (
                new MainPage(AppInfo)
                );
            Page2=new NavigationPage(
                new SecondPage(AppInfo)
                );
            Menu=new TemplateFlyoutMenuPage();
            Flyout=Menu;
            Detail=HomePage;
            FlyoutLayoutBehavior=FlyoutLayoutBehavior.Popover;
            Menu.Items.ItemSelected+=OnItemSelected;
            IsPresentedChanged+=TemplateFlyoutPage_IsPresentedChanged;
            #endregion
            }
        #endregion
        #region methods
        private void TemplateFlyoutPage_IsPresentedChanged(object sender,System.EventArgs e)
            {
            System.Diagnostics.Trace.Write($"********************************** {nameof(TemplateFlyoutPage)}.{nameof(IsPresented)} is {IsPresented}\r\n");
            System.Diagnostics.Trace.Write($"********************************** {nameof(TemplateFlyoutPage)}.{nameof(IsVisible)} is {IsVisible}\r\n");
            }
        #region OnItemSelected
        private void OnItemSelected(object sender,SelectedItemChangedEventArgs e)
            {
            MenuItem selectedItem = e.SelectedItem as MenuItem;
            if (selectedItem!=null)
                {
                switch (selectedItem.TargetHeading)
                    {
                    case "⌂ Home Page":
                        Detail=HomePage;
                        break;
                    case "Page 2":
                        Detail=Page2;
                        break;
                    default:
                        break;
                    }
                Menu.Items.SelectedItem=null;
                IsPresented=false;
                }
            }
        #endregion
        #endregion
        }
    }