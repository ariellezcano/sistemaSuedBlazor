using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Services;

namespace SistemaSuedBlazor.Pages.component.filtros
{
    public partial class Fil_departamento
    {
        int[] limits = { 5, 10, 15, 20, 50 };

        string criterio = "";
        int limit;
        int page;
        string estado;

        List<Departamento> items = new List<Departamento>();
        protected override async Task OnInitializedAsync()
        {
            await this.LstDpto();
            int limit = 5;
            int page = 1;
            string estado = "";
        }

        setPage(page, estado)
        {
            this.paginaActual = page;
            if (estado == 'siguiente')
            {
                this.paginaSiguiente = this.paginaActual + 1;
                this.paginaActual = this.paginaSiguiente;
            }
            if (estado == 'anterior')
            {
                this.paginaAnterior = this.paginaActual - 1;
                this.paginaActual = this.paginaAnterior;
            }
            this.filter();
        }

        private async Task LstDpto()
        {
            items = await DepartamentoService.LstDepartamentos(criterio);
            if (items == null)
            {
                items = new List<Departamento>();
            }
        }



    }
}
