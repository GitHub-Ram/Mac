using System;
using System.Collections;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace MacGuard.FeaturesList
{
    public class FeaturesListItem : NSObject , IEnumerable, IEnumerator
    {

        private string _title;
        private string _header;

        private string _tag;
        private NSImage _icon;
        private string _notifyCount;
        private List<FeaturesListItem> _items = new List<FeaturesListItem>();



        public string Title
        {
            get
            {
                return _title;
            }
            set
            {

                _title = value;
            }
        }

        public string Header
        {
            get
            {
                return _header;
            }
            set
            {

                _header = value;
            }
        }

        public NSImage Icon
        {
            get
            {
                return _icon;
            }
            set
            {

                _icon = value;
            }
        }


        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {

                _tag = value;
            }
        }


        public string NotifyCount
        {
            get
            {
                return _notifyCount;
            }
            set
            {

                _title = value;
            }
        }
        public FeaturesListItem this[int index]
        {
            get
            {
                return _items[index];
            }

            set
            {
                _items[index] = value;
            }
        }



        public int Count
        {
            get { return _items.Count; }
        }


        public bool HasChildren
        {
            get { return (Count > 0); }
        }
       
        #region Enumerable Routines
        private int _position = -1;

        public IEnumerator GetEnumerator()
        {
            _position = -1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Count);
        }

        public void Reset()
        { _position = -1; }

        public object Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }

                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        #endregion


      
        public FeaturesListItem()
        {
        }


        public FeaturesListItem(string title)
        {
            // Initialize
            this._title = title;
        }


        public FeaturesListItem(string title, string icon, string notifyCount)
        {
            // Initialize
            this._title = title;
            this._icon = NSImage.ImageNamed(icon);
            this._notifyCount = notifyCount;
        }


        public FeaturesListItem( string title, string icon, string notifyCount, ClickedDelegate clicked)
        {
            // Initialize
            this._title = title;
            this._icon = NSImage.ImageNamed(icon);
            //this._header = header;
            this._notifyCount = notifyCount;
            this.Clicked = clicked;
        }


        public FeaturesListItem(string title, NSImage icon, string notifyCount)
        {
            // Initialize
            this._title = title;
            this._icon = icon;
            this._notifyCount = notifyCount;
        }


        public FeaturesListItem(string title, NSImage icon, string notifyCount, ClickedDelegate clicked)
        {
            // Initialize
            this._title = title;
            this._icon = icon;
            this.Clicked = clicked;
            this._notifyCount = notifyCount;
        }


        public FeaturesListItem(string title, NSImage icon, string tag, string notifyCount)
        {
            // Initialize
            this._title = title;
            this._icon = icon;
            this._tag = tag;
            this._notifyCount = notifyCount;
        }
        public FeaturesListItem(string title, NSImage icon, string tag, string notifyCount, ClickedDelegate clicked)
        {
            // Initialize
            this._title = title;
            this._icon = icon;
            this._tag = tag;
            this.Clicked = clicked;
            this._notifyCount = notifyCount;
        }


 
        public void AddItem(FeaturesListItem item)
        {
            _items.Add(item);
        }

     
        public void AddItem(string title)
        {
            _items.Add(new FeaturesListItem(title));
        }


        public void AddItem(string title, string icon, string notifyCount)
        {
            _items.Add(new FeaturesListItem(title, icon, notifyCount));
        }


        public void AddItem(string title, string icon, string notifyCount, ClickedDelegate clicked)
        {
            _items.Add(new FeaturesListItem(title, icon, notifyCount, clicked));
        }

        public void AddItem(string title, NSImage icon, string notifyCount)
        {
            _items.Add(new FeaturesListItem(title, icon, notifyCount));
        }

      
        public void AddItem(string title, NSImage icon, string notifyCount, ClickedDelegate clicked)
        {
            _items.Add(new FeaturesListItem(title, icon, notifyCount, clicked));
        }

       
        public void AddItem(string title, NSImage icon, string tag, string notifyCount)
        {
            _items.Add(new FeaturesListItem(title, icon, tag, notifyCount));
        }


        public void AddItem(string title, NSImage icon, string tag, string notifyCount, ClickedDelegate clicked)
        {
            _items.Add(new FeaturesListItem(title, icon, tag, notifyCount, clicked));
        }

        public void Insert(int n, FeaturesListItem item)
        {
            _items.Insert(n, item);
        }

    
        public void RemoveItem(FeaturesListItem item)
        {
            _items.Remove(item);
        }


        public void RemoveItem(int n)
        {
            _items.RemoveAt(n);
        }

       
        public void Clear()
        {
            _items.Clear();
        }

        public delegate void ClickedDelegate();

        public event ClickedDelegate Clicked;

        internal void RaiseClickedEvent()
        {
            // Inform caller
            if (this.Clicked != null)
                this.Clicked();
        }



    }
}
