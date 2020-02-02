using SGEM_WEB_SITE.Areas.Item.Data.Converter;
using SGEM_WEB_SITE.Areas.Item.Data.VO;
using SGEM_WEB_SITE.Models.Class;
using System.Collections.Generic;
using System.Linq;

namespace SGEM_WEB_SITE.Areas.Item.Data.Converters
{
    public class ItemConverter : IParce<ItemVO, ItemObj>, IParce<ItemObj, ItemVO>
    {
        public ItemObj Parce(ItemVO origin)
        {
            if (origin == null) return new ItemObj();

            return new ItemObj
            {
                Codigo = origin.Codigo,
                Descricao = origin.Descricao,
                Preco = origin.Preco,
                Cadastro = origin.Cadastro,
                Estoque = origin.Estoque,
                Ativo = origin.Ativo
            };
        }

        public ItemVO Parce(ItemObj origin)
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

        public List<ItemObj> ParceList(List<ItemVO> origin)
        {
            if (origin == null) return new List<ItemObj>();

            return origin.Select(item => Parce(item)).ToList();
        }

        public List<ItemVO> ParceList(List<ItemObj> origin)
        {
            if (origin == null) return new List<ItemVO>();

            return origin.Select(item => Parce(item)).ToList();
        }
    }
}
