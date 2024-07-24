namespace ModbusCommunication
{
    partial class ModbusConn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDI3 = new System.Windows.Forms.TextBox();
            this.tbDI2 = new System.Windows.Forms.TextBox();
            this.tbDI1 = new System.Windows.Forms.TextBox();
            this.tbDI0 = new System.Windows.Forms.TextBox();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.btnWrite3 = new System.Windows.Forms.Button();
            this.btnWrite4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDI7 = new System.Windows.Forms.TextBox();
            this.tbDI6 = new System.Windows.Forms.TextBox();
            this.tbDI5 = new System.Windows.Forms.TextBox();
            this.tbDI4 = new System.Windows.Forms.TextBox();
            this.btnWrite7 = new System.Windows.Forms.Button();
            this.btnWrite6 = new System.Windows.Forms.Button();
            this.btnWrite5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIp.Location = new System.Drawing.Point(115, 39);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(186, 26);
            this.tbIp.TabIndex = 2;
            this.tbIp.Text = "192.168.1.60";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Indigo;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(331, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(166, 27);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.BackColor = System.Drawing.Color.Indigo;
            this.btnDisconect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconect.ForeColor = System.Drawing.Color.White;
            this.btnDisconect.Location = new System.Drawing.Point(331, 55);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(166, 27);
            this.btnDisconect.TabIndex = 5;
            this.btnDisconect.Text = "Disconnect";
            this.btnDisconect.UseVisualStyleBackColor = false;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(94, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "----";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Indigo;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(156, 149);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(107, 239);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read All";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Location = new System.Drawing.Point(291, 149);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(166, 27);
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(463, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "DO0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(463, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "DO1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(463, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "DO2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(463, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "DO3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "DI3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "DI2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "DI1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "DI0";
            // 
            // tbDI3
            // 
            this.tbDI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI3.Location = new System.Drawing.Point(46, 243);
            this.tbDI3.Name = "tbDI3";
            this.tbDI3.Size = new System.Drawing.Size(91, 23);
            this.tbDI3.TabIndex = 25;
            this.tbDI3.Text = "0";
            // 
            // tbDI2
            // 
            this.tbDI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI2.Location = new System.Drawing.Point(46, 212);
            this.tbDI2.Name = "tbDI2";
            this.tbDI2.Size = new System.Drawing.Size(91, 23);
            this.tbDI2.TabIndex = 24;
            this.tbDI2.Text = "0";
            // 
            // tbDI1
            // 
            this.tbDI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI1.Location = new System.Drawing.Point(46, 183);
            this.tbDI1.Name = "tbDI1";
            this.tbDI1.Size = new System.Drawing.Size(91, 23);
            this.tbDI1.TabIndex = 23;
            this.tbDI1.Text = "0";
            // 
            // tbDI0
            // 
            this.tbDI0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI0.Location = new System.Drawing.Point(46, 152);
            this.tbDI0.Name = "tbDI0";
            this.tbDI0.Size = new System.Drawing.Size(91, 23);
            this.tbDI0.TabIndex = 22;
            this.tbDI0.Text = "0";
            // 
            // btnWrite2
            // 
            this.btnWrite2.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite2.ForeColor = System.Drawing.Color.White;
            this.btnWrite2.Location = new System.Drawing.Point(291, 185);
            this.btnWrite2.Name = "btnWrite2";
            this.btnWrite2.Size = new System.Drawing.Size(166, 27);
            this.btnWrite2.TabIndex = 30;
            this.btnWrite2.Text = "Write";
            this.btnWrite2.UseVisualStyleBackColor = false;
            this.btnWrite2.Click += new System.EventHandler(this.btnWrite2_Click);
            // 
            // btnWrite3
            // 
            this.btnWrite3.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite3.ForeColor = System.Drawing.Color.White;
            this.btnWrite3.Location = new System.Drawing.Point(291, 221);
            this.btnWrite3.Name = "btnWrite3";
            this.btnWrite3.Size = new System.Drawing.Size(166, 27);
            this.btnWrite3.TabIndex = 31;
            this.btnWrite3.Text = "Write";
            this.btnWrite3.UseVisualStyleBackColor = false;
            this.btnWrite3.Click += new System.EventHandler(this.btnWrite3_Click);
            // 
            // btnWrite4
            // 
            this.btnWrite4.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite4.ForeColor = System.Drawing.Color.White;
            this.btnWrite4.Location = new System.Drawing.Point(291, 257);
            this.btnWrite4.Name = "btnWrite4";
            this.btnWrite4.Size = new System.Drawing.Size(166, 27);
            this.btnWrite4.TabIndex = 32;
            this.btnWrite4.Text = "Write";
            this.btnWrite4.UseVisualStyleBackColor = false;
            this.btnWrite4.Click += new System.EventHandler(this.btnWrite4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "DI7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "DI6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "DI5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "DI4";
            // 
            // tbDI7
            // 
            this.tbDI7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI7.Location = new System.Drawing.Point(46, 368);
            this.tbDI7.Name = "tbDI7";
            this.tbDI7.Size = new System.Drawing.Size(91, 23);
            this.tbDI7.TabIndex = 36;
            this.tbDI7.Text = "0";
            // 
            // tbDI6
            // 
            this.tbDI6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI6.Location = new System.Drawing.Point(46, 337);
            this.tbDI6.Name = "tbDI6";
            this.tbDI6.Size = new System.Drawing.Size(91, 23);
            this.tbDI6.TabIndex = 35;
            this.tbDI6.Text = "0";
            // 
            // tbDI5
            // 
            this.tbDI5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI5.Location = new System.Drawing.Point(46, 308);
            this.tbDI5.Name = "tbDI5";
            this.tbDI5.Size = new System.Drawing.Size(91, 23);
            this.tbDI5.TabIndex = 34;
            this.tbDI5.Text = "0";
            // 
            // tbDI4
            // 
            this.tbDI4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDI4.Location = new System.Drawing.Point(46, 277);
            this.tbDI4.Name = "tbDI4";
            this.tbDI4.Size = new System.Drawing.Size(91, 23);
            this.tbDI4.TabIndex = 33;
            this.tbDI4.Text = "0";
            // 
            // btnWrite7
            // 
            this.btnWrite7.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite7.ForeColor = System.Drawing.Color.White;
            this.btnWrite7.Location = new System.Drawing.Point(291, 361);
            this.btnWrite7.Name = "btnWrite7";
            this.btnWrite7.Size = new System.Drawing.Size(166, 27);
            this.btnWrite7.TabIndex = 46;
            this.btnWrite7.Text = "Write";
            this.btnWrite7.UseVisualStyleBackColor = false;
            this.btnWrite7.Click += new System.EventHandler(this.btnWrite7_Click);
            // 
            // btnWrite6
            // 
            this.btnWrite6.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite6.ForeColor = System.Drawing.Color.White;
            this.btnWrite6.Location = new System.Drawing.Point(291, 326);
            this.btnWrite6.Name = "btnWrite6";
            this.btnWrite6.Size = new System.Drawing.Size(166, 27);
            this.btnWrite6.TabIndex = 45;
            this.btnWrite6.Text = "Write";
            this.btnWrite6.UseVisualStyleBackColor = false;
            this.btnWrite6.Click += new System.EventHandler(this.btnWrite6_Click);
            // 
            // btnWrite5
            // 
            this.btnWrite5.BackColor = System.Drawing.Color.Indigo;
            this.btnWrite5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite5.ForeColor = System.Drawing.Color.White;
            this.btnWrite5.Location = new System.Drawing.Point(291, 293);
            this.btnWrite5.Name = "btnWrite5";
            this.btnWrite5.Size = new System.Drawing.Size(166, 27);
            this.btnWrite5.TabIndex = 44;
            this.btnWrite5.Text = "Write";
            this.btnWrite5.UseVisualStyleBackColor = false;
            this.btnWrite5.Click += new System.EventHandler(this.btnWrite5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(463, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "DO6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(463, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "DO5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(463, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "DO4";
            // 
            // ModbusConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(521, 433);
            this.Controls.Add(this.btnWrite7);
            this.Controls.Add(this.btnWrite6);
            this.Controls.Add(this.btnWrite5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDI7);
            this.Controls.Add(this.tbDI6);
            this.Controls.Add(this.tbDI5);
            this.Controls.Add(this.tbDI4);
            this.Controls.Add(this.btnWrite4);
            this.Controls.Add(this.btnWrite3);
            this.Controls.Add(this.btnWrite2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDI3);
            this.Controls.Add(this.tbDI2);
            this.Controls.Add(this.tbDI1);
            this.Controls.Add(this.tbDI0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.label1);
            this.Name = "ModbusConn";
            this.Text = "ModbusCommunication to PLC";
            this.Load += new System.EventHandler(this.ModbusConn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDI3;
        private System.Windows.Forms.TextBox tbDI2;
        private System.Windows.Forms.TextBox tbDI1;
        private System.Windows.Forms.TextBox tbDI0;
        private System.Windows.Forms.Button btnWrite2;
        private System.Windows.Forms.Button btnWrite3;
        private System.Windows.Forms.Button btnWrite4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDI7;
        private System.Windows.Forms.TextBox tbDI6;
        private System.Windows.Forms.TextBox tbDI5;
        private System.Windows.Forms.TextBox tbDI4;
        private System.Windows.Forms.Button btnWrite7;
        private System.Windows.Forms.Button btnWrite6;
        private System.Windows.Forms.Button btnWrite5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

