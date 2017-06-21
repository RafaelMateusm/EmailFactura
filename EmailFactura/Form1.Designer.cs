namespace EmailFactura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_de = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_para = new System.Windows.Forms.TextBox();
            this.tb_asunto = new System.Windows.Forms.TextBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.mes = new System.Windows.Forms.TextBox();
            this.lineauno = new System.Windows.Forms.TextBox();
            this.lineados = new System.Windows.Forms.TextBox();
            this.lineatres = new System.Windows.Forms.TextBox();
            this.lineafinal = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_de
            // 
            this.tb_de.Location = new System.Drawing.Point(35, 27);
            this.tb_de.Name = "tb_de";
            this.tb_de.Size = new System.Drawing.Size(100, 20);
            this.tb_de.TabIndex = 0;
            this.tb_de.Text = "De:";
            this.tb_de.TextChanged += new System.EventHandler(this.tb_de_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(193, 27);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.Text = "pass";
            this.tb_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_para
            // 
            this.tb_para.Location = new System.Drawing.Point(366, 27);
            this.tb_para.Name = "tb_para";
            this.tb_para.Size = new System.Drawing.Size(100, 20);
            this.tb_para.TabIndex = 2;
            this.tb_para.Text = "Para:";
            // 
            // tb_asunto
            // 
            this.tb_asunto.Location = new System.Drawing.Point(35, 85);
            this.tb_asunto.Name = "tb_asunto";
            this.tb_asunto.Size = new System.Drawing.Size(100, 20);
            this.tb_asunto.TabIndex = 3;
            this.tb_asunto.Text = "Asunto";
            // 
            // bt_enviar
            // 
            this.bt_enviar.Location = new System.Drawing.Point(613, 498);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(186, 66);
            this.bt_enviar.TabIndex = 5;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(35, 148);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 20);
            this.mes.TabIndex = 6;
            this.mes.Text = "Mes";
            this.mes.TextChanged += new System.EventHandler(this.mes_TextChanged);
            // 
            // lineauno
            // 
            this.lineauno.Location = new System.Drawing.Point(35, 195);
            this.lineauno.Name = "lineauno";
            this.lineauno.Size = new System.Drawing.Size(100, 20);
            this.lineauno.TabIndex = 7;
            this.lineauno.Text = "DÍAS";
            // 
            // lineados
            // 
            this.lineados.Location = new System.Drawing.Point(35, 245);
            this.lineados.Name = "lineados";
            this.lineados.Size = new System.Drawing.Size(100, 20);
            this.lineados.TabIndex = 8;
            this.lineados.Text = "DÍAS";
            // 
            // lineatres
            // 
            this.lineatres.Location = new System.Drawing.Point(35, 293);
            this.lineatres.Name = "lineatres";
            this.lineatres.Size = new System.Drawing.Size(100, 20);
            this.lineatres.TabIndex = 9;
            this.lineatres.Text = "DÍAS";
            // 
            // lineafinal
            // 
            this.lineafinal.Location = new System.Drawing.Point(35, 340);
            this.lineafinal.Name = "lineafinal";
            this.lineafinal.Size = new System.Drawing.Size(313, 20);
            this.lineafinal.TabIndex = 10;
            this.lineafinal.Text = "Todos los días hemos";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = " regado y limpiado toda la comunidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(363, 198);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(199, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "cortado el cesped, regado y limpiado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(568, 198);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(165, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "limpiado los macizos y regado";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(739, 198);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 17);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "limpiado la portería";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(156, 245);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(201, 17);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = " regado y limpiado toda la comunidad";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(739, 245);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(115, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "limpiado la portería";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(568, 245);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(165, 17);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "limpiado los macizos y regado";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(363, 245);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(199, 17);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.Text = "cortado el cesped, regado y limpiado";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(739, 283);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(115, 17);
            this.checkBox9.TabIndex = 22;
            this.checkBox9.Text = "limpiado la portería";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(568, 283);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(165, 17);
            this.checkBox10.TabIndex = 21;
            this.checkBox10.Text = "limpiado los macizos y regado";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(363, 283);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(199, 17);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "cortado el cesped, regado y limpiado";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(156, 283);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(201, 17);
            this.checkBox12.TabIndex = 23;
            this.checkBox12.Text = " regado y limpiado toda la comunidad";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 615);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lineafinal);
            this.Controls.Add(this.lineatres);
            this.Controls.Add(this.lineados);
            this.Controls.Add(this.lineauno);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.tb_asunto);
            this.Controls.Add(this.tb_para);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_de);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_de;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_para;
        private System.Windows.Forms.TextBox tb_asunto;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.TextBox lineauno;
        private System.Windows.Forms.TextBox lineados;
        private System.Windows.Forms.TextBox lineatres;
        private System.Windows.Forms.TextBox lineafinal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}

