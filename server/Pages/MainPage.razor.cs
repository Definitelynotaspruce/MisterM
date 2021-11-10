using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components.Web;

namespace MisterM.Pages
{
    public partial class MainPageComponent
    {
        protected void CustomComponentClick(MouseEventArgs args)
        {
            Console.WriteLine("Custom component clicked!");
        }
    }
}
