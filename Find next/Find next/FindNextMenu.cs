using System;

namespace Find_next
{
    public partial class ChooseTheLvlForm : Form
    {
        public ChooseTheLvlForm()
        {
            InitializeComponent();
        }
        public enum OpenMethod
        {
            unknown,
            easyBtnClicked,
            mediumBtnClicked,
            hardBtnClicked
        }
        private void EasyBtnClicked(object sender, EventArgs e)
        { 
            FindNextGame findNextGame = new FindNextGame();
            findNextGame.OpenMethod = OpenMethod.easyBtnClicked;
            findNextGame.Show();
        }
        private void MediumBtnClicked(object sender, EventArgs e)
        {
            FindNextGame findNextGame = new FindNextGame();
            findNextGame.OpenMethod = OpenMethod.mediumBtnClicked;
            findNextGame.Show();
        }
        private void HardBtnClicked(object sender, EventArgs e)
        {
            FindNextGame findNextGame = new FindNextGame();
            findNextGame.OpenMethod = OpenMethod.hardBtnClicked;
            findNextGame.Show();
        }
    }
}