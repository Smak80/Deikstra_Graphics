
namespace WindowsFormsWorkTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.begSelector = new System.Windows.Forms.NumericUpDown();
            this.endSelector = new System.Windows.Forms.NumericUpDown();
            this.pathResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.begSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите имя файла с матрицей смежности графа:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(13, 34);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(441, 22);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "graf.csv";
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(461, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 24);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Обзор...";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер стартовой верешины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер конечной верешины:";
            // 
            // begSelector
            // 
            this.begSelector.Location = new System.Drawing.Point(222, 63);
            this.begSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.begSelector.Name = "begSelector";
            this.begSelector.Size = new System.Drawing.Size(120, 22);
            this.begSelector.TabIndex = 5;
            this.begSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endSelector
            // 
            this.endSelector.Location = new System.Drawing.Point(222, 96);
            this.endSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endSelector.Name = "endSelector";
            this.endSelector.Size = new System.Drawing.Size(120, 22);
            this.endSelector.TabIndex = 6;
            this.endSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pathResult
            // 
            this.pathResult.FormattingEnabled = true;
            this.pathResult.ItemHeight = 16;
            this.pathResult.Location = new System.Drawing.Point(19, 164);
            this.pathResult.Name = "pathResult";
            this.pathResult.ScrollAlwaysVisible = true;
            this.pathResult.Size = new System.Drawing.Size(157, 84);
            this.pathResult.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Полученный маршрут:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Длина маршрута:";
            // 
            // lengthResult
            // 
            this.lengthResult.Location = new System.Drawing.Point(222, 164);
            this.lengthResult.Name = "lengthResult";
            this.lengthResult.ReadOnly = true;
            this.lengthResult.Size = new System.Drawing.Size(133, 22);
            this.lengthResult.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(368, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Построить маршрут";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 262);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lengthResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathResult);
            this.Controls.Add(this.endSelector);
            this.Controls.Add(this.begSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.begSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown begSelector;
        private System.Windows.Forms.NumericUpDown endSelector;
        private System.Windows.Forms.ListBox pathResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lengthResult;
        private System.Windows.Forms.Button btnStart;
    }
}

