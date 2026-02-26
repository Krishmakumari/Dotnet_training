namespace SerializationDemo
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
            this.txtEmployeeID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLableName = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeSerialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btsSOAPSerialize = new System.Windows.Forms.Button();
            this.btnSOAPDeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.AutoSize = true;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeID.Location = new System.Drawing.Point(197, 88);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(120, 25);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.Text = "Employee Id";
            this.txtEmployeeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(332, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 30);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(332, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtLableName
            // 
            this.txtLableName.AutoSize = true;
            this.txtLableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLableName.Location = new System.Drawing.Point(197, 144);
            this.txtLableName.Name = "txtLableName";
            this.txtLableName.Size = new System.Drawing.Size(64, 25);
            this.txtLableName.TabIndex = 2;
            this.txtLableName.Text = "Name";
            this.txtLableName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSalary.Location = new System.Drawing.Point(332, 201);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(127, 30);
            this.txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(197, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // btnSerialize
            // 
            this.btnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSerialize.Location = new System.Drawing.Point(102, 297);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(163, 45);
            this.btnSerialize.TabIndex = 6;
            this.btnSerialize.Text = "Bin Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeSerialize
            // 
            this.btnDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeSerialize.Location = new System.Drawing.Point(102, 358);
            this.btnDeSerialize.Name = "btnDeSerialize";
            this.btnDeSerialize.Size = new System.Drawing.Size(163, 45);
            this.btnDeSerialize.TabIndex = 7;
            this.btnDeSerialize.Text = "Bin DeSerialize";
            this.btnDeSerialize.UseVisualStyleBackColor = true;
            this.btnDeSerialize.Click += new System.EventHandler(this.btnDeSerialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXMLSerialize.Location = new System.Drawing.Point(287, 297);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(155, 45);
            this.btnXMLSerialize.TabIndex = 8;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(287, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 45);
            this.button4.TabIndex = 9;
            this.button4.Text = "XML DeSerialize";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btsSOAPSerialize
            // 
            this.btsSOAPSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btsSOAPSerialize.Location = new System.Drawing.Point(469, 297);
            this.btsSOAPSerialize.Name = "btsSOAPSerialize";
            this.btsSOAPSerialize.Size = new System.Drawing.Size(158, 45);
            this.btsSOAPSerialize.TabIndex = 10;
            this.btsSOAPSerialize.Text = "SOAP Serialize";
            this.btsSOAPSerialize.UseVisualStyleBackColor = true;
            this.btsSOAPSerialize.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSOAPDeSerialize
            // 
            this.btnSOAPDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSOAPDeSerialize.Location = new System.Drawing.Point(469, 358);
            this.btnSOAPDeSerialize.Name = "btnSOAPDeSerialize";
            this.btnSOAPDeSerialize.Size = new System.Drawing.Size(158, 45);
            this.btnSOAPDeSerialize.TabIndex = 11;
            this.btnSOAPDeSerialize.Text = "SOAP DeSerialize";
            this.btnSOAPDeSerialize.UseVisualStyleBackColor = true;
            this.btnSOAPDeSerialize.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSOAPDeSerialize);
            this.Controls.Add(this.btsSOAPSerialize);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btnDeSerialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLableName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmployeeID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEmployeeID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtLableName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeSerialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btsSOAPSerialize;
        private System.Windows.Forms.Button btnSOAPDeSerialize;
    }
}

