using System;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    [Register("FeaturesListView")]
    public class FeaturesListView : NSOutlineView
    {

       
        public FeaturesListDataSource Data
        {
            get { return (FeaturesListDataSource)this.DataSource; }
        }
    
       

        public FeaturesListView()
        {

        }

        public FeaturesListView(IntPtr handle) : base(handle)
        {

        }

        public FeaturesListView(NSCoder coder) : base(coder)
        {

        }

        public FeaturesListView(NSObjectFlag t) : base(t)
        {

        }
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
           

        }

        public void Initialize()
        {



            // Initialize this instance
            this.DataSource = new FeaturesListDataSource(this);
            this.Delegate = new  FeaturesListDelegate(this);

        }
        public void AddItem(FeaturesListItem item)
        {
            if (Data != null)
            {
                Data.Items.Add(item);
            }
        }


        public delegate void ItemSelectedDelegate(FeaturesListItem item);

        public event ItemSelectedDelegate ItemSelected;


        internal void RaiseItemSelected(FeaturesListItem item)
        {

            if (this.ItemSelected != null)
            {
                ItemSelected(item);
            }
        }
    }
}
