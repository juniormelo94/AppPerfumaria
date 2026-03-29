using AppPerfumaria.Api.ReinoCompany;
using AppPerfumaria.Exceptions;
using AppPerfumaria.Models.Auth;
using AppPerfumaria.Models.Tables;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Services
{
    public class UsuarioService
    {
        private Users? Usuario { get; set; }
        private List<string> Permissoes { get; set; } = new();
        private List<string> InstalacoesIds { get; set; } = new();
        public string CorPrimaria { get; set; }
        public string CorSecundaria { get; set; }
        public string CorTerciaria { get; set; }

        /// <summary>
        /// Carrega dados do usuário
        /// </summary>
        public async Task Set(Auth auth)
        {
            var reinoCompany = new ReinoCompany();
            var response = await reinoCompany.UsuariosBuscar(auth!.token!, auth!.data!.id);

            if (response!.status)
            {
                Usuario = response.data;

                if(Usuario != null && Usuario.colaborador_user != null)
                {
                    // Setando instalações do usuário
                    InstalacoesIds = Usuario.colaborador_user!.instalacoes_ids!;

                    // Setando permissoes do usuário
                    if (Usuario.colaborador_user.tipo_user != null && Usuario.colaborador_user.tipo_user.permissoes != null)
                    {
                        Permissoes = Usuario.colaborador_user.tipo_user.permissoes;
                    }
                }
            }
            else
            {
                throw new Exception("Tivemos um problema ao tentar carregar os dados do usuário!");
            }
        }

        /// <summary>
        /// Carrega dados da divisão
        /// </summary>
        public async Task SetDivisao(Divisoes divisao)
        {
            if (divisao != null)
            {
                CorPrimaria = divisao.cor_primaria ?? "";
                CorSecundaria = divisao.cor_secundaria ?? "";
                CorTerciaria = divisao.cor_tercearia ?? "";
            }
            else
            {
                throw new Exception("Tivemos um problema ao tentar carregar os dados do usuário!");
            }
        }

        /// <summary>
        /// Verifica se o usuário tem as permissão ou permissões
        /// </summary>
        public bool CheckPermissoes(List<string>? chaves)
        {
            if (chaves != null && chaves.Count() > 0)
            {
                foreach (var chave in chaves)
                {
                    if (!string.IsNullOrWhiteSpace(chave) && Permissoes.Contains(chave))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Contar quantas instalações o usuário tem acesso
        /// </summary>
        public int CountInstalacoes()
        {
            if (InstalacoesIds != null)
            {
                return InstalacoesIds.Count();
            }

            return 0;
        }
    }
}
