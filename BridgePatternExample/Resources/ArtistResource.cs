using BridgePatternExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample.Resources
{
    public class ArtistResource : IResource
    {
        private readonly Artist _artist;
        public ArtistResource(Artist artist)
        {
            _artist = artist;
        }
        public string Snippet => throw new NotImplementedException();

        public string Image => throw new NotImplementedException();

        public string Title => $"{_artist.FirstName} {_artist.LastName}";

        public string Url => throw new NotImplementedException();
    }
}
