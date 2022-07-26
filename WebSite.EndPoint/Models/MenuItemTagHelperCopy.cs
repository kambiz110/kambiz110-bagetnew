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
    public class MenuItemTagHelperCopy : TagHelper
    {
        private readonly IGetMenuItemService getMenuItemService;
        public MenuItemTagHelperCopy(IGetMenuItemService getMenuItemService)
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
                var child = data.Where(p => p.ParentId == item.Id).ToList();
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
                    int cloumn = 0;
                    var ulSub = CreateUlSub(data, child, item, cloumn, out cloumn);
                    ulSub = CreateSubLi(data, item, ulSub);






                    liMain.InnerHtml.AppendHtml(ulSub);
                }


            
            }
            return liMain;
        }
     
        private TagBuilder CreateUlSub(List<MenuItemDto> data, List<MenuItemDto> datachild, MenuItemDto sub1, int Cloumncount, out int IndexCount)
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
            if (cloumn>0)
            {
                cloumn++;
            } var classsss = "";
            switch (cloumn)
            {
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

        private TagBuilder CreateSubLi(List<MenuItemDto> data, MenuItemDto sub1, TagBuilder ul)
        {

            var li = CreateLi();
            string link = $"/product?CatalogTypeId={sub1.Id}";
            li.InnerHtml.AppendHtml(Create_a(sub1.Name, link));
            foreach (var sub2 in data.Where(p => p.ParentId == sub1.Id).ToList())
            {
                if (data.Any(p=>p.ParentId==sub2.Id))
                {
                    li.AddCssClass("menu_item_children");


                    var ulChild = new TagBuilder("ul");
                    ulChild.AddCssClass("categorie_sub_menu");
              
                    foreach (var item in data.Where(p => p.ParentId == sub2.Id).ToList())
                    {
                        var lii = CreateLi();
                        string linkk = $"/product?CatalogTypeId={item.Id}";
                        lii.InnerHtml.AppendHtml(Create_a(item.Name, linkk));
                        ulChild.InnerHtml.AppendHtml(lii);
                    }
                    li.InnerHtml.AppendHtml(ulChild);
                }
            }
           
             ul.InnerHtml.AppendHtml(li);
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
            a.MergeAttribute("title", Text);
            a.InnerHtml.Append(Text);
            var li = new TagBuilder("li");
            if (!String.IsNullOrEmpty(classs))
            {
                a.AddCssClass($"{classs}");
            }
            if (addTag_i)
            {
                a.InnerHtml.AppendHtml(CreateLi());
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
