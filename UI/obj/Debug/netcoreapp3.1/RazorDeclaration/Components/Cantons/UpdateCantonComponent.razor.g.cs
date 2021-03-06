#pragma checksum "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\Components\Cantons\UpdateCantonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6392aaa5cb999632958beb865202f3c3be011c8c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UI.Components.Cantons
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\_Imports.razor"
using UI.Components.Cantons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\Components\Cantons\UpdateCantonComponent.razor"
using Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\Components\Cantons\UpdateCantonComponent.razor"
using Business.Cantons;

#line default
#line hidden
#nullable disable
    public partial class UpdateCantonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\rvill\source\repos\PropiedadesAndreyQuesada\UI\Components\Cantons\UpdateCantonComponent.razor"
       
    [Parameter] public string CantonId { get; set; }
    CantonVM oCanton = new CantonVM();
    public string message;

    protected override void OnInitialized()
    {
        var response = router.Get(Int32.Parse(CantonId));

        if(!response.IsSuccess)
        {
            message = response.Message;
        }
        else
        {
            oCanton = response.Data;
        }
    }

    private void Save()
    {
        try
        {
            var response = router.Update(oCanton);
            if (!response.IsSuccess)
            {
                message = response.Message;
            }
            else
            {
                NavManager.NavigateTo("Cantons/Index");
            }
        }
        catch (Exception e)
        {

            message = e.InnerException.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterCanton router { get; set; }
    }
}
#pragma warning restore 1591
