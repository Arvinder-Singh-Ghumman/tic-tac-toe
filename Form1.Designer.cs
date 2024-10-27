namespace tic_tac_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            tictac1 = new tictactoe();
            SuspendLayout();
            // 
            // tictac1
            // 
            tictac1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tictac1.BackColor = SystemColors.AppWorkspace;
            tictac1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tictac1.Location = new Point(-8, -3);
            tictac1.Margin = new Padding(4);
            tictac1.Name = "tictac1";
            tictac1.Size = new Size(1377, 758);
            tictac1.TabIndex = 0;
            tictac1.Load += tictac1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 602);
            Controls.Add(tictac1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private tictactoe tictac1;
    }
}
