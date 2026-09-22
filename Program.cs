using System.Net.Http;
using Newtonsoft.Json;

// Cria o cliente HTTP responsável por fazer as requisições
HttpClient client = new HttpClient();

// Define o endereço da API
string url = "https://catfact.ninja/fact";

// Faz a requisição GET à API e aguarda a resposta (string JSON)
string json = await client.GetStringAsync(url);

// Transforma o JSON recebido no objeto CatFact
CatFact? catFact = JsonConvert.DeserializeObject<CatFact>(json);

// Exibe os dados retornados pela API no console
Console.WriteLine("Fato sobre Gatos:");
Console.WriteLine(catFact?.fact);
