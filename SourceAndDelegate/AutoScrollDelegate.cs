using System;

using Foundation;

using Alliance.Carousel;

namespace FiveStar
{
	public class AutoScrollDelegate : CarouselViewDelegate
	{
		NSTimer timer;
		double changedSpan=2;

		public AutoScrollDelegate()
		{
			
		}

		public override nfloat ValueForOption(CarouselView carousel, CarouselOption option, nfloat aValue)
		{
			if (option == CarouselOption.Spacing)
			{
				return aValue * 1.1f;
			}
			return aValue;
		}

		public override void DidSelectItem(CarouselView carousel, nint index)
		{
			Console.WriteLine("Selected: " + ++index);
		}

		public override void CurrentItemIndexDidChange (CarouselView carouselView)
		{
			base.CurrentItemIndexDidChange (carouselView);

			timer = NSTimer.CreateRepeatingScheduledTimer (changedSpan, delegate {
				if ((carouselView.CurrentItemIndex + 1) < carouselView.NumberOfItems)
					carouselView.ScrollToItem (carouselView.CurrentItemIndex + 1, true);
				else
					carouselView.ScrollToItem (0, true);

				if(timer!=null)
				{
					timer.Invalidate ();
					timer.Dispose ();
					timer = null;
				}
			});
		}
	}
}

