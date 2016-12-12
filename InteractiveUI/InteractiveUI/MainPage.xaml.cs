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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace InteractiveUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
       //     this.Loaded += MainPage_Loaded;
         //   this.SizeChanged += MainPage_SizeChanged;
        }

        //private void MainPage_Loaded ( object sender, RoutedEventArgs e )
        //{
        //    var width = Window.Current.Bounds.Width;
        //    string state = "Large";
        //    if ( width < 600 )
        //        state = "small";
        //    else if ( width < 900 )
        //        state = "Medium";
        //    else if ( width < 1200 )
        //        state = "Large";
        //    VisualStateManager.GoToState ( this, state, true );
        //}

        //private void MainPage_SizeChanged ( object sender, SizeChangedEventArgs e )
        //{
        //    string state = "Large";
        //    if ( e.NewSize.Width < 600 )
        //        state = "small";
        //    else if ( e.NewSize.Width < 900 )
        //        state = "Medium";
        //    else if ( e.NewSize.Width < 1200 )
        //        state = "Large";
        //    VisualStateManager.GoToState ( this, state, true );



        //}
    }
}
