﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleItem : ContentView
    {
        public ArticleItem()
        {
            InitializeComponent();
        }
    }
}