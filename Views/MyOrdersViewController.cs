using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using CoreGraphics;

namespace FiveStar
{
	public class MyOrdersViewController : UIViewController
	{
		UISegmentedControl segmentedControl;

		UITableView tableView;
		OrdersDataSource source;

		List<Order> Orders;

		public MyOrdersViewController ()
		{
			Title = NSBundle.MainBundle.LocalizedString ("我的订单", "我的订单");
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

			//RefreshOrders ();

			segmentedControl = new UISegmentedControl (new object[]{ "未完成", "已完成" });
			segmentedControl.SelectedSegment = 0;
			segmentedControl.ValueChanged += SegmentedControl_ValueChanged;

			source = new OrdersDataSource ();
			source.OrderSelected += (object sender, EventArgs e) => {
				if (sender == null)
					return;
				
				this.NavigationController.PushViewController (new OrderViewController (sender as Order), true);
			};

			tableView = new UITableView (this.View.Bounds,UITableViewStyle.Grouped);
			tableView.Source = source;
			tableView.TableHeaderView = segmentedControl;
			this.View.AddSubview (tableView);

			SegmentedControl_ValueChanged (null, EventArgs.Empty);
		}

		void SegmentedControl_ValueChanged (object sender, EventArgs e)
		{
			RefreshOrders ();

			switch (segmentedControl.SelectedSegment) {
			case 0:
				source.Orders = this.Orders.FindAll (f => f.State == OrderState.未完成);
				break;
			case 1:
				source.Orders = this.Orders.FindAll (f => f.State == OrderState.已完成);
				break;
			default:
				return;
			}

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

		private void RefreshOrders()
		{
			var dp = new DataProvider ();
			this.Orders = dp.GetOrders ();
		}
	}
}

