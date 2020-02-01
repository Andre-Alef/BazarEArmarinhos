using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTCC2
{
    public class AbrirFechar
      
    {



        public void Atalhos()
        {
            
        }



        public void AbrirCaixa()
        {
            OpenForm(typeof(Form));
        }

        public void OpenForm(Type frmType)
        {
            bool bolCtl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.BringToFront();
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                frm.Show();
            }
        }
    
    }
}