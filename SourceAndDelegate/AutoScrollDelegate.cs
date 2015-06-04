using System;

using Foundation;

using Alliance.Carousel;

namespace FiveStar
{
	public class AutoScrollDelegate : CarouselViewDelegate
	{
		public event EventHandler CurrentItemDidChanged;

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

			if (CurrentItemDidChanged != null)
				CurrentItemDidChanged (carouselView, EventArgs.Empty);
		}
	}
}

