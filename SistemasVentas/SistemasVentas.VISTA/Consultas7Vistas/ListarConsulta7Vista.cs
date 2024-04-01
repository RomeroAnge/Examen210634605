using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Consultas7Vistas
{
    public partial class ListarConsulta7Vista : Form
    {
        public ListarConsulta7Vista()
        {
            InitializeComponent();
        }
        PersonaBss bss= new PersonaBss();   
        private void ListarConsulta7Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }
    }
}
