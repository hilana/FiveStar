using System;
using System.Collections.Generic;

namespace FiveStar
{
	public class HomeTopItem
	{
		public string Uri { get; set; }
		public string Des { get; set; }
	}

	public class FuncItem
	{
		public nint No { get; set; }
		public string Content { get; set; }
		public string DefImg { get; set; }
		public string SelSImg { get; set; }
		public string Des { get; set; }
	}

	public class FuncItemGroup
	{
		public string Content { get; set;}
		public List<FuncItem> Items { get; set; }
		public string Des { get; set; }
	}

	public class UserInfo
	{
		public string UserName { get; set; }
		public string ImageUri { get; set; }
	}

	public class OrderItem
	{
		public string Content { get; set; }
		public OrderItemType ItemType { get; set; }
		public nfloat Price { get; set; }
		public int Num { get; set; }
	}

	public class Order
	{
		public string No { get; set; }
		public string CreateTime { get; set; }
		public List<OrderItem> Items { get; set; }
		public OrderState State { get; set; }
		public string Des { get; set; }
	}

	public enum OrderState
	{
		已完成=0,
		未完成,
		已取消,
		已冻结,
		已过期
	}

	public enum OrderItemType
	{
		上衣=0,
		裤子,
		鞋,
		帽子
	}

	public class AddressInfo
	{
		public string Content { get; set; }
		public string Des { get; set; }
	}
}

