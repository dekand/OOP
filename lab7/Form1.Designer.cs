namespace OOP_lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveTeam = new System.Windows.Forms.Button();
            this.resetWin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.takeOne = new System.Windows.Forms.Button();
            this.takeAll = new System.Windows.Forms.Button();
            this.removeOne = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 23);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(165, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.ToolTipText = "Выход из программы";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveTeam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resetWin, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 37);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // saveTeam
            // 
            this.saveTeam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveTeam.Location = new System.Drawing.Point(214, 7);
            this.saveTeam.Name = "saveTeam";
            this.saveTeam.Size = new System.Drawing.Size(75, 23);
            this.saveTeam.TabIndex = 0;
            this.saveTeam.Text = "Save";
            this.saveTeam.UseVisualStyleBackColor = true;
            this.saveTeam.Click += new System.EventHandler(this.saveTeam_Click);
            // 
            // resetWin
            // 
            this.resetWin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetWin.Location = new System.Drawing.Point(295, 7);
            this.resetWin.Name = "resetWin";
            this.resetWin.Size = new System.Drawing.Size(75, 23);
            this.resetWin.TabIndex = 1;
            this.resetWin.Text = "Reset";
            this.resetWin.UseVisualStyleBackColor = true;
            this.resetWin.Click += new System.EventHandler(this.resetWin_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(PlayersClub.getPlayers);
            this.listBox1.Location = new System.Drawing.Point(0, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(261, 301);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(323, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(261, 301);
            this.listBox2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.takeOne, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.takeAll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.removeOne, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.removeAll, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(261, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(62, 301);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // takeOne
            // 
            this.takeOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.takeOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeOne.Location = new System.Drawing.Point(3, 3);
            this.takeOne.Name = "takeOne";
            this.takeOne.Size = new System.Drawing.Size(56, 69);
            this.takeOne.TabIndex = 0;
            this.takeOne.Text = ">";
            this.takeOne.UseVisualStyleBackColor = false;
            this.takeOne.Click += new System.EventHandler(this.takeOne_Click);
            // 
            // takeAll
            // 
            this.takeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.takeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.takeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeAll.Location = new System.Drawing.Point(3, 78);
            this.takeAll.Name = "takeAll";
            this.takeAll.Size = new System.Drawing.Size(56, 69);
            this.takeAll.TabIndex = 1;
            this.takeAll.Text = ">>";
            this.takeAll.UseVisualStyleBackColor = false;
            this.takeAll.Click += new System.EventHandler(this.takeAll_Click);
            // 
            // removeOne
            // 
            this.removeOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeOne.Location = new System.Drawing.Point(3, 153);
            this.removeOne.Name = "removeOne";
            this.removeOne.Size = new System.Drawing.Size(56, 69);
            this.removeOne.TabIndex = 2;
            this.removeOne.Text = "<";
            this.removeOne.UseVisualStyleBackColor = false;
            this.removeOne.Click += new System.EventHandler(this.removeOne_Click);
            // 
            // removeAll
            // 
            this.removeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAll.Location = new System.Drawing.Point(3, 228);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(56, 70);
            this.removeAll.TabIndex = 3;
            this.removeAll.Text = "<<";
            this.removeAll.UseVisualStyleBackColor = false;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "lab7";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveTeam;
        private System.Windows.Forms.Button resetWin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button takeOne;
        private System.Windows.Forms.Button takeAll;
        private System.Windows.Forms.Button removeOne;
        private System.Windows.Forms.Button removeAll;
    }
}

