
namespace SorteiaAdedanha
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSorteio = new System.Windows.Forms.Button();
            this.lblLetraSorteada = new System.Windows.Forms.Label();
            this.lstSorteados = new System.Windows.Forms.ListBox();
            this.spinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorteio
            // 
            this.btnSorteio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSorteio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSorteio.Location = new System.Drawing.Point(12, 440);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(769, 47);
            this.btnSorteio.TabIndex = 0;
            this.btnSorteio.Text = "Sortear uma nova letra";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // lblLetraSorteada
            // 
            this.lblLetraSorteada.AutoSize = true;
            this.lblLetraSorteada.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLetraSorteada.ForeColor = System.Drawing.Color.Brown;
            this.lblLetraSorteada.Location = new System.Drawing.Point(46, 80);
            this.lblLetraSorteada.Name = "lblLetraSorteada";
            this.lblLetraSorteada.Size = new System.Drawing.Size(116, 128);
            this.lblLetraSorteada.TabIndex = 1;
            this.lblLetraSorteada.Text = "A";
            this.lblLetraSorteada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSorteados
            // 
            this.lstSorteados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSorteados.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSorteados.FormattingEnabled = true;
            this.lstSorteados.ItemHeight = 25;
            this.lstSorteados.Location = new System.Drawing.Point(218, 12);
            this.lstSorteados.Name = "lstSorteados";
            this.lstSorteados.Size = new System.Drawing.Size(563, 404);
            this.lstSorteados.TabIndex = 2;
            // 
            // spinner
            // 
            this.spinner.Image = ((System.Drawing.Image)(resources.GetObject("spinner.Image")));
            this.spinner.Location = new System.Drawing.Point(34, 92);
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(128, 128);
            this.spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinner.TabIndex = 3;
            this.spinner.TabStop = false;
            this.spinner.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 499);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.lstSorteados);
            this.Controls.Add(this.lblLetraSorteada);
            this.Controls.Add(this.btnSorteio);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soteador de Adedanha";
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Label lblLetraSorteada;
        private System.Windows.Forms.ListBox lstSorteados;
        private System.Windows.Forms.PictureBox spinner;
    }
}

