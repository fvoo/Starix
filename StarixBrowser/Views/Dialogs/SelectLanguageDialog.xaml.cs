﻿using StarixBrowser.Utils;
using System.Windows;

namespace StarixBrowser.Views.Dialogs
{
    /// <summary>
    /// SelectLanguageDialog.xaml 的交互逻辑
    /// </summary>
    public partial class SelectLanguageDialog : Window
    {
        public SelectLanguageDialog()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClick(object sender, RoutedEventArgs e)
        {
            WindowManager.ShowMainWindow();
            DialogResult = true;
        }
    }
}
