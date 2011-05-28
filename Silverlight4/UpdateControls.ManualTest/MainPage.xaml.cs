﻿using System.Threading;
using System.Windows;
using System.Windows.Controls;
using UpdateControls.XAML;

namespace UpdateControls.ManualTest
{
    public partial class MainPage : UserControl
    {
        private Model _model;
        private ViewModel _viewModel;
        private Thread _thread;

        public MainPage()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _model = new Model();
            _viewModel = new ViewModel(_model);
            _thread = new Thread(ThreadProc);
            _thread.Start();

            DataContext = ForView.Wrap(_viewModel);
        }

        private void ThreadProc(object o)
        {
            while (true)
            {
                Thread.Sleep(50);
                _model.FirstNumber++;
                _model.SecondNumber++;
            }
        }
    }
}