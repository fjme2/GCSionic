using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Book
{
    public partial class MainPage : ContentPage
    {
        BookDatabase db;
        public MainPage()
        {
            InitializeComponent();
            db = new BookDatabase();
            db.createDatabase();
            bookList.ItemsSource = db.selectAllBooks();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddingBook());
        }

        protected override void OnAppearing()
        {
            //base.OnAppearing();
            bookList.ItemsSource = db.selectAllBooks();
        }

        private void BookList_ItemSelected(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EditingBook(bookList.SelectedItem));
        }
    }
}
