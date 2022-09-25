using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
	[Serializable]
	public class AccIdData
	{
		private int nextId;
		private static AccIdData data;

		public static int NextId
		{
			get
			{
				data.nextId++;
				return data.nextId;
			}
		}

		public static AccIdData GetInstance()
		{
			if (data == null)
			{
				data = new AccIdData();
			}

			return data;
		}

		public static void SetInstance(AccIdData s)
		{
			data = s;
		}

		private AccIdData() { }
	}
}