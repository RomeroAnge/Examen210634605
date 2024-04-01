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

namespace SistemasVentas.VISTA.Consulta5Vistas
{
    public partial class ListarConsulta5Vista : Form
    {
        public ListarConsulta5Vista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ListarConsulta5Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }
    }
}
