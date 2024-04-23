 xmlns:popup="clr-namespace:Syncfusion.Blazor.Popups;assembly=Syncfusion.Blazor.Popups"<popup:SfPopup x:Name="privacyPopup" IsOpen="False">
    <popup:SfPopup.ContentTemplate>
        <DataTemplate>
            <StackLayout Padding="20">
                <Label Text="Data Privacy Act Agreement" FontSize="20" HorizontalOptions="Center" />
                <Label Text="By proceeding, you agree to our Data Privacy Act." HorizontalOptions="Center" />
                <Button Text="Agree" Clicked="OnAgreeClicked" HorizontalOptions="Center" />
                <Button Text="Disagree" Clicked="OnDisagreeClicked" HorizontalOptions="Center" />
            </StackLayout>
        </DataTemplate>
    </popup:SfPopup.ContentTemplate>
</popup:SfPopup>

    @code {
    private void OnAgreeClicked(object sender, EventArgs e)
    {
        privacyPopup.IsOpen = false;
        // Proceed with the form or any other action
    }

    private void OnDisagreeClicked(object sender, EventArgs e)
    {
        privacyPopup.IsOpen = false;
        // Optionally, handle the case where the user disagrees
    }

    protected override void OnAppearing()
{
    base.OnAppearing();
    privacyPopup.IsOpen = true;
}

}
