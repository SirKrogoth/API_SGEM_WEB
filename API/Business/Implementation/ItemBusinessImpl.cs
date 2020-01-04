using API.Business.Interface;
using API.Data.Converters;
using API.Data.VO;
using API.Model.Class;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Business.Implementation
{
    public class ItemBusinessImpl : IItemBusiness
    {
        private IRepository<Item> _repository;
        private readonly ItemConverter _converter;

        public ItemBusinessImpl(IRepository<Item> repository)
        {
            _repository = repository;
            _converter = new ItemConverter();
        }

        public ItemVO Create(ItemVO itemVO)
        {
            var itemEntity = _converter.Parce(itemVO);
            itemEntity = _repository.Create(itemEntity);

            return _converter.Parce(itemEntity);
        }

        public List<ItemVO> FindAll()
        {
            return _converter.ParceList(_repository.FindAll());
        }
    }
}
