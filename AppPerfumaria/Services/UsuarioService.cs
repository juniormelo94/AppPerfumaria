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
        private Users? _usuario { get; set; }
        private List<string> _permissoes { get; set; } = new();
        private List<string> _instalacoes_ids { get; set; } = new();

        /// <summary>
        /// Carrega dados do usuário + permissões
        /// </summary>
        public async Task Set(Auth auth)
        {
            var reinoCompany = new ReinoCompany();
            var response = await reinoCompany.UsuariosBuscar(auth!.token!, auth!.data!.id);

            if (response!.status)
            {
                _usuario = response.data;

                if(_usuario != null && _usuario.colaborador_user != null)
                {
                    // Setando instalações do usuário
                    _instalacoes_ids = _usuario.colaborador_user!.instalacoes_ids!;

                    // Setando permissoes do usuário
                    if (_usuario.colaborador_user.tipo_user != null && _usuario.colaborador_user.tipo_user.permissoes != null)
                    {
                        _permissoes = _usuario.colaborador_user.tipo_user.permissoes;
                    }
                }
            }
            else
            {
                throw new Exception("Tivemos um problema ao tentar setar os dados do usuário!");
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
                    if (!string.IsNullOrWhiteSpace(chave) && _permissoes.Contains(chave))
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
            if (_instalacoes_ids != null)
            {
                return _instalacoes_ids.Count();
            }

            return 0;
        }
    }
}
