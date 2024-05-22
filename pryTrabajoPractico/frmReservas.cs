using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPractico
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Asiento = textBox1.Text;
            int indiceQuenaken = cmbLocal.Items.IndexOf("quenaken");
            int indiceOnas = cmbLocal.Items.IndexOf("onas");
            int indiceTobas = cmbLocal.Items.IndexOf("tobas");
            if (cmbLocal.SelectedIndex == indiceQuenaken) 
            {
                if(rbtAzul.Checked == true)
                {
                    dataGridView1.Rows.Add(Asiento,"azul", "quenaken" );
                    
                }
                
                if(rbtVerde.Checked == true)
                {
                    dataGridView1.Rows.Add(Asiento, "verde", "quenaken");
                }
            }

            if (cmbLocal.SelectedIndex == indiceOnas)
            {
                if (rbtAzul.Checked == true)
                {

                }

                if (rbtVerde.Checked == true)
                {

                }
            }

            if(cmbLocal.SelectedIndex == indiceTobas) 
            {
                if (rbtAzul.Checked == true)
                {

                }

                if (rbtVerde.Checked == true)
                {

                }
            }
        }
    }
}
