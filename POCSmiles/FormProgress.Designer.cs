using System;
using System.Windows.Forms;

/*
 * Created by Ranorex
 * User: welli
 * Date: 18/11/2016
 * Time: 10:07
 * 
 * To change FormProgresso template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace POCSmiles
{
    partial class FormProgresso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of FormProgresso method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
        	labelInicio = new System.Windows.Forms.Label();
        	labelTermino = new System.Windows.Forms.Label();
        	labelCasosTeste = new System.Windows.Forms.Label();
        	labelSuitesTeste = new System.Windows.Forms.Label();
        	textBoxinicio = new System.Windows.Forms.TextBox();
        	textBoxTermino = new System.Windows.Forms.TextBox();
        	textBoxCasosTeste = new System.Windows.Forms.TextBox();
        	textBoxSuitesTeste = new System.Windows.Forms.TextBox();
        	progressBar1 = new System.Windows.Forms.ProgressBar();
        	labelProgressBar = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// labelInicio
        	// 
        	labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	labelInicio.Location = new System.Drawing.Point(3, 7);
        	labelInicio.Name = "labelInicio";
        	labelInicio.Size = new System.Drawing.Size(53, 18);
        	labelInicio.TabIndex = 0;
        	labelInicio.Text = "Início:";
        	// 
        	// labelTermino
        	// 
        	labelTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	labelTermino.Location = new System.Drawing.Point(192, 7);
        	labelTermino.Name = "labelTermino";
        	labelTermino.Size = new System.Drawing.Size(69, 20);
        	labelTermino.TabIndex = 1;
        	labelTermino.Text = "Término:";
        	// 
        	// labelCasosTeste
        	// 
        	labelCasosTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	labelCasosTeste.Location = new System.Drawing.Point(686, 7);
        	labelCasosTeste.Name = "labelCasosTeste";
        	labelCasosTeste.Size = new System.Drawing.Size(125, 20);
        	labelCasosTeste.TabIndex = 2;
        	labelCasosTeste.Text = "Casos de teste:";
        	// 
        	// labelSuitesTeste
        	// 
        	labelSuitesTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	labelSuitesTeste.Location = new System.Drawing.Point(410, 8);
        	labelSuitesTeste.Name = "labelSuitesTeste";
        	labelSuitesTeste.Size = new System.Drawing.Size(121, 21);
        	labelSuitesTeste.TabIndex = 3;
        	labelSuitesTeste.Text = "Suítes de teste:";
        	// 
        	// textBoxinicio
        	// 
        	textBoxinicio.Enabled = false;
        	textBoxinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	textBoxinicio.Location = new System.Drawing.Point(62, 5);
        	textBoxinicio.Name = "textBoxinicio";
        	textBoxinicio.Size = new System.Drawing.Size(124, 21);
        	textBoxinicio.TabIndex = 4;
        	// 
        	// textBoxTermino
        	// 
        	textBoxTermino.Enabled = false;
        	textBoxTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	textBoxTermino.Location = new System.Drawing.Point(267, 4);
        	textBoxTermino.Name = "textBoxTermino";
        	textBoxTermino.Size = new System.Drawing.Size(136, 21);
        	textBoxTermino.TabIndex = 5;
        	textBoxTermino.Text = "Processando...";
        	// 
        	// textBoxCasosTeste
        	// 
        	textBoxCasosTeste.Enabled = false;
        	textBoxCasosTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	textBoxCasosTeste.Location = new System.Drawing.Point(817, 5);
        	textBoxCasosTeste.Name = "textBoxCasosTeste";
        	textBoxCasosTeste.Size = new System.Drawing.Size(143, 21);
        	textBoxCasosTeste.TabIndex = 6;
        	textBoxCasosTeste.Text = "Processando...";
        	// 
        	// textBoxSuitesTeste
        	// 
        	textBoxSuitesTeste.Enabled = false;
        	textBoxSuitesTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	textBoxSuitesTeste.Location = new System.Drawing.Point(537, 5);
        	textBoxSuitesTeste.Name = "textBoxSuitesTeste";
        	textBoxSuitesTeste.Size = new System.Drawing.Size(143, 21);
        	textBoxSuitesTeste.TabIndex = 7;
        	textBoxSuitesTeste.Text = "Processando...";
        	// 
        	// progressBar1
        	// 
        	progressBar1.ForeColor = System.Drawing.Color.LightGreen;
        	progressBar1.Location = new System.Drawing.Point(8, 27);
        	progressBar1.MaximumSize = new System.Drawing.Size(952, 18);
        	progressBar1.MinimumSize = new System.Drawing.Size(952, 18);
        	progressBar1.Name = "progressBar1";
        	progressBar1.Size = new System.Drawing.Size(952, 18);
        	progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        	progressBar1.TabIndex = 8;
        	// 
        	// labelProgressBar
        	// 
        	labelProgressBar.BackColor = System.Drawing.Color.Transparent;
        	labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	labelProgressBar.Location = new System.Drawing.Point(464, 29);
        	labelProgressBar.Name = "labelProgressBar";
        	labelProgressBar.Size = new System.Drawing.Size(41, 13);
        	labelProgressBar.TabIndex = 9;
        	labelProgressBar.Text = "0%";
        	labelProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// FormProgresso
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.ClientSize = new System.Drawing.Size(965, 51);
        	this.ControlBox = false;
        	this.Controls.Add(labelProgressBar);
        	this.Controls.Add(progressBar1);
        	this.Controls.Add(textBoxSuitesTeste);
        	this.Controls.Add(textBoxCasosTeste);
        	this.Controls.Add(textBoxTermino);
        	this.Controls.Add(textBoxinicio);
        	this.Controls.Add(labelSuitesTeste);
        	this.Controls.Add(labelCasosTeste);
        	this.Controls.Add(labelTermino);
        	this.Controls.Add(labelInicio);
        	this.Cursor = System.Windows.Forms.Cursors.No;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Location = new System.Drawing.Point((int)(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2) - 241, 0);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(965, 51);
        	this.MinimizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(965, 51);
        	this.Name = "FormProgresso";
        	this.RightToLeftLayout = true;
        	this.ShowIcon = false;
        	this.ShowInTaskbar = false;
        	this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        	this.Text = "Progresso";
        	this.TopMost = true;
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }


        #endregion

        public static Label labelProgressBar;
        public static Label labelInicio;
        public static Label labelTermino;
        public static Label labelCasosTeste;
        public static Label labelSuitesTeste;
        public static TextBox textBoxinicio;
        public static TextBox textBoxTermino;
        public static TextBox textBoxCasosTeste;
        public static TextBox textBoxSuitesTeste;
        public static ProgressBar progressBar1;
    }
}

