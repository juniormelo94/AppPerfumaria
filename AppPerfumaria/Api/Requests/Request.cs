using ApexCharts;
using AppPerfumaria.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Api.Requests
{
    public class Request
    {
        public async Task<string> GetAsync(string url, string? authorization = null)
        {
            using var client = new HttpClient();
            if (!String.IsNullOrEmpty(authorization))
            {
                client.DefaultRequestHeaders.Add("Authorization", authorization);
            }

            var response = await client.GetAsync(url);

            return await TreatmentExceptions(response);
        }

        public async Task<string> PostAsync(string url, string? authorization = null, object? data = null)
        {
            using var client = new HttpClient();
            if (!String.IsNullOrEmpty(authorization))
            {
                client.DefaultRequestHeaders.Add("Authorization", authorization);
            }

            StringContent? content = null;
            if (data != null)
            {
                var json = JsonConvert.SerializeObject(data);
                content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            var response = await client.PostAsync(url, content);

            return await TreatmentExceptions(response);
        }

        public async Task<string> PutAsync(string url, string? authorization = null, object? data = null)
        {
            using var client = new HttpClient();
            if (!String.IsNullOrEmpty(authorization))
            {
                client.DefaultRequestHeaders.Add("Authorization", authorization);
            }

            StringContent? content = null;
            if (data != null)
            {
                var json = JsonConvert.SerializeObject(data);
                content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            var response = await client.PutAsync(url, content);

            return await TreatmentExceptions(response);
        }

        public async Task<string> DeleteAsync(string url, string? authorization = null)
        {
            using var client = new HttpClient();
            if (!String.IsNullOrEmpty(authorization))
            {
                client.DefaultRequestHeaders.Add("Authorization", authorization);
            }

            var response = await client.DeleteAsync(url);

            return await TreatmentExceptions(response);
        }

        private async Task<string> TreatmentExceptions(HttpResponseMessage response)
        {
            string responseString = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                // Lança exceção específica se o token for inválido
                throw new UnauthorizedException();
            }

            // Opcional: tratar outros status genéricos
            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new Exception($"Erro HTTP {(int)response.StatusCode}: {response.ReasonPhrase}\n{responseString}");
            //}

            return responseString;
        }
    }
}
