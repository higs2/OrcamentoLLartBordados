using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoLLart
{
    public partial class frmOrcamento : Form
    {
        public frmOrcamento()
        {
            InitializeComponent();
        }
      
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string texto = "espaços";
            string nome = txtNome.Text.Trim(); // recebe o nome
            int contadorLetras = texto.Replace(" ", "").Length;; //conta as letras
            double totalLetras; // recebe o total de letras
            contadorLetras = nome.Length;

            totalLetras = contadorLetras - 5; // subtrai -5 do total de letras
            
           
           
            if (txtNome.Text == "")
            {   //se o campo de texto estiver vazio esconde o resultado
                lblResultado.Visible = false;
            }
            else
            {
                lblResultado.Visible = true;
            }
            
            
            if (nome.Length <= 5) // se a quantidade de letras for menor ou igual a 5 
            {
                // exibir essa msg no campo lblResultado + o total de letras
                lblResultado.Text = "R$:" + 15.00 + " reais" + "\n Total de letras = " + contadorLetras;

            }
            else //se não
            {
                // total de letras vezes 0.50 centavos + 15
                totalLetras = totalLetras * 0.5 + 15;
                lblResultado.Text = "R$: " + totalLetras +" reais"+ "\n Total de letras = " + contadorLetras;
            }                        
            

        }

       
    }
}
