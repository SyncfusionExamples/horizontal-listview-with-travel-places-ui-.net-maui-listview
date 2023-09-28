# horizontal-listview-with-travel-place-ui-.net-maui-listview

This example demonstrates the HorizontalListView with travel places UI in .NET MAUI ListView

## XAML 
 
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="40"/>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="40"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Label Grid.Row="0" Text="Tourist Destinations Near:" FontSize="16" TextColor="#E3000000" FontFamily="Roboto-Medium" CharacterSpacing="0.25" Margin="16,10,0,0"/>
    <ListView:SfListView x:Name="listView" Grid.Row="1"                                   
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
                <Grid Margin="8,0,8,0">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="130"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <Border Stroke="{Binding IsSelected, Converter={StaticResource borderStrokeConverter}}"             
                            StrokeThickness="6"    
                            HorizontalOptions="Center">
                        <Border.StrokeShape>
                            <RoundRectangle CornerRadius="6"/>
                        </Border.StrokeShape>

                        <Image Grid.Row="0" Source="{Binding Image}" HeightRequest="120" WidthRequest="110" Aspect="Fill" />
                    </Border>
                    <Label Grid.Row="1" Text="{Binding Name}"
                                        LineBreakMode="WordWrap"                                               
                                        HorizontalTextAlignment="Center"
                                        HorizontalOptions="Center"
                                        VerticalTextAlignment="Center" 
                                        FontFamily="Roboto-Regular"
                                        VerticalOptions="Center"                                                                                   
                                        HeightRequest="40"
                                        WidthRequest="110"                                  
                                        TextColor="#99000000"
                                        FontSize="14">
                    </Label>
                </Grid>
            </DataTemplate>
        </ListView:SfListView.ItemTemplate>
    </ListView:SfListView>
    <Label Grid.Row="2" Text="Other Places in this City" FontSize="16" TextColor="#E3000000" Margin="16,0,0,0" FontFamily="Roboto-Medium" VerticalOptions="Center"/>
    <ListView:SfListView x:Name="verticalListView" Grid.Row="3" 
                        ItemsSource="{Binding Path=SelectedItem.TouristPlaces, Source={x:Reference listView}}" 
                        ItemSize="60" 
                        ItemSpacing="16,8,16,8" 
                        SelectionMode="None">
        <ListView:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="76"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <Frame HorizontalOptions="Start" CornerRadius="3" IsClippedToBounds="True" Padding="0" Margin="0" HasShadow="False" HeightRequest="60" WidthRequest="60">
                        <Image Grid.Column="0" HorizontalOptions="Start" Source="{Binding Image}" Aspect="Fill" HeightRequest="60" WidthRequest="60"/>
                    </Frame>
                    <Grid Grid.Column="1" VerticalOptions="Center">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="Auto"/>
                            <RowDefinition Height="*"/>
                        </Grid.RowDefinitions>
                        <Label Grid.Row="0" Text="{Binding Name}" FontSize="14" TextColor="#666666" FontFamily="Roboto-Regular" CharacterSpacing="0.25"/>
                        <Label Grid.Row="1" Text="{Binding Description}" FontSize="14" FontFamily="Roboto-Regular" TextColor="#DE000000" LineBreakMode="WordWrap" CharacterSpacing="0.15" Margin="0,5,0,0"/>
                    </Grid>
                </Grid>
            </DataTemplate>
        </ListView:SfListView.ItemTemplate>
    </ListView:SfListView>
</Grid>

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.