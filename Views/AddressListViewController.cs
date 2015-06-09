using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using CoreGraphics;

namespace FiveStar
{
	public class AddressListViewController : UIViewController
	{
		UITableView tableView;

		List<AddressInfo> addressInfos;

		public AddressListViewController ()
		{
			Title = NSBundle.MainBundle.LocalizedString ("常用地址", "常用地址");
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			this.View.BackgroundColor = UIColor.White;

			tableView = new UITableView (this.View.Bounds, UITableViewStyle.Grouped);
			this.View.AddSubview (tableView);
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

		private void RefreshOrders()
		{
			var dp = new DataProvider ();
			this.addressInfos = dp.GetAddressInfos ();
		}
	}
}

