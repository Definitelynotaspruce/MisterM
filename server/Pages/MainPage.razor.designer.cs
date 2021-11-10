using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using MisterM.Models.MsMisterM;
using Microsoft.EntityFrameworkCore;

namespace MisterM.Pages
{
    public partial class MainPageComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected MsMisterMService MsMisterM { get; set; }
        protected RadzenDataGrid<MisterM.Models.MsMisterM.MsMisterMComputer> datagrid0;

        IEnumerable<MisterM.Models.MsMisterM.MsMisterMComputer> _getMsMisterMComputersResult;
        protected IEnumerable<MisterM.Models.MsMisterM.MsMisterMComputer> getMsMisterMComputersResult
        {
            get
            {
                return _getMsMisterMComputersResult;
            }
            set
            {
                if (!object.Equals(_getMsMisterMComputersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getMsMisterMComputersResult", NewValue = value, OldValue = _getMsMisterMComputersResult };
                    _getMsMisterMComputersResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var msMisterMGetMsMisterMComputersResult = await MsMisterM.GetMsMisterMComputers();
            getMsMisterMComputersResult = msMisterMGetMsMisterMComputersResult;
        }
    }
}
