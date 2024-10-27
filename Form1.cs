using System.Windows.Forms;

namespace tic_tac_2
{
    public partial class Form1 : Form
    {
        private tictactoe t;
        public Form1()
        {

            InitializeComponent();
            // Create a new instance of the tictac UserControl.
            t = new tictactoe();

            // Set the tictac control to be visible.
            t.Visible = true;

            // Add the tictac control to the form's Controls collection so it displays in the form.
            this.Controls.Add(t);
        }

        private void tictac1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
