using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repositories
{
    public interface IListRepo 
    {
        public Task<List<List>> GetAsync();  
  
        public Task<List> GetByIdAsync(int Id);  
  
        public Task<List> CreateAsync(List _list);  
  
        public void UpdateAsync(int Id, List _list);  
  
        public void DeleteAsync(int Id);  
    }

    public class ListRepo : IListRepo
    {
        private readonly ToDoDbContext _toDoDbContext;

        public ListRepo(ToDoDbContext toDoDbContext)
        {
            _toDoDbContext = toDoDbContext;
        }

        public async Task<List<List>> GetAsync()
        {
            var Lists = await _toDoDbContext.List.ToListAsync();
            return Lists;
        }

        public async Task<List> GetByIdAsync(int Id)
        {
            var List = await _toDoDbContext.List.FindAsync(Id);
            return List;
        } 

        public async Task<List> CreateAsync(List _list)
        {
            throw await Task.FromResult(new NotImplementedException());
        }  
  
        public async void UpdateAsync(int Id, List _list)
        {
            throw await Task.FromResult(new NotImplementedException());
        }    
  
        public async void DeleteAsync(int Id)
        {
            throw await Task.FromResult(new NotImplementedException());
        }      
    }
}