using AppPerfumaria.Api.Requests;
using AppPerfumaria.Models.Collections;
using AppPerfumaria.Models.Forms;
using AppPerfumaria.Models.Resources;
using AppPerfumaria.Models.Tables;
using MudBlazor;
using MudBlazor.Charts;
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
            var requestBody = new
            {
                email = loginForm.Email,
                password = loginForm.Senha
            };

            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/logar", data: requestBody);
            return JsonConvert.DeserializeObject<AuthResource>(responseString);
        }

        public async Task<AuthResource?> Deslogar(string token)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/deslogar", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<AuthResource>(responseString);
        }

        #region Instalações
        public async Task<InstalacoesCollection?> InstalacoesListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoes{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesCollection>(responseString);
        }
        #endregion

        #region Marcas
        public async Task<MarcasCollection?> MarcasListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/marcas{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MarcasCollection>(responseString);
        }

        public async Task<MarcasResource?> MarcasCriar(string token, Marcas marca)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/marcas", authorization: $"Bearer {token}", data: marca);
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/marcas/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasAtualizar(string token, Marcas marca)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/marcas/{marca.id}", authorization: $"Bearer {token}", data: marca);
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }

        public async Task<MarcasResource?> MarcasDeletar(string token, Marcas marca)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/marcas/{marca.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MarcasResource>(responseString);
        }
        #endregion

        #region Produtos
        public async Task<ProdutosCollection?> ProdutosListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtos{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosCollection>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosCriar(string token, Produtos produto)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/produtos", authorization: $"Bearer {token}", data: produto);
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtos/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosAtualizar(string token, Produtos produto)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/produtos/{produto.id}", authorization: $"Bearer {token}", data: produto);
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }

        public async Task<ProdutosResource?> ProdutosDeletar(string token, Produtos produto)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/produtos/{produto.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosResource>(responseString);
        }
        #endregion

        #region Colaboradores
        public async Task<ColaboradoresCollection?> ColaboradoresListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/colaboradores{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ColaboradoresCollection>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresCriar(string token, Colaboradores colaborador)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/colaboradores", authorization: $"Bearer {token}", data: colaborador);
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/colaboradores/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresAtualizar(string token, Colaboradores colaborador)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/colaboradores/{colaborador.id}", authorization: $"Bearer {token}", data: colaborador);
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }

        public async Task<ColaboradoresResource?> ColaboradoresDeletar(string token, Colaboradores colaborador)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/colaboradores/{colaborador.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ColaboradoresResource>(responseString);
        }
        #endregion

        #region Clientes
        public async Task<ClientesCollection?> ClientesListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/clientes{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ClientesCollection>(responseString);
        }

        public async Task<ClientesResource?> ClientesCriar(string token, Clientes cliente)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/clientes", authorization: $"Bearer {token}", data: cliente);
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/clientes/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesAtualizar(string token, Clientes cliente)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/clientes/{cliente.id}", authorization: $"Bearer {token}", data: cliente);
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }

        public async Task<ClientesResource?> ClientesDeletar(string token, Clientes cliente)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/clientes/{cliente.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ClientesResource>(responseString);
        }
        #endregion

        #region Vendas
        public async Task<VendasCollection?> VendasListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/vendas{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<VendasCollection>(responseString);
        }

        public async Task<VendasResource?> VendasCriar(string token, Vendas venda)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/vendas", authorization: $"Bearer {token}", data: venda);
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasBuscar(string token, int? id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/vendas/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasAtualizar(string token, Vendas venda)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/vendas/{venda.id}", authorization: $"Bearer {token}", data: venda);
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }

        public async Task<VendasResource?> VendasDeletar(string token, Vendas venda)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/vendas/{venda.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<VendasResource>(responseString);
        }
        #endregion

        #region Formas de Pagamento
        public async Task<FormasPagamentosCollection?> FormasPagamentosListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/formaspagamentos{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<FormasPagamentosCollection>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosCriar(string token, FormasPagamentos formaPagamento)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/formaspagamentos", authorization: $"Bearer {token}", data: formaPagamento);
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/formaspagamentos/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosAtualizar(string token, FormasPagamentos formaPagamento)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/formaspagamentos/{formaPagamento.id}", authorization: $"Bearer {token}", data: formaPagamento);
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }

        public async Task<FormasPagamentosResource?> FormasPagamentosDeletar(string token, FormasPagamentos formaPagamento)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/formaspagamentos/{formaPagamento.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<FormasPagamentosResource>(responseString);
        }
        #endregion

        #region Maquinas de Cartão
        public async Task<MaquinasCartaoCollection?> MaquinasCartaoListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/maquinascartao{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MaquinasCartaoCollection>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoCriar(string token, MaquinasCartao maquinaCartao)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/maquinascartao", authorization: $"Bearer {token}", data: maquinaCartao);
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/maquinascartao/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoAtualizar(string token, MaquinasCartao maquinaCartao)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/maquinascartao/{maquinaCartao.id}", authorization: $"Bearer {token}", data: maquinaCartao);
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }

        public async Task<MaquinasCartaoResource?> MaquinasCartaoDeletar(string token, MaquinasCartao maquinaCartao)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/maquinascartao/{maquinaCartao.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<MaquinasCartaoResource>(responseString);
        }
        #endregion

        #region Instalações Marcas
        public async Task<InstalacoesMarcasCollection?> InstalacoesMarcasListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoesmarcas{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesMarcasCollection>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasCriar(string token, InstalacoesMarcas instalacaoMarca)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/instalacoesmarcas", authorization: $"Bearer {token}", data: instalacaoMarca);
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasAtualizar(string token, InstalacoesMarcas instalacaoMarca)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/instalacoesmarcas/{instalacaoMarca.id}", authorization: $"Bearer {token}", data: instalacaoMarca);
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }

        public async Task<InstalacoesMarcasResource?> InstalacoesMarcasDeletar(string token, InstalacoesMarcas instalacaoMarca)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/instalacoesmarcas/{instalacaoMarca.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesMarcasResource>(responseString);
        }
        #endregion

        #region Instalações Produtos
        public async Task<InstalacoesProdutosCollection?> InstalacoesProdutosListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoesprodutos{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesProdutosCollection>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosCriar(string token, InstalacoesProdutos instalacaoProduto)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/instalacoesprodutos", authorization: $"Bearer {token}", data: instalacaoProduto);
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosBuscar(string token, int id, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoesprodutos/{id}{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosAtualizar(string token, InstalacoesProdutos instalacaoProduto)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/instalacoesprodutos/{instalacaoProduto.id}", authorization: $"Bearer {token}", data: instalacaoProduto);
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }

        public async Task<InstalacoesProdutosResource?> InstalacoesProdutosDeletar(string token, InstalacoesProdutos instalacaoProduto)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/instalacoesprodutos/{instalacaoProduto.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesProdutosResource>(responseString);
        }
        #endregion

        #region Instalações Colaboradores
        public async Task<InstalacoesColaboradoresCollection?> InstalacoesColaboradoresListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoescolaboradores{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresCollection>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresCriar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/instalacoescolaboradores", authorization: $"Bearer {token}", data: instalacaoColaborador);
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresBuscar(string token, int id, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoescolaboradores/{id}{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresAtualizar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/instalacoescolaboradores/{instalacaoColaborador.id}", authorization: $"Bearer {token}", data: instalacaoColaborador);
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }

        public async Task<InstalacoesColaboradoresResource?> InstalacoesColaboradoresDeletar(string token, InstalacoesColaboradores instalacaoColaborador)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/instalacoescolaboradores/{instalacaoColaborador.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesColaboradoresResource>(responseString);
        }
        #endregion

        #region Instalações Clientes
        public async Task<InstalacoesClientesCollection?> InstalacoesClientesListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoesclientes{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesClientesCollection>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesCriar(string token, InstalacoesClientes instalacaoCliente)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/instalacoesclientes", authorization: $"Bearer {token}", data: instalacaoCliente);
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesBuscar(string token, int id, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/instalacoesclientes/{id}{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesAtualizar(string token, InstalacoesClientes instalacaoCliente)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/instalacoesclientes/{instalacaoCliente.id}", authorization: $"Bearer {token}", data: instalacaoCliente);
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }

        public async Task<InstalacoesClientesResource?> InstalacoesClientesDeletar(string token, InstalacoesClientes instalacaoCliente)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/instalacoesclientes/{instalacaoCliente.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<InstalacoesClientesResource>(responseString);
        }
        #endregion

        #region Estoques
        public async Task<EstoquesCollection?> EstoquesListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/estoques{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<EstoquesCollection>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesCriar(string token, Estoques estoque)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/estoques", authorization: $"Bearer {token}", data: estoque);
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesAtualizar(string token, Estoques estoque)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/estoques/{estoque.id}", authorization: $"Bearer {token}", data: estoque);
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }

        public async Task<EstoquesResource?> EstoquesDeletar(string token, Estoques estoque)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/estoques/{estoque.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<EstoquesResource>(responseString);
        }

        public async Task<EstoquesCollection?> EstoquesVendidosListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/estoques/getAllSolds{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<EstoquesCollection>(responseString);
        }
        #endregion

        #region Combos
        public async Task<CombosCollection?> CombosListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/combos{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<CombosCollection>(responseString);
        }

        public async Task<CombosResource?> CombosCriar(string token, Combos combo)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/combos", authorization: $"Bearer {token}", data: combo);
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosBuscar(string token, int id)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/combos/{id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosAtualizar(string token, Combos combo)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/combos/{combo.id}", authorization: $"Bearer {token}", data: combo);
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }

        public async Task<CombosResource?> CombosDeletar(string token, Combos combo)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/combos/{combo.id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<CombosResource>(responseString);
        }
        #endregion

        #region Produtos Divulgações
        public async Task<ProdutosDivulgacoesCollection?> ProdutosDivulagacoesListar(string token, string? filtros = null)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtosdivulgacoes{filtros}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesCollection>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesCriar(string token, ProdutosDivulgacoes produtoDivulgacao)
        {
            var request = new Request();
            string responseString = await request.PostAsync($"{_baseUrl}/api/produtosdivulgacoes", authorization: $"Bearer {token}", data: produtoDivulgacao);
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesBuscar(string token, int produtoId)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtosdivulgacoes/{produtoId}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesAtualizar(string token, ProdutosDivulgacoes produtoDivulgacao)
        {
            var request = new Request();
            string responseString = await request.PutAsync($"{_baseUrl}/api/produtosdivulgacoes/{produtoDivulgacao.produtos_id}", authorization: $"Bearer {token}", data: produtoDivulgacao);
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesDeletar(string token, ProdutosDivulgacoes produtoDivulgacao)
        {
            var request = new Request();
            string responseString = await request.DeleteAsync($"{_baseUrl}/api/produtosdivulgacoes/{produtoDivulgacao.produtos_id}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesBuscarColuna(string token, int produtoId, string coluna)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtosdivulgacoes/getValueColumn/{produtoId}/{coluna}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesExisteValorColuna(string token, int produtoId, string coluna)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtosdivulgacoes/existsValueColumn/{produtoId}/{coluna}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }

        public async Task<ProdutosDivulgacoesResource?> ProdutosDivulagacoesExiste(string token, int produtoId)
        {
            var request = new Request();
            string responseString = await request.GetAsync($"{_baseUrl}/api/produtosdivulgacoes/exists/{produtoId}", authorization: $"Bearer {token}");
            return JsonConvert.DeserializeObject<ProdutosDivulgacoesResource>(responseString);
        }
        #endregion
    }
}
