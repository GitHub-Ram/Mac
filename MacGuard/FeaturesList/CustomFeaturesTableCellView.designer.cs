// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacGuard.FeaturesList
{
	partial class CustomFeaturesTableCellView
	{
		[Outlet]
		AppKit.NSTextField nsFeastureRoundedText { get; set; }

		[Outlet]
		AppKit.NSTextField nsFeatureHeader { get; set; }

		[Outlet]
		AppKit.NSImageView nsFeatureImage { get; set; }

		[Outlet]
		AppKit.NSTextField nsFeatureTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (nsFeastureRoundedText != null) {
				nsFeastureRoundedText.Dispose ();
				nsFeastureRoundedText = null;
			}

			if (nsFeatureHeader != null) {
				nsFeatureHeader.Dispose ();
				nsFeatureHeader = null;
			}

			if (nsFeatureImage != null) {
				nsFeatureImage.Dispose ();
				nsFeatureImage = null;
			}

			if (nsFeatureTextField != null) {
				nsFeatureTextField.Dispose ();
				nsFeatureTextField = null;
			}
		}
	}
}
