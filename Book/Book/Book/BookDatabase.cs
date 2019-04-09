using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace Book
{
    class BookDatabase
    {
        string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(path, "Book.db")))
                {
                    connection.CreateTable<Book>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Debug.WriteLine("SQLiteEx" + ex.Message);
                return false;
            }
        }

        //Insert new book
        public bool insertNewBook(Book newBook)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(path, "Book.db")))
                {
                    connection.Insert(newBook);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Debug.WriteLine("SQLiteEx" + ex.Message);
                return false;
            }
        }

        //select all rows
        public List<Book> selectAllBooks()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(path, "Book.db")))
                {
                    return connection.Table<Book>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                //Debug.WriteLine("SQLiteEx" + ex.Message);
                return null;
            }
        }

        //Delete new book
        public bool deleteBook(Book newBook)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(path, "Book.db")))
                {
                    connection.Delete(newBook);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Debug.WriteLine("SQLiteEx" + ex.Message);
                return false;
            }
        }

        //Updatee new book
        public bool updateBook(Book newBook)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(path, "Book.db")))
                {
                    connection.Update(newBook);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Debug.WriteLine("SQLiteEx" + ex.Message);
                return false;
            }
        }
    }
}