using Microsoft.AspNetCore.Components.Web;

namespace SistemaVeterinario.Components.Services
{
    public class KeyboardService
    {
        public event Action<KeyboardEventArgs>? KeyDown;

        public void TriggerKeyDown(KeyboardEventArgs args)
        {
            KeyDown?.Invoke(args);
        }
    }
}
