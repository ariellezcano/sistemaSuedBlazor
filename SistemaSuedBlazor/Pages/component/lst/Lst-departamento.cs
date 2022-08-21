using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Services;

namespace SistemaSuedBlazor.Pages.component.lst
{
    public partial class Lst_departamento
    {
        string criterio = "";

        List<Departamento> items = new List<Departamento>();
        protected override async Task OnInitializedAsync()
        {
            await this.LstDpto();
        }


        private async Task LstDpto()
        {
            items = await DepartamentoService.LstDepartamentos(criterio);
            if (items == null)
            {
               items = new List<Departamento>();
            }
        }



        private void navegar()
        {
            navigate.NavigateTo("/abm-departamento");
        }
    }
}
