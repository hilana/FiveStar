using System;
using System.Collections.Generic;

using UIKit;
using Foundation;

namespace FiveStar
{
	public class FuncListDataSource : UITableViewSource
	{
		static readonly NSString CellIdentifier = new NSString ("DataSourceCell");
		List<FuncItemGroup> groups;

		public event EventHandler FuncSelected;

		public FuncListDataSource (List<FuncItemGroup> groups)
		{
			this.groups = groups;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return this.groups.Count;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return this.groups[(int)section].Items.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, CellIdentifier);
			}

			var item = this.groups [indexPath.Section].Items [indexPath.Row];
			cell.ImageView.Image = UIImage.FromBundle (item.Img);
			cell.TextLabel.Text = item.Content;
			cell.DetailTextLabel.Text = item.Des;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (FuncSelected != null)
				FuncSelected (this.groups [indexPath.Section].Items [indexPath.Row], EventArgs.Empty);
		}
	}
}

