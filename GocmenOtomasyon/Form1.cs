﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GocmenOtomasyon
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ekle_button_Click(object sender, EventArgs e)
        {
            tablolar_ekleme frm = new tablolar_ekleme();
            frm.Show();
            this.Hide();
        }

        private void ara_button_Click(object sender, EventArgs e)
        {
            arama_gocmen frm = new arama_gocmen();
            frm.Show();
            this.Hide();
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            kayıt_silme_formu frm = new kayıt_silme_formu();
            frm.Show();
            this.Hide();

        }

        private void duzenle_button_Click(object sender, EventArgs e)
        {
            guncelleme_form_ekranı frm = new guncelleme_form_ekranı();
            frm.Show();
            this.Hide();
        }

        private void listele_button_Click(object sender, EventArgs e)
        {
            listeleme_formu frm = new listeleme_formu(); 
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
