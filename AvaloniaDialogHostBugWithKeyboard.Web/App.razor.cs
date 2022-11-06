using Avalonia.Web.Blazor;

namespace AvaloniaDialogHostBugWithKeyboard.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaDialogHostBugWithKeyboard.App>()
            .SetupWithSingleViewLifetime();
    }
}