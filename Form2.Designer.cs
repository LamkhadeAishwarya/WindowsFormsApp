namespace WindowsFormsApp
{
    partial class Form2
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
            this.textEmp_name = new System.Windows.Forms.TextBox();
            this.textEmpid = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelEmp_Name = new System.Windows.Forms.Label();
            this.textgross = new System.Windows.Forms.TextBox();
            this.textPF = new System.Windows.Forms.TextBox();
            this.textTA = new System.Windows.Forms.TextBox();
            this.textDA = new System.Windows.Forms.TextBox();
            this.textHRA = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.labelsalary = new System.Windows.Forms.Label();
            this.labelHRA = new System.Windows.Forms.Label();
            this.labelDA = new System.Windows.Forms.Label();
            this.labelTA = new System.Windows.Forms.Label();
            this.labeLPF = new System.Windows.Forms.Label();
            this.labeLGross = new System.Windows.Forms.Label();
            this.comDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lbltynhg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textEmp_name
            // 
            this.textEmp_name.Location = new System.Drawing.Point(524, 114);
            this.textEmp_name.Name = "textEmp_name";
            this.textEmp_name.Size = new System.Drawing.Size(100, 22);
            this.textEmp_name.TabIndex = 6;
            // 
            // textEmpid
            // 
            this.textEmpid.Location = new System.Drawing.Point(524, 71);
            this.textEmpid.Name = "textEmpid";
            this.textEmpid.Size = new System.Drawing.Size(100, 22);
            this.textEmpid.TabIndex = 7;
            this.textEmpid.TextChanged += new System.EventHandler(this.textEmp_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(411, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 20);
            this.label.TabIndex = 8;
            this.label.Text = "Empid";
            // 
            // labelEmp_Name
            // 
            this.labelEmp_Name.AutoSize = true;
            this.labelEmp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmp_Name.Location = new System.Drawing.Point(411, 120);
            this.labelEmp_Name.Name = "labelEmp_Name";
            this.labelEmp_Name.Size = new System.Drawing.Size(101, 20);
            this.labelEmp_Name.TabIndex = 9;
            this.labelEmp_Name.Text = "Emp_name";
            // 
            // textgross
            // 
            this.textgross.Location = new System.Drawing.Point(524, 481);
            this.textgross.Name = "textgross";
            this.textgross.ReadOnly = true;
            this.textgross.Size = new System.Drawing.Size(100, 22);
            this.textgross.TabIndex = 11;
            // 
            // textPF
            // 
            this.textPF.Location = new System.Drawing.Point(524, 415);
            this.textPF.Name = "textPF";
            this.textPF.ReadOnly = true;
            this.textPF.Size = new System.Drawing.Size(100, 22);
            this.textPF.TabIndex = 12;
            // 
            // textTA
            // 
            this.textTA.Location = new System.Drawing.Point(524, 339);
            this.textTA.Name = "textTA";
            this.textTA.ReadOnly = true;
            this.textTA.Size = new System.Drawing.Size(100, 22);
            this.textTA.TabIndex = 13;
            // 
            // textDA
            // 
            this.textDA.Location = new System.Drawing.Point(524, 280);
            this.textDA.Name = "textDA";
            this.textDA.ReadOnly = true;
            this.textDA.Size = new System.Drawing.Size(100, 22);
            this.textDA.TabIndex = 14;
            // 
            // textHRA
            // 
            this.textHRA.Location = new System.Drawing.Point(524, 224);
            this.textHRA.Name = "textHRA";
            this.textHRA.ReadOnly = true;
            this.textHRA.Size = new System.Drawing.Size(100, 22);
            this.textHRA.TabIndex = 15;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(524, 173);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(100, 22);
            this.textsalary.TabIndex = 16;
            // 
            // labelsalary
            // 
            this.labelsalary.AutoSize = true;
            this.labelsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalary.Location = new System.Drawing.Point(413, 176);
            this.labelsalary.Name = "labelsalary";
            this.labelsalary.Size = new System.Drawing.Size(60, 20);
            this.labelsalary.TabIndex = 19;
            this.labelsalary.Text = "salary";
            // 
            // labelHRA
            // 
            this.labelHRA.AutoSize = true;
            this.labelHRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHRA.Location = new System.Drawing.Point(413, 224);
            this.labelHRA.Name = "labelHRA";
            this.labelHRA.Size = new System.Drawing.Size(48, 20);
            this.labelHRA.TabIndex = 20;
            this.labelHRA.Text = "HRA";
            // 
            // labelDA
            // 
            this.labelDA.AutoSize = true;
            this.labelDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDA.Location = new System.Drawing.Point(411, 286);
            this.labelDA.Name = "labelDA";
            this.labelDA.Size = new System.Drawing.Size(35, 20);
            this.labelDA.TabIndex = 21;
            this.labelDA.Text = "DA";
            // 
            // labelTA
            // 
            this.labelTA.AutoSize = true;
            this.labelTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTA.Location = new System.Drawing.Point(413, 345);
            this.labelTA.Name = "labelTA";
            this.labelTA.Size = new System.Drawing.Size(32, 20);
            this.labelTA.TabIndex = 22;
            this.labelTA.Text = "TA";
            // 
            // labeLPF
            // 
            this.labeLPF.AutoSize = true;
            this.labeLPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLPF.Location = new System.Drawing.Point(413, 415);
            this.labeLPF.Name = "labeLPF";
            this.labeLPF.Size = new System.Drawing.Size(32, 20);
            this.labeLPF.TabIndex = 23;
            this.labeLPF.Text = "PF";
            // 
            // labeLGross
            // 
            this.labeLGross.AutoSize = true;
            this.labeLGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLGross.Location = new System.Drawing.Point(413, 481);
            this.labeLGross.Name = "labeLGross";
            this.labeLGross.Size = new System.Drawing.Size(74, 20);
            this.labeLGross.TabIndex = 24;
            this.labeLGross.Text = "GROSS";
            this.labeLGross.Click += new System.EventHandler(this.labeLGross_Click);
            // 
            // comDepartment
            // 
            this.comDepartment.AutoSize = true;
            this.comDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDepartment.Location = new System.Drawing.Point(392, 542);
            this.comDepartment.Name = "comDepartment";
            this.comDepartment.Size = new System.Drawing.Size(107, 20);
            this.comDepartment.TabIndex = 25;
            this.comDepartment.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(524, 542);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartment.TabIndex = 26;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(664, 646);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 27;
            this.buttonexit.Text = "exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(676, 306);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 28;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(805, 306);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 29;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lbltynhg
            // 
            this.lbltynhg.AutoSize = true;
            this.lbltynhg.Location = new System.Drawing.Point(788, 201);
            this.lbltynhg.Name = "lbltynhg";
            this.lbltynhg.Size = new System.Drawing.Size(39, 16);
            this.lbltynhg.TabIndex = 30;
            this.lbltynhg.Text = "tynhg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 758);
            this.Controls.Add(this.lbltynhg);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comDepartment);
            this.Controls.Add(this.labeLGross);
            this.Controls.Add(this.labeLPF);
            this.Controls.Add(this.labelTA);
            this.Controls.Add(this.labelDA);
            this.Controls.Add(this.labelHRA);
            this.Controls.Add(this.labelsalary);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textHRA);
            this.Controls.Add(this.textDA);
            this.Controls.Add(this.textTA);
            this.Controls.Add(this.textPF);
            this.Controls.Add(this.textgross);
            this.Controls.Add(this.labelEmp_Name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textEmpid);
            this.Controls.Add(this.textEmp_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textEmp_name;
        private System.Windows.Forms.TextBox textEmpid;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelEmp_Name;
        private System.Windows.Forms.TextBox textgross;
        private System.Windows.Forms.TextBox textPF;
        private System.Windows.Forms.TextBox textTA;
        private System.Windows.Forms.TextBox textDA;
        private System.Windows.Forms.TextBox textHRA;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.Label labelsalary;
        private System.Windows.Forms.Label labelHRA;
        private System.Windows.Forms.Label labelDA;
        private System.Windows.Forms.Label labelTA;
        private System.Windows.Forms.Label labeLPF;
        private System.Windows.Forms.Label labeLGross;
        private System.Windows.Forms.Label comDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lbltynhg;
    }
}