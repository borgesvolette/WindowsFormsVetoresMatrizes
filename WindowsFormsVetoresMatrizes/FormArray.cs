using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVetoresMatrizes
{
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }
         

        private void btnListarVetor_Click(object sender, EventArgs e)
        {
            lbxVetor.Items.Clear();

            //Inicializacao
            int[] numeros;
            string[] frutas;
            //char[] alfabeto;

            //Entrada de Dados
            // Alocar valores de um por um
            numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;
            // numeros[5] = 6;


            // Alocar valores todos de uma vez
            frutas = new string[3] { "Maça","Uva", "Pitaya" };
        
            for (int i = 0; i < 5; i++)
            {
                lbxVetor.Items.Add("Elemento [" + i + "] =" + numeros[i]);
            }

        }
    }
}
