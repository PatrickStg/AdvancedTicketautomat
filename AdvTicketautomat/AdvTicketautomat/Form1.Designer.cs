
namespace AdvTicketautomat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelH = new System.Windows.Forms.Label();
            this.textH = new System.Windows.Forms.TextBox();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textL = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.listTickets = new System.Windows.Forms.ListBox();
            this.labelTickets = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonAuf = new System.Windows.Forms.Button();
            this.buttonAb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(73, 310);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(129, 13);
            this.labelH.TabIndex = 0;
            this.labelH.Text = "Ticket hinzufügen (Name)";
            this.labelH.Click += new System.EventHandler(this.labelH_Click);
            // 
            // textH
            // 
            this.textH.Location = new System.Drawing.Point(76, 326);
            this.textH.Name = "textH";
            this.textH.Size = new System.Drawing.Size(124, 20);
            this.textH.TabIndex = 1;
            this.textH.TextChanged += new System.EventHandler(this.textH_TextChanged);
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(323, 326);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(113, 20);
            this.textB1.TabIndex = 3;
            this.textB1.TextChanged += new System.EventHandler(this.textB1_TextChanged);
            // 
            // textL
            // 
            this.textL.Location = new System.Drawing.Point(569, 326);
            this.textL.Name = "textL";
            this.textL.Size = new System.Drawing.Size(74, 20);
            this.textL.TabIndex = 4;
            this.textL.TextChanged += new System.EventHandler(this.textL_TextChanged);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(309, 310);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(142, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "Ticket bearbeiten (Id, Name)";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(565, 310);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(95, 13);
            this.labelL.TabIndex = 6;
            this.labelL.Text = "Ticket löschen (Id)";
            this.labelL.Click += new System.EventHandler(this.labelL_Click);
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(323, 352);
            this.textB2.Name = "textB2";
            this.textB2.Size = new System.Drawing.Size(113, 20);
            this.textB2.TabIndex = 7;
            this.textB2.TextChanged += new System.EventHandler(this.textB2_TextChanged);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(95, 352);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(75, 23);
            this.buttonH.TabIndex = 8;
            this.buttonH.Text = "hinzufügen";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(336, 378);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 23);
            this.buttonB.TabIndex = 9;
            this.buttonB.Text = "updaten";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(568, 352);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(75, 23);
            this.buttonL.TabIndex = 10;
            this.buttonL.Text = "löschen";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // listTickets
            // 
            this.listTickets.FormattingEnabled = true;
            this.listTickets.Location = new System.Drawing.Point(182, 102);
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(415, 95);
            this.listTickets.TabIndex = 11;
            this.listTickets.SelectedIndexChanged += new System.EventHandler(this.listTickets_SelectedIndexChanged);
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Location = new System.Drawing.Point(369, 86);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(42, 13);
            this.labelTickets.TabIndex = 12;
            this.labelTickets.Text = "Tickets";
            this.labelTickets.Click += new System.EventHandler(this.labelTickets_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(348, 203);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 23);
            this.buttonA.TabIndex = 13;
            this.buttonA.Text = "aktualisieren";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonAuf
            // 
            this.buttonAuf.Location = new System.Drawing.Point(603, 128);
            this.buttonAuf.Name = "buttonAuf";
            this.buttonAuf.Size = new System.Drawing.Size(75, 23);
            this.buttonAuf.TabIndex = 14;
            this.buttonAuf.Text = "aufsteigend";
            this.buttonAuf.UseVisualStyleBackColor = true;
            this.buttonAuf.Click += new System.EventHandler(this.buttonAuf_Click);
            // 
            // buttonAb
            // 
            this.buttonAb.Location = new System.Drawing.Point(603, 157);
            this.buttonAb.Name = "buttonAb";
            this.buttonAb.Size = new System.Drawing.Size(75, 23);
            this.buttonAb.TabIndex = 15;
            this.buttonAb.Text = "absteigend";
            this.buttonAb.UseVisualStyleBackColor = true;
            this.buttonAb.Click += new System.EventHandler(this.buttonAb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAb);
            this.Controls.Add(this.buttonAuf);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.labelTickets);
            this.Controls.Add(this.listTickets);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.textB2);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textL);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.textH);
            this.Controls.Add(this.labelH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox textH;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textL;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.ListBox listTickets;
        private System.Windows.Forms.Label labelTickets;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonAuf;
        private System.Windows.Forms.Button buttonAb;
    }
}

