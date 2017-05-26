﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 1 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Item.cshtml")]
    public partial class _Views_Shared__List_Data_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_List_Data_Item.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Shared\_List_Data_Item.cshtml"
 if (item.PrimaryKey)
{

            
            #line default
            #line hidden
WriteLiteral("    <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                     Write(entity[item.Name]);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 11 "..\..\Views\Shared\_List_Data_Item.cshtml"
}
else
{
    switch (Type.GetTypeCode(item.Type))
    {
        case TypeCode.Boolean:
            if ((Boolean)entity[item.Name])
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 22 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 28 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.DateTime:
            var dt = (DateTime)entity[item.Name];
            if (dt > DateTime.MinValue && dt.Year > 1900)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td>");

            
            #line 34 "..\..\Views\Shared\_List_Data_Item.cshtml"
                Write(((DateTime)entity[item.Name]).ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td></td>\r\n");

            
            #line 39 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.Decimal:

            
            #line default
            #line hidden
WriteLiteral("            <td>");

            
            #line 42 "..\..\Views\Shared\_List_Data_Item.cshtml"
           Write(entity[item.Name]);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 43 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Single:
        case TypeCode.Double:

            
            #line default
            #line hidden
WriteLiteral("            <td>");

            
            #line 46 "..\..\Views\Shared\_List_Data_Item.cshtml"
           Write(entity[item.Name]);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 47 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Byte:
        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
        case TypeCode.UInt16:
        case TypeCode.UInt32:
        case TypeCode.UInt64:
            //特殊处理枚举
            if (item.Type.IsEnum)
            {
                var v = entity[item.Name];
                var val = v + "";
                try
                {
                    val = System.EnumHelper.GetDescription((Enum)v) ?? v + "";
                }
                catch { }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(val);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 66 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                  Write(Convert.ToInt64(entity[item.Name]).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 70 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.String:
        default:
            {
                var val = entity[item.Name];
                var map = item.Map;
                if (map != null && map.Provider != null && val + "" != "")
                {
                    var dic = new RouteValueDictionary();
                    var key = map.Provider.Key;
                    if (!key.IsNullOrEmpty() && item.OriField != null) { dic[key] = entity[item.OriField.Name]; }

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 82 "..\..\Views\Shared\_List_Data_Item.cshtml"
                   Write(Html.ActionLink(entity[item.Name] + "", "Edit", map.Provider.EntityType.Name, dic, null));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 83 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 86 "..\..\Views\Shared\_List_Data_Item.cshtml"
                   Write(entity[item.Name]);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 87 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
            }
            break;
            
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Shared\_List_Data_Item.cshtml"
                        
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
