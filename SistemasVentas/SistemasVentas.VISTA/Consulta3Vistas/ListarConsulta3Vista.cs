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

namespace SistemasVentas.VISTA.Consulta3Vistas
{
    public partial class ListarConsulta3Vista : Form
    {
        public ListarConsulta3Vista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void ListarConsulta3Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }
    }
}
