namespace Algoritmos_de_busqueda
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
            lblResult = new Label();
            btnSearch = new Button();
            txtNumbers = new TextBox();
            txtSearch = new TextBox();
            rbtnSequential = new RadioButton();
            rbtnBinary = new RadioButton();
            rbtnHash = new RadioButton();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(291, 28);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightCoral;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(29, 136);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtNumbers
            // 
            txtNumbers.BackColor = Color.FromArgb(255, 128, 128);
            txtNumbers.Location = new Point(29, 28);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(170, 23);
            txtNumbers.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 128, 128);
            txtSearch.Location = new Point(29, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(170, 23);
            txtSearch.TabIndex = 3;
            // 
            // rbtnSequential
            // 
            rbtnSequential.AutoSize = true;
            rbtnSequential.Location = new Point(29, 199);
            rbtnSequential.Name = "rbtnSequential";
            rbtnSequential.Size = new Size(116, 19);
            rbtnSequential.TabIndex = 4;
            rbtnSequential.TabStop = true;
            rbtnSequential.Text = "Search secuential";
            rbtnSequential.UseVisualStyleBackColor = true;
            // 
            // rbtnBinary
            // 
            rbtnBinary.AutoSize = true;
            rbtnBinary.Location = new Point(29, 246);
            rbtnBinary.Name = "rbtnBinary";
            rbtnBinary.Size = new Size(96, 19);
            rbtnBinary.TabIndex = 5;
            rbtnBinary.TabStop = true;
            rbtnBinary.Text = "Search Binary";
            rbtnBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnHash
            // 
            rbtnHash.AutoSize = true;
            rbtnHash.Location = new Point(29, 293);
            rbtnHash.Name = "rbtnHash";
            rbtnHash.Size = new Size(90, 19);
            rbtnHash.TabIndex = 6;
            rbtnHash.TabStop = true;
            rbtnHash.Text = "Search Hash";
            rbtnHash.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(655, 353);
            Controls.Add(rbtnHash);
            Controls.Add(rbtnBinary);
            Controls.Add(rbtnSequential);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Controls.Add(btnSearch);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnSearch;
        private TextBox txtNumbers;
        private TextBox txtSearch;
        private RadioButton rbtnSequential;
        private RadioButton rbtnBinary;
        private RadioButton rbtnHash;
    }
}
