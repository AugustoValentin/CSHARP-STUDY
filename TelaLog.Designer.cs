namespace aula_6
{
    partial class TelaLog
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
            this.lblLoguin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoguin
            // 
            this.lblLoguin.AutoSize = true;
            this.lblLoguin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoguin.Location = new System.Drawing.Point(62, 52);
            this.lblLoguin.Name = "lblLoguin";
            this.lblLoguin.Size = new System.Drawing.Size(61, 20);
            this.lblLoguin.TabIndex = 0;
            this.lblLoguin.Text = "Loguin:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(63, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(117, 137);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Location = new System.Drawing.Point(224, 137);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(126, 52);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(189, 20);
            this.txtLog.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(126, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(189, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // TelaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 207);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLoguin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.Load += new System.EventHandler(this.TelaLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoguin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtSenha;
    }
}