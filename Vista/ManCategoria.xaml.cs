﻿using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Vista.ViewModel;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para ManCategoria.xaml
    /// </summary>
    public partial class ManCategoria : Window
    {
        public Categoria categoria = new Categoria();

        public ManCategoriaViewModel viewModel;

        public ManCategoria(Categoria categoria)
        {
            InitializeComponent();
            viewModel = new ManCategoriaViewModel();
            this.DataContext = viewModel;
        }
    }
}
