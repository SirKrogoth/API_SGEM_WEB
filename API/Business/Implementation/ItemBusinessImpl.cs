using API.Business.Interface;
using API.Data.Converters;
using API.Data.VO;
using API.Model.Class;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace API.Business.Implementation
{
    public class ItemBusinessImpl : IItemBusiness
    {
        private IRepository<Item> _genericrepository;
        private readonly ItemConverter _converter;

        public ItemBusinessImpl(IRepository<Item> repository)
        {
            _genericrepository = repository;
            _converter = new ItemConverter();
        }

        public ItemVO Create(ItemVO itemVO)
        {
            var itemEntity = _converter.Parce(itemVO);
            itemEntity = _genericrepository.Create(itemEntity);

            return _converter.Parce(itemEntity);
        }

        public ItemVO Update(ItemVO itemVO)
        {
            var itemEntity = _converter.Parce(itemVO);

            itemEntity = _genericrepository.Update(itemEntity);

            return _converter.Parce(itemEntity);
        }

        public void Delete(long codigo)
        {
            _genericrepository.Delete(codigo);
        }

        public ItemVO FindById(long codigo)
        {
            return _converter.Parce(_genericrepository.FindById(codigo));
        }

        public List<ItemVO> FindAll()
        {
            return _converter.ParceList(_genericrepository.FindAll());
        }
    }
}
