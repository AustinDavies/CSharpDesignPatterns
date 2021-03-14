using BridgePatternExample.Resources;

namespace BridgePatternExample.Views
{
    public abstract class View
    {
        protected readonly IResource _resource;
        public View(IResource resource)
        {
            _resource = resource;
        }

        public abstract string Show();
    }
}
