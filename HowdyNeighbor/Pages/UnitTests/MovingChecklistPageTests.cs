using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HowdyNeighbor.Pages.UnitTests
{
    public class MovingChecklistPageTests
    {
        [Fact]
        public void OnPost_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new MovingListModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: POST method failed in MovingChecklist.cs.");
            var result = pageModel.OnPost();
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPost_IfValidModel_ReturnPage()
        {
            var pageModel = new MovingListModel();
            var result = pageModel.OnPost();
            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnGet_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new MovingListModel();
            pageModel.ModelState.AddModelError("Error", "Bad request: GET method failed in MovingChecklist.cs.");
            var result = pageModel.OnGetAsync(1);
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnGet_IfValidModel_ReturnPage()
        {
            var pageModel = new MovingListModel();
            var result = pageModel.OnGetAsync(1);
            Assert.IsType<PageResult>(result);
        }
    }
}
