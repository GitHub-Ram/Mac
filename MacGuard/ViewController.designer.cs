// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacGuard
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSView bottomView { get; set; }

		[Outlet]
		AppKit.NSView bottomViewBorder { get; set; }

		[Outlet]
		AppKit.NSView ContentView { get; set; }

		[Outlet]
		MacGuard.FeaturesList.FeaturesListView FeatureSourceList { get; set; }

		[Outlet]
		AppKit.NSSplitView splitView { get; set; }

		[Action ("NotifyButton:")]
		partial void NotifyButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ContentView != null) {
				ContentView.Dispose ();
				ContentView = null;
			}

			if (FeatureSourceList != null) {
				FeatureSourceList.Dispose ();
				FeatureSourceList = null;
			}

			if (splitView != null) {
				splitView.Dispose ();
				splitView = null;
			}

			if (bottomView != null) {
				bottomView.Dispose ();
				bottomView = null;
			}

			if (bottomViewBorder != null) {
				bottomViewBorder.Dispose ();
				bottomViewBorder = null;
			}
		}
	}
}
