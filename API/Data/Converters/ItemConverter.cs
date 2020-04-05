using API.Data.Converter;
using API.Data.VO;
using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace API.Data.Converters
{
    public class ItemConverter : IParce<ItemVO, Item>, IParce<Item, ItemVO>
    {
        public Item Parce(ItemVO origin)
        {
            if (origin == null) return new Item();

            return new Item
            {
                Codigo = origin.Codigo,
                Descricao = origin.Descricao,
                Preco = origin.Preco,
                Cadastro = origin.Cadastro,
                Estoque = origin.Estoque,
                Ativo = origin.Ativo
            };
        }

        public ItemVO Parce(Item origin)
        {
            if (origin == null) return new ItemVO();

            return new ItemVO
            {
                Codigo = origin.Codigo,
                Descricao = origin.Descricao,
                Preco = origin.Preco,
                Cadastro = origin.Cadastro,
                Estoque = origin.Estoque,
                Ativo = origin.Ativo
            };
        }

        public List<Item> ParceList(List<ItemVO> origin)
        {
            if (origin == null) return new List<Item>();

            return origin.Select(item => Parce(item)).ToList();
        }

        public List<ItemVO> ParceList(List<Item> origin)
        {
            if (origin == null) return new List<ItemVO>();

            return origin.Select(item => Parce(item)).ToList();
        }
    }
}
