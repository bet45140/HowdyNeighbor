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
        private readonly Data.HowdyNeighborContext _context;

        [Fact]
        public void OnGet_IfInvalidModel_ReturnBadRequest()
        {
            var pageModel = new MovingListModel(_context);
            pageModel.ModelState.AddModelError("Error", "Bad request: GET method failed in MovingChecklist.cs.");
            var result = pageModel.OnGetAsync();
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnGet_IfValidModel_ReturnPage()
        {
            var pageModel = new MovingListModel(_context);
            var result = pageModel.OnGetAsync();
            Assert.IsType<PageResult>(result);
        }
    }
}
