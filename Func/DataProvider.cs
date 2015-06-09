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
						new FuncItem (){ No = 3, Content = "常用地址", Img = "", Des = "" },
						new FuncItem (){ No = 4, Content = "分享朋友", Img = "", Des = "" }
					}
				},
				new FuncItemGroup () {
					Content = "",
					Des = "",
					Items = new List<FuncItem> () {
						new FuncItem (){ No = 5, Content = "意见反馈", Img = "", Des = "" },
						new FuncItem (){ No = 6, Content = "关于我们", Img = "", Des = "" }
					}
				}
			};
		}

		public List<Order> GetOrders()
		{
			return new List<Order> () { 
				new Order () {
					No = Guid.NewGuid ().ToString (),
					CreateTime = DateTime.Now.ToString ("yyyy-MM-dd HH:mm"),
					State = OrderState.未完成,
					Des = "",
					Items = new List<OrderItem> () {
						new OrderItem (){ Content = "aaaa", ItemType = OrderItemType.上衣, Price = 20, Num = 1 },
						new OrderItem (){ Content = "bbbb", ItemType = OrderItemType.裤子, Price = 30, Num = 2 },
						new OrderItem (){ Content = "cccc", ItemType = OrderItemType.裤子, Price = 50, Num = 1 },
						new OrderItem (){ Content = "dddd", ItemType = OrderItemType.鞋, Price = 100, Num = 1 }
					}
				},
				new Order () {
					No = Guid.NewGuid ().ToString (),
					CreateTime = DateTime.Now.ToString ("yyyy-MM-dd HH:mm"),
					State = OrderState.未完成,
					Des = "",
					Items = new List<OrderItem> () {
						new OrderItem (){ Content = "eeee", ItemType = OrderItemType.上衣, Price = 20, Num = 1 },
						new OrderItem (){ Content = "ffff", ItemType = OrderItemType.裤子, Price = 30, Num = 2 },
						new OrderItem (){ Content = "gggg", ItemType = OrderItemType.裤子, Price = 50, Num = 1 },
						new OrderItem (){ Content = "hhhh", ItemType = OrderItemType.鞋, Price = 100, Num = 1 }
					}
				},
				new Order () {
					No = Guid.NewGuid ().ToString (),
					CreateTime = DateTime.Now.ToString ("yyyy-MM-dd HH:mm"),
					State = OrderState.已完成,
					Des = "",
					Items = new List<OrderItem> () {
						new OrderItem (){ Content = "iiii", ItemType = OrderItemType.上衣, Price = 20, Num = 1 },
						new OrderItem (){ Content = "jjjj", ItemType = OrderItemType.裤子, Price = 30, Num = 2 },
						new OrderItem (){ Content = "kkkk", ItemType = OrderItemType.裤子, Price = 50, Num = 1 },
						new OrderItem (){ Content = "llll", ItemType = OrderItemType.鞋, Price = 100, Num = 1 }
					}
				}
			};
		}

		public List<AddressInfo> GetAddressInfos()
		{
			return new List<AddressInfo> () {
				new AddressInfo (){ Content = "aaaaaaaaaaaaaaaa", Des = "" },
				new AddressInfo (){ Content = "bbbbbbbbbbbbbbbb", Des = "" },
				new AddressInfo (){ Content = "cccccccccccccccc", Des = "" },
				new AddressInfo (){ Content = "dddddddddddddddd", Des = "" }
			};
		}
	}
}

