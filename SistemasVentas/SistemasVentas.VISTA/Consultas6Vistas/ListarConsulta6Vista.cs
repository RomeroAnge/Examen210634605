using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Consultas6Vistas
{
    public partial class ListarConsulta6Vista : Form
    {
        public ListarConsulta6Vista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ListarConsulta6Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }
    }
}
