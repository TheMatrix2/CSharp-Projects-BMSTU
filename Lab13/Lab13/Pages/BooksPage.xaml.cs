using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab13.Models;

namespace Lab13.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {

        public PassengersPage()
        {
            InitializeComponent();
        }

        private void SaveBook(object sender, EventArgs e)
        {
            var book = (Book)BindingContext;
            if (!String.IsNullOrEmpty(book.Title))
            {
                using (LibraryContext db = new LibraryContext())
                {

                    if (book.ID == 0)
                        db.Books.Add(book);
                    else
                    {
                        db.Books.Update(book);
                    }
                    db.SaveChanges();
                }
            }
            this.Navigation.PopAsync();
        }
        private void DeleteBook(object sender, EventArgs e)
        {
            var book = (Book)BindingContext;
            using (LibraryContext db = new LibraryContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
            this.Navigation.PopAsync();
        }
    }
}
