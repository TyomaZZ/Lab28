
namespace Lab28
{
    partial class Form12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Slovar = new System.Windows.Forms.DataGridView();
            this.ColumnUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.labelPodsk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPodskazka = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slovar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 32);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(449, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Х";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перекладач";
            // 
            // Slovar
            // 
            this.Slovar.AllowUserToAddRows = false;
            this.Slovar.AllowUserToDeleteRows = false;
            this.Slovar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Slovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Slovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUA,
            this.ColumnENG});
            this.Slovar.Location = new System.Drawing.Point(12, 38);
            this.Slovar.Name = "Slovar";
            this.Slovar.ReadOnly = true;
            this.Slovar.Size = new System.Drawing.Size(300, 218);
            this.Slovar.TabIndex = 1;
            // 
            // ColumnUA
            // 
            this.ColumnUA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnUA.Frozen = true;
            this.ColumnUA.HeaderText = "Українське слово";
            this.ColumnUA.MinimumWidth = 130;
            this.ColumnUA.Name = "ColumnUA";
            this.ColumnUA.ReadOnly = true;
            this.ColumnUA.Width = 130;
            // 
            // ColumnENG
            // 
            this.ColumnENG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnENG.Frozen = true;
            this.ColumnENG.HeaderText = "Англійське слово";
            this.ColumnENG.MinimumWidth = 130;
            this.ColumnENG.Name = "ColumnENG";
            this.ColumnENG.ReadOnly = true;
            this.ColumnENG.Width = 130;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(13, 263);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(197, 20);
            this.textBoxStart.TabIndex = 2;
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Переклад";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.BackColor = System.Drawing.Color.White;
            this.textBoxFinal.Location = new System.Drawing.Point(279, 263);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.ReadOnly = true;
            this.textBoxFinal.Size = new System.Drawing.Size(195, 20);
            this.textBoxFinal.TabIndex = 4;
            this.textBoxFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPodsk
            // 
            this.labelPodsk.AutoSize = true;
            this.labelPodsk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPodsk.Location = new System.Drawing.Point(16, 286);
            this.labelPodsk.Name = "labelPodsk";
            this.labelPodsk.Size = new System.Drawing.Size(131, 13);
            this.labelPodsk.TabIndex = 5;
            this.labelPodsk.Text = "Почніть вводити слово...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Можливо ви шукали:";
            this.label4.Visible = false;
            // 
            // labelPodskazka
            // 
            this.labelPodskazka.AutoSize = true;
            this.labelPodskazka.ForeColor = System.Drawing.Color.Blue;
            this.labelPodskazka.Location = new System.Drawing.Point(125, 299);
            this.labelPodskazka.Name = "labelPodskazka";
            this.labelPodskazka.Size = new System.Drawing.Size(37, 13);
            this.labelPodskazka.TabIndex = 7;
            this.labelPodskazka.Text = "Текст";
            this.labelPodskazka.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(319, 39);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(319, 68);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(319, 97);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(155, 23);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Видалити";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(314, 165);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 52);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2Lang\r\nTRANSLATOR\r\n";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 333);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPodskazka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPodsk);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.Slovar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перекладач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Slovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnENG;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Label labelPodsk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPodskazka;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

