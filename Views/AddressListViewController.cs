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

		AddressListDataSource source;

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
			base.ViewDidLoad ();

			this.View.BackgroundColor = UIColor.White;

			var addButton = new UIBarButtonItem (UIBarButtonSystemItem.Add, onAddNewAddress);
			NavigationItem.RightBarButtonItem = addButton;

			source = new AddressListDataSource ();
			source.AddressInfoSelected += (object sender, EventArgs e) => {
				if (sender == null)
					return;

				this.NavigationController.PushViewController (new AddressViewController (sender as AddressInfo), true);
			};

			tableView = new UITableView (this.View.Bounds, UITableViewStyle.Grouped);
			tableView.Source = source;
			this.View.AddSubview (tableView);

			RefreshAddressInfos ();
			tableView.ReloadData ();
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

		void onAddNewAddress (object sender, EventArgs e)
		{
			this.NavigationController.PushViewController (new AddressViewController (new AddressInfo()), true);
		}

		private void RefreshAddressInfos()
		{
			var dp = new DataProvider ();
			source.addressInfos = this.addressInfos = dp.GetAddressInfos ();
		}
	}
}

