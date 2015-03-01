using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomCell
{
	partial class myCell : UITableViewCell
	{
		public myCell (IntPtr handle) : base (handle){}

		public myCell(){}

		//建立三個方法，來指定值給畫面上的控制項
		public void mylabeltitle(String title)
		{
			this.myLabel.Text = title;
		}

		public void mylabeldetail(String detail)
		{
			this.myLabelDetail.Text = detail;
		}

		public void myImageview(String image)
		{
			this.myImage.Image =  UIImage.FromFile(image);
		}


	}
}
