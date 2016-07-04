﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelKundenManagementDLL;
using DLL;

namespace Project_Blutbank
{
    public partial class Form3 : Form
    {
        private DTO dto = null;
        private List<Patient> listPatient = null;

        public Form3()
        {
            InitializeComponent();
            dto = new DTO();
            listPatient = new List<Patient>();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonLadenMitarbeiter_Click(object sender, EventArgs e)
        {
            listPatient = dto.GetAllePatienten();
            dataGridView1.DataSource = listPatient;
        }
    }
}
