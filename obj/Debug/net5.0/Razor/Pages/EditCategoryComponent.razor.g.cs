#pragma checksum "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2cf528cc4171a09db0239356fec75c04096886271c4c5067a172584c63f1a4ff"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editcategory/{categoryId}")]
    public partial class EditCategoryComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Category</h3>\r\n<br>");
#nullable restore
#line 11 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 13 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
                     category

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
                                              OnValidSumit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"name\">Name</label>\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", (object)("name"));
                __builder2.AddAttribute(14, "class", (object)("form-control"));
                __builder2.AddAttribute(15, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 19 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
                                              category.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Name = __value, category.Name)))));
                __builder2.AddAttribute(17, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Name)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"description\">Description</label>\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", (object)("description"));
                __builder2.AddAttribute(24, "class", (object)("form-control"));
                __builder2.AddAttribute(25, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 24 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
                                                     category.Description

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Description = __value, category.Description)))));
                __builder2.AddAttribute(27, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Description)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n        ");
                __builder2.AddMarkupContent(29, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        ");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "type", "button");
                __builder2.AddAttribute(32, "class", "btn btn-primary");
                __builder2.AddAttribute(33, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
                                                                OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(34, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\DEICIDA\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditCategoryComponent.razor"
       
    [Parameter]
    public string CategoryId { get; set; }

    private Category category;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (int.TryParse(this.CategoryId, out int iCategoryId))
        {
            var cat = GetCategoryByIdUseCase.Execute(iCategoryId);
            this.category = new Category { CategoryId = cat.CategoryId, Name = cat.Name, Description = cat.Description };
        }
    }

    private void OnValidSumit()
    {
        EditCategoryUseCase.Execute(this.category);
        NavigationManager.NavigateTo("/categories");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/categories");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditCategoryUseCase EditCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddCategoryUseCase AddCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
