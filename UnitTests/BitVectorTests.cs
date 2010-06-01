﻿using System;
using Lidgren.Network;

namespace UnitTests
{
	public static class BitVectorTests
	{
		public static void Run()
		{
			NetBitVector v = new NetBitVector(256);
			for (int i = 0; i < 256; i++)
			{
				v.Clear();
				if (i > 42 && i < 65)
					v = new NetBitVector(256);

				if (!v.IsEmpty())
					throw new NetException("bit vector fail 1");

				v.Set(i, true);

				if (v.Get(i) == false)
					throw new NetException("bit vector fail 2");

				if (v.IsEmpty())
					throw new NetException("bit vector fail 3");

				if (i != 79 && v.Get(79) == true)
					throw new NetException("bit vector fail 4");

				int f = v.GetFirstSetIndex();
				if (f != i)
					throw new NetException("bit vector fail 4");
			}
			
			Console.WriteLine("NetBitVector tests OK");
		}
	}
}
