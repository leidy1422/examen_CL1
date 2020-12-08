using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace POOI_EL1_BRANDON_SOTO_MALLQUI
{
    public partial class FmrAlumo : Form
    {
        public FmrAlumo()
        {
            InitializeComponent();
        }
        List<Alumno> listaPostulante = new List<Alumno>();
        Alumno obj = new Alumno();

        void listado()
        {
            lvlalumno.Items.Clear();
            foreach (Alumno reg in listaPostulante)
            {
                ListViewItem item = new ListViewItem(reg.codigo);
                item.SubItems.Add(reg.dni.ToUpper());
                item.SubItems.Add(reg.nombre);
                item.SubItems.Add(reg.apellido);
                item.SubItems.Add(reg.grado);
                item.SubItems.Add(reg.correo);
                lvlalumno.Items.Add(item);
            }
        }
        void limpiar()
        {
            //limpiar objetos
            cboGrado.SelectedIndex = -1;
            txtCodigo.Text = obj.GeneraCodigo();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtDNI.Clear();
            txtDNI.Focus();


        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //controlar la duplicidad de Dni
            Boolean encuentra = false;
            foreach (Alumno reg in listaPostulante)
            {
                if (reg.dni == txtDNI.Text.ToUpper())
                {
                    MessageBox.Show("Ya se encuentra ese DNI registrado...", "AVISO");
                    encuentra = true;
                    break;
                }
            }
            if (encuentra == false)
            {
                obj = new Alumno();
                obj.codigo = txtCodigo.Text;
                obj.dni = txtDNI.Text.ToUpper();
                obj.nombre = txtNombre.Text;
                obj.apellido = txtApellidos.Text;
                obj.grado = cboGrado.Text;
                obj.correo = txtCorreo.Text;
                listaPostulante.Add(obj);
                listado();
                limpiar();
            }
        }

       

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string codigoBuscando = Interaction.InputBox("ingresar Codigo a eliminar:", "AVISO");
            Boolean encuentra = true;
            foreach (Alumno reg in listaPostulante)
            {
                if (reg.codigo == codigoBuscando)
                {
                    encuentra = true;
                    listaPostulante.Remove(reg);
                    break;
                }
                else
                {
                    encuentra = false;
                }
            }
            if (encuentra == false)
            {
                MessageBox.Show("El codigo no existe...", "AVISO");
                return;
            }
            listado();

        }

        private void FmrAlumo_Load(object sender, EventArgs e)
        {
            txtCorreo.Text = obj.GeneraCodigo();
        }
    }
}

   