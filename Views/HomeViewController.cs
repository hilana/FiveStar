using System;

using UIKit;
using CoreGraphics;

using Alliance.Carousel;

namespace FiveStar
{
	public class HomeViewController : UIViewController
	{
		CarouselView carousel;

		public HomeViewController ()
		{ 
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

			var dp = new DataProvider ();
			carousel = new CarouselView (new CGRect (0, this.NavigationController.NavigationBar.Frame.Bottom, this.View.Bounds.Width, 150)) {
				DataSource = new AutoScrollDataSource (dp.GetHomeTopItems ()),
				Delegate = new AutoScrollDelegate ()
			};
			carousel.CarouselType = CarouselType.Linear;
			carousel.ConfigureView();

			View.AddSubview(carousel);
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

