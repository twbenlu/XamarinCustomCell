// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomCell
{
	[Register ("CustomCellViewController")]
	partial class CustomCellViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView myTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (myTable != null) {
				myTable.Dispose ();
				myTable = null;
			}
		}
	}
}
