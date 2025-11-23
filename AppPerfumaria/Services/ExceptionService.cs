using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Exceptions
{
    public class ExceptionService
    {
        private readonly ISnackbar _snack;
        private readonly NavigationManager _nav;
        private readonly ILocalStorageService _localStorage;

        public ExceptionService
        (
            ISnackbar snack,
            NavigationManager nav,
            ILocalStorageService localStorage
        )
        {
            _snack = snack;
            _nav = nav;
            _localStorage = localStorage;
        }

        public void HandleAsync(Exception ex, string? messageDefault = null)
        {
            // Remover sessão caso se for o token de autenticação for inválida
            if (ex is UnauthorizedException)
            {
                _ = _localStorage.RemoveItemAsync("auth");
                _ = _localStorage.RemoveItemAsync("instalacao");
                _nav.NavigateTo("/", true);
                return;
            }

            if (!string.IsNullOrEmpty(messageDefault)) 
            {
                _snack.Add(messageDefault, Severity.Warning);
            }
            else
            {
                _snack.Add(ex.Message, Severity.Warning);
            }
        }
    }
}
