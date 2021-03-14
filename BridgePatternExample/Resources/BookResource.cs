using BridgePatternExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample.Resources
{
    public class BookResource : IResource
    {
        private readonly Book _book;

        public BookResource(Book book)
        {
            _book = book;
        }

        public string Snippet => _book.BackDescription;

        public string Image => throw new NotImplementedException();

        public string Title => _book.BookTitle;

        public string Url => throw new NotImplementedException();
    }
}
