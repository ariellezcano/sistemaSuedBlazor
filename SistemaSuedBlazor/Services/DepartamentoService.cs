using Newtonsoft.Json;
using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Util;
using System.Text;

namespace SistemaSuedBlazor.Services
{
    public class DepartamentoService
    {

        static string api = Utils.URL;
        static string ruta = "Departamento/";
        static string url = "";
        public static async Task<List<Departamento>> LstDepartamentos(string criterio)
        {

            if (criterio != null && criterio != "")
            {
                url = api + ruta +"/"+criterio;
            }
            else
            {
                url = api + ruta + "paginate/1,10";
            }

            List<Departamento> items = new List<Departamento>();

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                Console.WriteLine("respuesta {0}", response);
                Result<Departamento> res = JsonConvert.DeserializeObject<Result<Departamento>>(response);

                if (res.code == "200")
                {
                    items = res.data;
                }
                else
                {
                    items = new List<Departamento>();
                }
            }
            return items;

        }

        public static async Task<bool> AddDepto(Departamento depto)
        {

            using (var http = new HttpClient())
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(depto), Encoding.UTF8, "application/json");
                var response = await http.PostAsync(api + ruta, stringContent);
                var result = response.Content.ReadAsStringAsync().Result;

               //Result<Departamento> res = JsonConvert.DeserializeObject<Result<Departamento>>(response);

            }
            return true;
        }

    }
}
