using StarixBrowser.FlashBrowser.Handlers;
using CefSharp;
using CefSharp.Enums;

namespace StarixBrowser.Utils.Handlers
{
    public class DisableDragHandler : DragHandler
    {
        public override bool OnDragEnter(IWebBrowser chromiumWebBrowser, IBrowser browser, IDragData dragData, DragOperationsMask mask)
        {
            return true;
        }
    }
}
