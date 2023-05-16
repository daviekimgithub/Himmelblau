namespace PSO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSequentialSwarms = new System.Windows.Forms.Button();
            this.btnParallelSwarms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSequentialSwarms
            // 
            this.btnSequentialSwarms.Location = new System.Drawing.Point(29, 33);
            this.btnSequentialSwarms.Name = "btnSequentialSwarms";
            this.btnSequentialSwarms.Size = new System.Drawing.Size(130, 23);
            this.btnSequentialSwarms.TabIndex = 0;
            this.btnSequentialSwarms.Text = "Sequential Swarms";
            this.btnSequentialSwarms.UseVisualStyleBackColor = true;
            this.btnSequentialSwarms.Click += new System.EventHandler(this.btnSequentialSwarms_Click);
            // 
            // btnParallelSwarms
            // 
            this.btnParallelSwarms.Location = new System.Drawing.Point(29, 73);
            this.btnParallelSwarms.Name = "btnParallelSwarms";
            this.btnParallelSwarms.Size = new System.Drawing.Size(130, 23);
            this.btnParallelSwarms.TabIndex = 1;
            this.btnParallelSwarms.Text = "ParallelSwarms";
            this.btnParallelSwarms.UseVisualStyleBackColor = true;
            this.btnParallelSwarms.Click += new System.EventHandler(this.btnParallelSwarms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best Results";
         
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(208, 331);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label2";
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(193, 33);
            this.dg1.Name = "dg1";
            this.dg1.RowTemplate.Height = 25;
            this.dg1.Size = new System.Drawing.Size(533, 142);
            this.dg1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParallelSwarms);
            this.Controls.Add(this.btnSequentialSwarms);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSequentialSwarms;
        private Button btnParallelSwarms;
        private Label label1;
        private Label lblResult;
        private DataGridView dg1;
    }
}