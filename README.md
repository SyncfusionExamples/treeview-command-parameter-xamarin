# How to bind node data as CommandParameter for TreeView ItemTemplate content in Xamarin.Forms (SfTreeView)

You can bind the node item to [CommandParameter](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.button.commandparameter?view=xamarin-forms#Xamarin_Forms_Button_CommandParameter) in Xamarin.Forms [SfTreeview](https://help.syncfusion.com/xamarin/treeview/overview?) by binding with dot.

You can also refer the following article.

https://www.syncfusion.com/kb/11406/how-to-bind-node-data-as-commandparameter-for-treeview-itemtemplate-content-in-xamarin

**C#**

**ItemInfoCommand** defined to get the node data in the **ViewModel**.
``` c#
public class FileManagerViewModel
{
    public Command<object> NodeCommand { get; set; }
    public FileManagerViewModel()
    { 
        NodeCommand = new Command<object>(OnNodeExecuted);
    }
    public void OnNodeExecuted(object data)
    {
        App.Current.MainPage.DisplayAlert("Alert", (data as FileManager).ItemName.ToString() , "OK");
    }
}
```
**XAML**

Binding (.) dot to **CommandParameter** of ViewModel command and will get the node data in the handler.
``` xml
<Grid Grid.Column=”1”
        RowSpacing="1"
        Padding="1,0,0,0"
        VerticalOptions="Center">
    <Label LineBreakMode="NoWrap" TextColor="Black"
            Text="{Binding ItemName}"
            VerticalTextAlignment="Center">
    </Label>
    <Button Grid.Column="1" HorizontalOptions="End" Text="Node Data" CommandParameter="{Binding . }" 
    Command="{Binding Path=BindingContext.NodeCommand, Source={x:Reference treeView}}"/>
</Grid>
```
