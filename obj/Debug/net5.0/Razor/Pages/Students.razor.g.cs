#pragma checksum "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa09fd4e04c95bdc1bc0c592743ecf1aec27b5b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3 b-hm71437luk>Students</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "studentsTable");
            __builder.AddAttribute(3, "b-hm71437luk");
            __builder.OpenElement(4, "thead");
            __builder.AddAttribute(5, "class", "studentsTableHeader");
            __builder.AddAttribute(6, "b-hm71437luk");
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "class", "columnNames");
            __builder.AddAttribute(9, "b-hm71437luk");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                            () => Sort("Avatar")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "b-hm71437luk");
            __builder.AddContent(13, "Avatar");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "th");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                            () => Sort("FirstName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-hm71437luk");
            __builder.AddContent(18, "FirstName");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "th");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                            () => Sort("LastName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-hm71437luk");
            __builder.AddContent(23, "LastName");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                            () => Sort("Birthdate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-hm71437luk");
            __builder.AddContent(28, "Birthdate");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                            () => Sort("Studies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "b-hm71437luk");
            __builder.AddContent(33, "Studies");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<th b-hm71437luk>Actions</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "tbody");
            __builder.AddAttribute(38, "class", "studentsTableContent");
            __builder.AddAttribute(39, "b-hm71437luk");
#nullable restore
#line 19 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
     foreach(var stud in StudentsList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "tr");
            __builder.AddAttribute(41, "b-hm71437luk");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "b-hm71437luk");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "src", 
#nullable restore
#line 22 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                           stud.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "alt", (
#nullable restore
#line 22 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                                               stud.FirstName

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 22 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                                                                 stud.LastName

#line default
#line hidden
#nullable disable
            ) + " Avatar");
            __builder.AddAttribute(47, "b-hm71437luk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-hm71437luk");
            __builder.AddContent(51, 
#nullable restore
#line 23 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                 stud.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-hm71437luk");
            __builder.AddContent(55, 
#nullable restore
#line 24 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                 stud.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "b-hm71437luk");
            __builder.AddContent(59, 
#nullable restore
#line 25 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                 stud.Birthdate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "b-hm71437luk");
            __builder.AddContent(63, 
#nullable restore
#line 26 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                 stud.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "td");
            __builder.AddAttribute(66, "b-hm71437luk");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "deleteButton");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                                                       (() => DeleteStudent(stud.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "b-hm71437luk");
            __builder.AddContent(71, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "detailsButton");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
                                                        (() => ShowDetails(stud.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "b-hm71437luk");
            __builder.AddContent(77, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Mateu\Desktop\blazor-22c\Pages\Students.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
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
