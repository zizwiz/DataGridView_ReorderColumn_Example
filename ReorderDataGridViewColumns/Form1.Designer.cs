
namespace ReorderDataGridViewColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reorder = new System.Windows.Forms.Button();
            this.prn_dgv_one_stream = new System.Windows.Forms.Button();
            this.btn_prn_dgv_one = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_prn_dgv_two = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_two = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_cpy_reorder = new System.Windows.Forms.Button();
            this.prn_dgv_two_stream = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_two)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_one);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 557);
            this.panel1.TabIndex = 0;
            // 
            // dgv_one
            // 
            this.dgv_one.AllowUserToOrderColumns = true;
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_one.Location = new System.Drawing.Point(0, 0);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.RowHeadersWidth = 60;
            this.dgv_one.RowTemplate.Height = 24;
            this.dgv_one.Size = new System.Drawing.Size(587, 557);
            this.dgv_one.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_reorder);
            this.panel2.Controls.Add(this.prn_dgv_one_stream);
            this.panel2.Controls.Add(this.btn_prn_dgv_one);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 134);
            this.panel2.TabIndex = 1;
            // 
            // btn_reorder
            // 
            this.btn_reorder.Location = new System.Drawing.Point(476, 27);
            this.btn_reorder.Name = "btn_reorder";
            this.btn_reorder.Size = new System.Drawing.Size(83, 65);
            this.btn_reorder.TabIndex = 0;
            this.btn_reorder.Text = "Reorder left";
            this.btn_reorder.UseVisualStyleBackColor = true;
            this.btn_reorder.Click += new System.EventHandler(this.btn_reorder_Click);
            // 
            // prn_dgv_one_stream
            // 
            this.prn_dgv_one_stream.Location = new System.Drawing.Point(184, 27);
            this.prn_dgv_one_stream.Name = "prn_dgv_one_stream";
            this.prn_dgv_one_stream.Size = new System.Drawing.Size(120, 65);
            this.prn_dgv_one_stream.TabIndex = 2;
            this.prn_dgv_one_stream.Text = "Save left by stream";
            this.prn_dgv_one_stream.UseVisualStyleBackColor = true;
            this.prn_dgv_one_stream.Click += new System.EventHandler(this.prn_dgv_one_stream_Click);
            // 
            // btn_prn_dgv_one
            // 
            this.btn_prn_dgv_one.Location = new System.Drawing.Point(28, 27);
            this.btn_prn_dgv_one.Name = "btn_prn_dgv_one";
            this.btn_prn_dgv_one.Size = new System.Drawing.Size(120, 65);
            this.btn_prn_dgv_one.TabIndex = 1;
            this.btn_prn_dgv_one.Text = "Save left by copy";
            this.btn_prn_dgv_one.UseVisualStyleBackColor = true;
            this.btn_prn_dgv_one.Click += new System.EventHandler(this.btn_prn_dgv_one_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prn_dgv_two_stream);
            this.panel3.Controls.Add(this.btn_cpy_reorder);
            this.panel3.Controls.Add(this.btn_prn_dgv_two);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(727, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 134);
            this.panel3.TabIndex = 2;
            // 
            // btn_prn_dgv_two
            // 
            this.btn_prn_dgv_two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prn_dgv_two.Location = new System.Drawing.Point(313, 27);
            this.btn_prn_dgv_two.Name = "btn_prn_dgv_two";
            this.btn_prn_dgv_two.Size = new System.Drawing.Size(120, 65);
            this.btn_prn_dgv_two.TabIndex = 2;
            this.btn_prn_dgv_two.Text = "Save right by copy";
            this.btn_prn_dgv_two.UseVisualStyleBackColor = true;
            this.btn_prn_dgv_two.Click += new System.EventHandler(this.btn_prn_dgv_two_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_two);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(727, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 557);
            this.panel4.TabIndex = 3;
            // 
            // dgv_two
            // 
            this.dgv_two.AllowUserToOrderColumns = true;
            this.dgv_two.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_two.Location = new System.Drawing.Point(0, 0);
            this.dgv_two.Name = "dgv_two";
            this.dgv_two.RowHeadersWidth = 60;
            this.dgv_two.RowTemplate.Height = 24;
            this.dgv_two.Size = new System.Drawing.Size(588, 557);
            this.dgv_two.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(596, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 134);
            this.panel5.TabIndex = 4;
            // 
            // btn_cpy_reorder
            // 
            this.btn_cpy_reorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpy_reorder.Location = new System.Drawing.Point(36, 27);
            this.btn_cpy_reorder.Name = "btn_cpy_reorder";
            this.btn_cpy_reorder.Size = new System.Drawing.Size(83, 65);
            this.btn_cpy_reorder.TabIndex = 3;
            this.btn_cpy_reorder.Text = "Copy and Reorder";
            this.btn_cpy_reorder.UseVisualStyleBackColor = true;
            this.btn_cpy_reorder.Click += new System.EventHandler(this.btn_cpy_reorder_Click);
            // 
            // prn_dgv_two_stream
            // 
            this.prn_dgv_two_stream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prn_dgv_two_stream.Location = new System.Drawing.Point(459, 27);
            this.prn_dgv_two_stream.Name = "prn_dgv_two_stream";
            this.prn_dgv_two_stream.Size = new System.Drawing.Size(120, 65);
            this.prn_dgv_two_stream.TabIndex = 4;
            this.prn_dgv_two_stream.Text = "Save right by stream";
            this.prn_dgv_two_stream.UseVisualStyleBackColor = true;
            this.prn_dgv_two_stream.Click += new System.EventHandler(this.prn_dgv_two_stream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DataGridView Reorder Column Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_two)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_two;
        private System.Windows.Forms.Button btn_prn_dgv_one;
        private System.Windows.Forms.Button btn_reorder;
        private System.Windows.Forms.Button btn_prn_dgv_two;
        private System.Windows.Forms.Button prn_dgv_one_stream;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_cpy_reorder;
        private System.Windows.Forms.Button prn_dgv_two_stream;
    }
}

