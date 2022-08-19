using Newtonsoft.Json;
using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Util;

namespace SistemaSuedBlazor.Services
{
    public class DepartamentoService
    {

        static string api;

        static string ruta = "Departamento";

        public static async Task<List<Departamento>> LstDepartamentos(string criterio)
        {

            if (criterio != null && criterio != "")
            {
                api = Utils.URL + ruta;
            }
            else
            {
                api = Utils.URL + ruta;
            }

            List<Departamento> items = new List<Departamento>();

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(api);
                Result<Departamento> res = JsonConvert.DeserializeObject<Result<Departamento>>(response); ;

                //  Paginate pa = r.data.paginate;
                if (res.code == "200")
                {
                    items = res.data.docs;
                }
                else
                {
                    items = new List<Departamento>();
                }
            }
            return items;

        }

    }
}
