using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab13.Models;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab13.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            using (LibraryContext db = new LibraryContext())
            {
                booksList.ItemsSource = db.Books.ToList();
            }
            base.OnAppearing();
        }

        // select element in list
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Book selectedBook = (Book)e.SelectedItem;
            BooksPage booksPage = new BooksPage();
            booksPage.BindingContext = selectedBook;
            await Navigation.PushAsync(booksPage);
        }
        // create
        private async void CreateBook(object sender, EventArgs e)
        {
            Book book = new Book();
            BooksPage booksPage = new BooksPage();
            booksPage.BindingContext = book;
            await Navigation.PushAsync(booksPage);
        }
    }
}
