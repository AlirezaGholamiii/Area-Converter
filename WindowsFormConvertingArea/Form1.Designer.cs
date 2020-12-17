namespace WindowsFormConvertingArea
{
    partial class frmAreaConvert
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSqCm = new System.Windows.Forms.Label();
            this.lblSqIn = new System.Windows.Forms.Label();
            this.blSqM = new System.Windows.Forms.Label();
            this.lblSqYd = new System.Windows.Forms.Label();
            this.lblHectar = new System.Windows.Forms.Label();
            this.lblAcres = new System.Windows.Forms.Label();
            this.blSqKm = new System.Windows.Forms.Label();
            this.lblSqMile = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnTotalChars = new System.Windows.Forms.Button();
            this.btnTotalID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.Button();
            this.txtID2 = new System.Windows.Forms.Button();
            this.txtID3 = new System.Windows.Forms.Button();
            this.txtID4 = new System.Windows.Forms.Button();
            this.txtID5 = new System.Windows.Forms.Button();
            this.txtID6 = new System.Windows.Forms.Button();
            this.txtID7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(248, 320);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "&1st conversion";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltitle.Location = new System.Drawing.Point(-1, 273);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(462, 25);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Enter the value of the Area you want to convert";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSqCm
            // 
            this.lblSqCm.AutoSize = true;
            this.lblSqCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSqCm.Location = new System.Drawing.Point(12, 323);
            this.lblSqCm.Name = "lblSqCm";
            this.lblSqCm.Size = new System.Drawing.Size(107, 20);
            this.lblSqCm.TabIndex = 3;
            this.lblSqCm.Text = "Metric sq cm";
            // 
            // lblSqIn
            // 
            this.lblSqIn.AutoSize = true;
            this.lblSqIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSqIn.Location = new System.Drawing.Point(526, 323);
            this.lblSqIn.Name = "lblSqIn";
            this.lblSqIn.Size = new System.Drawing.Size(73, 20);
            this.lblSqIn.TabIndex = 4;
            this.lblSqIn.Text = "US sq in";
            // 
            // blSqM
            // 
            this.blSqM.AutoSize = true;
            this.blSqM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.blSqM.Location = new System.Drawing.Point(12, 387);
            this.blSqM.Name = "blSqM";
            this.blSqM.Size = new System.Drawing.Size(98, 20);
            this.blSqM.TabIndex = 5;
            this.blSqM.Text = "Metric sq m";
            this.blSqM.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSqYd
            // 
            this.lblSqYd.AutoSize = true;
            this.lblSqYd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSqYd.Location = new System.Drawing.Point(526, 387);
            this.lblSqYd.Name = "lblSqYd";
            this.lblSqYd.Size = new System.Drawing.Size(77, 20);
            this.lblSqYd.TabIndex = 6;
            this.lblSqYd.Text = "US sq yd";
            // 
            // lblHectar
            // 
            this.lblHectar.AutoSize = true;
            this.lblHectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHectar.Location = new System.Drawing.Point(12, 455);
            this.lblHectar.Name = "lblHectar";
            this.lblHectar.Size = new System.Drawing.Size(108, 20);
            this.lblHectar.TabIndex = 7;
            this.lblHectar.Text = "Metric hectar";
            // 
            // lblAcres
            // 
            this.lblAcres.AutoSize = true;
            this.lblAcres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAcres.Location = new System.Drawing.Point(526, 455);
            this.lblAcres.Name = "lblAcres";
            this.lblAcres.Size = new System.Drawing.Size(79, 20);
            this.lblAcres.TabIndex = 8;
            this.lblAcres.Text = "US acres";
            // 
            // blSqKm
            // 
            this.blSqKm.AutoSize = true;
            this.blSqKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.blSqKm.Location = new System.Drawing.Point(12, 527);
            this.blSqKm.Name = "blSqKm";
            this.blSqKm.Size = new System.Drawing.Size(106, 20);
            this.blSqKm.TabIndex = 9;
            this.blSqKm.Text = "Metric sq km";
            // 
            // lblSqMile
            // 
            this.lblSqMile.AutoSize = true;
            this.lblSqMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSqMile.Location = new System.Drawing.Point(526, 527);
            this.lblSqMile.Name = "lblSqMile";
            this.lblSqMile.Size = new System.Drawing.Size(91, 20);
            this.lblSqMile.TabIndex = 10;
            this.lblSqMile.Text = "US sq mile";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 453);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 22);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 525);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(408, 321);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(90, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(408, 385);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(90, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(408, 453);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(90, 22);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(408, 525);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(90, 22);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(248, 384);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "&2nd conversion";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(248, 452);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "&3rd conversion";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(248, 524);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 23);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "&4th conversion";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 591);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxdate
            // 
            this.txtboxdate.Location = new System.Drawing.Point(79, 25);
            this.txtboxdate.Name = "txtboxdate";
            this.txtboxdate.ReadOnly = true;
            this.txtboxdate.Size = new System.Drawing.Size(251, 22);
            this.txtboxdate.TabIndex = 18;
            this.txtboxdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Today:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 107);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(318, 22);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = "First Name Last Name:";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Your Full Name:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(355, 107);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(106, 22);
            this.textBox10.TabIndex = 22;
            this.textBox10.Text = "20";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotalChars
            // 
            this.btnTotalChars.Location = new System.Drawing.Point(504, 84);
            this.btnTotalChars.Name = "btnTotalChars";
            this.btnTotalChars.Size = new System.Drawing.Size(95, 44);
            this.btnTotalChars.TabIndex = 23;
            this.btnTotalChars.Text = "Show Total &Length";
            this.btnTotalChars.UseVisualStyleBackColor = true;
            this.btnTotalChars.Click += new System.EventHandler(this.btnTotalChars_Click);
            // 
            // btnTotalID
            // 
            this.btnTotalID.Location = new System.Drawing.Point(504, 172);
            this.btnTotalID.Name = "btnTotalID";
            this.btnTotalID.Size = new System.Drawing.Size(95, 44);
            this.btnTotalID.TabIndex = 24;
            this.btnTotalID.Text = "Show Total &ID";
            this.btnTotalID.UseVisualStyleBackColor = true;
            this.btnTotalID.Click += new System.EventHandler(this.btnTotalID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(336, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 40);
            this.label3.TabIndex = 35;
            this.label3.Text = "The Total number \r\nof characters: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(351, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 40);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total value of \r\nID numbers: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(355, 194);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(106, 22);
            this.textBox11.TabIndex = 37;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(16, 180);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(35, 36);
            this.txtID1.TabIndex = 38;
            this.txtID1.Text = "1";
            this.txtID1.UseVisualStyleBackColor = true;
            this.txtID1.Click += new System.EventHandler(this.txtID1_Click);
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(57, 180);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(35, 36);
            this.txtID2.TabIndex = 39;
            this.txtID2.Text = "2";
            this.txtID2.UseVisualStyleBackColor = true;
            this.txtID2.Click += new System.EventHandler(this.txtID2_Click);
            // 
            // txtID3
            // 
            this.txtID3.Location = new System.Drawing.Point(98, 180);
            this.txtID3.Name = "txtID3";
            this.txtID3.Size = new System.Drawing.Size(35, 36);
            this.txtID3.TabIndex = 40;
            this.txtID3.Text = "3";
            this.txtID3.UseVisualStyleBackColor = true;
            this.txtID3.Click += new System.EventHandler(this.txtID3_Click);
            // 
            // txtID4
            // 
            this.txtID4.Location = new System.Drawing.Point(139, 180);
            this.txtID4.Name = "txtID4";
            this.txtID4.Size = new System.Drawing.Size(35, 36);
            this.txtID4.TabIndex = 41;
            this.txtID4.Text = "4";
            this.txtID4.UseVisualStyleBackColor = true;
            this.txtID4.Click += new System.EventHandler(this.txtID4_Click);
            // 
            // txtID5
            // 
            this.txtID5.Location = new System.Drawing.Point(180, 180);
            this.txtID5.Name = "txtID5";
            this.txtID5.Size = new System.Drawing.Size(35, 36);
            this.txtID5.TabIndex = 42;
            this.txtID5.Text = "5";
            this.txtID5.UseVisualStyleBackColor = true;
            this.txtID5.Click += new System.EventHandler(this.txtID5_Click);
            // 
            // txtID6
            // 
            this.txtID6.Location = new System.Drawing.Point(221, 180);
            this.txtID6.Name = "txtID6";
            this.txtID6.Size = new System.Drawing.Size(35, 36);
            this.txtID6.TabIndex = 43;
            this.txtID6.Text = "6";
            this.txtID6.UseVisualStyleBackColor = true;
            this.txtID6.Click += new System.EventHandler(this.txtID6_Click);
            // 
            // txtID7
            // 
            this.txtID7.Location = new System.Drawing.Point(262, 180);
            this.txtID7.Name = "txtID7";
            this.txtID7.Size = new System.Drawing.Size(35, 36);
            this.txtID7.TabIndex = 44;
            this.txtID7.Text = "7";
            this.txtID7.UseVisualStyleBackColor = true;
            this.txtID7.Click += new System.EventHandler(this.txtID7_Click);
            // 
            // frmAreaConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 637);
            this.Controls.Add(this.txtID7);
            this.Controls.Add(this.txtID6);
            this.Controls.Add(this.txtID5);
            this.Controls.Add(this.txtID4);
            this.Controls.Add(this.txtID3);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTotalID);
            this.Controls.Add(this.btnTotalChars);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSqMile);
            this.Controls.Add(this.blSqKm);
            this.Controls.Add(this.lblAcres);
            this.Controls.Add(this.lblHectar);
            this.Controls.Add(this.lblSqYd);
            this.Controls.Add(this.blSqM);
            this.Controls.Add(this.lblSqIn);
            this.Controls.Add(this.lblSqCm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btn1);
            this.Name = "frmAreaConvert";
            this.Text = "Alireza Gholami";
            this.Load += new System.EventHandler(this.frmAreaConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSqCm;
        private System.Windows.Forms.Label lblSqIn;
        private System.Windows.Forms.Label blSqM;
        private System.Windows.Forms.Label lblSqYd;
        private System.Windows.Forms.Label lblHectar;
        private System.Windows.Forms.Label lblAcres;
        private System.Windows.Forms.Label blSqKm;
        private System.Windows.Forms.Label lblSqMile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtboxdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnTotalChars;
        private System.Windows.Forms.Button btnTotalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button txtID1;
        private System.Windows.Forms.Button txtID2;
        private System.Windows.Forms.Button txtID3;
        private System.Windows.Forms.Button txtID4;
        private System.Windows.Forms.Button txtID5;
        private System.Windows.Forms.Button txtID6;
        private System.Windows.Forms.Button txtID7;
    }
}

