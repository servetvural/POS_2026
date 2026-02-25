using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DTRMMobilePadSL.Resources;


using System.Windows.Media;


namespace DTRMMobilePadSL {
    public partial class MainPage : PhoneApplicationPage {
        DTRMNS.SimpleBusinessServiceClient service;


        // Constructor
        public MainPage() {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            service = new DTRMNS.SimpleBusinessServiceClient();

            //Assign async event handlers
            service.EnsureBSLayerCompleted += service_EnsureBSLayerCompleted;
            service.GetCategoryListCompleted += service_GetCategoryListCompleted;

            try {
                service.EnsureBSLayerAsync();
            } catch {
                MessageBox.Show("Can't locate service. Closing");
                Application.Current.Terminate();
            }
        }

        void service_GetCategoryListCompleted(object sender, DTRMNS.GetCategoryListCompletedEventArgs e) {
            System.Collections.ObjectModel.ObservableCollection<string> thelist = e.Result;
            string msg = "";
           // pnlStack.Children.Clear();
            for (int i = 0; i < thelist.Count; i++) {
                msg += thelist[i] + "\n";
                Button btn = new Button();
                btn.Content = thelist[i];
                btn.Click += btn_Click;
                pnlStack.Children.Add(btn);
                


                //Button btn2 = new Button();
                //btn2.Content = thelist[i];
                //btn2.Click += btn_Click;
                
                //gridEntity.Children.Add(btn2);

            }
            pnlStack.Height = Double.NaN;
            //MessageBox.Show(msg);
        }

        void btn_Click(object sender, RoutedEventArgs e) {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Content.ToString());
            //throw new NotImplementedException();
        }

        void service_EnsureBSLayerCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            //throw new NotImplementedException();
        }

        private void btnGetCategories_Click(object sender, RoutedEventArgs e) {
            service.GetCategoryListAsync();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}