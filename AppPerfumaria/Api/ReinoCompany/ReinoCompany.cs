using AppPerfumaria.Models.Collections;
using AppPerfumaria.Models.Forms;
using AppPerfumaria.Models.Resources;
using AppPerfumaria.Models.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Api.ReinoCompany
{
    public class ReinoCompany
    {
        const string _baseUrl = "https://api.reinocompany.com.br";

        public async Task<AuthResource?> Logar(LoginForm loginForm)
        {
            using var client = new HttpClient();

            var requestBody = new
            {
                email = loginForm.Email,
                password = loginForm.Senha
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/logar", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AuthResource>(responseString);
            //return returnObject;

            //if (response.IsSuccessStatusCode)
            //{
            //    return (true, "sucess", returnObject);
            //}

            //var messageError = response.StatusCode.ToString();
            //return (bool.Parse(returnObject.status), returnObject.message, null);
        }

        public async Task<AuthResource?> Deslogar(string token)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.PostAsync($"{_baseUrl}/api/deslogar", null);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AuthResource>(responseString);
        }

        #region Instalações
        public async Task<InstalacoesCollection?> InstalacoesListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoes{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesCollection>(responseString);
        }
        #endregion

        #region Marcas
        public async Task<MarcasCollection?> MarcasListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/marcas{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcasCollection>(responseString);
        }

        public async Task<MarcasResource?> MarcasCriar(string token, Marcas marca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(marca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/marcas", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/marcas/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasAtualizar(string token, Marcas marca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(marca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/marcas/{marca.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasDeletar(string token, Marcas marca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/marcas/{marca.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }
        #endregion

        #region Produtos
        public async Task<ProdutosCollection?> ProdutosListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/produtos{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutosCollection>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosCriar(string token, Produtos produto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(produto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/produtos", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/produtos/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosAtualizar(string token, Produtos produto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(produto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/produtos/{produto.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosDeletar(string token, Produtos produto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/produtos/{produto.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }
        #endregion

        #region Colaboradores
        public async Task<ColaboradoresCollection?> ColaboradoresListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/colaboradores{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ColaboradoresCollection>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresCriar(string token, Colaboradores colaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(colaborador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/colaboradores", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/colaboradores/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresAtualizar(string token, Colaboradores colaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(colaborador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/colaboradores/{colaborador.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresDeletar(string token, Colaboradores colaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/colaboradores/{colaborador.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }
        #endregion

        #region Clientes
        public async Task<ClientesCollection?> ClientesListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/clientes{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientesCollection>(responseString);
        }

        public async Task<ClientesResource?> ClientesCriar(string token, Clientes cliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/clientes", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/clientes/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesAtualizar(string token, Clientes cliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/clientes/{cliente.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesDeletar(string token, Clientes cliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/clientes/{cliente.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }
        #endregion

        #region Vendas
        public async Task<VendasCollection?> VendasListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/vendas{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VendasCollection>(responseString);
        }

        public async Task<VendasResource?> VendasCriar(string token, Vendas venda)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(venda);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/vendas", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasBuscar(string token, int? id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/vendas/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasAtualizar(string token, Vendas venda)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(venda);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/vendas/{venda.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasDeletar(string token, Vendas venda)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/vendas/{venda.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }
        #endregion

        #region Formas de Pagamento
        public async Task<FormasPagamentosCollection?> FormasPagamentosListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/formaspagamentos{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FormasPagamentosCollection>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosCriar(string token, FormasPagamentos formaPagamento)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(formaPagamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/formaspagamentos", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/formaspagamentos/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosAtualizar(string token, FormasPagamentos formaPagamento)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(formaPagamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/formaspagamentos/{formaPagamento.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosDeletar(string token, FormasPagamentos formaPagamento)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/formaspagamentos/{formaPagamento.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }
        #endregion

        #region Maquinas de Cartão
        public async Task<MaquinasCartaoCollection?> MaquinasCartaoListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/maquinascartao{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MaquinasCartaoCollection>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoCriar(string token, MaquinasCartao maquinaCartao)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(maquinaCartao);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/maquinascartao", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/maquinascartao/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoAtualizar(string token, MaquinasCartao maquinaCartao)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(maquinaCartao);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/maquinascartao/{maquinaCartao.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoDeletar(string token, MaquinasCartao maquinaCartao)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/maquinascartao/{maquinaCartao.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }
        #endregion

        #region Instalações Marcas
        public async Task<InstalacoesMarcasCollection?> InstalacoesMarcasListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoesmarcas{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesMarcasCollection>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasCriar(string token, InstalacoesMarcas instalacaoMarca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoMarca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/instalacoesmarcas", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasAtualizar(string token, InstalacoesMarcas instalacaoMarca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoMarca);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/instalacoesmarcas/{instalacaoMarca.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasDeletar(string token, InstalacoesMarcas instalacaoMarca)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/instalacoesmarcas/{instalacaoMarca.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }
        #endregion

        #region Instalações Produtos
        public async Task<InstalacoesProdutosCollection?> InstalacoesProdutosListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoesprodutos{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesProdutosCollection>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosCriar(string token, InstalacoesProdutos instalacaoProduto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoProduto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/instalacoesprodutos", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosBuscar(string token, int id, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoesprodutos/{id}{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosAtualizar(string token, InstalacoesProdutos instalacaoProduto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoProduto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/instalacoesprodutos/{instalacaoProduto.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosDeletar(string token, InstalacoesProdutos instalacaoProduto)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/instalacoesprodutos/{instalacaoProduto.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }
        #endregion

        #region Instalações Colaboradores
        public async Task<InstalacoesColaboradoresCollection?> InstalacoesColaboradoresListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoescolaboradores{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresCollection>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresCriar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoColaborador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/instalacoescolaboradores", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresBuscar(string token, int id, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoescolaboradores/{id}{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresAtualizar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoColaborador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/instalacoescolaboradores/{instalacaoColaborador.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresDeletar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/instalacoescolaboradores/{instalacaoColaborador.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }
        #endregion

        #region Instalações Clientes
        public async Task<InstalacoesClientesCollection?> InstalacoesClientesListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoesclientes{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesClientesCollection>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesCriar(string token, InstalacoesClientes instalacaoCliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoCliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/instalacoesclientes", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesBuscar(string token, int id, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/instalacoesclientes/{id}{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesAtualizar(string token, InstalacoesClientes instalacaoCliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(instalacaoCliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/instalacoesclientes/{instalacaoCliente.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesDeletar(string token, InstalacoesClientes instalacaoCliente)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/instalacoesclientes/{instalacaoCliente.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }
        #endregion

        #region Estoques
        public async Task<EstoquesCollection?> EstoquesListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/estoques{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EstoquesCollection>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesCriar(string token, Estoques estoque)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(estoque);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/estoques", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesAtualizar(string token, Estoques estoque)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(estoque);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/estoques/{estoque.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesDeletar(string token, Estoques estoque)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/estoques/{estoque.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }
        #endregion

        #region Combos
        public async Task<CombosCollection?> CombosListar(string token, string? filtros = null)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/combos{filtros}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CombosCollection>(responseString);
        }

        public async Task<CombosResource?> CombosCriar(string token, Combos combo)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(combo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_baseUrl}/api/combos", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosBuscar(string token, int id)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.GetAsync($"{_baseUrl}/api/combos/{id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosAtualizar(string token, Combos combo)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var json = JsonConvert.SerializeObject(combo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{_baseUrl}/api/combos/{combo.id}", content);

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosDeletar(string token, Combos combo)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var response = await client.DeleteAsync($"{_baseUrl}/api/combos/{combo.id}");

            string responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }
        #endregion
    }
}
