using Newtonsoft.Json;
using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Util;

namespace SistemaSuedBlazor.Services
{
    public class DepartamentoService
    {

        static string api;

        static string ruta = "Departamento";

        public static async Task<List<Departamento>> LstDepartamentos(string dni)
        {

            if (dni != null && dni != "")
            {
                api = Utils.URL + ruta + "/finDni/" + dni;
            }
            else
            {
                api = Utils.URL + ruta;
            }

            List<Departamento> p = new List<Departamento>();

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(api);
                Result res = new Result();
                var = JsonConvert.DeserializeObject<Departamento>(response); ;
                //Respuesta<Departamento> r = JsonConvert.DeserializeObject<Respuesta<Departamento>>(response);

                //  Paginate pa = r.data.paginate;
                if (r.code == "200")
                {
                    p = r.data.docs;
                }
                else
                {
                    p = new List<Departamento>();
                }
            }
            // 
            return p;

        }

    }
}
