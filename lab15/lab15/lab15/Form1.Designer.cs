namespace lab15
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.преобразоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.source = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.преобразоватьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВToolStripMenuItem
            // 
            this.сохранитьВToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйToolStripMenuItem,
            this.бинарныйToolStripMenuItem});
            this.сохранитьВToolStripMenuItem.Name = "сохранитьВToolStripMenuItem";
            this.сохранитьВToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.сохранитьВToolStripMenuItem.Text = "Сохранить в";
            // 
            // текстовыйToolStripMenuItem
            // 
            this.текстовыйToolStripMenuItem.Name = "текстовыйToolStripMenuItem";
            this.текстовыйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.текстовыйToolStripMenuItem.Text = "Текстовый";
            this.текстовыйToolStripMenuItem.Click += new System.EventHandler(this.текстовыйToolStripMenuItem_Click);
            // 
            // бинарныйToolStripMenuItem
            // 
            this.бинарныйToolStripMenuItem.Name = "бинарныйToolStripMenuItem";
            this.бинарныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.бинарныйToolStripMenuItem.Text = "Бинарный";
            this.бинарныйToolStripMenuItem.Click += new System.EventHandler(this.бинарныйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйToolStripMenuItem1,
            this.бинарныйToolStripMenuItem1});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // текстовыйToolStripMenuItem1
            // 
            this.текстовыйToolStripMenuItem1.Name = "текстовыйToolStripMenuItem1";
            this.текстовыйToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.текстовыйToolStripMenuItem1.Text = "Текстовый";
            this.текстовыйToolStripMenuItem1.Click += new System.EventHandler(this.текстовыйToolStripMenuItem1_Click);
            // 
            // бинарныйToolStripMenuItem1
            // 
            this.бинарныйToolStripMenuItem1.Name = "бинарныйToolStripMenuItem1";
            this.бинарныйToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.бинарныйToolStripMenuItem1.Text = "Бинарный";
            this.бинарныйToolStripMenuItem1.Click += new System.EventHandler(this.бинарныйToolStripMenuItem1_Click);
            // 
            // преобразоватьToolStripMenuItem
            // 
            this.преобразоватьToolStripMenuItem.Name = "преобразоватьToolStripMenuItem";
            this.преобразоватьToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.преобразоватьToolStripMenuItem.Text = "Преобразовать";
            this.преобразоватьToolStripMenuItem.Click += new System.EventHandler(this.преобразоватьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
            this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click);
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(12, 75);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(611, 20);
            this.source.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 132);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(611, 20);
            this.result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Содержимое двоичного файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Содержимое измененного двоичного файла";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "bin";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.source);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Обработка двоичных потоков";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem бинарныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem преобразоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

