using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HowdyNeighbor.Pages.UnitTests
{
    public class AboutPageTests
    {
        [Fact]
        public void OnGet_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new AboutModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: GET method failed in About.cshtml.cs.");
            var result = pageModel.OnGet();
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnGet_IfValidModel_ReturnPage()
        {
            var pageModel = new AboutModel();
            var result = pageModel.OnGet();
            Assert.IsType<PageResult>(result);
        }
    }
}
