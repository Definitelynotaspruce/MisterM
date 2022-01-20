using Microsoft.AspNetCore.Components;

namespace MisterM.Shared
{
    public partial class ArcGaugeComponent : ComponentBase
    {
        [Parameter] public float MaxValue { get; set; } 
        
        [Parameter] public float CurrentValue { get; set; }
    }
}