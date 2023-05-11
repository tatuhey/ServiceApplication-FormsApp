namespace ServiceApplication_FormsApp
{
    partial class ServiceApplicationForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lvRegular = new System.Windows.Forms.ListView();
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvExpress = new System.Windows.Forms.ListView();
            this.colHeadName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadModel1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadProblem1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTag1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCost1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbFinished = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTag = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPriority = new System.Windows.Forms.GroupBox();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnExpress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTag)).BeginInit();
            this.gbPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(55, 62);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(55, 103);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(206, 20);
            this.tbModel.TabIndex = 1;
            // 
            // tbProblem
            // 
            this.tbProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProblem.Location = new System.Drawing.Point(55, 144);
            this.tbProblem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(206, 181);
            this.tbProblem.TabIndex = 2;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(55, 413);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(206, 20);
            this.tbCost.TabIndex = 3;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // lvRegular
            // 
            this.lvRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName,
            this.colHeadModel,
            this.colHeadProblem,
            this.colHeadCost,
            this.colHeadTag});
            this.lvRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRegular.HideSelection = false;
            this.lvRegular.Location = new System.Drawing.Point(317, 62);
            this.lvRegular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvRegular.Name = "lvRegular";
            this.lvRegular.Size = new System.Drawing.Size(380, 160);
            this.lvRegular.TabIndex = 4;
            this.lvRegular.UseCompatibleStateImageBehavior = false;
            this.lvRegular.View = System.Windows.Forms.View.Details;
            this.lvRegular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRegular_MouseClick);
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Client Name";
            this.colHeadName.Width = 86;
            // 
            // colHeadModel
            // 
            this.colHeadModel.Text = "Drone Model";
            this.colHeadModel.Width = 87;
            // 
            // colHeadProblem
            // 
            this.colHeadProblem.Text = "Service Problem";
            this.colHeadProblem.Width = 108;
            // 
            // colHeadTag
            // 
            this.colHeadTag.Text = "Service Tag";
            this.colHeadTag.Width = 98;
            // 
            // colHeadCost
            // 
            this.colHeadCost.Text = "Service Cost";
            this.colHeadCost.Width = 90;
            // 
            // lvExpress
            // 
            this.lvExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName1,
            this.colHeadModel1,
            this.colHeadProblem1,
            this.colHeadCost1,
            this.colHeadTag1});
            this.lvExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExpress.HideSelection = false;
            this.lvExpress.Location = new System.Drawing.Point(317, 272);
            this.lvExpress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvExpress.Name = "lvExpress";
            this.lvExpress.Size = new System.Drawing.Size(380, 160);
            this.lvExpress.TabIndex = 5;
            this.lvExpress.UseCompatibleStateImageBehavior = false;
            this.lvExpress.View = System.Windows.Forms.View.Details;
            this.lvExpress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvExpress_MouseClick);
            // 
            // colHeadName1
            // 
            this.colHeadName1.Text = "Client Name";
            this.colHeadName1.Width = 92;
            // 
            // colHeadModel1
            // 
            this.colHeadModel1.Text = "Drone Model";
            this.colHeadModel1.Width = 87;
            // 
            // colHeadProblem1
            // 
            this.colHeadProblem1.Text = "Service Problem";
            this.colHeadProblem1.Width = 112;
            // 
            // colHeadTag1
            // 
            this.colHeadTag1.Text = "Service Tag";
            this.colHeadTag1.Width = 81;
            // 
            // colHeadCost1
            // 
            this.colHeadCost1.Text = "Service Cost";
            this.colHeadCost1.Width = 87;
            // 
            // lbFinished
            // 
            this.lbFinished.ColumnWidth = 1;
            this.lbFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinished.FormattingEnabled = true;
            this.lbFinished.Location = new System.Drawing.Point(751, 62);
            this.lbFinished.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbFinished.Name = "lbFinished";
            this.lbFinished.Size = new System.Drawing.Size(146, 329);
            this.lbFinished.TabIndex = 6;
            this.lbFinished.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFinished_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Drone Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Service Problem";
            // 
            // numTag
            // 
            this.numTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTag.Location = new System.Drawing.Point(55, 346);
            this.numTag.Name = "numTag";
            this.numTag.Size = new System.Drawing.Size(52, 20);
            this.numTag.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Tag";
            // 
            // gbPriority
            // 
            this.gbPriority.Controls.Add(this.rbExpress);
            this.gbPriority.Controls.Add(this.rbRegular);
            this.gbPriority.Location = new System.Drawing.Point(141, 331);
            this.gbPriority.Name = "gbPriority";
            this.gbPriority.Size = new System.Drawing.Size(121, 61);
            this.gbPriority.TabIndex = 13;
            this.gbPriority.TabStop = false;
            this.gbPriority.Text = "Service Priority";
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(6, 38);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(69, 17);
            this.rbExpress.TabIndex = 1;
            this.rbExpress.TabStop = true;
            this.rbExpress.Text = "Express";
            this.rbExpress.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(6, 16);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(69, 17);
            this.rbRegular.TabIndex = 0;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Service Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Regular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Express";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Finished List";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(751, 397);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 57);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnRegular
            // 
            this.btnRegular.Location = new System.Drawing.Point(317, 228);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(75, 23);
            this.btnRegular.TabIndex = 20;
            this.btnRegular.Text = "Remove";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnExpress
            // 
            this.btnExpress.Location = new System.Drawing.Point(317, 438);
            this.btnExpress.Name = "btnExpress";
            this.btnExpress.Size = new System.Drawing.Size(75, 23);
            this.btnExpress.TabIndex = 21;
            this.btnExpress.Text = "Remove";
            this.btnExpress.UseVisualStyleBackColor = true;
            this.btnExpress.Click += new System.EventHandler(this.btnExpress_Click);
            // 
            // ServiceApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 522);
            this.Controls.Add(this.btnExpress);
            this.Controls.Add(this.btnRegular);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFinished);
            this.Controls.Add(this.lvExpress);
            this.Controls.Add(this.lvRegular);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceApplicationForm";
            this.Text = "Service Application";
            ((System.ComponentModel.ISupportInitialize)(this.numTag)).EndInit();
            this.gbPriority.ResumeLayout(false);
            this.gbPriority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ListView lvRegular;
        private System.Windows.Forms.ListView lvExpress;
        private System.Windows.Forms.ListBox lbFinished;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPriority;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.Button btnExpress;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadModel;
        private System.Windows.Forms.ColumnHeader colHeadProblem;
        private System.Windows.Forms.ColumnHeader colHeadTag;
        private System.Windows.Forms.ColumnHeader colHeadCost;
        private System.Windows.Forms.ColumnHeader colHeadName1;
        private System.Windows.Forms.ColumnHeader colHeadModel1;
        private System.Windows.Forms.ColumnHeader colHeadProblem1;
        private System.Windows.Forms.ColumnHeader colHeadTag1;
        private System.Windows.Forms.ColumnHeader colHeadCost1;
    }
}

