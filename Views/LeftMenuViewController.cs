using System;
using System.Collections.Generic;

using UIKit;
using CoreGraphics;

using JASidePanels;

namespace FiveStar
{
	public class LeftMenuViewController : UIViewController
	{
		JASidePanelController parentController;

		UserInfoView userView;
		UITableView tableView;

		FuncListDataSource source;

		public LeftMenuViewController (JASidePanelController controller)
		{
			this.parentController = controller;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			this.View.BackgroundColor = UIColor.Red;

			userView = new UserInfoView (new CGRect (0, 0, this.parentController.LeftVisibleWidth, 200));
			userView.UserInfo = new UserInfo ();
			this.View.AddSubview (userView);

			var dp = new DataProvider ();
			source = new FuncListDataSource (dp.GetFuncItemGroups ());
			source.FuncSelected += Source_FuncSelected;

			tableView = new UITableView (new CGRect (0, userView.Frame.Bottom, userView.Bounds.Width, this.View.Bounds.Height - userView.Bounds.Height), UITableViewStyle.Grouped);
			tableView.Source = source;
			this.View.AddSubview (tableView);
		}

		void Source_FuncSelected (object sender, EventArgs e)
		{
			var item = sender as FuncItem;

			UIViewController controller;
			switch (item.No) {
			case 1:
				controller = new MyOrdersViewController ();
				break;
			case 2:
				controller = new MyWalletViewController ();
				break;
			case 3:
				controller = new AddressListViewController ();
				break;
			case 4:
				controller = new MyOrdersViewController ();
				break;
			case 5:
				controller = new FeedbackViewController ();
				break;
			case 6:
				controller = new AboutViewController ();
				break;
			default:
				return;
			}

			this.parentController.ShowCenterPanelAnimated (true);
			(this.parentController.CenterPanel as UINavigationController).PushViewController (controller, true);
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
	}
}