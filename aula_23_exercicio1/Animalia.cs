using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio
{
    public abstract class Animalia
    {
        public abstract string obterDescricao();

        public string obterTaxonomia()
        {
            Type tipoAtual = this.GetType();
            Type? tipoBase = tipoAtual.BaseType;

            string descricao = obterDescricao();

            while (tipoBase != null && tipoBase != typeof(object))
            {
                // Inclui a descrição de cada classe na hierarquia
                descricao = $"{tipoBase.Name} -> {descricao}";
                tipoBase = tipoBase.BaseType;
            }

            return descricao;
        }
    }
}