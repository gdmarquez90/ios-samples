// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HeadsUp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView BackgroundImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView HoverView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LeftButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RightButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView TitleView { get; set; }

        [Action ("LeftAction:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LeftAction (UIKit.UIButton sender);

        [Action ("RightAction:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RightAction (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BackgroundImage != null) {
                BackgroundImage.Dispose ();
                BackgroundImage = null;
            }

            if (HoverView != null) {
                HoverView.Dispose ();
                HoverView = null;
            }

            if (LeftButton != null) {
                LeftButton.Dispose ();
                LeftButton = null;
            }

            if (RightButton != null) {
                RightButton.Dispose ();
                RightButton = null;
            }

            if (TitleView != null) {
                TitleView.Dispose ();
                TitleView = null;
            }
        }
    }
}