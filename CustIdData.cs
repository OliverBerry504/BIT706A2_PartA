using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
	[Serializable]
	public class CustIdData
	{
		private int nextId;
		private static CustIdData data;

		public static int NextId
		{
			get
			{	
				data.nextId++;
				return data.nextId;
			}
		}

		public static CustIdData GetInstance()
		{
			if (data == null)
			{
				data = new CustIdData();
			}
			return data;
		}

		public static void SetInstance(CustIdData s)
		{
			data = s;
		}

		private CustIdData() { }
	}
}
