# horizontal-listview-with-travel-place-ui-.net-maui-listview
HorizontalListView with travel places UI in .NET MAUI ListView

## Sample

```xaml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
<ListView:SfListView x:Name="listView" Grid.Row="0"                                   
                        ItemsSource="{Binding Places}"                                
                        ScrollBarVisibility="Never"
                        SelectionMode="Single"                             
                        Orientation="Horizontal" 
                        SelectionBackground="Transparent"
                        ItemSize="{OnPlatform Android=120,Default=130}" 
                        Margin="8,0,0,0"
                        HeightRequest="180"
                        SelectedItem="{Binding SelectedItem}">
    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>

<ListView:SfListView x:Name="verticalListView" Grid.Row="1" 
                        ItemsSource="{Binding Path=SelectedItem.TouristPlaces, Source={x:Reference listView}}" 
                        ItemSize="60" 
                        ItemSpacing="16,8,16,8" 
                        SelectionMode="None">
    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>
</Grid>
```
