﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsappTopluMesaj
{
    public partial class Form1 : Form
    {
        string[] sNumaraDizisi = new string[1000];
        string sMesaj;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void NumaralariKaydet()
        {
            string sNumaralar = txtNumaraGirdisi.Text;
            for (int i = 0; i < sNumaraDizisi.Length; i++)
            {
                sNumaraDizisi[i] = "0";
            }
            sNumaraDizisi = sNumaralar.Split('\n');
            MessageBox.Show("Kaydetme Başarılı!");

            lblKayitliKisiSayisi.Text = "Kayıtlı Kişi Sayısı :" + sNumaraDizisi.Length;
        }

        public void MesajGonder()
        {
            sMesaj = txtMesaj.Text;

            for (int i = 0; i < sNumaraDizisi.Length; i++)
            {
                System.Diagnostics.Process.Start("https://wa.me/+90" + sNumaraDizisi[i] + "?text=" + txtMesaj.Text);
                System.Threading.Thread.Sleep(3000);

                SendKeys.Send("{ENTER}");
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NumaralariKaydet();
            MesajGonder();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.rakko.tools/tools/22/");
        }
    }
}
