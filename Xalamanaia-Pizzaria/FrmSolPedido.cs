using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Xalamanaia_Pizzaria.WSCorreios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Xalamanaia_Pizzaria
{
    public partial class FrmSolPedido : Form
    {

        List<SaboresModelo> listaSabores = new List<SaboresModelo>();
        List<AdicionaisModelo> listaAdicionais = new List<AdicionaisModelo>();
        PedidoController pedidoController = new PedidoController();

        string tamanho;
        int quantidade = 0;
        decimal valorFinal = 0.0M;
        decimal valorAdFinal = 0.0M;

        public FrmSolPedido()
        {
            InitializeComponent();

            // Gera  a lista de Items Exceção
            string[] excecoes = { "Sem Cebola", "Sem Alho", "Sem Pimenta" }; // criar lista e criar tabela no bd
            checkedListBoxExcecao.Items.AddRange(excecoes);

            // Define apenas um Click

            checkedListBoxExcecao.CheckOnClick = true;
            cbxAdicionais.SelectedItem = "Selecione";
            

            
        }

        private void cbxtamanho_SelectedIndexChanged(object sender, EventArgs e)
        {

            valorpizza.Clear();

            cbxsabor1.Items.Clear();
            cbxsabor2.Items.Clear();
            cbxsabor3.Items.Clear();
            //cbxAdicionais.Items.Clear();
            valorpizza.Text = string.Empty;
            exibeteladicional.Text = string.Empty;
            tamanho = cbxtamanho.SelectedItem as string;
            valorpizza.Clear();
            
            switch (tamanho)
            {
                case "Broto":
                   
                    cbxsabor1.Visible = true;
                    CarregarSabores(tamanho);

                    cbxsabor2.Visible = false;
                    cbxsabor3.Visible = false;
                    CarregaAdicionais(tamanho);
                    break;

                case "Media":

                    cbxsabor1.Visible = true;
                    cbxsabor2.Visible = true;
                    CarregarSabores(tamanho);
                    cbxsabor3.Visible = false;
                    CarregaAdicionais(tamanho);
                    break;
                case "Grande":
                    cbxsabor1.Visible = true;
                    cbxsabor2.Visible = true;
                    CarregarSabores(tamanho);
                    cbxsabor3.Visible = false;


                    break;
                case "Gigante":
                    cbxsabor1.Visible = true;
                    cbxsabor2.Visible = true;
                    cbxsabor3.Visible = true;
                    CarregarSabores(tamanho);

                    break;

                default:
                    cbxsabor1.Visible = false;
                    cbxsabor2.Visible = false;
                    cbxsabor3.Visible = false;
                    break;
            }
            panel1.Invalidate();
        }

        private void FrmSolPedido_Load(object sender, EventArgs e)
        {
            listaSabores = pedidoController.ObterSabores();


            foreach (var item in pedidoController.ObterPizzas()) // para cada item na lista resultados
            {
                cbxtamanho.Items.Add(item.Tamanho.ToString()); // adicione o item encontrado na Combobox

            }

            //listaAdicionais = pedidoController.ObterAdicionais();

            //foreach (var item in pedidoController.ObterAdicionais())
            //{
            //    cbxAdicionais.Items.Add(item.descricao.ToString());
            //}



            cbxtamanho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxtamanho.SelectedItem = "Nenhum";
            string[] quantidade = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            cbxUnidades.Items.AddRange(quantidade);

            cbxUnidades.SelectedItem = "0";
            string[] adicionais = { "Selecione" };
            cbxAdicionais.Items.AddRange(adicionais);
            cbxAdicionais.SelectedItem = "Selecione";

            cbxsabor1.SelectedIndexChanged += cbxsabor1_SelectedIndexChanged;

            checkBoxExcecoes.Checked = false;
            checkedListBoxExcecao.Visible = false;





            panel1.Invalidate();
        }

        private void CarregarSabores(string tamanho)
        {
            //var sabores = pedidoController.ObterSabores();
            //sabores.Clear();

            if (tamanho == "Broto")
            {
                foreach (var item in listaSabores)
                {
                    if (item.ValorBroto != 0)
                    {


                        cbxsabor1.Items.Add(item.DescricaoSabor.ToString());

                    }

                }

                //cbxAdicionais.Items.Clear();
                CarregaAdicionais(tamanho);

                //foreach (var item in listaAdicionais)
                //{
                //    if (item.valoradicional_broto != 0)
                //    {
                //        cbxAdicionais.Items.Add(item.descricao.ToString());
                //    }
                //}

                cbxAdicionais.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxsabor1.DropDownStyle = ComboBoxStyle.DropDownList;

            }

            if (tamanho == "Media")
            {
                foreach (var item in listaSabores)
                {
                    if (item.ValorMedia != 0)
                    {

                        cbxsabor1.Items.Add(item.DescricaoSabor.ToString());
                        cbxsabor2.Items.Add(item.DescricaoSabor.ToString());
                    }
                }
                foreach (var item in listaAdicionais)
                {
                    if (item.valoradicional_media != 0)
                    {
                        cbxAdicionais.Items.Add(item.descricao.ToString());
                    }
                }

                //cbxAdicionais.DropDownStyle = ComboBoxStyle.DropDownList;
                //cbxsabor1.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            if (tamanho == "Grande")
            {
                foreach (var item in listaSabores)
                {
                    if (item.ValorGrande != 0)
                    {
                        cbxsabor1.Items.Add(item.DescricaoSabor.ToString());
                        cbxsabor2.Items.Add(item.DescricaoSabor.ToString());
                    }
                }
                foreach (var item in listaAdicionais)
                {
                    if (item.valoradicional_grande != 0)
                    {
                        cbxAdicionais.Items.Add(item.descricao.ToString());
                    }
                }
            }

            if (tamanho == "Gigante")
            {
                foreach (var item in listaSabores)
                {
                    if (item.ValorGigante != 0)
                    {
                        cbxsabor1.Items.Add(item.DescricaoSabor.ToString());
                        cbxsabor2.Items.Add(item.DescricaoSabor.ToString());
                        cbxsabor3.Items.Add(item.DescricaoSabor.ToString());
                    }
                }
                foreach (var item in listaAdicionais)
                {
                    if (item.valoradicional_gigante != 0)
                    {
                        cbxAdicionais.Items.Add(item.descricao.ToString());
                    }
                }
            }
        }

        private void cbxsabor1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ValorPizza(tamanho, quantidade);

        }

        private void cbxsabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorPizza(tamanho, quantidade);


        }


        private void cbxsabor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorPizza(tamanho, quantidade);
        }




        private void ValorPizza(string tamanho, int quantidade)
        {
            SaboresModelo sabor1 = new SaboresModelo();
            SaboresModelo sabor2 = new SaboresModelo();
            SaboresModelo sabor3 = new SaboresModelo();
            AdicionaisModelo adicionais = new AdicionaisModelo();





            switch (tamanho)
            {
                case "Broto":

                    if (cbxsabor1.SelectedItem.ToString() != null)
                    {
                        string selecionado1 = cbxsabor1.SelectedItem.ToString();
                        sabor1 = listaSabores.Find(a => a.DescricaoSabor == selecionado1);

                        if (sabor1 != null)
                        {
                            decimal valor1 = sabor1.ValorBroto;
                            valorpizza.Text = (valor1 * quantidade).ToString();
                            valorFinal = decimal.Parse(valorpizza.Text);
                        }
                    }

                    if (cbxAdicionais.SelectedItem.ToString() != null)
                    {
                        string adicionado = cbxAdicionais.SelectedItem.ToString();

                        adicionais = listaAdicionais.Find(a => a.descricao == adicionado);

                        if (adicionais != null)
                        {
                            decimal valoradicional = adicionais.valoradicional_broto;
                            //MessageBox.Show(valoradicional.ToString());
                            exibeteladicional.Text = valoradicional.ToString();
                            valorAdFinal = decimal.Parse(exibeteladicional.Text) * quantidade;
                        }
                    }




                    break;

                case "Media":

                    if (cbxsabor2.SelectedItem != null || cbxsabor1.SelectedItem != null)
                    {
                        string selecionado1 = "";
                        string selecionado2 = "";
                        if (cbxsabor1.SelectedItem != null)
                        {
                            selecionado1 = cbxsabor1.SelectedItem.ToString();
                            sabor1 = listaSabores.Find(a => a.DescricaoSabor == selecionado1);
                        }
                        if (cbxsabor2.SelectedItem != null)
                        {
                            selecionado2 = cbxsabor2.SelectedItem.ToString();
                            sabor2 = listaSabores.Find(a => a.DescricaoSabor == selecionado2);
                        }


                        if (sabor1 != null || sabor2 != null)
                        {
                            decimal valor1 = sabor1 != null ? sabor1.ValorMedia : 0;
                            decimal valor2 = sabor2 != null ? sabor2.ValorMedia : 0;
                            decimal resultadoMaior = pedidoController.MaiorDValor(valor1, valor2);
                            valorpizza.Text = (resultadoMaior * quantidade).ToString();
                            valorFinal = resultadoMaior;
                            //if (valor1 >= valor2)
                            //{
                            //    valorpizza.Text = valor1.ToString();

                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}
                            //else
                            //{
                            //    valorpizza.Text = valor2.ToString();

                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}

                            if (cbxAdicionais.SelectedItem.ToString() != null)
                            {
                                string adicionado = cbxAdicionais.SelectedItem.ToString();

                                adicionais = listaAdicionais.Find(a => a.descricao == adicionado);

                                if (adicionais != null)
                                {
                                    decimal valoradicional = adicionais.valoradicional_media;
                                    //MessageBox.Show(valoradicional.ToString());
                                    exibeteladicional.Text = valoradicional.ToString();
                                    valorAdFinal = decimal.Parse(exibeteladicional.Text) * quantidade;
                                }
                            }

                        }
                    }
                    break;

                case "Grande":

                    if (cbxsabor2.SelectedItem != null || cbxsabor1.SelectedItem != null)
                    {
                        string selecionado1 = "";
                        string selecionado2 = "";
                        if (cbxsabor1.SelectedItem != null)
                        {
                            selecionado1 = cbxsabor1.SelectedItem.ToString();
                            sabor1 = listaSabores.Find(a => a.DescricaoSabor == selecionado1);
                        }
                        if (cbxsabor2.SelectedItem != null)
                        {
                            selecionado2 = cbxsabor2.SelectedItem.ToString();
                            sabor2 = listaSabores.Find(a => a.DescricaoSabor == selecionado2);
                        }

                        if (sabor1 != null || sabor2 != null)
                        {
                            decimal valor1 = sabor1 != null ? sabor1.ValorGrande : 0;
                            decimal valor2 = sabor2 != null ? sabor2.ValorGrande : 0;

                            decimal resultadoMaior = pedidoController.MaiorDValor(valor1, valor2);
                            valorpizza.Text = (resultadoMaior * quantidade).ToString();
                            valorFinal = resultadoMaior;
                            //if (valor1 >= valor2)
                            //{
                            //    valorpizza.Text = valor1.ToString();
                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}
                            //else
                            //{
                            //    valorpizza.Text = valor2.ToString();
                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}

                        }
                    }
                    break;

                case "Gigante":

                    if (cbxsabor1.SelectedItem != null || cbxsabor2.SelectedItem != null || cbxsabor3.SelectedItem != null)
                    {
                        string selecionado1 = "";
                        string selecionado2 = "";
                        string selecionado3 = "";
                        if (cbxsabor1.SelectedItem != null)
                        {
                            selecionado1 = cbxsabor1.SelectedItem.ToString();
                            sabor1 = listaSabores.Find(a => a.DescricaoSabor == selecionado1);
                        }
                        if (cbxsabor2.SelectedItem != null)
                        {
                            selecionado2 = cbxsabor2.SelectedItem.ToString();
                            sabor2 = listaSabores.Find(a => a.DescricaoSabor == selecionado2);
                        }

                        if (cbxsabor3.SelectedItem != null)
                        {
                            selecionado3 = cbxsabor3.SelectedItem.ToString();
                            sabor3 = listaSabores.Find(a => a.DescricaoSabor == selecionado3);
                        }

                        if (sabor1 != null || sabor2 != null || sabor3 != null)
                        {
                            decimal valor1 = sabor1 != null ? sabor1.ValorGigante : 0;
                            decimal valor2 = sabor2 != null ? sabor2.ValorGigante : 0;
                            decimal valor3 = sabor3 != null ? sabor3.ValorGigante : 0;

                            decimal resultadoMaior = pedidoController.MaiorTValor(valor1, valor2, valor3);
                            valorpizza.Text = (resultadoMaior * quantidade).ToString();
                            valorFinal = resultadoMaior;

                            //if (valor1 >= valor2 && valor1 >= valor3)
                            //{
                            //    valorpizza.Text = (valor1 * quantidade).ToString();
                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}
                            //else if (valor2 >= valor1 && valor2 >= valor3)
                            //{
                            //    valorpizza.Text = (valor2 * quantidade).ToString();
                            //    valorFinal = decimal.Parse(valorpizza.Text);
                            //}
                            //else
                            //{
                            //    valorpizza.Text = (valor3 * quantidade).ToString();
                            //    valorFinal = decimal.Parse(valorpizza.Text);

                            //}

                        }
                    }
                    break;
            }

        }





        private void checkBoxExcecoes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExcecoes.Checked)
            {
                checkedListBoxExcecao.Visible = true;



            }
            else
            {
                checkedListBoxExcecao.Visible = false;

            }
        }

        private void checkedListBoxExcecao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxAdicionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibeteladicional.Text = string.Empty;
            ValorPizza(tamanho, quantidade);
        }



        private void cbxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantidade = int.Parse(cbxUnidades.SelectedItem.ToString());
            ValorPizza(tamanho, quantidade);
            valorpizza.Text = Convert.ToString((valorFinal + valorAdFinal)* quantidade);
        }

        private void CarregaAdicionais(string tamanho)
        {
            listaAdicionais = pedidoController.ObterAdicionais();

            switch (tamanho)
            {
                case "Broto":
                    foreach (var item in listaAdicionais)
                    {

                        if (item.valoradicional_broto != 0)
                        {

                            cbxAdicionais.Items.Add(item.descricao.ToString());
                        }
                    }
                    break;

                case "Media":
                    foreach (var item in listaAdicionais)
                    {

                        if (item.valoradicional_media != 0)
                        {

                            cbxAdicionais.Items.Add(item.descricao.ToString());
                        }
                    }
                    break;

                case "Grande":
                    foreach (var item in listaAdicionais)
                    {

                        if (item.valoradicional_grande != 0)
                        {

                            cbxAdicionais.Items.Add(item.descricao.ToString());
                        }
                    }
                    break;

                case "Gigante":
                    foreach (var item in listaAdicionais)
                    {

                        if (item.valoradicional_gigante != 0)
                        {

                            cbxAdicionais.Items.Add(item.descricao.ToString());
                        }
                    }
                    break;



                default:
                    break;
            }

        }
    }
}

// fazendo alteração para fazer requisição de pull request
// teste de pull request