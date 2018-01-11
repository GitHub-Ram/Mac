using System;
using AppKit;

namespace MacGuard.FeaturesList
{
    public class FeatureListTableRowView : NSTableRowView 
    {
        public FeatureListTableRowView()
        {
        }

        public override void DrawSelection(CoreGraphics.CGRect dirtyRect)
        {
            //base.DrawRect(dirtyRect);

    //        if (self.selectionHighlightStyle != NSTableViewSelectionHighlightStyleNone)
    //        {
    //            NSRect selectionRect = NSInsetRect(self.bounds, 2.5, 2.5);
    //    [[NSColor colorWithCalibratedWhite:.65 alpha:1.0] setStroke];
    //    [[NSColor redColor] setFill];
    //    NSBezierPath* selectionPath = [NSBezierPath bezierPathWithRoundedRect: selectionRect xRadius: 6 yRadius: 6];
    //    [selectionPath fill];
    //    [selectionPath stroke];
    //}

            if(this.SelectionHighlightStyle!= NSTableViewSelectionHighlightStyle.None){
                //NSColor.FromCalibratedWhite(0.65f, 1.0f).SetStroke();
                NSColor.FromRgb(51, 153,255).SetStroke();
                NSColor.FromRgb(51, 153, 255).SetFill();
                //NSColor.White.SetStroke();
                var selectionPath = NSBezierPath.FromRoundedRect(dirtyRect, 0, 0);

                selectionPath.Fill();
                selectionPath.Stroke();
            }
        }
    }
}
