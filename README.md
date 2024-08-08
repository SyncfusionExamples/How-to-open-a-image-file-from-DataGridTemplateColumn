# How do you open a image file from DataGridTemplateColumn in .NET MAUI DataGrid?  
In this article, we will show you how to open a image file from DataGridTemplateColumn in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<syncfusion:SfDataGrid x:Name="sfGrid"
                       SelectionMode="Single"
                       NavigationMode="Cell"
                       GridLinesVisibility="Both"
                       ColumnWidthMode="Auto"
                       HeaderGridLinesVisibility="Both"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding Employees}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="EmployeeID"
                                       HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Employee Name" />
        <syncfusion:DataGridTextColumn MappingName="Designation"
                                       HeaderText="Designation" />
        <syncfusion:DataGridTemplateColumn HeaderText="Image">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <ImageButton Source="dot_icon.png"
                                 Clicked="ImageButton_Clicked" />
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
```

## C#
The below code illustrates how to open a image file from DataGridTemplateColumn in DataGrid.
```
private void ImageButton_Clicked(object sender, EventArgs e)
{
    var imageButton = sender as ImageButton;
    var rowData = (imageButton.BindingContext as Employee);

    if (rowData != null)
    {
        // Assuming you have a method to show the image
        ShowPartImage(rowData.URL);
    }
}

private async Task ShowPartImage(string imageUrl)
{
    // Implement your logic to display the image
    // For example, you can open a new page or a popup with the image
    await Navigation.PushAsync(new PartImage(imageUrl));
}
```
 ![OpenImg.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI3OTg3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.EesChAO08inaEV5h7V57fgpJFlXIO9hZuC07jX0KIzQ)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-open-a-image-file-from-DataGridTemplateColumn)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to open a image file from DataGridTemplateColumn in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!