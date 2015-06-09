using System;

using UIKit;
using CoreGraphics;

namespace FiveStar
{
	public class UserInfoView : UIView
	{
		UIImageView UserImage;
		UIButton InfoButton;

		public UserInfo UserInfo
		{
			set{ 
				if (value == null)
					return;

				if(!string.IsNullOrEmpty(value.ImageUri))
					UserImage.Image = UIImage.FromBundle ("DefaultUserImage.png");
				else
					UserImage.Image = UIImage.FromBundle ("DefaultUserImage.png");

				if(string.IsNullOrEmpty(value.UserName))
					InfoButton.SetTitle ("点击验证身份", UIControlState.Normal);
				else
					InfoButton.SetTitle (string.Format("{0}",value.UserName), UIControlState.Normal);
			}
		}

		public UserInfoView (CGRect frame):base(frame)
		{
			UserImage = new UIImageView ();

			InfoButton = new UIButton ();
		}

		public override void Draw (CGRect rect)
		{
			base.Draw (rect);

			UserImage.Frame = new CGRect (rect.Width / 2 - 50, 50, 100, 100);
			this.AddSubview (UserImage);

			InfoButton.Frame = new CGRect (0, UserImage.Frame.Bottom + 20, rect.Width, 30);
			InfoButton.Font = UIFont.SystemFontOfSize (18);
			this.AddSubview (InfoButton);
		}
	}
}

