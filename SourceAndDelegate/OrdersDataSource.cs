using System;
using System.Collections.Generic;

using UIKit;
using Foundation;

namespace FiveStar
{
	public class OrdersDataSource : UITableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("DataSourceCell");
		public List<Order> Orders { get; set; }

		public event EventHandler OrderSelected;

		public OrdersDataSource ()
		{
			this.Orders = new List<Order> ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return this.Orders.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, CellIdentifier);
			}

			Order order = this.Orders [indexPath.Row];
			cell.TextLabel.Text = order.No;
			cell.DetailTextLabel.Text = order.CreateTime;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (OrderSelected != null)
				OrderSelected (this.Orders [indexPath.Row], EventArgs.Empty);
		}
	}
}

