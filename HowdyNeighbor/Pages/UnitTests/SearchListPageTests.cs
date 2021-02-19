using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HowdyNeighbor.Pages.UnitTests
{
    public class SearchListPageTests
    {
        [Fact]
        public void OnPostSaveChecklistAsync_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new SearchListModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: OnPostSaveChecklistAsync method failed in SearchList.cshtml.cs.");
            string testString = "test";
            var result = pageModel.OnPostSaveChecklistAsync(testString);
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPostSaveChecklistAsync_IfValidModel_ReturnPage()
        {
            var pageModel = new SearchListModel();
            string testString = "test";
            var result = pageModel.OnPostSaveChecklistAsync(testString);
            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnPostTrafficDensity_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new SearchListModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: OnPostSearchList method failed in SearchList.cshtml.cs.");
            string testString = "test";
            var result = pageModel.OnPostTrafficDensity(testString);
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPostTrafficDensity_IfValidModel_ReturnPage()
        {
            var pageModel = new SearchListModel();
            string testString = "test";
            var result = pageModel.OnPostTrafficDensity(testString);
            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnGet_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new SearchListModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: GET method failed in SearchList.cshtml.cs.");
            var result = pageModel.OnGet();
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnGet_IfValidModel_ReturnPage()
        {
            var pageModel = new SearchListModel();
            var result = pageModel.OnGet();
            Assert.IsType<PageResult>(result);
        }
    }
}
