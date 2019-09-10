namespace aula_6
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aplicativos = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstbtWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtexcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtCalculadora = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtExit = new System.Windows.Forms.ToolStripButton();
            this.processo = new System.Diagnostics.Process();
            this.Aplicativos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aplicativos
            // 
            this.Aplicativos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.Aplicativos.Location = new System.Drawing.Point(0, 0);
            this.Aplicativos.Name = "Aplicativos";
            this.Aplicativos.Size = new System.Drawing.Size(490, 31);
            this.Aplicativos.TabIndex = 0;
            this.Aplicativos.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 27);
            this.toolStripMenuItem1.Text = "&Aplicativos";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 28);
            this.toolStripMenuItem4.Text = "Programa 4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 27);
            this.toolStripMenuItem2.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(54, 27);
            this.ToolStripMenuItem3.Text = "&Sair";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstbtWord,
            this.toolStripbtexcel,
            this.toolStripBtCalculadora,
            this.toolStripBtExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(53, 544);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstbtWord
            // 
            this.toolstbtWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstbtWord.Image = global::aula_6.Properties.Resources.wordicon;
            this.toolstbtWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolstbtWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstbtWord.Name = "toolstbtWord";
            this.toolstbtWord.Size = new System.Drawing.Size(50, 52);
            this.toolstbtWord.Text = "toolStripButton1";
            this.toolstbtWord.Click += new System.EventHandler(this.toolstbtWord_Click);
            // 
            // toolStripbtexcel
            // 
            this.toolStripbtexcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtexcel.Image = global::aula_6.Properties.Resources.excelicon;
            this.toolStripbtexcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtexcel.Name = "toolStripbtexcel";
            this.toolStripbtexcel.Size = new System.Drawing.Size(50, 52);
            this.toolStripbtexcel.Text = "toolStripButton2";
            this.toolStripbtexcel.Click += new System.EventHandler(this.toolStripbtexcel_Click);
            // 
            // toolStripBtCalculadora
            // 
            this.toolStripBtCalculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtCalculadora.Image = global::aula_6.Properties.Resources.calculadoraicon;
            this.toolStripBtCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtCalculadora.Name = "toolStripBtCalculadora";
            this.toolStripBtCalculadora.Size = new System.Drawing.Size(50, 52);
            this.toolStripBtCalculadora.Text = "toolStripButton3";
            this.toolStripBtCalculadora.Click += new System.EventHandler(this.toolStripBtCalculadora_Click);
            // 
            // toolStripBtExit
            // 
            this.toolStripBtExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtExit.Image = global::aula_6.Properties.Resources.exit;
            this.toolStripBtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtExit.Name = "toolStripBtExit";
            this.toolStripBtExit.Size = new System.Drawing.Size(50, 52);
            this.toolStripBtExit.Text = "toolStripButton4";
            this.toolStripBtExit.Click += new System.EventHandler(this.toolStripBtExit_Click);
            // 
            // processo
            // 
            this.processo.StartInfo.Domain = "";
            this.processo.StartInfo.LoadUserProfile = false;
            this.processo.StartInfo.Password = null;
            this.processo.StartInfo.StandardErrorEncoding = null;
            this.processo.StartInfo.StandardOutputEncoding = null;
            this.processo.StartInfo.UserName = "";
            this.processo.SynchronizingObject = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(490, 575);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Aplicativos);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Aplicativos.ResumeLayout(false);
            this.Aplicativos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Aplicativos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstbtWord;
        private System.Windows.Forms.ToolStripButton toolStripbtexcel;
        private System.Windows.Forms.ToolStripButton toolStripBtCalculadora;
        private System.Windows.Forms.ToolStripButton toolStripBtExit;
        private System.Diagnostics.Process processo;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

