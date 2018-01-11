using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    public class FeaturesListDelegate : NSOutlineViewDelegate
    {

        public List<FeaturesListItem> Items = new List<FeaturesListItem>();
        private FeaturesListView _controller;

        public FeaturesListDelegate(FeaturesListView controller)
        {
            this._controller = controller;
        }

        public override bool ShouldEditTableColumn(NSOutlineView outlineView, NSTableColumn tableColumn, Foundation.NSObject item)
        {
            return false;
        }

        public override NSCell GetCell(NSOutlineView outlineView, NSTableColumn tableColumn, Foundation.NSObject item)
        {
            nint row = outlineView.RowForItem(item);
            return tableColumn.DataCellForRow(row);
        }

        public override bool IsGroupItem(NSOutlineView outlineView, Foundation.NSObject item)
        {
            return ((FeaturesListItem)item).HasChildren;
        }

        public override NSTableRowView RowViewForItem(NSOutlineView outlineView, NSObject item)
        {
            var rowView = outlineView.MakeView("DataCell", this);
            if (rowView != null)
            {
                rowView = new FeatureListTableRowView();
                rowView.Identifier = "DataCell";
            }
            return rowView as NSTableRowView;
        }

        public override NSView GetView(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
        {
            CustomFeaturesTableCellView view = null;
            // Is this a group item?
            if (((FeaturesListItem)item).HasChildren)
            {
                view = (CustomFeaturesTableCellView)outlineView.MakeView("HeaderCell", this);
                view.FeatureHeader.StringValue = ((FeaturesListItem)item).Title;
            }
            else
            {
                view = (CustomFeaturesTableCellView)outlineView.MakeView("DataCell", this);
                view.FeatureIcon.Image  = ((FeaturesListItem)item).Icon;
                view.FeatureTextField.StringValue = ((FeaturesListItem)item).Title;
               // view.FeatureTextField.StringValue = ((FeaturesListItem)item).Title;

                view.NotifyButton.StringValue = ((FeaturesListItem)item).NotifyCount;


            }
            // Initialize view
          //  view.TextFieldC.StringValue = ((FeaturesListItem)item).Title;


            // Return new view
            return view;
        }

        /// <summary>
        /// Shoulds the select item.
        /// </summary>
        /// <returns><c>true</c>, if select item was shoulded, <c>false</c> otherwise.</returns>
        /// <param name="outlineView">Outline view.</param>
        /// <param name="item">Item.</param>

        public override bool ShouldSelectItem(NSOutlineView outlineView, NSObject item)
        {
            return true;
        }

        /// <summary>
        /// Selections the did change.
        /// </summary>
        /// <param name="notification">Notification.</param>
        public override void SelectionDidChange(NSNotification notification)
        {
            NSIndexSet selectedIndexes = _controller.SelectedRows;
            if (selectedIndexes.Count > 1)
            {
                
            }
            else
            {
                var item = _controller.Data.ItemForRow((int)selectedIndexes.FirstIndex);
                if (item != null)
                {
                    item.RaiseClickedEvent();
                    _controller.RaiseItemSelected(item);
                }
            }
        }
    }
}
