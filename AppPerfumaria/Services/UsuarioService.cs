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

        /// <summary>
        /// Carrega dados do usuário + permissões
        /// </summary>
        public async Task Set(Auth auth)
        {
            try
            {
                var reinoCompany = new ReinoCompany();
                var response = await reinoCompany.UsuariosBuscar(auth!.token!, auth!.data!.id);

                if (response!.status)
                {
                    _usuario = response.data;

                    if(_usuario != null && _usuario.colaborador_user != null)
                    {
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
            catch (Exception e)
            {
                throw new Exception("Tivemos um problema ao tentar setar os dados do usuário!");
            }
        }

        /// <summary>
        /// Verifica se o usuário tem uma permissão
        /// </summary>
        public bool CheckPermissao(string chave)
        {
            if (string.IsNullOrWhiteSpace(chave))
            {
                return false;
            }

            return _permissoes.Contains(chave);
        }
    }
}
