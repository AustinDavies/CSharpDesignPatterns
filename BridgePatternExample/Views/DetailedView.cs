using BridgePatternExample.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternExample.Views
{
    public class DetailedView : View
    {
        public DetailedView(IResource resource)
            :base(resource)
        {

        }

        public override string Show()
        {
            return _resource.Snippet;
        }
    }
}
