
namespace Lab28
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
            this.panel1.Size = new System.Drawing.Size(324, 32);
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
            this.button1.Location = new System.Drawing.Point(287, 0);
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
            this.Slovar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Slovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Slovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUA,
            this.ColumnENG});
            this.Slovar.Location = new System.Drawing.Point(12, 38);
            this.Slovar.Name = "Slovar";
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
            this.ColumnUA.Width = 130;
            // 
            // ColumnENG
            // 
            this.ColumnENG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnENG.Frozen = true;
            this.ColumnENG.HeaderText = "Англійське слово";
            this.ColumnENG.MinimumWidth = 130;
            this.ColumnENG.Name = "ColumnENG";
            this.ColumnENG.Width = 130;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(13, 263);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(134, 20);
            this.textBoxStart.TabIndex = 2;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Переклад";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(178, 302);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.ReadOnly = true;
            this.textBoxFinal.Size = new System.Drawing.Size(134, 20);
            this.textBoxFinal.TabIndex = 4;
            // 
            // labelPodsk
            // 
            this.labelPodsk.AutoSize = true;
            this.labelPodsk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPodsk.Location = new System.Drawing.Point(153, 266);
            this.labelPodsk.Name = "labelPodsk";
            this.labelPodsk.Size = new System.Drawing.Size(131, 13);
            this.labelPodsk.TabIndex = 5;
            this.labelPodsk.Text = "Почніть вводити слово...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
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
            this.labelPodskazka.Location = new System.Drawing.Point(15, 312);
            this.labelPodskazka.Name = "labelPodskazka";
            this.labelPodskazka.Size = new System.Drawing.Size(37, 13);
            this.labelPodskazka.TabIndex = 7;
            this.labelPodskazka.Text = "Текст";
            this.labelPodskazka.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 333);
            this.Controls.Add(this.labelPodskazka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPodsk);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.Slovar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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
    }
}

