using Microsoft.AspNetCore.Components;

namespace MisterM.Shared
{
    public partial class StatusIconComponent : ComponentBase
    {
        [Parameter] public string OnlineColor { get; set; } = "#32CD32";
        [Parameter] public string OfflineColor { get; set; } = "#FF4500";
        [Parameter] public bool IsOnline { get; set; } = false;
        [Parameter] public float Radius { get; set; } = 8;

        protected string GetStatusColor()
        {
            return IsOnline ? OnlineColor : OfflineColor;
        }
    }
}