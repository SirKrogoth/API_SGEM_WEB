using API.Business.Interface;
using API.Data.Converters;
using API.Data.VO;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Business.Implementation
{
    public class ItemBusinessImpl : IItemBusiness
    {
        private IItemRepository _repository;
        private readonly ItemConverter _converter;

        public ItemBusinessImpl(IItemRepository repository, ItemConverter converter)
        {
            _repository = repository;
            _converter = converter;
        }

        public ItemVO Create(ItemVO itemVO)
        {
            var itemEntity = _converter.Parce(itemVO);
            itemEntity = _repository.Create(itemEntity);

            return _converter.Parce(itemEntity);
        }
    }
}
