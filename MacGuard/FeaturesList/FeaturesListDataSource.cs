using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    public class FeaturesListDataSource : NSOutlineViewDataSource
    {

        private FeaturesListView _controller;
        public List<FeaturesListItem> Items = new List<FeaturesListItem>();
     
        public FeaturesListDataSource(FeaturesListView  controller)
        {
            this._controller = controller;
        }

        public override nint GetChildrenCount(NSOutlineView outlineView, Foundation.NSObject item)
        {
            if (item == null)
            {
                return Items.Count;
            }
            else
            {
                return ((FeaturesListItem)item).Count;
            }
        }

        public override bool ItemExpandable(NSOutlineView outlineView, Foundation.NSObject item)
        {
            return ((FeaturesListItem)item).HasChildren;
        }

        public override NSObject GetChild(NSOutlineView outlineView, nint childIndex, Foundation.NSObject item)
        {
            if (item == null)
            {
                return Items[(int)childIndex];
            }
            else
            {
                return ((FeaturesListItem)item)[(int)childIndex];
            }
        }
        public override NSObject GetObjectValue(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
        {
            return new NSString(((FeaturesListItem)item).Title);
        }

        internal FeaturesListItem ItemForRow(int row)
        {
            int index = 0;

            // Look at each group
            foreach (FeaturesListItem item in Items)
            {
                // Is the row inside this group?
                if (row >= index && row <= (index + item.Count))
                {
                    return item[row - index - 1];
                }

                // Move index
                index += item.Count + 1;
            }

            // Not found 
            return null;
        }
    }
}
