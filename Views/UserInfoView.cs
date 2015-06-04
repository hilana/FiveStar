using System;

using UIKit;
using CoreGraphics;

namespace FiveStar
{
	public class UserInfoView : UIView
	{
		UIImageView UserImage;
		UIButton InfoButton;

		public bool IsLogin
		{
			set{
				if (value) {
					UserImage.Image = UIImage.FromBundle ("");
					InfoButton.SetTitle ("您尚未登录", UIControlState.Normal);
				}

				UserImage.Image = UIImage.FromBundle ("");
				InfoButton.SetTitle ("您尚未登录", UIControlState.Normal);
			}
		}

		public UserInfo UserInfo
		{
			set{ 
				if(!string.IsNullOrEmpty(value.ImageUri))
					UserImage.Image = UIImage.FromBundle ("");
				else
					UserImage.Image = UIImage.FromBundle ("");

				if(string.IsNullOrEmpty(value.UserName))
					InfoButton.SetTitle ("您尚未登录", UIControlState.Normal);
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

			InfoButton.Frame = new CGRect (0,UserImage.Frame.Bottom+20,rect.Width,30);
			InfoButton.Font = UIFont.SystemFontOfSize (24);
			this.AddSubview (InfoButton);
		}
	}
}

