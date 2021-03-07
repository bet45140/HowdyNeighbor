using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HowdyNeighbor.Pages.UnitTests
{
    public class CrimeDataPageTests
    {
        [Fact]
        public void OnPostSearchList_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new CrimeDataModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: OnPostSearchList method failed in CrimeData.cshtml.cs.");
            string testString = "test";
            var result = pageModel.OnPostSearchList(testString);
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPostSearchList_IfValidModel_ReturnPage()
        {
            var pageModel = new CrimeDataModel();
            string testString = "test";
            var result = pageModel.OnPostSearchList(testString);
            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnGet_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new CrimeDataModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: GET method failed in CrimeData.cshtml.cs.");
            var result = pageModel.OnGet();
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnGet_IfValidModel_ReturnPage()
        {
            var pageModel = new CrimeDataModel();
            var result = pageModel.OnGet();
            Assert.IsType<PageResult>(result);
        }
    }
}
