using System;
using System.Collections.Generic;
using ListViewScheduleTest.ViewModels;
using Xamarin.Forms;

namespace ListViewScheduleTest.Views
{
    public partial class ListsView : ContentPage
    {
        public ListsView()
        {
            InitializeComponent();
            var model = new ListsViewModel();
            BindingContext = model;
        }
    }
}
