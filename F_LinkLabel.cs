using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CFB_Cursos_Aula
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0, 6, "http://google.com");
            ll_multiplosLinks.Links.Add(7, 5, "http://yahoo.com");
            ll_multiplosLinks.Links.Add(13, 7, "http://chatgpt.com");

        }

        private void ll_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtube.com");

            ll_Canal.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           Process.Start("calc.exe");
            ll_calculadora.LinkVisited=true;
           

        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited=true;
        }
    }
}
