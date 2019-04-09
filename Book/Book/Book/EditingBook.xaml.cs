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
    public partial class EditingBook : ContentPage
    {
        BookDatabase bookdb;
        Book book;
        public EditingBook(object selected)
        {

            InitializeComponent();
            book = (Book)selected;
            title.Text = book.title;
            author.Text = book.firstAuthor;
            year.Text = book.publishYear.ToString();
            bookdb = new BookDatabase();
        }

        //Cancel
        private void Button_Cancel(object sender, EventArgs e)
        {
            //go back to main page
            Navigation.PopModalAsync();
        }

        private void Button_updateBook(object sender, EventArgs e)
        {

            book.title = title.Text;
            book.firstAuthor = author.Text;
            book.publishYear = Convert.ToInt32(year.Text);
            if ((book.title != String.Empty) && (book.firstAuthor != String.Empty) && (book.publishYear != 0))
            {
                //update book
                bookdb.updateBook(book);
                //go back to main page
                Navigation.PopModalAsync();
            }
        }

        private void Button_deleteBook(object sender, EventArgs e)
        {
            bookdb.deleteBook(book);
            Navigation.PopModalAsync();
        }
    }
}