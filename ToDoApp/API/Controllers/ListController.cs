using API.Data.Dtos;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ListController : BaseController
    {
        private readonly IListService _listService;
        public ListController(IListService listService)
        {
            _listService = listService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListDto>>> GetAsync()
        {
            var listDtos = await _listService.GetAsync();
            if (listDtos == null)
                return NotFound();
            return listDtos;
        }
    }
}