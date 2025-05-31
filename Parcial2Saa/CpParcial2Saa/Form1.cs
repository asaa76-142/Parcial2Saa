using CadParcial2Saa;
using ClnParcial2Saa;
using CpParcial2Saa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Saa
{
    public partial class Form1 : Form
    {
        private bool esNuevo = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var lista = SeriesCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["titulo"].HeaderText = "Título";
            dgvLista.Columns["sinopsis"].HeaderText = "Sinopsis";
            dgvLista.Columns["director"].HeaderText = "Director";
            dgvLista.Columns["episodios"].HeaderText = "Episodios";
            dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            dgvLista.Columns["urlPortada"].HeaderText = "URL Portada";
            dgvLista.Columns["ididiomaOriginal"].HeaderText = "Idioma Original";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void cargarIdiomaOriginal()
        {
            var idiomaOriginal = IdiomaOriginalCln.listar();
            cxbIdiomaOriginal.DataSource = idiomaOriginal;
            cxbIdiomaOriginal.DisplayMember = "descripcion";
            cxbIdiomaOriginal.ValueMember = "id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(818, 350);
            listar();
            cargarIdiomaOriginal();
        }
        private void limpiar()
        {
            txtTitulo.Clear();
            txtSinopsis.Clear();
            txtDirector.Clear();
            txturlPortada.Clear();
            cxbIdiomaOriginal.SelectedIndex = -1;
            nudEpisodios.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(818, 350);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(818, 518);
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(818, 518);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var series = SeriesCln.obtenerUno(id);
            txtTitulo.Text = series.titulo;
            txtSinopsis.Text = series.sinopsis;
            txtDirector.Text = series.director;
            nudEpisodios.Value = series.episodios;
            dTiFechaEstreno.Value = series.fechaEstreno;
            txturlPortada.Text = series.urlPortada;
            cxbIdiomaOriginal.SelectedValue = series.ididiomaOriginal;

            txtTitulo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpTitulo.SetError(txtTitulo, "");
            erpSinopsis.SetError(txtSinopsis, "");
            erpDirector.SetError(txtDirector, "");
            erpEpisodios.SetError(nudEpisodios, "");
            erpFechaEstreno.SetError(dTiFechaEstreno, "");
            erpUrlPortada.SetError(txturlPortada, "");
            erpIdiomaOriginal.SetError(cxbIdiomaOriginal, "");
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El campo del Titulo es obligatorio");
                esValido = false;
            }
            if ((string.IsNullOrEmpty(txtSinopsis.Text)))
            {
                erpSinopsis.SetError(txtSinopsis, "El campo de la Sinopsis es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                erpDirector.SetError(txtDirector, "El campo del Director es obligatorio");
                esValido = false;
            }
            if (nudEpisodios.Value < 0)
            {
                erpEpisodios.SetError(nudEpisodios, "El campo del Precio de Venta no debe ser menor a cero");
                esValido = false;
            }
            if (dTiFechaEstreno.Value == DateTimePicker.MinimumDateTime)
            {
                erpFechaEstreno.SetError(dTiFechaEstreno, "El campo de la Fecha Estreno es obligatorio");
                esValido = false;
            }
            //if (string.IsNullOrEmpty(txturlPortada.Text))
            //{
            //    erpUrlPortada.SetError(txturlPortada, "El campo del URL es obligatorio");
            //    esValido = false;
            //}

            if (string.IsNullOrEmpty(cxbIdiomaOriginal.Text))
            {
                erpIdiomaOriginal.SetError(cxbIdiomaOriginal, "El campo Unidad de Medida es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var series = new Series();
                series.titulo = txtTitulo.Text.Trim();
                series.sinopsis = txtSinopsis.Text.Trim();
                series.director = txtDirector.Text.Trim();
                series.episodios = (int)nudEpisodios.Value;
                series.fechaEstreno = dTiFechaEstreno.Value;
                //series.usuarioRegistro = "admin";
                series.urlPortada = txturlPortada.Text.Trim();
                series.ididiomaOriginal = Convert.ToInt32(cxbIdiomaOriginal.SelectedValue);

                if (esNuevo)
                {
                    series.estado = 1;
                    SeriesCln.insertar(series);

                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    series.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    SeriesCln.actualizar(series);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Serie guardado correctamente", "::: Parcial2Saa - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string titulo = dgvLista.Rows[index].Cells["titulo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el producto {titulo}?",
                "::: Parcial2Saa - Mensaje :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SeriesCln.eliminar(id);
                listar();
                MessageBox.Show("Serie dado de baja correctamente", "::: Parcial2Saa - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
