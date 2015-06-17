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

		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 64;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, CellIdentifier);
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
				cell.TextLabel.Font = UIFont.BoldSystemFontOfSize (18);
			}

			var item = this.groups [indexPath.Section].Items [indexPath.Row];
			cell.TextLabel.Text = item.Content;
			cell.DetailTextLabel.Text = item.Des;

			if (cell.Selected) {
				cell.ImageView.Image = UIImage.FromBundle (item.SelSImg);
				cell.TextLabel.TextColor = UIColor.FromRGB (255, 255, 255);
			} else {
				cell.ImageView.Image = UIImage.FromBundle (item.DefImg);
				cell.TextLabel.TextColor = UIColor.FromRGB (109, 127, 153);
			}

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var item = this.groups [indexPath.Section].Items [indexPath.Row];
			var cell = tableView.CellAt (indexPath);
			if (cell.Selected) {
				cell.ImageView.Image = UIImage.FromBundle (item.SelSImg);
				cell.TextLabel.TextColor = UIColor.FromRGB (255, 255, 255);
			} else {
				cell.ImageView.Image = UIImage.FromBundle (item.DefImg);
				cell.TextLabel.TextColor = UIColor.FromRGB (109, 127, 153);
			}

			if (FuncSelected != null)
				FuncSelected (this.groups [indexPath.Section].Items [indexPath.Row], EventArgs.Empty);
		}
	}
}

