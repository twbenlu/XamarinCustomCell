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
	[Register ("myCell")]
	partial class myCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView myImage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel myLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel myLabelDetail { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (myImage != null) {
				myImage.Dispose ();
				myImage = null;
			}
			if (myLabel != null) {
				myLabel.Dispose ();
				myLabel = null;
			}
			if (myLabelDetail != null) {
				myLabelDetail.Dispose ();
				myLabelDetail = null;
			}
		}
	}
}
