using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample.Resources
{
    public interface IResource
    {
        string Snippet { get; }
        string Image { get; }
        string Title { get; }
        string Url { get; }
    }
}
