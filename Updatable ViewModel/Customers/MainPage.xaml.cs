﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Customers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.SizeChanged += WindowSizeChanged;

            List<string> titles = new List<string> 
            {
                "Mr", "Mrs", "Ms" 
            };

            this.title.ItemsSource = titles;
            this.cTitle.ItemsSource = titles;

            ViewModel viewModel = new ViewModel();
            viewModel.GetData();
            this.DataContext = viewModel;
        }

        private void WindowSizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            ApplicationViewState viewState = ApplicationView.Value;
            VisualStateManager.GoToState(this, viewState.ToString(), false);
        }

        private void AppBarSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationViewState viewState = ApplicationView.Value;
            VisualStateManager.GoToState(this.firstCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.previousCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.nextCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.lastCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.addCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.editCustomer, viewState.ToString(), false);
            VisualStateManager.GoToState(this.saveChanges, viewState.ToString(), false);
            VisualStateManager.GoToState(this.discardChanges, viewState.ToString(), false);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
