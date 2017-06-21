using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace EmailFactura
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_de_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                if (checkBox1.Checked)
                    checkBox1.Text = checkBox1.Text;
                else
                    checkBox1.Text = null;
                if (checkBox2.Checked)
                    checkBox2.Text = checkBox2.Text;
                else
                    checkBox2.Text = null;
                if (checkBox3.Checked)
                    checkBox3.Text = checkBox1.Text;
                else
                    checkBox3.Text = null;
                if (checkBox4.Checked)
                    checkBox4.Text = checkBox4.Text;
                else
                    checkBox4.Text = null;
                if (checkBox5.Checked)
                    checkBox5.Text = checkBox5.Text;
                else
                    checkBox5.Text = null;
                if (checkBox6.Checked)
                    checkBox6.Text = checkBox6.Text;
                else
                    checkBox6.Text = null;
                if (checkBox7.Checked)
                    checkBox7.Text = checkBox7.Text;
                else
                    checkBox7.Text = null;
                if (checkBox8.Checked)
                    checkBox8.Text = checkBox8.Text;
                else
                    checkBox8.Text = null;
                if (checkBox12.Checked)
                    checkBox12.Text = checkBox12.Text;
                else
                    checkBox12.Text = null;
                if (checkBox9.Checked)
                    checkBox9.Text = checkBox9.Text;
                else
                    checkBox9.Text = null;
                if (checkBox10.Checked)
                    checkBox10.Text = checkBox10.Text;
                else
                    checkBox10.Text = null;
                if (checkBox11.Checked)
                    checkBox11.Text = checkBox11.Text;
                else
                    checkBox11.Text = null;
                mes.Text.ToUpper();
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(tb_de.Text, tb_pass.Text);
                MailMessage mensaje = new MailMessage(tb_de.Text, tb_para.Text, tb_asunto.Text, "MANUEL TOMÁS" + 
                    System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + 
                    "RESUMEN DEL MES DE " + mes.Text + " DE LA COMUNIDAD DE PORTILLO DEL PARDO N 6 " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    lineauno.Text + " hemos " + checkBox1.Text + checkBox2.Text + checkBox3.Text + checkBox4.Text +
                    System.Environment.NewLine + System.Environment.NewLine +
                    lineados.Text + " hemos " + checkBox5.Text + checkBox6.Text + checkBox7.Text + checkBox8.Text + 
                    System.Environment.NewLine + System.Environment.NewLine +
                    lineatres.Text + " hemos " + checkBox9.Text + checkBox10.Text + checkBox11.Text + checkBox12.Text + 
                    System.Environment.NewLine + System.Environment.NewLine +
                    lineafinal.Text);
                try
                {
                    cliente.Send(mensaje);
                    MessageBox.Show("El email se ha enviado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb_mensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void mes_TextChanged(object sender, EventArgs e)
        {

        }
        private void tb_final_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}