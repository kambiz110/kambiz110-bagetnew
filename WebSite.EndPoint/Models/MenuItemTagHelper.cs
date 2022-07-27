using Application.Catalogs.GetMenuItem;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Models
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("tag-name")]
    public class MenuItemTagHelper : TagHelper
    {
        private readonly IGetMenuItemService getMenuItemService;
        public MenuItemTagHelper(IGetMenuItemService getMenuItemService)
        {
            this.getMenuItemService = getMenuItemService;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.Content.AppendHtml(GetContent());
        }
        private TagBuilder GetContent()
        {
            var data = getMenuItemService.Execute();
            TagBuilder liMain = null;
          
            foreach (var item in data.Where(p => p.ParentId == null))
            {
                var child = item.SubMenu; 
                var childCount = child.Count();
                string link = $"/product?CatalogTypeId={item.Id}";
                /// فاقد فرزند
                if (childCount == 0)
                {

                    if (liMain == null)
                    {

                        liMain = CreateLiWithTag_a(item.Name, link, "", false);
                    }
                    else
                    {
                        liMain.InnerHtml.AppendHtml(CreateLiWithTag_a(item.Name, link, "", false));
                    }
                }
                //دارای فرزند
                else
                {
                    if (liMain == null)
                    {
                        liMain = CreateLiWithTag_a(item.Name, link, "menu_item_children", true);
                    }
                    else
                    {
                        liMain.InnerHtml.AppendHtml(CreateLiWithTag_a(item.Name, link, "menu_item_children", true));
                    }

                    // end level 1
                    int cloumn = 0;
                 
                    var ulSub = CreateUlSub1(data, child, item, cloumn, out cloumn);
                   
                    ulSub.InnerHtml.AppendHtml( CreateSubLi(data, child, ulSub));






                    liMain.InnerHtml.AppendHtml(ulSub);
                }


            
            }
            return liMain;
        }
     
        private TagBuilder CreateUlSub1(List<MenuItemDto> data, List<MenuItemDto> datachild, MenuItemDto sub1, int Cloumncount, out int IndexCount)
        {
            IndexCount = Cloumncount;
            var ulsub2 = new TagBuilder("ul");
            //چند تا از فرزندان فرزند دارند
            foreach (var item in datachild)
            {
                if (data.Any(p=>p.ParentId==item.Id))
                {
                    IndexCount++;
                }
            }
            var datachilCount = datachild.Count();
            if (IndexCount>4)
            {
                IndexCount = 4;
            }
            var cloumn = datachilCount- IndexCount;
            if (IndexCount==0)
            {
                cloumn = 0;
            }
            if (cloumn>0)
            {
                cloumn++;
            } var classsss = "";
            switch (cloumn)
            {
                case 0:
                    classsss = "categories_mega_menu column_1";
                    break;
                case 1:
                    classsss = "categories_mega_menu column_1";
                    break;
                case 2:
                    classsss = "categories_mega_menu column_2";
                    break;
                case 3:
                    classsss = "categories_mega_menu column_3";
                    break;
                case 4:
                    classsss = "categories_mega_menu";
                    break;
                default:
                    break;
            }
            ulsub2.AddCssClass(classsss);
            return ulsub2;
        }
        private TagBuilder CreateUlSub2( )
        {
            var ulChild = new TagBuilder("ul");
            ulChild.AddCssClass("categorie_sub_menu");

            return ulChild;
        }

        private TagBuilder CreateSubLi(List<MenuItemDto> data, List<MenuItemDto> sub1, TagBuilder ul)
        {

           
            
            foreach (var sub2 in sub1)
            {
                var li = CreateLi();
                string link = $"/product?CatalogTypeId={sub2.Id}";
                li.InnerHtml.AppendHtml(Create_a(sub2.Name, link));
                
                if (data.Any(p=>p.ParentId==sub2.Id))
                {
                    li.AddCssClass("menu_item_children");
                    var ulChild = CreateUlSub2();
                    foreach (var item in data.Where(p => p.ParentId == sub2.Id).ToList())
                    {
                        var lii = CreateLi();
                        string linkk = $"/product?CatalogTypeId={item.Id}";
                        lii.InnerHtml.AppendHtml(Create_a(item.Name, linkk));
                        ulChild.InnerHtml.AppendHtml(lii);
                    }
                    li.InnerHtml.AppendHtml(ulChild);
                }
             
                ul.InnerHtml.AppendHtml(li);
            }
           
           
            return ul;
        }

        private TagBuilder CreateSub(List<MenuItemDto> data, MenuItemDto sub1, int count, out int IndexCount)
        {
            IndexCount = count;
            var ulsub2 = new TagBuilder("ul");
            foreach (var sub2 in data.Where(p => p.ParentId == sub1.Id))
            {
                ulsub2.InnerHtml.AppendHtml(CreateLiWithTag_a(sub2.Name, $"/product?CatalogTypeId={sub2.Id}", "", false));
                IndexCount++;
            }
            return ulsub2;
        }

        private TagBuilder CreateLiWithTag_a(string Text, string Link, string classs, bool addTag_i)
        {
            var a = new TagBuilder("a");
            a.MergeAttribute("href", $"{Link}");
            //a.MergeAttribute("title", Text);
            a.InnerHtml.Append(Text);
            var li = new TagBuilder("li");
            if (!String.IsNullOrEmpty(classs))
            {
               li.AddCssClass($"{classs}");
            }
            if (addTag_i)
            {
                a.InnerHtml.AppendHtml(Create_i());
            }
            li.InnerHtml.AppendHtml(a);
            return li;
        }
        private TagBuilder CreateLi()
        {
            var li = new TagBuilder("li");
            return li;
        }
        private TagBuilder Create_a(string Text, string Link)
        {
            var a = new TagBuilder("a");
            a.MergeAttribute("href", $"{Link}");
            a.MergeAttribute("title", Text);
            a.InnerHtml.Append(Text);
            return a;
        }
        private TagBuilder Create_i()
        {
            var i = new TagBuilder("i");
            i.AddCssClass("fa fa-angle-left");
            return i;
        }

    }
}
