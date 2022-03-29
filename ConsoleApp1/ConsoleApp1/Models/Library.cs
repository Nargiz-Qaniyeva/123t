using ConsoleApp1.Exceptions;
using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Library
    {
        public string BookLimit { get; set; }
        Books<int> book = new Books<int>();

        public Library()
        {
            this.BookLimit = BookLimit;
        }

        public void AddBook()
        {
            Books.Add(new Book());
            if (true)
            {
                return;
            }
            else
            {
                throw new CapacityLimitException("Limiti asacaq")
            }
        }
        public object GetBookById(int? id)
        {
            if (id == null)
                throw new ArgumentNullException("Bos deyil");
            return null;
        }
    }
}
