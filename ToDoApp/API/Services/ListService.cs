using API.Data.Repositories;
using API.Data.Dtos;
using AutoMapper;

namespace API.Services
{
    public interface IListService
    {
        public Task<List<ListDto>> GetAsync();
    }

    public class ListService : IListService
    {
        private readonly IListRepo _listRepo;
        private readonly IMapper _mapper;
    
        public ListService(IListRepo listRepo, IMapper mapper)
        {
            _listRepo = listRepo;
            _mapper = mapper;
        }    

        public async Task<List<ListDto>> GetAsync()
        {
            var lists = await _listRepo.GetAsync();
            var listDtos = (from list in lists
                               select _mapper.Map<ListDto>(list)).ToList();
            return listDtos;
        }
    }
}