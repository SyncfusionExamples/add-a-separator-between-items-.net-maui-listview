**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13202/how-to-add-a-separator-between-items-in-net-maui-listview-sflistview)**

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:SeparatorVisibilityConverter x:Key="separatorVisibilityConverter"/>
    </ResourceDictionary>
</ContentPage.Resources>

<listView:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}" ItemSize="120">
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>

C#:

public class SeparatorVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var listView = parameter as SfListView;

        if (value == null)
            return false;

        return listView.DataSource.DisplayItems[listView.DataSource.DisplayItems.Count - 1] != value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```