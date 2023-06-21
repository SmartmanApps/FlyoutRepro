using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace FlyoutRepro
    {
    public class TemplateFlyoutMenuPage :ContentPage
        {
        ListView _itemsView;
        public ListView Items { get { return _itemsView; } }
        #region constructor
        public TemplateFlyoutMenuPage()
            {
            List<MenuItem> menuItemsList = new List<MenuItem>();
            menuItemsList.Add(new MenuItem
                {
                TargetHeading="⌂ Home Page",
                TargetType=typeof(MainPage),
                });
            menuItemsList.Add(new MenuItem
                {
                TargetHeading="Page 2",
                TargetType=typeof(SecondPage),
                });
            _itemsView=new ListView
                {
                ItemsSource=menuItemsList,
                ItemTemplate=new DataTemplate(() =>
                {
                    Grid grid = new Grid { Padding=new Thickness(5,0,0,5) };
                    Label itemLabel = new Label
                        {
                        //                FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        FontSize=20,
                        };
                    itemLabel.SetBinding(Label.TextProperty,"TargetHeading");
                    grid.Add(itemLabel,0,0);
                    return new ViewCell { View=grid };
                }),
                SeparatorVisibility=SeparatorVisibility.None,
                };
            Title="Template Menu";
            //    Padding=new Thickness(0,0,40,0);
            Content=_itemsView;
            }
        #endregion
        protected override void OnAppearing()
            {
            System.Diagnostics.Trace.Write($"********************************** {nameof(TemplateFlyoutMenuPage)}.{nameof(OnAppearing)} is running\r\n");
            base.OnAppearing();
            }
        protected override void OnDisappearing()
            {
            System.Diagnostics.Trace.Write($"********************************** {nameof(TemplateFlyoutMenuPage)}.{nameof(OnDisappearing)} is running\r\n");
            base.OnDisappearing();
            }
        }
    }