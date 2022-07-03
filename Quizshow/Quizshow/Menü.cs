namespace Quizshow
{
    using Quiz;
    public partial class Quizshows : Form
    {
        public Quizshows()
        {
            InitializeComponent();
        }

        private void tenVsWilli_Click(object sender, EventArgs e)
        {
            TenVsWilli form = new TenVsWilli();
            form.ShowDialog();
        }

        private void longest_Click(object sender, EventArgs e)
        {
            Longest form = new Longest();
            form.ShowDialog();
        }
        private void costs_Click(object sender, EventArgs e)
        {
            auktion form = new auktion();
            form.ShowDialog();
        }
        private void spotify_Click(object sender, EventArgs e)
        {
            Spotify form = new Spotify();
            form.ShowDialog();
        }
        private void sloxikon_Click(object sender, EventArgs e)
        {
            Sloxikon form = new Sloxikon();
            form.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}