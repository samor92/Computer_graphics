namespace CG_1
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbWindow = new System.Windows.Forms.RadioButton();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.CreatePoligon = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMouseCoord = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.gbMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbMain.Location = new System.Drawing.Point(12, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(670, 471);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 19);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(57, 17);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Линия";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbWindow
            // 
            this.rbWindow.AutoSize = true;
            this.rbWindow.Location = new System.Drawing.Point(6, 42);
            this.rbWindow.Name = "rbWindow";
            this.rbWindow.Size = new System.Drawing.Size(51, 17);
            this.rbWindow.TabIndex = 2;
            this.rbWindow.TabStop = true;
            this.rbWindow.Text = "Окно";
            this.rbWindow.UseVisualStyleBackColor = true;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnClear);
            this.gbMain.Controls.Add(this.btnCut);
            this.gbMain.Controls.Add(this.rbLine);
            this.gbMain.Controls.Add(this.rbWindow);
            this.gbMain.Location = new System.Drawing.Point(688, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(170, 100);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Элементы управления:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(87, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(6, 71);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 3;
            this.btnCut.Text = "Обрубить";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // CreatePoligon
            // 
            this.CreatePoligon.Location = new System.Drawing.Point(688, 118);
            this.CreatePoligon.Name = "CreatePoligon";
            this.CreatePoligon.Size = new System.Drawing.Size(170, 23);
            this.CreatePoligon.TabIndex = 4;
            this.CreatePoligon.Text = "Отрисовать";
            this.CreatePoligon.UseVisualStyleBackColor = true;
            this.CreatePoligon.Click += new System.EventHandler(this.CreatePoligon_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMain,
            this.tsslMouseCoord});
            this.ssMain.Location = new System.Drawing.Point(0, 491);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(870, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslMain
            // 
            this.tsslMain.Name = "tsslMain";
            this.tsslMain.Size = new System.Drawing.Size(137, 17);
            this.tsslMain.Text = "Координаты указателя: ";
            // 
            // tsslMouseCoord
            // 
            this.tsslMouseCoord.Name = "tsslMouseCoord";
            this.tsslMouseCoord.Size = new System.Drawing.Size(12, 17);
            this.tsslMouseCoord.Text = "-";
            this.tsslMouseCoord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 513);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.CreatePoligon);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.pbMain);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbWindow;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button CreatePoligon;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslMouseCoord;
    }
}

