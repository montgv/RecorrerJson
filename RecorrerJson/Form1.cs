using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecorrerJson
{
    public partial class Form1 : Form
    {
        BaseDeDatos<Cliente> bdCliente = new BaseDeDatos<Cliente> ("bdCliente.json");

        void mostrar(List<Cliente> listaClientes)
        {
            dgv.Rows.Clear();

            foreach (Cliente cliente in listaClientes)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = cliente.propiedades.referencia
                });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = cliente.propiedades.direccion
                });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = cliente.propiedades.localidad
                });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = cliente.propiedades.descripcion
                });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = cliente.propiedades.cuota
                });
                dgv.Rows.Add(fila);
            }
        }

        public Form1()
        {
            //Fallo al cargar los datos
            InitializeComponent();
            bdCliente.Cargar();
            mostrar(bdCliente.valores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Cliente cliente = bdCliente.Buscar(x => x.dni.Equals(dgv.CurrentRow.Cells[0].Value.ToString()))[0];
            tbDni.Text = cliente.dni.ToString();
            tbNombre.Text = cliente.nombre.ToString();
            tbTelef.Text = cliente.telef.ToString();
            tbEmail.Text = cliente.email.ToString();
        }
    }
}
