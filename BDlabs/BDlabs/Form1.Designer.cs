namespace BDlabs
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЕдыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЕдуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЕдуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantsDataSet = new BDlabs.PlantsDataSet();
            this.foodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdlabsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButt = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.plantsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantsTableAdapter = new BDlabs.PlantsDataSetTableAdapters.PlantsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TestInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdlabsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрДанныхToolStripMenuItem,
            this.создатьЕдуToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрДанныхToolStripMenuItem
            // 
            this.просмотрДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеToolStripMenuItem,
            this.списокЕдыToolStripMenuItem});
            this.просмотрДанныхToolStripMenuItem.Name = "просмотрДанныхToolStripMenuItem";
            this.просмотрДанныхToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.просмотрДанныхToolStripMenuItem.Text = "Інформація";
            this.просмотрДанныхToolStripMenuItem.Click += new System.EventHandler(this.просмотрДанныхToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.расписаниеToolStripMenuItem.Text = "Усі рослини";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // списокЕдыToolStripMenuItem
            // 
            this.списокЕдыToolStripMenuItem.Name = "списокЕдыToolStripMenuItem";
            this.списокЕдыToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.списокЕдыToolStripMenuItem.Text = "Продивитись партії";
            this.списокЕдыToolStripMenuItem.Click += new System.EventHandler(this.списокЕдыToolStripMenuItem_Click);
            // 
            // создатьЕдуToolStripMenuItem
            // 
            this.создатьЕдуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЕдуToolStripMenuItem1,
            this.создатьРасписаниеToolStripMenuItem});
            this.создатьЕдуToolStripMenuItem.Name = "создатьЕдуToolStripMenuItem";
            this.создатьЕдуToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.создатьЕдуToolStripMenuItem.Text = "Створити";
            // 
            // создатьЕдуToolStripMenuItem1
            // 
            this.создатьЕдуToolStripMenuItem1.Name = "создатьЕдуToolStripMenuItem1";
            this.создатьЕдуToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.создатьЕдуToolStripMenuItem1.Text = "Створити рослину";
            this.создатьЕдуToolStripMenuItem1.Click += new System.EventHandler(this.создатьЕдуToolStripMenuItem1_Click);
            // 
            // создатьРасписаниеToolStripMenuItem
            // 
            this.создатьРасписаниеToolStripMenuItem.Name = "создатьРасписаниеToolStripMenuItem";
            this.создатьРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.создатьРасписаниеToolStripMenuItem.Text = "Створити партію";
            this.создатьРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.создатьРасписаниеToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.удалитьToolStripMenuItem.Text = "Видалити";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.plantsBindingSource;
            this.comboBox1.DisplayMember = "plantName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(618, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id_plants";
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.plantsDataSet;
            // 
            // plantsDataSet
            // 
            this.plantsDataSet.DataSetName = "PlantsDataSet";
            this.plantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBindingSource1
            // 
            this.foodBindingSource1.DataMember = "Food";
            this.foodBindingSource1.DataSource = this.bdlabsDataSet1BindingSource;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            // 
            // searchButt
            // 
            this.searchButt.Location = new System.Drawing.Point(228, 40);
            this.searchButt.Margin = new System.Windows.Forms.Padding(4);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(100, 28);
            this.searchButt.TabIndex = 6;
            this.searchButt.Text = "Пошук";
            this.searchButt.UseVisualStyleBackColor = true;
            this.searchButt.Click += new System.EventHandler(this.searchButt_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(20, 42);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(169, 22);
            this.searchbox.TabIndex = 5;
            // 
            // plantsDataSetBindingSource
            // 
            this.plantsDataSetBindingSource.DataSource = this.plantsDataSet;
            this.plantsDataSetBindingSource.Position = 0;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1100, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Do SQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestInput
            // 
            this.TestInput.Location = new System.Drawing.Point(785, 70);
            this.TestInput.Margin = new System.Windows.Forms.Padding(4);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(415, 94);
            this.TestInput.TabIndex = 20;
            this.TestInput.Text = "SELECT";
            this.TestInput.TextChanged += new System.EventHandler(this.TestInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TestInput);
            this.Controls.Add(this.searchButt);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьЕдуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЕдуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЕдыToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.BindingSource bdlabsDataSet1BindingSource;
        private System.Windows.Forms.BindingSource foodBindingSource1;
        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.BindingSource plantsDataSetBindingSource;
        private PlantsDataSet plantsDataSet;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private PlantsDataSetTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TestInput;
    }
}

