using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string nome = txtNome.Text.Trim(); // recebe o nome
            int contadorLetras = 0; //conta as letras
        
            double totalLetras = 0.0; // recebe o valor R$ total de letras
            contadorLetras = nome.Length;
            nome = nome.Replace(" ","");
            

            lblResultado.Text = txtNome.Text;         
                        
                      
            if (txtNome.Text == "")
            {   //se o campo de texto estiver vazio esconde o resultado
                lblResultado.Visible = false;
                
            }
            else
            {
                lblResultado.Visible = true;
               
            }
            
            
            if (nome.Length <= 5 ) // se a quantidade de letras for menor ou igual a 5 
            {
                
                // exibi essa msg no campo lblResultado + o total de letras
                lblResultado.Text = "R$: " + 17.00 + " reais" + "\n Total de letras = " + contadorLetras + " " + nome;

            }
            else if(nome.Length > 5)
            {
                totalLetras = contadorLetras - 5; // subtrai -5 do total de letras
                // total de letras vezes 0.50 centavos + 17
                totalLetras = totalLetras * 0.5 + 17;
                totalLetras.ToString().Replace(" ", "");
                lblResultado.Text = "R$: " + totalLetras +" reais"+ "\n Total de letras = " + contadorLetras +" " + nome;
            }                        
            

        }


       

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?","Saindo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("HH:mm:ss"); //mostra hora no status
        }

        private void frmOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
