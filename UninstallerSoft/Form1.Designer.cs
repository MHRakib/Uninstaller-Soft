namespace UninstallerSoft
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.all_prog_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.large_program_button = new System.Windows.Forms.Button();
            this.start_up_button = new System.Windows.Forms.Button();
            this.recent_install_button = new System.Windows.Forms.Button();
            this.rare_button = new System.Windows.Forms.Button();
            this.show_dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(205, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // all_prog_button
            // 
            this.all_prog_button.AutoEllipsis = true;
            this.all_prog_button.BackColor = System.Drawing.Color.Navy;
            this.all_prog_button.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.all_prog_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.all_prog_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_prog_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_prog_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all_prog_button.Location = new System.Drawing.Point(3, 3);
            this.all_prog_button.Name = "all_prog_button";
            this.all_prog_button.Size = new System.Drawing.Size(146, 38);
            this.all_prog_button.TabIndex = 0;
            this.all_prog_button.Text = "All Programs";
            this.all_prog_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.all_prog_button.UseVisualStyleBackColor = false;
            this.all_prog_button.Click += new System.EventHandler(this.color_change);
            this.all_prog_button.MouseEnter += new System.EventHandler(this.color_mouse_point);
            this.all_prog_button.MouseLeave += new System.EventHandler(this.mouse_leave);
            this.all_prog_button.MouseHover += new System.EventHandler(this.color_mouse_point);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menu_tableLayoutPanel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 504);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menu_tableLayoutPanel
            // 
            this.menu_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_tableLayoutPanel.ColumnCount = 1;
            this.menu_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menu_tableLayoutPanel.Controls.Add(this.large_program_button, 0, 4);
            this.menu_tableLayoutPanel.Controls.Add(this.start_up_button, 0, 3);
            this.menu_tableLayoutPanel.Controls.Add(this.all_prog_button, 0, 0);
            this.menu_tableLayoutPanel.Controls.Add(this.recent_install_button, 0, 1);
            this.menu_tableLayoutPanel.Controls.Add(this.rare_button, 0, 2);
            this.menu_tableLayoutPanel.Location = new System.Drawing.Point(58, 147);
            this.menu_tableLayoutPanel.Name = "menu_tableLayoutPanel";
            this.menu_tableLayoutPanel.RowCount = 5;
            this.menu_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9993F));
            this.menu_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0007F));
            this.menu_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menu_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menu_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menu_tableLayoutPanel.Size = new System.Drawing.Size(152, 249);
            this.menu_tableLayoutPanel.TabIndex = 2;
            // 
            // large_program_button
            // 
            this.large_program_button.BackColor = System.Drawing.Color.Navy;
            this.large_program_button.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.large_program_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.large_program_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.large_program_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.large_program_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.large_program_button.Location = new System.Drawing.Point(3, 199);
            this.large_program_button.Name = "large_program_button";
            this.large_program_button.Size = new System.Drawing.Size(146, 38);
            this.large_program_button.TabIndex = 3;
            this.large_program_button.Text = "Large Programs";
            this.large_program_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.large_program_button.UseVisualStyleBackColor = false;
            this.large_program_button.Click += new System.EventHandler(this.large_program_button_Click);
            // 
            // start_up_button
            // 
            this.start_up_button.BackColor = System.Drawing.Color.Navy;
            this.start_up_button.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.start_up_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.start_up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_up_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_up_button.Location = new System.Drawing.Point(3, 150);
            this.start_up_button.Name = "start_up_button";
            this.start_up_button.Size = new System.Drawing.Size(146, 38);
            this.start_up_button.TabIndex = 3;
            this.start_up_button.Text = "Start Up Programs";
            this.start_up_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.start_up_button.UseVisualStyleBackColor = false;
            this.start_up_button.Click += new System.EventHandler(this.start_up_button_Click);
            // 
            // recent_install_button
            // 
            this.recent_install_button.BackColor = System.Drawing.Color.Navy;
            this.recent_install_button.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.recent_install_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.recent_install_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recent_install_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent_install_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recent_install_button.Location = new System.Drawing.Point(3, 52);
            this.recent_install_button.Name = "recent_install_button";
            this.recent_install_button.Size = new System.Drawing.Size(146, 38);
            this.recent_install_button.TabIndex = 1;
            this.recent_install_button.Text = "Recently Installed";
            this.recent_install_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recent_install_button.UseVisualStyleBackColor = false;
            this.recent_install_button.Click += new System.EventHandler(this.recent_install_button_Click);
            // 
            // rare_button
            // 
            this.rare_button.BackColor = System.Drawing.Color.Navy;
            this.rare_button.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.rare_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.rare_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rare_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rare_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rare_button.Location = new System.Drawing.Point(3, 101);
            this.rare_button.Name = "rare_button";
            this.rare_button.Size = new System.Drawing.Size(146, 38);
            this.rare_button.TabIndex = 2;
            this.rare_button.Text = "Rarely Used";
            this.rare_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rare_button.UseVisualStyleBackColor = false;
            this.rare_button.Click += new System.EventHandler(this.rare_button_Click);
            // 
            // show_dataGridView
            // 
            this.show_dataGridView.AllowUserToAddRows = false;
            this.show_dataGridView.AllowUserToDeleteRows = false;
            this.show_dataGridView.AllowUserToResizeColumns = false;
            this.show_dataGridView.AllowUserToResizeRows = false;
            this.show_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.show_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.show_dataGridView.Location = new System.Drawing.Point(205, 66);
            this.show_dataGridView.Name = "show_dataGridView";
            this.show_dataGridView.RowHeadersVisible = false;
            this.show_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_dataGridView.Size = new System.Drawing.Size(644, 347);
            this.show_dataGridView.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(38, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 156);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 501);
            this.Controls.Add(this.show_dataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Uninstaller Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button all_prog_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel menu_tableLayoutPanel;
        private System.Windows.Forms.Button recent_install_button;
        private System.Windows.Forms.Button rare_button;
        private System.Windows.Forms.Button large_program_button;
        private System.Windows.Forms.Button start_up_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView show_dataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

