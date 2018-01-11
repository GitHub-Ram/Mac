using System;
using AppKit;
using CoreGraphics;
using Foundation;

namespace MacGuard
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void WillFinishLaunching(NSNotification notification)
        {
            //NSWindow window = NSApplication.
            NSScreen screen = NSScreen.MainScreen;
            double Setheight = screen.Frame.Height * 0.7;
            double Setwidth = screen.Frame.Width * 0.8;

            NSApplication.SharedApplication.MainWindow.SetFrame(new CGRect(0,0, Setwidth, Setheight),true);
            NSApplication.SharedApplication.MainWindow.Center();

        }
        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
        {
            return true;
        }
    }
}
