using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Book
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddingBook : ContentPage
	{
        BookDatabase bookdb;
        public AddingBook() {
            InitializeComponent();
            bookdb = new BookDatabase();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //create a new Book object
            var newBook = new Book();
            newBook.title = title.Text;
            newBook.firstAuthor = author.Text;
            newBook.publishYear = Convert.ToInt32(year.Text);
            if ((newBook.title != String.Empty) && (newBook.firstAuthor != String.Empty) && (newBook.publishYear != 0)){
                //insert new row
                bookdb.insertNewBook(newBook);
                //go back to main page
                Navigation.PopModalAsync();
            }
        }
        //Cancel
        private void Button_Clicked_1(object sender, EventArgs e){
            //go back to main page
            Navigation.PopModalAsync();
        }
    }
}