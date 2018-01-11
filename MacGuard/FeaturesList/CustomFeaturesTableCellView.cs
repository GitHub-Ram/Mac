using System;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    [Register("CustomFeaturesTableCellView")]
    public partial class CustomFeaturesTableCellView : NSTableCellView
    {
        private NSTextField _FeatureHeader;
        private NSTextField _NotifyButton;
        private NSImageView _FeatureIcon;
        private NSTextField _FeatureTextField;

        public NSImageView FeatureIcon
        {
            get
            {
                return _FeatureIcon;
            }
            set
            {
                _FeatureIcon = value;
            }
        }

        public NSTextField NotifyButton
        {
            get
            {
                return _NotifyButton;
            }
            set
            {
                _NotifyButton = value;
            }
        }
        public NSTextField FeatureTextField
        {
            get
            {
                return _FeatureTextField;
            }
            set
            {
                _FeatureTextField = value;
            }
        }


        public NSTextField FeatureHeader
        {
            get
            {
                return _FeatureHeader;
            }
            set
            {
                _FeatureHeader = value;
            }
        }

        public CustomFeaturesTableCellView(IntPtr intPtr):base(intPtr)
        {

        }
        public CustomFeaturesTableCellView()
        {


        }
        public override void AwakeFromNib()
        { 
            base.AwakeFromNib();
            this.WantsLayer = true;
            this.Layer.BackgroundColor = NSColor.Clear.CGColor;
            this._NotifyButton = nsFeastureRoundedText;
            this._FeatureIcon = nsFeatureImage;
            this._FeatureTextField = nsFeatureTextField;
            this._FeatureHeader = nsFeatureHeader;
            if(nsFeastureRoundedText!=null){
                //nsFeastureRoundedText.WantsLayer = true;
                //nsFeastureRoundedText.DrawsBackground = true;
                //nsFeastureRoundedText.Layer.BorderWidth = 1;
                //nsFeastureRoundedText.Layer.CornerRadius = 8;
                //nsFeastureRoundedText.Layer.BorderColor = NSColor.FromDeviceRgb(153,153,153).CGColor;
                //nsFeastureRoundedText.BackgroundColor = NSColor.Red;
            }

        
        }
    }
}
