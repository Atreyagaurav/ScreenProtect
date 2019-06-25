using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ScreenProtect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1.WindowState = FormWindowState.Maximized;
            Form1.FormBorderStyle = FormBorderStyle.None;
            Form1.TopMost = true;
            InstructionsLabel.Text = "Please Do not press anything or click anywhere, some process is going on and it may cause the computer to overload.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void InstructionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
