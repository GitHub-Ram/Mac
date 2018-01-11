using System;
using AppKit;
using Foundation;
using MacGuard.FeaturesList;

namespace MacGuard
{
    public partial class ViewController : NSViewController, INSSplitViewDelegate
    {
        private NSImage Picture = null;
        public NSView Content
        {
            get { return ContentView; }
        }
        public ViewController(IntPtr handle) : base(handle)
        {


        }
        public override void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            // Take action based on segue type
            switch (segue.Identifier)
            {
                case "PictureSegue":
                    //var pictureView = segue.DestinationController as PictureViewController;
                    //pictureView.Picture = Picture;
                    break;
            }
        }

        public override void ViewWillAppear()
        {
            base.ViewWillAppear();
            splitView.Delegate = this;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            FeatureSourceList.Initialize();


            var SystemStaus = new FeaturesListItem("");
            SystemStaus.AddItem("System Status", "33.png", "press", () =>
            {
                PerformSegue("TableSegue", this);
            });
            FeatureSourceList.AddItem(SystemStaus);


            var HumanAssistance = new FeaturesListItem("Human Assistance");

            HumanAssistance.AddItem("Find & Fix", "33.png", " not press ", () =>
            {
                PerformSegue("SystemStatusSegue", this);
            });
            HumanAssistance.AddItem("Geek on Demand", "333.png", " not press ", () =>
            {
                PerformSegue("SystemStatusSegue", this);
            });
            FeatureSourceList.AddItem(HumanAssistance);


            var Security = new FeaturesListItem("Security");

            Security.AddItem("Internet Security", "333.png", " not press ", () =>
            {
                PerformSegue("SystemStatusSegue", this);
            });
            Security.AddItem("Anti-Theft", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            FeatureSourceList.AddItem(Security);

            var AdvancedTools = new FeaturesListItem("Advanced Tools");

            AdvancedTools.AddItem("Adware Cleaner", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Memory Cleaner", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });

            AdvancedTools.AddItem("Duplicate Finder", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Smart Uninstalls", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });


            AdvancedTools.AddItem("Files Recovery", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Data Encryptor", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });

            AdvancedTools.AddItem("Files Finder", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Login Items", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Disk Usage Items", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Default Apps", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Login Items", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            });
            AdvancedTools.AddItem("Update Tracker", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            }); AdvancedTools.AddItem("Login Items", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            }); AdvancedTools.AddItem("Fast Cleanup", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            }); AdvancedTools.AddItem("Backup", "333.png", " not press ", () =>
            {
                PerformSegue("OutlineSegue", this);
            }); 



            FeatureSourceList.AddItem(AdvancedTools);


            //var ImageViews = new FeaturesListItem("Photos");
            //ImageViews.AddItem("First Person", "333.png", "--", () =>
            //{
            //    Picture = NSImage.ImageNamed("333.png");
            //    PerformSegue("PictureSegue", this);
            //});
            //ImageViews.AddItem("Second Person", "333.png", "--", () =>
            //{
            //    Picture = NSImage.ImageNamed("333.png");
            //    PerformSegue("PictureSegue", this);
            //});
            //ImageViews.AddItem("Third Person", "333.png", "--", () =>
            //{
            //    Picture = NSImage.ImageNamed("333.png");
            //    PerformSegue("PictureSegue", this);
            //});
            //FeatureSourceList.AddItem(ImageViews);

            // Display Source List
            FeatureSourceList.ReloadData();
          //  FeatureSourceList.ExpandItem(null, true);
            FeatureSourceList.ExpandItem(HumanAssistance, true);
            FeatureSourceList.ExpandItem(Security, true);
            FeatureSourceList.ExpandItem(SystemStaus, true);

            //   FeatureSourceList.ExpandItem(AdvancedTools, false);



            //// Do any additional setup after loading the view.
            bottomViewBorder.WantsLayer = true;
            bottomViewBorder.Layer.BorderWidth = 1;
            bottomViewBorder.Layer.BorderColor = NSColor.LightGray.CGColor;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

    }
}
