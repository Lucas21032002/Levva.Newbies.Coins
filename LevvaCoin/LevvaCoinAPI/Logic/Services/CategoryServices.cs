using AutoMapper;
using LevvaCoinAPI.Interfaces;
using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using LevvaCoinAPI.Domain.Models;

namespace LevvaCoinAPI.Logic.Services
{
    public class CategoryServices : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryServices(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CategoryDto Create(createCategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            var categoryCreated = _repository.Create(_category);
            return _mapper.Map<CategoryDto>(categoryCreated);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public CategoryDto Get(int id)
        {
            var user = _mapper.Map<CategoryDto>(_repository.Get(id));
            return user;
        }

        public List<CategoryDto> GetAll()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_repository.GetAll());
            return categories;
        }

        public void Update(CategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            _repository.Update(_category);

        }
    }
}
