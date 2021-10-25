using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            TodosEmpleados();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado();
            TodosEmpleados();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleadoNombre();
        }

        private void TodosEmpleados()
        {
            using (var context = new ApplicationDbContext())
            {
                var empleados = context.Empleados.ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void AgregarEmpleado()
        {
            using(var context = new ApplicationDbContext())
            {
                //Paso 1: Creamos el objeto
                var empleado1 = new Empleados();
                empleado1.Nombres = txtNombre.Text;
                empleado1.ApellidoPaterno = txtApellidoPaterno.Text;
                empleado1.ApellidoMaterno = txtApellidoMaterno.Text;
                empleado1.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                empleado1.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                empleado1.RFC = txtRFC.Text;

                //Paso 2: Notificamos que queremos agregar un empleado
                context.Empleados.Add(empleado1);

                //Paso 3: Guardamos los cambios
                context.SaveChanges();
            }
        }

        private void BuscarEmpleadoNombre()
        {
            using (var context = new ApplicationDbContext())
            {
                var empleados = context.Empleados.Where(x => x.Nombres.Contains(txtNombre.Text)).ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }
    }
}
