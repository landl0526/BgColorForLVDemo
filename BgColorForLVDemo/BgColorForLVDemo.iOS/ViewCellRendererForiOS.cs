using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BgColorForLVDemo;
using BgColorForLVDemo.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyViewCell), typeof(ViewCellRendererForiOS))]
namespace BgColorForLVDemo.iOS
{
    public class ViewCellRendererForiOS : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            cell.SelectedBackgroundView = new UIView { BackgroundColor = UIColor.Red };

            return cell;
        }
    }
}