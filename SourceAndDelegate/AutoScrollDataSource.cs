using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using CoreGraphics;

using Alliance.Carousel;

namespace FiveStar
{
	public class AutoScrollDataSource : CarouselViewDataSource
	{
		List<HomeTopItem> items;

		public AutoScrollDataSource(List<HomeTopItem> items)
		{
			this.items = items;
		}

		public override nint NumberOfItems(CarouselView carousel)
		{
			return (nint)this.items.Count;
		}

		public override UIView ViewForItem(CarouselView carousel, nint index, UIView reusingView)
		{
			return new UIImageView (carousel.Bounds) {
				BackgroundColor = UIColor.Black,
				Image = UIImage.FromBundle (this.items [(int)index].Uri),
				ContentMode = UIViewContentMode.ScaleToFill
			};
		}
	}
}

