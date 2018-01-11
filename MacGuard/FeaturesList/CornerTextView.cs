using System;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    [Register("CornerTextView")]
    public class CornerTextView : NSTextField
    {
        public CornerTextView()
        {
        }
        public CornerTextView(IntPtr handle) : base(handle)
        {


        }
        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            base.DrawRect(dirtyRect);
            //        var bounds: NSRect = self.bounds
            //var border: NSBezierPath = NSBezierPath(roundedRect: NSInsetRect(bounds, 0.5, 0.5), xRadius: 3, yRadius: 3)
            //NSColor(red: 47 / 255.0, green: 146 / 255.0, blue: 204 / 255.0, alpha: 1.0).set()
            //border.stroke()
            var bound = this.Bounds;
            bound.X = 0.5f;
            bound.Y = 0.5f;
            bound.Height -= 1f;
            bound.Width -= 1f;
            var selectionPath = NSBezierPath.FromRoundedRect(bound, 7, 7);
            NSColor.FromDeviceRgb(153, 153, 153);
            selectionPath.Stroke();

        }
    }
}
