
namespace BD.ETL.Gui
{
    partial class Form1
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSincro = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnSincro
            // 
            this.btnSincro.Location = new System.Drawing.Point(851, 418);
            this.btnSincro.Name = "btnSincro";
            this.btnSincro.Size = new System.Drawing.Size(156, 53);
            this.btnSincro.TabIndex = 0;
            this.btnSincro.Text = "Sincronizar Datos";
            this.btnSincro.Click += new System.EventHandler(this.btnSincro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 500);
            this.Controls.Add(this.btnSincro);
            this.Name = "Form1";
            this.Text = "ETL Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSincro;
    }
}

