﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Muebleria
{
    public partial class InicioSistema : Form
    {
        public InicioSistema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);

        }

        private void materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);

        }

        private void materialBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muebleriaMultimediaDataSet.Mueble' table. You can move, or remove it, as needed.
            this.muebleTableAdapter.Fill(this.muebleriaMultimediaDataSet.Mueble);
            // TODO: esta línea de código carga datos en la tabla 'muebleriaMultimediaDataSet.Material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.muebleriaMultimediaDataSet.Material);

        }
    }
}