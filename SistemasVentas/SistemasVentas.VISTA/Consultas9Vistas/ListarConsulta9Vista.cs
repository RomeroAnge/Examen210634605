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

namespace SistemasVentas.VISTA.Consultas9Vistas
{
    public partial class ListarConsulta9Vista : Form
    {
        public ListarConsulta9Vista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ListarConsulta9Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
