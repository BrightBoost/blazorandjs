using Microsoft.JSInterop;

namespace DemoJSandBlazor.Services
{
    public class InteropExample
    {
        private readonly IJSRuntime _jsRuntime;

        public InteropExample(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async ValueTask<string> ShowPrompt(string message)
        {
            return await _jsRuntime.InvokeAsync<string>("exampleJSfuntions.showPrompt", message);
        }

        public async ValueTask ShowAlert(string message)
        {
            await _jsRuntime.InvokeVoidAsync("exampleJSfuntions.showAlert", message);
        }
    }
}
