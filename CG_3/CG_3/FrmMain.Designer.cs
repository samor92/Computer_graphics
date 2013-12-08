namespace CG_3
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
            this.sogMain = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.btnConeSettingsApply = new System.Windows.Forms.Button();
            this.gbConeMain = new System.Windows.Forms.GroupBox();
            this.lbSlices = new System.Windows.Forms.Label();
            this.lbConeRadius = new System.Windows.Forms.Label();
            this.lbConeHight = new System.Windows.Forms.Label();
            this.nupConeSlices = new System.Windows.Forms.NumericUpDown();
            this.nupConeRadius = new System.Windows.Forms.NumericUpDown();
            this.nupConeHeight = new System.Windows.Forms.NumericUpDown();
            this.gbLightMain = new System.Windows.Forms.GroupBox();
            this.lbLightColor = new System.Windows.Forms.Label();
            this.lbLightZ = new System.Windows.Forms.Label();
            this.lbLightY = new System.Windows.Forms.Label();
            this.lbLightX = new System.Windows.Forms.Label();
            this.btnLightSettingsApply = new System.Windows.Forms.Button();
            this.btnLightSelectColor = new System.Windows.Forms.Button();
            this.pbColorPreviewMain = new System.Windows.Forms.PictureBox();
            this.nupLightZ = new System.Windows.Forms.NumericUpDown();
            this.nupLightY = new System.Windows.Forms.NumericUpDown();
            this.nupLightX = new System.Windows.Forms.NumericUpDown();
            this.cdLightMain = new System.Windows.Forms.ColorDialog();
            this.gbConeMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeSlices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeHeight)).BeginInit();
            this.gbLightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPreviewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightX)).BeginInit();
            this.SuspendLayout();
            // 
            // sogMain
            // 
            this.sogMain.AccumBits = ((byte)(0));
            this.sogMain.AutoCheckErrors = false;
            this.sogMain.AutoFinish = false;
            this.sogMain.AutoMakeCurrent = true;
            this.sogMain.AutoScroll = true;
            this.sogMain.AutoSize = true;
            this.sogMain.AutoSwapBuffers = true;
            this.sogMain.BackColor = System.Drawing.Color.Linen;
            this.sogMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sogMain.ColorBits = ((byte)(32));
            this.sogMain.DepthBits = ((byte)(32));
            this.sogMain.Location = new System.Drawing.Point(12, 12);
            this.sogMain.Name = "sogMain";
            this.sogMain.Size = new System.Drawing.Size(726, 552);
            this.sogMain.StencilBits = ((byte)(0));
            this.sogMain.TabIndex = 0;
            this.sogMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sogMain_MouseMove);
            // 
            // btnConeSettingsApply
            // 
            this.btnConeSettingsApply.Location = new System.Drawing.Point(6, 107);
            this.btnConeSettingsApply.Name = "btnConeSettingsApply";
            this.btnConeSettingsApply.Size = new System.Drawing.Size(177, 23);
            this.btnConeSettingsApply.TabIndex = 5;
            this.btnConeSettingsApply.Text = "Применить";
            this.btnConeSettingsApply.UseVisualStyleBackColor = true;
            this.btnConeSettingsApply.Click += new System.EventHandler(this.btnConeSettingsApply_Click);
            // 
            // gbConeMain
            // 
            this.gbConeMain.Controls.Add(this.lbSlices);
            this.gbConeMain.Controls.Add(this.btnConeSettingsApply);
            this.gbConeMain.Controls.Add(this.lbConeRadius);
            this.gbConeMain.Controls.Add(this.lbConeHight);
            this.gbConeMain.Controls.Add(this.nupConeSlices);
            this.gbConeMain.Controls.Add(this.nupConeRadius);
            this.gbConeMain.Controls.Add(this.nupConeHeight);
            this.gbConeMain.Location = new System.Drawing.Point(744, 12);
            this.gbConeMain.Name = "gbConeMain";
            this.gbConeMain.Size = new System.Drawing.Size(189, 136);
            this.gbConeMain.TabIndex = 2;
            this.gbConeMain.TabStop = false;
            this.gbConeMain.Text = "Паремтры конуса:";
            this.gbConeMain.Enter += new System.EventHandler(this.gbConeMain_Enter);
            // 
            // lbSlices
            // 
            this.lbSlices.AutoSize = true;
            this.lbSlices.Location = new System.Drawing.Point(15, 73);
            this.lbSlices.Name = "lbSlices";
            this.lbSlices.Size = new System.Drawing.Size(40, 13);
            this.lbSlices.TabIndex = 9;
            this.lbSlices.Text = "Грани:";
            // 
            // lbConeRadius
            // 
            this.lbConeRadius.AutoSize = true;
            this.lbConeRadius.Location = new System.Drawing.Point(9, 47);
            this.lbConeRadius.Name = "lbConeRadius";
            this.lbConeRadius.Size = new System.Drawing.Size(46, 13);
            this.lbConeRadius.TabIndex = 8;
            this.lbConeRadius.Text = "Радиус:";
            // 
            // lbConeHight
            // 
            this.lbConeHight.AutoSize = true;
            this.lbConeHight.Location = new System.Drawing.Point(7, 21);
            this.lbConeHight.Name = "lbConeHight";
            this.lbConeHight.Size = new System.Drawing.Size(48, 13);
            this.lbConeHight.TabIndex = 7;
            this.lbConeHight.Text = "Высота:";
            // 
            // nupConeSlices
            // 
            this.nupConeSlices.Location = new System.Drawing.Point(61, 71);
            this.nupConeSlices.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupConeSlices.Name = "nupConeSlices";
            this.nupConeSlices.Size = new System.Drawing.Size(120, 20);
            this.nupConeSlices.TabIndex = 4;
            this.nupConeSlices.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nupConeRadius
            // 
            this.nupConeRadius.Location = new System.Drawing.Point(61, 45);
            this.nupConeRadius.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupConeRadius.Name = "nupConeRadius";
            this.nupConeRadius.Size = new System.Drawing.Size(120, 20);
            this.nupConeRadius.TabIndex = 3;
            this.nupConeRadius.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nupConeHeight
            // 
            this.nupConeHeight.Location = new System.Drawing.Point(61, 19);
            this.nupConeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupConeHeight.Name = "nupConeHeight";
            this.nupConeHeight.Size = new System.Drawing.Size(120, 20);
            this.nupConeHeight.TabIndex = 2;
            this.nupConeHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbLightMain
            // 
            this.gbLightMain.Controls.Add(this.lbLightColor);
            this.gbLightMain.Controls.Add(this.lbLightZ);
            this.gbLightMain.Controls.Add(this.lbLightY);
            this.gbLightMain.Controls.Add(this.lbLightX);
            this.gbLightMain.Controls.Add(this.btnLightSettingsApply);
            this.gbLightMain.Controls.Add(this.btnLightSelectColor);
            this.gbLightMain.Controls.Add(this.pbColorPreviewMain);
            this.gbLightMain.Controls.Add(this.nupLightZ);
            this.gbLightMain.Controls.Add(this.nupLightY);
            this.gbLightMain.Controls.Add(this.nupLightX);
            this.gbLightMain.Location = new System.Drawing.Point(744, 163);
            this.gbLightMain.Name = "gbLightMain";
            this.gbLightMain.Size = new System.Drawing.Size(189, 173);
            this.gbLightMain.TabIndex = 3;
            this.gbLightMain.TabStop = false;
            this.gbLightMain.Text = "Парамерты освещения:";
            this.gbLightMain.Enter += new System.EventHandler(this.gbLightMain_Enter);
            // 
            // lbLightColor
            // 
            this.lbLightColor.AutoSize = true;
            this.lbLightColor.Location = new System.Drawing.Point(15, 107);
            this.lbLightColor.Name = "lbLightColor";
            this.lbLightColor.Size = new System.Drawing.Size(35, 13);
            this.lbLightColor.TabIndex = 16;
            this.lbLightColor.Text = "Цвет:";
            // 
            // lbLightZ
            // 
            this.lbLightZ.AutoSize = true;
            this.lbLightZ.Location = new System.Drawing.Point(33, 78);
            this.lbLightZ.Name = "lbLightZ";
            this.lbLightZ.Size = new System.Drawing.Size(17, 13);
            this.lbLightZ.TabIndex = 15;
            this.lbLightZ.Text = "Z:";
            // 
            // lbLightY
            // 
            this.lbLightY.AutoSize = true;
            this.lbLightY.Location = new System.Drawing.Point(33, 52);
            this.lbLightY.Name = "lbLightY";
            this.lbLightY.Size = new System.Drawing.Size(17, 13);
            this.lbLightY.TabIndex = 14;
            this.lbLightY.Text = "Y:";
            // 
            // lbLightX
            // 
            this.lbLightX.AutoSize = true;
            this.lbLightX.Location = new System.Drawing.Point(33, 26);
            this.lbLightX.Name = "lbLightX";
            this.lbLightX.Size = new System.Drawing.Size(17, 13);
            this.lbLightX.TabIndex = 13;
            this.lbLightX.Text = "X:";
            // 
            // btnLightSettingsApply
            // 
            this.btnLightSettingsApply.Location = new System.Drawing.Point(6, 144);
            this.btnLightSettingsApply.Name = "btnLightSettingsApply";
            this.btnLightSettingsApply.Size = new System.Drawing.Size(177, 23);
            this.btnLightSettingsApply.TabIndex = 10;
            this.btnLightSettingsApply.Text = "Применить";
            this.btnLightSettingsApply.UseVisualStyleBackColor = true;
            this.btnLightSettingsApply.Click += new System.EventHandler(this.btnLightSettingsApply_Click);
            // 
            // btnLightSelectColor
            // 
            this.btnLightSelectColor.Location = new System.Drawing.Point(108, 102);
            this.btnLightSelectColor.Name = "btnLightSelectColor";
            this.btnLightSelectColor.Size = new System.Drawing.Size(75, 23);
            this.btnLightSelectColor.TabIndex = 9;
            this.btnLightSelectColor.Text = "Изменить";
            this.btnLightSelectColor.UseVisualStyleBackColor = true;
            this.btnLightSelectColor.Click += new System.EventHandler(this.btnLightSelectColor_Click);
            // 
            // pbColorPreviewMain
            // 
            this.pbColorPreviewMain.BackColor = System.Drawing.Color.Cyan;
            this.pbColorPreviewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColorPreviewMain.Location = new System.Drawing.Point(63, 102);
            this.pbColorPreviewMain.Name = "pbColorPreviewMain";
            this.pbColorPreviewMain.Size = new System.Drawing.Size(39, 23);
            this.pbColorPreviewMain.TabIndex = 10;
            this.pbColorPreviewMain.TabStop = false;
            // 
            // nupLightZ
            // 
            this.nupLightZ.Location = new System.Drawing.Point(63, 76);
            this.nupLightZ.Name = "nupLightZ";
            this.nupLightZ.Size = new System.Drawing.Size(120, 20);
            this.nupLightZ.TabIndex = 8;
            // 
            // nupLightY
            // 
            this.nupLightY.Location = new System.Drawing.Point(63, 50);
            this.nupLightY.Name = "nupLightY";
            this.nupLightY.Size = new System.Drawing.Size(120, 20);
            this.nupLightY.TabIndex = 7;
            // 
            // nupLightX
            // 
            this.nupLightX.Location = new System.Drawing.Point(63, 24);
            this.nupLightX.Name = "nupLightX";
            this.nupLightX.Size = new System.Drawing.Size(120, 20);
            this.nupLightX.TabIndex = 6;
            // 
            // cdLightMain
            // 
            this.cdLightMain.Color = System.Drawing.Color.Cyan;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 576);
            this.Controls.Add(this.gbLightMain);
            this.Controls.Add(this.gbConeMain);
            this.Controls.Add(this.sogMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Задача 3";
            this.gbConeMain.ResumeLayout(false);
            this.gbConeMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeSlices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupConeHeight)).EndInit();
            this.gbLightMain.ResumeLayout(false);
            this.gbLightMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPreviewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLightX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl sogMain;
        private System.Windows.Forms.Button btnConeSettingsApply;
        private System.Windows.Forms.GroupBox gbConeMain;
        private System.Windows.Forms.Label lbSlices;
        private System.Windows.Forms.Label lbConeRadius;
        private System.Windows.Forms.Label lbConeHight;
        private System.Windows.Forms.NumericUpDown nupConeSlices;
        private System.Windows.Forms.NumericUpDown nupConeRadius;
        private System.Windows.Forms.NumericUpDown nupConeHeight;
        private System.Windows.Forms.GroupBox gbLightMain;
        private System.Windows.Forms.Button btnLightSettingsApply;
        private System.Windows.Forms.Button btnLightSelectColor;
        private System.Windows.Forms.PictureBox pbColorPreviewMain;
        private System.Windows.Forms.NumericUpDown nupLightZ;
        private System.Windows.Forms.NumericUpDown nupLightY;
        private System.Windows.Forms.NumericUpDown nupLightX;
        private System.Windows.Forms.ColorDialog cdLightMain;
        private System.Windows.Forms.Label lbLightColor;
        private System.Windows.Forms.Label lbLightZ;
        private System.Windows.Forms.Label lbLightY;
        private System.Windows.Forms.Label lbLightX;
    }
}

