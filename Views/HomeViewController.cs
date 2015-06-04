using System;

using UIKit;
using Foundation;
using CoreGraphics;

using Alliance.Carousel;

namespace FiveStar
{
	public class HomeViewController : UIViewController
	{
		CarouselView carousel;
		UIPageControl pageControl;

		AutoScrollDelegate autoScrollDelegate;

		NSTimer timer;
		double changedSpan=2;

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
			autoScrollDelegate = new AutoScrollDelegate ();
			autoScrollDelegate.CurrentItemDidChanged += (object sender, EventArgs e) => {
				pageControl.CurrentPage = carousel.CurrentItemIndex;
			};
			carousel = new CarouselView (new CGRect (0, this.NavigationController.NavigationBar.Frame.Bottom, this.View.Bounds.Width, 150)) {
				DataSource = new AutoScrollDataSource (dp.GetHomeTopItems ()),
				Delegate = autoScrollDelegate
			};
			carousel.CarouselType = CarouselType.Linear;
			carousel.ConfigureView();

			View.AddSubview(carousel);

			pageControl = new UIPageControl (new CGRect (0, carousel.Frame.Height - 20, carousel.Frame.Width, 20));
			pageControl.BackgroundColor = UIColor.Black;
			pageControl.Pages = carousel.NumberOfItems;
			pageControl.CurrentPage = carousel.CurrentItemIndex;
			carousel.AddSubview (pageControl);
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

			timer = NSTimer.CreateRepeatingScheduledTimer (changedSpan, delegate {
				Console.WriteLine (carousel.CurrentItemIndex);
				if ((carousel.CurrentItemIndex + 1) < carousel.NumberOfItems)
					carousel.ScrollToItem (carousel.CurrentItemIndex + 1, true);
				else
					carousel.ScrollToItem (0, true);
			});
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			if (timer != null) {
				timer.Invalidate ();
				timer.Dispose ();
				timer = null;
			}
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
	}
}

