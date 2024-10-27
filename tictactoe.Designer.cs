namespace tic_tac_2
{
    partial class tictactoe
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            turn = new Label();
            label2 = new Label();
            w1 = new Label();
            label4 = new Label();
            w2 = new Label();
            b5 = new Button();
            b3 = new Button();
            b2 = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            b4 = new Button();
            b1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // turn
            // 
            turn.AutoSize = true;
            turn.Location = new Point(102, 120);
            turn.Margin = new Padding(4, 0, 4, 0);
            turn.Name = "turn";
            turn.Size = new Size(171, 28);
            turn.TabIndex = 1;
            turn.Text = "Turn Player 1- X ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 2;
            label2.Text = "Player1- X  Wins:";
            label2.Click += label2_Click;
            // 
            // w1
            // 
            w1.AutoSize = true;
            w1.Location = new Point(655, 92);
            w1.Margin = new Padding(4, 0, 4, 0);
            w1.Name = "w1";
            w1.Size = new Size(0, 28);
            w1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 4;
            label4.Text = "Player 2- O  Wins:";
            // 
            // w2
            // 
            w2.AutoSize = true;
            w2.Location = new Point(655, 120);
            w2.Margin = new Padding(4, 0, 4, 0);
            w2.Name = "w2";
            w2.Size = new Size(0, 28);
            w2.TabIndex = 5;
            // 
            // b5
            // 
            b5.Dock = DockStyle.Fill;
            b5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b5.Location = new Point(248, 116);
            b5.Margin = new Padding(4);
            b5.Name = "b5";
            b5.Size = new Size(233, 100);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += b2_Click;
            // 
            // b3
            // 
            b3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3.Location = new Point(491, 6);
            b3.Margin = new Padding(4);
            b3.Name = "b3";
            b3.Size = new Size(234, 100);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b2_Click;
            // 
            // b2
            // 
            b2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.Location = new Point(248, 6);
            b2.Margin = new Padding(4);
            b2.Name = "b2";
            b2.Size = new Size(233, 100);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b9
            // 
            b9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b9.Location = new Point(491, 226);
            b9.Margin = new Padding(4);
            b9.Name = "b9";
            b9.Size = new Size(234, 102);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += b2_Click;
            // 
            // b8
            // 
            b8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b8.Location = new Point(248, 226);
            b8.Margin = new Padding(4);
            b8.Name = "b8";
            b8.Size = new Size(233, 102);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += b2_Click;
            // 
            // b7
            // 
            b7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b7.Location = new Point(6, 226);
            b7.Margin = new Padding(4);
            b7.Name = "b7";
            b7.Size = new Size(232, 102);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += b2_Click;
            // 
            // b6
            // 
            b6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b6.Location = new Point(491, 116);
            b6.Margin = new Padding(4);
            b6.Name = "b6";
            b6.Size = new Size(234, 100);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += b2_Click;
            // 
            // b4
            // 
            b4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b4.Location = new Point(6, 116);
            b4.Margin = new Padding(4);
            b4.Name = "b4";
            b4.Size = new Size(232, 100);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += b2_Click;
            // 
            // b1
            // 
            b1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(6, 6);
            b1.Margin = new Padding(4);
            b1.Name = "b1";
            b1.Size = new Size(232, 100);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Location = new Point(102, 170);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(731, 334);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 39);
            label1.Name = "label1";
            label1.Size = new Size(190, 41);
            label1.TabIndex = 6;
            label1.Text = "TIC TAC TOE";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(672, 511);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(515, 511);
            button2.Name = "button2";
            button2.Size = new Size(151, 57);
            button2.TabIndex = 8;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tictactoe
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(w2);
            Controls.Add(label4);
            Controls.Add(w1);
            Controls.Add(label2);
            Controls.Add(turn);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "tictactoe";
            Size = new Size(953, 638);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label turn;
        private Label label2;
        private Label w1;
        private Label label4;
        private Label w2;
        private Button b5;
        private Button b3;
        private Button b2;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b4;
        private Button b1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
