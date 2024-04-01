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

namespace SistemasVentas.VISTA.Consulta2Vistas
{
    public partial class ListarConsulta2Vista : Form
    {
        public ListarConsulta2Vista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void ListarConsulta2Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }
    }
}
