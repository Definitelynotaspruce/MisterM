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
    public partial class AssetListComponent : ComponentBase
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
        protected RadzenDataGrid<MisterM.Models.MsMisterM.Computer> datagrid0;

        IEnumerable<MisterM.Models.MsMisterM.Computer> _getComputersResult;
        protected IEnumerable<MisterM.Models.MsMisterM.Computer> getComputersResult
        {
            get
            {
                return _getComputersResult;
            }
            set
            {
                if (!object.Equals(_getComputersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getComputersResult", NewValue = value, OldValue = _getComputersResult };
                    _getComputersResult = value;
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
            var msMisterMGetComputersResult = await MsMisterM.GetComputers();
            getComputersResult = msMisterMGetComputersResult;
        }
    }
}
