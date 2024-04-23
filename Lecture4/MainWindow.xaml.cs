﻿using System.Net.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Joshua Saetern
    /// 04.18.2024
    /// Lecture 4 
    public partial class MainWindow : Window
    {
        Product[] movies =
            {
                new Product {title = "The Shawshank Redemption", director = "Frank Darabont", rating = 9.3, price = 9.99m },
                new Product {title = "The Godfather", director = "Francis Ford Coppola", rating = 9.2, price = 12.99m },
                new Product {title = "The Dark Knight", director = "Christopher Nolan", rating = 9.0, price = 14.99m },
                new Product {title = "Inception", director = "Christopher Nolan", rating = 8.8, price = 9.99m },
                new Product {title = "Forrest Gump", director = "Robert Zemeckis", rating = 8.8, price = 7.99m },
                new Product {title = "The Matrix", director = "Lana and Lilly Wachowski", rating = 8.7, price = 8.99m },
            };
        public MainWindow()
        {
            InitializeComponent();
            

            /*
            for (int i = 0; i < movies.Length; i++)
            {
                runDisplay.Text += movies[i].ToString();
            }
            */
        }

        private void richTxtBoxInfo_Changed(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnShawShank_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[0].ToString();
        }

        private void btnGodFather_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[1].ToString();
        }

        private void btnDarkKnight_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[2].ToString();
        }

        private void btnInception_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[3].ToString();
        }

        private void btnForrest_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[4].ToString();
        }

        private void btnMatrix_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = movies[5].ToString();
        }
    }
}