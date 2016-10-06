using System;

using UIKit;
using Foundation;

namespace HeadsUp
{
	public partial class ViewController : UIViewController
	{
		NSTimer hoverViewInactiveTimer = null;

		protected ViewController(IntPtr handle) : base(handle)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.HoverView.Layer.CornerRadius = 5.0f;
			this.HoverView.Alpha = 0.0f;
		}

		// -------------------------------------------------------------------------------
		//	touchesEnded:withEvent:
		//  Called when the user touches our view.
		// -------------------------------------------------------------------------------
		public override void TouchesEnded(Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesEnded(touches, evt);

			UITouch touch= touches.AnyObject as UITouch;

			if (touch.TapCount > 0) {
				this.ShowHoverView(this.HoverView.Alpha < 1.0f);
			}

		}

		// -------------------------------------------------------------------------------
		//	showHoverView:
		//  Helper method that animates the hoverView into or out of view deending on
		//  the value of the 'show' parameter.  If animating the hoverView into view,
		//  it starts a timer to hide the hoverView after a few seconds of inactivity.
		// -------------------------------------------------------------------------------
		public void ShowHoverView(bool show){
			if (this.hoverViewInactiveTimer != null)
			{
				this.hoverViewInactiveTimer.Invalidate();
				this.hoverViewInactiveTimer = null;
			}

			UIView.Animate(0.40, () => {
				if (show)
				{
					this.HoverView.Alpha = 1.0f;
					this.hoverViewInactiveTimer = NSTimer.CreateScheduledTimer(3.0, (obj) => {
						this.TimerFired();
					}); 
				} else {
					this.HoverView.Alpha = 0.0f;
				}
			});
		}

		// -------------------------------------------------------------------------------
		//	TimerFired
		//  Called when the hoverViewInactiveTimer fires.
		// -------------------------------------------------------------------------------
		public void TimerFired() {
			this.ShowHoverView(false);
		}

		// -------------------------------------------------------------------------------
		//	LeftAction
		//  Action for the pause button.
		// -------------------------------------------------------------------------------
		partial void LeftAction(UIButton sender)
		{
			this.ShowHoverView(false);
		}

		// -------------------------------------------------------------------------------
		//	RightAction
		//  Action for the play button.
		// -------------------------------------------------------------------------------
		partial void RightAction(UIButton sender)
		{
			this.ShowHoverView(false);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

