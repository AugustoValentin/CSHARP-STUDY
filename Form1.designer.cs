namespace aula_6
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdLimparTodos = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.lblPosLista = new System.Windows.Forms.Label();
            this.lblTextoSel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite um texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(109, 20);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(345, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(26, 74);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(497, 225);
            this.lstBox.TabIndex = 2;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 336);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Posição na lista:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(13, 371);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(97, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Texto selecionado:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(13, 407);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(74, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Total de itens:";
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.Location = new System.Drawing.Point(618, 74);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(75, 23);
            this.cmdAdicionar.TabIndex = 11;
            this.cmdAdicionar.Text = "Adicionar";
            this.cmdAdicionar.UseVisualStyleBackColor = true;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(618, 127);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 12;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdLimparTodos
            // 
            this.cmdLimparTodos.Location = new System.Drawing.Point(618, 183);
            this.cmdLimparTodos.Name = "cmdLimparTodos";
            this.cmdLimparTodos.Size = new System.Drawing.Size(75, 37);
            this.cmdLimparTodos.TabIndex = 13;
            this.cmdLimparTodos.Text = "Limpar todos os itens";
            this.cmdLimparTodos.UseVisualStyleBackColor = true;
            this.cmdLimparTodos.Click += new System.EventHandler(this.cmdLimparTodos_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(618, 254);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 14;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(618, 397);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 15;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lblPosLista
            // 
            this.lblPosLista.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPosLista.Location = new System.Drawing.Point(132, 336);
            this.lblPosLista.Name = "lblPosLista";
            this.lblPosLista.Size = new System.Drawing.Size(237, 23);
            this.lblPosLista.TabIndex = 16;
            this.lblPosLista.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTextoSel
            // 
            this.lblTextoSel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTextoSel.Location = new System.Drawing.Point(132, 370);
            this.lblTextoSel.Name = "lblTextoSel";
            this.lblTextoSel.Size = new System.Drawing.Size(237, 23);
            this.lblTextoSel.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotal.Location = new System.Drawing.Point(132, 407);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(237, 23);
            this.lblTotal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTextoSel);
            this.Controls.Add(this.lblPosLista);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.cmdLimparTodos);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAdicionar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdLimparTodos;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Label lblPosLista;
        private System.Windows.Forms.Label lblTextoSel;
        private System.Windows.Forms.Label lblTotal;
    }
}

