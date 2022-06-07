// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_22c.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using blazor_22c;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using blazor_22c.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mateu\Desktop\blazor-22c\_Imports.razor"
using blazor_22c.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
       
    public List<Student> StudentsList { get; set; }
    public KeyValuePair<string, bool> ColumnSort { get; set; } = new KeyValuePair<string, bool>("", false);

    private void Sort(string columnName)
    {
        if(ColumnSort.Key != columnName)
        {
            ColumnSort = new KeyValuePair<string, bool>(columnName, false);
        } else
        {
            ColumnSort = new KeyValuePair<string, bool>(columnName, !ColumnSort.Value);
        }

        if (ColumnSort.Value)
        {
            SortDesc(columnName);
        } else
        {
            SortAsc(columnName);
        }
    }

    private void SortAsc(string columnName)
    {
        StudentsList = StudentsList.OrderBy(e => e.GetType().GetProperty(columnName).GetValue(e, null)).ToList();
    }

    private void SortDesc(string columnName)
    {
        StudentsList = StudentsList.OrderByDescending(e => e.GetType().GetProperty(columnName).GetValue(e, null)).ToList();
    }

    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }

    private async Task DeleteStudent(int id)
    {
        var result = await js.InvokeAsync<bool>("confirm", "Are you sure?");
        if (result)
        {
            StudentService.Remove(id);
        }
    }

    private void ShowDetails(int id)
    {
        navigator.NavigateTo("/students/" + id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
