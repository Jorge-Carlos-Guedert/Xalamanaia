using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xalamanaia_Pizzaria
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrincipal());




            // Deixar todos comnetados antes do Pull Request.

            //Application.Run(new FrmLogin());

            //Application.Run(new FrmPrincipal());


            //Application.Run(new FrmCadastraBebidaProvisorio());
            //Application.Run(new FrmCadastroPessoaProvisorio());


            //Application.Run(new FrmCadastraCliente());
            //Application.Run(new FrmCadastroClienteProvisorio());

            Application.Run(new FrmSolPedido());


        }
    }
}

//tentativa merge com Gabriel

