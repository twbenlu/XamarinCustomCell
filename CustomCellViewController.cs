using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace CustomCell
{

	public class User{
		public string title;
		public string detail;
		public string image;
	}


	public partial class CustomCellViewController : UIViewController
	{
		public CustomCellViewController (IntPtr handle) : base (handle){}

		List<User> tableItems;

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//建立一個資料集合，資料型別為User
			tableItems = new List<User>{
				new User{title = "title1",detail="detail1",image="a.jpg"},
				new User{title = "title2",detail="detail2",image="a.jpg"},
				new User{title = "title3",detail="detail3",image="a.jpg"},
				new User{title = "title4",detail="detail4",image="a.jpg"},
				new User{title = "title5",detail="detail5",image="a.jpg"},
			};
			//將資料指定給UItable
			this.myTable.Source = new TableSource(tableItems);
		}



		public class TableSource : UITableViewSource {
			//這個UITableView接收的資料型別
			List<User> tableItems;
			string cellIdentifier = "Cell";

			//在建構子的部分傳入資料型別
			public TableSource (List<User> items)
			{
				tableItems = items;
			}

			//告知這個UITableView一共有多少資料
			public override int RowsInSection (UITableView tableview, int section)
			{
				return tableItems.Count;
			}

			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				//return [MyCell cellHeightForContent:yourContent];
//				Console.WriteLine ("Row = " + tableView.CellAt (indexPath).Frame.ToString ());
				return 150.0f;
				// NOTE: Don't call the base implementation on a Model class
				// see http://docs.xamarin.com/guides/ios/application_fundamentals/delegates,_protocols,_and_events
//				throw new NotImplementedException ();
			}
				
			public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
			{
				//建立一個Cell，這邊使用我們自建的myCell類別
				myCell cell = (myCell)tableView.DequeueReusableCell (cellIdentifier);
				// if there are no cells to reuse, create a new one
				if (cell == null)
					cell = new myCell ();

				//呼叫Cell方法，將值帶入
				cell.mylabeltitle(tableItems[indexPath.Row].title);
				cell.mylabeldetail(tableItems [indexPath.Row].detail);
				cell.myImageview(tableItems [indexPath.Row].image);
				return cell;
			}
		}



		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

