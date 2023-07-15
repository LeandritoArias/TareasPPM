namespace Calculadora_Leandro
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.buttonBACKS = new System.Windows.Forms.Button();
            this.buttonSUMA = new System.Windows.Forms.Button();
            this.buttonRESTA = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.buttonMULTIP = new System.Windows.Forms.Button();
            this.buttonIGUAL = new System.Windows.Forms.Button();
            this.buttonPOTENCIA = new System.Windows.Forms.Button();
            this.buttonRAIZ = new System.Windows.Forms.Button();
            this.buttonNEGATIVO = new System.Windows.Forms.Button();
            this.buttonPUNTO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(26, 32);
            this.txtResult.MaxLength = 22;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(682, 81);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(131, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(246, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(246, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(131, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(246, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(131, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(26, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregar_numero);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(131, 476);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 70);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.agregar_numero);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(354, 164);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(107, 70);
            this.buttonCE.TabIndex = 18;
            this.buttonCE.Text = "ce";
            this.buttonCE.UseVisualStyleBackColor = true;
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLEAR.Location = new System.Drawing.Point(477, 164);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(107, 70);
            this.buttonCLEAR.TabIndex = 19;
            this.buttonCLEAR.Text = "c";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            // 
            // buttonBACKS
            // 
            this.buttonBACKS.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBACKS.Location = new System.Drawing.Point(601, 164);
            this.buttonBACKS.Name = "buttonBACKS";
            this.buttonBACKS.Size = new System.Drawing.Size(107, 70);
            this.buttonBACKS.TabIndex = 20;
            this.buttonBACKS.Text = "<";
            this.buttonBACKS.UseVisualStyleBackColor = true;
            // 
            // buttonSUMA
            // 
            this.buttonSUMA.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSUMA.Location = new System.Drawing.Point(354, 275);
            this.buttonSUMA.Name = "buttonSUMA";
            this.buttonSUMA.Size = new System.Drawing.Size(107, 70);
            this.buttonSUMA.TabIndex = 21;
            this.buttonSUMA.Tag = "SUMA";
            this.buttonSUMA.Text = "+";
            this.buttonSUMA.UseVisualStyleBackColor = true;
            this.buttonSUMA.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonRESTA
            // 
            this.buttonRESTA.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRESTA.Location = new System.Drawing.Point(354, 382);
            this.buttonRESTA.Name = "buttonRESTA";
            this.buttonRESTA.Size = new System.Drawing.Size(107, 70);
            this.buttonRESTA.TabIndex = 22;
            this.buttonRESTA.Tag = "RESTA";
            this.buttonRESTA.Text = "-";
            this.buttonRESTA.UseVisualStyleBackColor = true;
            this.buttonRESTA.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonDIV
            // 
            this.buttonDIV.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDIV.Location = new System.Drawing.Point(477, 382);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(107, 70);
            this.buttonDIV.TabIndex = 24;
            this.buttonDIV.Tag = "/";
            this.buttonDIV.Text = "%";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonMULTIP
            // 
            this.buttonMULTIP.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMULTIP.Location = new System.Drawing.Point(477, 275);
            this.buttonMULTIP.Name = "buttonMULTIP";
            this.buttonMULTIP.Size = new System.Drawing.Size(107, 70);
            this.buttonMULTIP.TabIndex = 23;
            this.buttonMULTIP.Tag = "X";
            this.buttonMULTIP.Text = "x";
            this.buttonMULTIP.UseVisualStyleBackColor = true;
            this.buttonMULTIP.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonIGUAL
            // 
            this.buttonIGUAL.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIGUAL.Location = new System.Drawing.Point(354, 476);
            this.buttonIGUAL.Name = "buttonIGUAL";
            this.buttonIGUAL.Size = new System.Drawing.Size(354, 70);
            this.buttonIGUAL.TabIndex = 25;
            this.buttonIGUAL.Text = "=";
            this.buttonIGUAL.UseVisualStyleBackColor = true;
            this.buttonIGUAL.Click += new System.EventHandler(this.buttonIGUAL_Click);
            // 
            // buttonPOTENCIA
            // 
            this.buttonPOTENCIA.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPOTENCIA.Location = new System.Drawing.Point(601, 275);
            this.buttonPOTENCIA.Name = "buttonPOTENCIA";
            this.buttonPOTENCIA.Size = new System.Drawing.Size(107, 70);
            this.buttonPOTENCIA.TabIndex = 26;
            this.buttonPOTENCIA.Tag = "°";
            this.buttonPOTENCIA.Text = "x²";
            this.buttonPOTENCIA.UseVisualStyleBackColor = true;
            this.buttonPOTENCIA.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonRAIZ
            // 
            this.buttonRAIZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRAIZ.Location = new System.Drawing.Point(601, 382);
            this.buttonRAIZ.Name = "buttonRAIZ";
            this.buttonRAIZ.Size = new System.Drawing.Size(107, 70);
            this.buttonRAIZ.TabIndex = 27;
            this.buttonRAIZ.Tag = "√";
            this.buttonRAIZ.Text = "√";
            this.buttonRAIZ.UseVisualStyleBackColor = true;
            this.buttonRAIZ.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonNEGATIVO
            // 
            this.buttonNEGATIVO.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.buttonNEGATIVO.Location = new System.Drawing.Point(26, 476);
            this.buttonNEGATIVO.Name = "buttonNEGATIVO";
            this.buttonNEGATIVO.Size = new System.Drawing.Size(70, 70);
            this.buttonNEGATIVO.TabIndex = 28;
            this.buttonNEGATIVO.Text = "+/-";
            this.buttonNEGATIVO.UseVisualStyleBackColor = true;
            // 
            // buttonPUNTO
            // 
            this.buttonPUNTO.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPUNTO.Location = new System.Drawing.Point(246, 476);
            this.buttonPUNTO.Name = "buttonPUNTO";
            this.buttonPUNTO.Size = new System.Drawing.Size(70, 70);
            this.buttonPUNTO.TabIndex = 29;
            this.buttonPUNTO.Text = ".";
            this.buttonPUNTO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 578);
            this.Controls.Add(this.buttonPUNTO);
            this.Controls.Add(this.buttonNEGATIVO);
            this.Controls.Add(this.buttonRAIZ);
            this.Controls.Add(this.buttonPOTENCIA);
            this.Controls.Add(this.buttonIGUAL);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.buttonMULTIP);
            this.Controls.Add(this.buttonRESTA);
            this.Controls.Add(this.buttonSUMA);
            this.Controls.Add(this.buttonBACKS);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CalcEmprendurismo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.Windows.Forms.Button buttonBACKS;
        private System.Windows.Forms.Button buttonSUMA;
        private System.Windows.Forms.Button buttonRESTA;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Button buttonMULTIP;
        private System.Windows.Forms.Button buttonIGUAL;
        private System.Windows.Forms.Button buttonPOTENCIA;
        private System.Windows.Forms.Button buttonRAIZ;
        private System.Windows.Forms.Button buttonNEGATIVO;
        private System.Windows.Forms.Button buttonPUNTO;
    }
}

