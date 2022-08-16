using SistemaSuedBlazor.Models;

namespace SistemaSuedBlazor.Pages.component.frm_abm
{
    public partial class Abm_departamento
    {
        private Departamento objMod = new Departamento();

        private void guardar() { }

        private void back()
        {
            navigate.NavigateTo("/lst-departamento");
        }


    }
}
