namespace SessionPlayer.MainViews
{
    partial class MainView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRef = new System.Windows.Forms.Button();
            this.textBoxFilepath = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAccelationlZ = new System.Windows.Forms.Label();
            this.labelAccelationlY = new System.Windows.Forms.Label();
            this.labelAccelationlX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarPower = new System.Windows.Forms.ProgressBar();
            this.groupBoxGroove = new System.Windows.Forms.GroupBox();
            this.progressBarGroove = new System.Windows.Forms.ProgressBar();
            this.groupBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.groupBoxSerialPort = new System.Windows.Forms.GroupBox();
            this.buttonPortUpdate = new System.Windows.Forms.Button();
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGroove.SuspendLayout();
            this.groupBoxSelectFile.SuspendLayout();
            this.groupBoxSerialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(514, 27);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(87, 29);
            this.buttonRef.TabIndex = 0;
            this.buttonRef.Text = "参照...";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // textBoxFilepath
            // 
            this.textBoxFilepath.Location = new System.Drawing.Point(6, 27);
            this.textBoxFilepath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFilepath.Name = "textBoxFilepath";
            this.textBoxFilepath.ReadOnly = true;
            this.textBoxFilepath.Size = new System.Drawing.Size(502, 27);
            this.textBoxFilepath.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPlay.Location = new System.Drawing.Point(333, 272);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(138, 72);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "再生";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DtrEnable = true;
            this.serialPort.RtsEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTwe_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelAccelationlZ);
            this.groupBox1.Controls.Add(this.labelAccelationlY);
            this.groupBox1.Controls.Add(this.labelAccelationlX);
            this.groupBox1.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(16, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(302, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加速度";
            // 
            // labelAccelationlZ
            // 
            this.labelAccelationlZ.AutoSize = true;
            this.labelAccelationlZ.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAccelationlZ.Location = new System.Drawing.Point(7, 56);
            this.labelAccelationlZ.Name = "labelAccelationlZ";
            this.labelAccelationlZ.Size = new System.Drawing.Size(27, 16);
            this.labelAccelationlZ.TabIndex = 8;
            this.labelAccelationlZ.Text = "Z：";
            // 
            // labelAccelationlY
            // 
            this.labelAccelationlY.AutoSize = true;
            this.labelAccelationlY.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAccelationlY.Location = new System.Drawing.Point(7, 40);
            this.labelAccelationlY.Name = "labelAccelationlY";
            this.labelAccelationlY.Size = new System.Drawing.Size(28, 16);
            this.labelAccelationlY.TabIndex = 7;
            this.labelAccelationlY.Text = "Y：";
            // 
            // labelAccelationlX
            // 
            this.labelAccelationlX.AutoSize = true;
            this.labelAccelationlX.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAccelationlX.Location = new System.Drawing.Point(7, 24);
            this.labelAccelationlX.Name = "labelAccelationlX";
            this.labelAccelationlX.Size = new System.Drawing.Size(28, 16);
            this.labelAccelationlX.TabIndex = 6;
            this.labelAccelationlX.Text = "X：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.progressBarPower);
            this.groupBox2.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(16, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(607, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "パワー";
            // 
            // progressBarPower
            // 
            this.progressBarPower.ForeColor = System.Drawing.Color.Goldenrod;
            this.progressBarPower.Location = new System.Drawing.Point(8, 24);
            this.progressBarPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarPower.Name = "progressBarPower";
            this.progressBarPower.Size = new System.Drawing.Size(591, 16);
            this.progressBarPower.TabIndex = 0;
            // 
            // groupBoxGroove
            // 
            this.groupBoxGroove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGroove.Controls.Add(this.progressBarGroove);
            this.groupBoxGroove.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxGroove.Location = new System.Drawing.Point(16, 156);
            this.groupBoxGroove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxGroove.Name = "groupBoxGroove";
            this.groupBoxGroove.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxGroove.Size = new System.Drawing.Size(607, 48);
            this.groupBoxGroove.TabIndex = 7;
            this.groupBoxGroove.TabStop = false;
            this.groupBoxGroove.Text = "グルーヴ";
            // 
            // progressBarGroove
            // 
            this.progressBarGroove.Location = new System.Drawing.Point(8, 24);
            this.progressBarGroove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarGroove.Name = "progressBarGroove";
            this.progressBarGroove.Size = new System.Drawing.Size(591, 16);
            this.progressBarGroove.TabIndex = 0;
            // 
            // groupBoxSelectFile
            // 
            this.groupBoxSelectFile.Controls.Add(this.textBoxFilepath);
            this.groupBoxSelectFile.Controls.Add(this.buttonRef);
            this.groupBoxSelectFile.Location = new System.Drawing.Point(16, 24);
            this.groupBoxSelectFile.Name = "groupBoxSelectFile";
            this.groupBoxSelectFile.Size = new System.Drawing.Size(607, 66);
            this.groupBoxSelectFile.TabIndex = 9;
            this.groupBoxSelectFile.TabStop = false;
            this.groupBoxSelectFile.Text = "再生するMP3ファイル";
            // 
            // groupBoxSerialPort
            // 
            this.groupBoxSerialPort.Controls.Add(this.buttonPortUpdate);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxSerialPorts);
            this.groupBoxSerialPort.Location = new System.Drawing.Point(16, 96);
            this.groupBoxSerialPort.Name = "groupBoxSerialPort";
            this.groupBoxSerialPort.Size = new System.Drawing.Size(607, 53);
            this.groupBoxSerialPort.TabIndex = 10;
            this.groupBoxSerialPort.TabStop = false;
            this.groupBoxSerialPort.Text = "シリアルポート接続";
            // 
            // buttonPortUpdate
            // 
            this.buttonPortUpdate.Location = new System.Drawing.Point(514, 20);
            this.buttonPortUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPortUpdate.Name = "buttonPortUpdate";
            this.buttonPortUpdate.Size = new System.Drawing.Size(87, 29);
            this.buttonPortUpdate.TabIndex = 2;
            this.buttonPortUpdate.Text = "更新";
            this.buttonPortUpdate.UseVisualStyleBackColor = true;
            this.buttonPortUpdate.Click += new System.EventHandler(this.buttonPortUpdate_Click);
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(6, 23);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(502, 24);
            this.comboBoxSerialPorts.TabIndex = 0;
            this.comboBoxSerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPorts_SelectedIndexChanged);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestart.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRestart.Location = new System.Drawing.Point(477, 272);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(138, 72);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "最初から";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 357);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.groupBoxSerialPort);
            this.Controls.Add(this.groupBoxSelectFile);
            this.Controls.Add(this.groupBoxGroove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPlay);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "空杓琴";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxGroove.ResumeLayout(false);
            this.groupBoxSelectFile.ResumeLayout(false);
            this.groupBoxSelectFile.PerformLayout();
            this.groupBoxSerialPort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.TextBox textBoxFilepath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAccelationlZ;
        private System.Windows.Forms.Label labelAccelationlY;
        private System.Windows.Forms.Label labelAccelationlX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBarPower;
        private System.Windows.Forms.GroupBox groupBoxGroove;
        private System.Windows.Forms.ProgressBar progressBarGroove;
        private System.Windows.Forms.GroupBox groupBoxSelectFile;
        private System.Windows.Forms.GroupBox groupBoxSerialPort;
        private System.Windows.Forms.Button buttonPortUpdate;
        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.Button buttonRestart;
    }
}

