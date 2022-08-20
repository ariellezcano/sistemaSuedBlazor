using SistemaSuedBlazor.Models;
using SistemaSuedBlazor.Services;

namespace SistemaSuedBlazor.Pages.component.frm_abm
{
    public partial class Abm_departamento
    {
        protected override async Task OnInitializedAsync()
        {
        }

        private Departamento objMod = new Departamento();


        private async Task guardar() {
           bool insert = await DepartamentoService.AddDepto(objMod);
            if (insert)
            {
                //inserto
            }
            else { 
            //no inserto
            }
        }

        private void back()
        {
            navigate.NavigateTo("/lst-departamento");
        }


    }
}
