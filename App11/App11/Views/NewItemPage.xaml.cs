using System;
using System.Collections.Generic;
using System.ComponentModel;
using App11.Models;
using App11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}