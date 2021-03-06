﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatencyTray
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
			{
				if (!mutex.WaitOne(0, false))
				{
					return;
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
		}
		private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
	}
}
