using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using System;

namespace FlyoutRepro
    {
    internal class App :Application
        {
        IAppInfo AppInfo;
        public App()
            {
            AppDomain.CurrentDomain.FirstChanceException+=CurrentDomain_FirstChanceException;
            AppInfo=Microsoft.Maui.ApplicationModel.AppInfo.Current;
            MainPage=new TemplateFlyoutPage(AppInfo);
            }
        private void CurrentDomain_FirstChanceException(object sender,System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
            {
            System.Diagnostics.Trace.WriteLine($"********************************** UNHANDLED EXCEPTION! Details: {e.Exception}");
            }
        protected override void OnStart()
            {
            }
        protected override void OnSleep()
            {
            }
        protected override void OnResume()
            {
            }
        }
    }