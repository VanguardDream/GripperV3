namespace Demo_EposCmd
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAOM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_limitcurrent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_final_angle = new System.Windows.Forms.TextBox();
            this.hs_fine = new System.Windows.Forms.HScrollBar();
            this.tb_motor4 = new System.Windows.Forms.TextBox();
            this.tb_motor3 = new System.Windows.Forms.TextBox();
            this.tb_motor2 = new System.Windows.Forms.TextBox();
            this.tb_motor1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAbsoluteMove = new System.Windows.Forms.RadioButton();
            this.radioButtonRelativeMode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTargetPosition = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPositionActualValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPositionStart = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonHalt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonGrasp = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAOM);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(415, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Operation Mode:";
            // 
            // textBoxAOM
            // 
            this.textBoxAOM.Location = new System.Drawing.Point(161, 33);
            this.textBoxAOM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAOM.Name = "textBoxAOM";
            this.textBoxAOM.ReadOnly = true;
            this.textBoxAOM.Size = new System.Drawing.Size(198, 21);
            this.textBoxAOM.TabIndex = 0;
            this.textBoxAOM.Text = "Unknown";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_limitcurrent);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_final_angle);
            this.groupBox2.Controls.Add(this.hs_fine);
            this.groupBox2.Controls.Add(this.tb_motor4);
            this.groupBox2.Controls.Add(this.tb_motor3);
            this.groupBox2.Controls.Add(this.tb_motor2);
            this.groupBox2.Controls.Add(this.tb_motor1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonAbsoluteMove);
            this.groupBox2.Controls.Add(this.radioButtonRelativeMode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTargetPosition);
            this.groupBox2.Location = new System.Drawing.Point(14, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(415, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grasp Control";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "mA";
            // 
            // tb_limitcurrent
            // 
            this.tb_limitcurrent.Location = new System.Drawing.Point(102, 110);
            this.tb_limitcurrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_limitcurrent.Name = "tb_limitcurrent";
            this.tb_limitcurrent.Size = new System.Drawing.Size(41, 21);
            this.tb_limitcurrent.TabIndex = 24;
            this.tb_limitcurrent.Text = "50";
            this.tb_limitcurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "Limit Current :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "degree";
            // 
            // tb_final_angle
            // 
            this.tb_final_angle.Location = new System.Drawing.Point(302, 28);
            this.tb_final_angle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_final_angle.Name = "tb_final_angle";
            this.tb_final_angle.Size = new System.Drawing.Size(41, 21);
            this.tb_final_angle.TabIndex = 21;
            this.tb_final_angle.Text = "0";
            this.tb_final_angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hs_fine
            // 
            this.hs_fine.Location = new System.Drawing.Point(161, 18);
            this.hs_fine.Name = "hs_fine";
            this.hs_fine.Size = new System.Drawing.Size(127, 34);
            this.hs_fine.TabIndex = 20;
            // 
            // tb_motor4
            // 
            this.tb_motor4.Enabled = false;
            this.tb_motor4.Location = new System.Drawing.Point(208, 84);
            this.tb_motor4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_motor4.Name = "tb_motor4";
            this.tb_motor4.Size = new System.Drawing.Size(84, 21);
            this.tb_motor4.TabIndex = 18;
            this.tb_motor4.Text = "0";
            this.tb_motor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_motor3
            // 
            this.tb_motor3.Enabled = false;
            this.tb_motor3.Location = new System.Drawing.Point(70, 84);
            this.tb_motor3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_motor3.Name = "tb_motor3";
            this.tb_motor3.Size = new System.Drawing.Size(84, 21);
            this.tb_motor3.TabIndex = 17;
            this.tb_motor3.Text = "0";
            this.tb_motor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_motor2
            // 
            this.tb_motor2.Enabled = false;
            this.tb_motor2.Location = new System.Drawing.Point(208, 60);
            this.tb_motor2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_motor2.Name = "tb_motor2";
            this.tb_motor2.Size = new System.Drawing.Size(84, 21);
            this.tb_motor2.TabIndex = 16;
            this.tb_motor2.Text = "0";
            this.tb_motor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_motor1
            // 
            this.tb_motor1.Enabled = false;
            this.tb_motor1.Location = new System.Drawing.Point(70, 60);
            this.tb_motor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_motor1.Name = "tb_motor1";
            this.tb_motor1.Size = new System.Drawing.Size(84, 21);
            this.tb_motor1.TabIndex = 15;
            this.tb_motor1.Text = "0";
            this.tb_motor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "Motor 4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Motor 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Motor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Motor 1";
            // 
            // radioButtonAbsoluteMove
            // 
            this.radioButtonAbsoluteMove.AutoSize = true;
            this.radioButtonAbsoluteMove.Location = new System.Drawing.Point(296, 85);
            this.radioButtonAbsoluteMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonAbsoluteMove.Name = "radioButtonAbsoluteMove";
            this.radioButtonAbsoluteMove.Size = new System.Drawing.Size(72, 16);
            this.radioButtonAbsoluteMove.TabIndex = 2;
            this.radioButtonAbsoluteMove.TabStop = true;
            this.radioButtonAbsoluteMove.Text = "&Absolute";
            this.radioButtonAbsoluteMove.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelativeMode
            // 
            this.radioButtonRelativeMode.AutoSize = true;
            this.radioButtonRelativeMode.Location = new System.Drawing.Point(296, 64);
            this.radioButtonRelativeMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonRelativeMode.Name = "radioButtonRelativeMode";
            this.radioButtonRelativeMode.Size = new System.Drawing.Size(67, 16);
            this.radioButtonRelativeMode.TabIndex = 1;
            this.radioButtonRelativeMode.TabStop = true;
            this.radioButtonRelativeMode.Text = "&Relative";
            this.radioButtonRelativeMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Angle:";
            // 
            // textBoxTargetPosition
            // 
            this.textBoxTargetPosition.Location = new System.Drawing.Point(102, 28);
            this.textBoxTargetPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTargetPosition.Name = "textBoxTargetPosition";
            this.textBoxTargetPosition.Size = new System.Drawing.Size(41, 21);
            this.textBoxTargetPosition.TabIndex = 0;
            this.textBoxTargetPosition.Text = "30";
            this.textBoxTargetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPositionActualValue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxPositionStart);
            this.groupBox3.Location = new System.Drawing.Point(14, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(415, 105);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual Values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "qc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position Actual Value:";
            // 
            // textBoxPositionActualValue
            // 
            this.textBoxPositionActualValue.Location = new System.Drawing.Point(168, 63);
            this.textBoxPositionActualValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPositionActualValue.Name = "textBoxPositionActualValue";
            this.textBoxPositionActualValue.ReadOnly = true;
            this.textBoxPositionActualValue.Size = new System.Drawing.Size(191, 21);
            this.textBoxPositionActualValue.TabIndex = 8;
            this.textBoxPositionActualValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "qc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position Start:";
            // 
            // textBoxPositionStart
            // 
            this.textBoxPositionStart.Location = new System.Drawing.Point(168, 39);
            this.textBoxPositionStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPositionStart.Name = "textBoxPositionStart";
            this.textBoxPositionStart.ReadOnly = true;
            this.textBoxPositionStart.Size = new System.Drawing.Size(191, 21);
            this.textBoxPositionStart.TabIndex = 2;
            this.textBoxPositionStart.Text = "0";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(470, 32);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(170, 26);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Device &Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Enabled = false;
            this.buttonEnable.Location = new System.Drawing.Point(470, 76);
            this.buttonEnable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(170, 26);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "&Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.ButtonEnableClick);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Enabled = false;
            this.buttonDisable.Location = new System.Drawing.Point(470, 107);
            this.buttonDisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(170, 26);
            this.buttonDisable.TabIndex = 2;
            this.buttonDisable.Text = "&Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.ButtonDisableClick);
            // 
            // buttonMove
            // 
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(470, 171);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(170, 26);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "&Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMoveClick);
            // 
            // buttonHalt
            // 
            this.buttonHalt.Enabled = false;
            this.buttonHalt.Location = new System.Drawing.Point(470, 202);
            this.buttonHalt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(170, 26);
            this.buttonHalt.TabIndex = 4;
            this.buttonHalt.Text = "&Halt";
            this.buttonHalt.UseVisualStyleBackColor = true;
            this.buttonHalt.Click += new System.EventHandler(this.ButtonHaltClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(470, 361);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 26);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exi&t";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // buttonGrasp
            // 
            this.buttonGrasp.Enabled = false;
            this.buttonGrasp.Location = new System.Drawing.Point(470, 252);
            this.buttonGrasp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGrasp.Name = "buttonGrasp";
            this.buttonGrasp.Size = new System.Drawing.Size(170, 26);
            this.buttonGrasp.TabIndex = 6;
            this.buttonGrasp.Text = "&Grasp";
            this.buttonGrasp.UseVisualStyleBackColor = true;
            this.buttonGrasp.Click += new System.EventHandler(this.buttonGrasp_Click);
            // 
            // bt_home
            // 
            this.bt_home.Enabled = false;
            this.bt_home.Location = new System.Drawing.Point(470, 284);
            this.bt_home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(170, 26);
            this.bt_home.TabIndex = 7;
            this.bt_home.Text = "H&ome";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 410);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.buttonGrasp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Gripper V3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTargetPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAOM;
        private System.Windows.Forms.RadioButton radioButtonRelativeMode;
        private System.Windows.Forms.RadioButton radioButtonAbsoluteMove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPositionActualValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPositionStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonHalt;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonGrasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_final_angle;
        private System.Windows.Forms.HScrollBar hs_fine;
        private System.Windows.Forms.TextBox tb_motor4;
        private System.Windows.Forms.TextBox tb_motor3;
        private System.Windows.Forms.TextBox tb_motor2;
        private System.Windows.Forms.TextBox tb_motor1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_limitcurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_home;
    }
}

