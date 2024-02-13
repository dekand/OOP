namespace lab2
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
            this.costCalcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coffeeType = new System.Windows.Forms.ComboBox();
            this.countOfCoffee = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.countOfSugar = new System.Windows.Forms.NumericUpDown();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkSugar = new System.Windows.Forms.CheckBox();
            this.cream = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.countOfCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSugar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // costCalcButton
            // 
            this.costCalcButton.Location = new System.Drawing.Point(221, 184);
            this.costCalcButton.Name = "costCalcButton";
            this.costCalcButton.Size = new System.Drawing.Size(93, 41);
            this.costCalcButton.TabIndex = 0;
            this.costCalcButton.Text = "Рассчитать стоимость";
            this.costCalcButton.UseVisualStyleBackColor = true;
            this.costCalcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите вид кофе:";
            // 
            // coffeeType
            // 
            this.coffeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coffeeType.FormattingEnabled = true;
            this.coffeeType.Items.AddRange(new object[] {
            "Американо",
            "Каппучино",
            "Латте",
            "Эспрессо",
            "Раф кофе",
            "Мокко",
            "Марочино"});
            this.coffeeType.Location = new System.Drawing.Point(221, 8);
            this.coffeeType.Name = "coffeeType";
            this.coffeeType.Size = new System.Drawing.Size(168, 21);
            this.coffeeType.TabIndex = 5;
            this.coffeeType.SelectedIndexChanged += new System.EventHandler(this.coffeeType_SelectedIndexChanged);
            // 
            // countOfCoffee
            // 
            this.countOfCoffee.Enabled = false;
            this.countOfCoffee.Location = new System.Drawing.Point(221, 56);
            this.countOfCoffee.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countOfCoffee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countOfCoffee.Name = "countOfCoffee";
            this.countOfCoffee.Size = new System.Drawing.Size(41, 20);
            this.countOfCoffee.TabIndex = 6;
            this.countOfCoffee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество чашек: ";
            // 
            // countOfSugar
            // 
            this.countOfSugar.Enabled = false;
            this.countOfSugar.Location = new System.Drawing.Point(221, 96);
            this.countOfSugar.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.countOfSugar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countOfSugar.Name = "countOfSugar";
            this.countOfSugar.Size = new System.Drawing.Size(40, 20);
            this.countOfSugar.TabIndex = 8;
            this.countOfSugar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPriceText
            // 
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceText.Location = new System.Drawing.Point(8, 154);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(75, 13);
            this.labelPriceText.TabIndex = 10;
            this.labelPriceText.Text = "Стоимость:";
            this.labelPriceText.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPrice.Location = new System.Drawing.Point(221, 154);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 13);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "label4";
            this.labelPrice.Visible = false;
            // 
            // checkSugar
            // 
            this.checkSugar.AutoSize = true;
            this.checkSugar.Location = new System.Drawing.Point(8, 96);
            this.checkSugar.Name = "checkSugar";
            this.checkSugar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkSugar.Size = new System.Drawing.Size(108, 17);
            this.checkSugar.TabIndex = 12;
            this.checkSugar.Text = "Добавить сахар";
            this.checkSugar.UseVisualStyleBackColor = true;
            this.checkSugar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cream
            // 
            this.cream.AutoSize = true;
            this.cream.Location = new System.Drawing.Point(8, 128);
            this.cream.Name = "cream";
            this.cream.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cream.Size = new System.Drawing.Size(115, 17);
            this.cream.TabIndex = 13;
            this.cream.Text = "Добавить сливки";
            this.cream.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.47619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.costCalcButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cream, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPriceText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.coffeeType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.countOfCoffee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkSugar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.countOfSugar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 233);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(397, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кофе";
            ((System.ComponentModel.ISupportInitialize)(this.countOfCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSugar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button costCalcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coffeeType;
        private System.Windows.Forms.NumericUpDown countOfCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countOfSugar;
        private System.Windows.Forms.Label labelPriceText;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkSugar;
        private System.Windows.Forms.CheckBox cream;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

