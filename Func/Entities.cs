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
		public string Img { get; set; }
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
}

