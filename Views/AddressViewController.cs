using System;

using UIKit;
using Foundation;

namespace FiveStar
{
	public class AddressViewController : UIViewController
	{
		AddressInfo addressInfo;

		public AddressViewController (AddressInfo addressInfo)
		{
			Title = NSBundle.MainBundle.LocalizedString ("地址详情", "地址详情");
			this.addressInfo = addressInfo;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();
			
			this.View.BackgroundColor = UIColor.White;

			var doneButton = new UIBarButtonItem (UIBarButtonSystemItem.Save, onSave);
			NavigationItem.RightBarButtonItem = doneButton;
		}

		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		void onSave (object sender, EventArgs e)
		{
			this.NavigationController.PopViewController(true);
		}
	}
}

