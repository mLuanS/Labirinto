namespace Labirinto
{
    public partial class Form1 : Form
    {
        Point startLocation;
        int countDown= 0;
        public Form1()
        {
            InitializeComponent();
            InicioGame();
        }
        private void InicioGame()
        {
            GameTempo.Start();
            startLocation = panel2.Location;
            Cursor.Position = PointToScreen(startLocation);
            countDown = 30;
        }

        private void MurosLabirinto_MouseEnter(object sender, EventArgs e)
        {
            InicioGame();

        }

        private void GameTempo_Tick(object sender, EventArgs e)
        {
            if (countDown < 0)
            {
                GameTempo.Stop();

                DialogResult userChoice = MessageBox.Show("Você perdeu\n Quer jogar de novo?","Information", MessageBoxButtons.YesNo );
                if (userChoice == DialogResult.Yes)
                {
                    InicioGame();
                }
                else
                {
                    this.Close();
                }
            }
            lblTempo.Text = countDown.ToString();
            countDown  --;
        }
    }
}
