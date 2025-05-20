using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos;
using Softbreak.OnionArch.APPLICATION.Managers;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.InnerInfrastructure.ManagerConcretes
{
    public class BaseManager<D, T> : IManager<D, T> where D : class, IEntity where T : class, IDto
    {
        private readonly IRepository<D> _repository;
        private readonly IMapper _mapper;
        public BaseManager(IRepository<D> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> AnyAsync(Expression<Func<D, bool>> exp)
        {
            return await _repository.AnyAsync(exp);
        }

        public async Task<string> CreateAsync(T entity)
        {
            try
            {
                entity.CreatedDate = DateTime.Now;
                entity.Status = DOMAIN.Enums.DataStatus.Inserted;
                D domainEntity = _mapper.Map<D>(entity);
                await _repository.CreateAsync(domainEntity);
                return "Ekleme başarılıdır";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = DOMAIN.Enums.DataStatus.Deleted;
            D newValue = _mapper.Map<D>(entity);
            D originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
            return "Veri pasife çekilmiştir";
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<D, bool>> exp)
        {
            D value =  await _repository.FirstOrDefaultAsync(exp);
            return _mapper.Map<T>(value);
        }

        public async Task<List<T>> GetAllAsync()
        {
            List<D> values = await _repository.GetAllAsync();
            return _mapper.Map<List<T>>(values);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            D value = await _repository.GetByIdAsync(id);
            return _mapper.Map<T>(value);
        }

        public async Task<string> RemoveAsync(T entity)
        {
            if(entity.Status != DOMAIN.Enums.DataStatus.Deleted)
            {
                return "Silme işlemi sadece pasif veriler üzerinde uygulanabilir";
            }

            D originalValue = await _repository.GetByIdAsync(entity.Id);
            await _repository.DeleteAsync(originalValue);
            return $"Silme işlemi başarı ile gerçekleştirildi...Silinen id : {entity.Id}";
        }

        public async Task<string> UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            entity.Status = DOMAIN.Enums.DataStatus.Updated;
            D newValue = _mapper.Map<D>(entity);
            D originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
            return "Güncelleme işlemi başarıyla gerçekleştirildi";
        }

        public IQueryable<T> Where(Expression<Func<D, bool>> exp)
        {
            IQueryable<D> values = _repository.Where(exp);
            return _mapper.Map<IQueryable<T>>(values);
        }
    }
}
