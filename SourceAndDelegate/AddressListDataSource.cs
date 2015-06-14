using System;
using System.Collections.Generic;

using UIKit;
using Foundation;

namespace FiveStar
{
	public class AddressListDataSource : UITableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("DataSourceCell");
		public List<AddressInfo> addressInfos { get; set; }

		public event EventHandler AddressInfoSelected;

		public AddressListDataSource ()
		{
			this.addressInfos = new List<AddressInfo> ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return this.addressInfos.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, CellIdentifier);
			}

			var addressInfo = this.addressInfos [indexPath.Row];
			cell.TextLabel.Text = addressInfo.Content;
			cell.DetailTextLabel.Text = addressInfo.Des;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (AddressInfoSelected != null)
				AddressInfoSelected (this.addressInfos [indexPath.Row], EventArgs.Empty);
		}
	}
}

