using API.Data.Converter;
using API.Data.VO;
using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Converters
{
    public class ItemConverter : IParce<ItemVO, Item>, IParce<Item, ItemVO>
    {
        public Item Parce(ItemVO origin)
        {
            if (origin == null) return new Item();

            return new Item
            {
                Codigo = Convert.ToInt64(origin.Codigo),
                Descricao = origin.Descricao,
                Preco = Convert.ToDouble(origin.Preco),
                Cadastro = Convert.ToDateTime(origin.Cadastro),
                Estoque = Convert.ToDouble(origin.Estoque),
                Ativo = Convert.ToBoolean(origin.Ativo)
            };
        }

        public ItemVO Parce(Item origin)
        {
            if (origin == null) return new ItemVO();

            return new ItemVO
            {
                Codigo = Convert.ToInt64(origin.Codigo),
                Descricao = origin.Descricao,
                Preco = Convert.ToDouble(origin.Preco),
                Cadastro = Convert.ToDateTime(origin.Cadastro),
                Estoque = Convert.ToDouble(origin.Estoque),
                Ativo = Convert.ToBoolean(origin.Ativo)
            };
        }

        public List<Item> ParceList(List<ItemVO> origin)
        {
            throw new NotImplementedException();
        }

        public List<ItemVO> ParceList(List<Item> origin)
        {
            throw new NotImplementedException();
        }
    }
}
