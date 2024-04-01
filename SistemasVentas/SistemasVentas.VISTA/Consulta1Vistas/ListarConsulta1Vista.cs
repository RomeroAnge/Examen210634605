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

namespace SistemasVentas.VISTA.Consulta1Vistas
{
    public partial class ListarConsulta1Vista : Form
    {
        public ListarConsulta1Vista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ListarConsulta1Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
            dataGridView1.Columns[1].Width = 200;
        }
    }
}
