
namespace TextBoxTest;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        _stackPanel.Children.Add(new TextBox());
    }
}
