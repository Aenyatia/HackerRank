using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Domain.WarmUp
{
	public class SockMerchant
	{
		public static int SockMer(int[] ar)
		{
			var socks = new Dictionary<int, int>();

			foreach (var sock in ar)
			{
				if (socks.ContainsKey(sock))
					socks[sock]++;
				else
					socks.Add(sock, 1);
			}

			return socks.Sum(sockColor => sockColor.Value / 2);
		}
	}
}
