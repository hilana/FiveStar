using System;
using System.Collections.Generic;

namespace FiveStar
{
	public class DataProvider
	{
		public DataProvider ()
		{
		}

		public List<HomeTopItem> GetHomeTopItems()
		{
			return new List<HomeTopItem> () {
				new HomeTopItem (){ Uri = "1.jpg", Des = "" },
				new HomeTopItem (){ Uri = "2.jpg", Des = "" },
				new HomeTopItem (){ Uri = "3.jpg", Des = "" },
				new HomeTopItem (){ Uri = "4.jpg", Des = "" }
			};
		}

		public List<FuncItemGroup> GetFuncItemGroups()
		{
			return new List<FuncItemGroup> () {
				new FuncItemGroup () {
					Content = "",
					Des = "",
					Items = new List<FuncItem> () {
						new FuncItem (){ No = 1, Content = "我的订单", Img = "", Des = "" },
						new FuncItem (){ No = 2, Content = "我的优惠", Img = "", Des = "" }
					}
				},
				new FuncItemGroup () {
					Content = "",
					Des = "",
					Items = new List<FuncItem> () {
						new FuncItem (){ No = 1, Content = "常用地址", Img = "", Des = "" },
						new FuncItem (){ No = 2, Content = "分享朋友", Img = "", Des = "" }
					}
				},
				new FuncItemGroup () {
					Content = "",
					Des = "",
					Items = new List<FuncItem> () {
						new FuncItem (){ No = 1, Content = "意见反馈", Img = "", Des = "" },
						new FuncItem (){ No = 2, Content = "关于我们", Img = "", Des = "" }
					}
				}
			};
		}
	}
}

