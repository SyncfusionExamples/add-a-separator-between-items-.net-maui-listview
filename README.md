# How to add a separator between items in .NET MAUI ListView (SfListView)?

You can add a separator between [ListViewItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewItem.html) in [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview)<font face="Segoe UI"><span>&nbsp;by utilizing a BoxView to represent the separator line.</span></font>

In the [SfListView.ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate), a [BoxView](https://docs.microsoft.com/en-us/dotnet/maui/user-interface/controls/boxview) with HeightRequest set to 1 is added to show the separator line. Bind the converter to the IsVisible property to manage the visibility of the separator line of the last item.

The following converter returns false for the last item that can be accessed from the [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems), and true for other items.

![Separator line between item in .NET MAUI SfListView](https://www.syncfusion.com/uploads/user/kb/maui/maui-2119/maui-2119_img1.png)

Download the
complete sample on [GitHub](https://github.com/SyncfusionExamples/add-a-separator-between-items-.net-maui-listview "https://github.com/SyncfusionExamples/add-a-separator-between-items-.net-maui-listview").

**Conclusion**

I hope you enjoyed learning how to add a separator between items in .NET MAUI ListView (SfListView).

You can refer to our [.NET MAUI ListView feature tour](https://www.syncfusion.com/maui-controls/maui-listview) page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data. For current customers, check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls. Please let us know in the comments section if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums/), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
