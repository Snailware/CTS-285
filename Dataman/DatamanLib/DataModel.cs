using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLib
{
	/// <summary>
	/// data model for dataman.
	/// </summary>
	public static class DataModel
	{
		/// <summary>
		/// bool to control power state of device. 
		/// </summary>
		public static bool PoweredOn { get; set; } = false;

		/// <summary>
		/// string to hold user input.
		/// </summary>
		public static string Input { get; set; } = "";

		/// <summary>
		/// current score of user.
		/// </summary>
		public static int Score { get; set; } = 0;

		/// <summary>
		/// mode that dataman is in.
		/// </summary>
		public static Mode CurrentMode { get; set; }
	}
}
