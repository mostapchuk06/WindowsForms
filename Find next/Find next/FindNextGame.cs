using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Find_next.ChooseTheLvlForm;

namespace Find_next
{
    public partial class FindNextGame : Form
    {
        public OpenMethod OpenMethod { get; set; } = OpenMethod.unknown;
        public int timerInitialValue = 0; // початкове значення таймера
        public int wastedTime = 0; 
        public int currentIndex = 0;

        public FindNextGame()
        {
            InitializeComponent();
            GameTimer = new System.Windows.Forms.Timer();
            GameTimer.Interval = 1000;
            GameTimer.Tick += new EventHandler(GameStartTick);          
            TimerLbl.Text = timerInitialValue.ToString();
            Load += new EventHandler(FindNextGame_Load);
            
        }
        private void FindNextGame_Load(object sender, EventArgs e)
        {
            if (OpenMethod == OpenMethod.easyBtnClicked)
                timerInitialValue = 30;
            else if (OpenMethod == OpenMethod.mediumBtnClicked)
                timerInitialValue = 20;
            else if (OpenMethod == OpenMethod.hardBtnClicked)
                timerInitialValue = 10;

            TimerLbl.Text = timerInitialValue.ToString();
            
        }
        private void GameStartTick(object sender, EventArgs e)
        {                    
            timerInitialValue--; 
            wastedTime++;
            if (timerInitialValue == 0)
            {
                MessageBox.Show("You lose!");
                Close();
            }
            else
            {
                TimerLbl.Text = timerInitialValue.ToString();
            }
           
        }
        private void StartBtnClicked(object sender, EventArgs e)
        {
            GameTimer.Start();

            Random random = new Random();
            int[] numbers = new int[16];
            int index = 0;
            while (index < 16)
            {
                int randomNumber = random.Next(1, 17);
                if (!numbers.Contains(randomNumber))
                {
                    numbers[index] = randomNumber;
                    index++;
                }
            }
            index = 0;
            foreach (Button button in Controls.OfType<Button>())
            {
                if (button.Name.StartsWith("button"))
                {
                    button.Text = numbers[index].ToString();
                    index++;
                }
            }
        }
        private void ButtonClicked(object sender, EventArgs e)
        {          
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Text);
            if (buttonNumber == currentIndex + 1)
            {
                clickedButton.BackColor = Color.GreenYellow;
                currentIndex++;
                clickedButton.Enabled = false;
                if (currentIndex == 16)
                {
                    GameTimer.Stop();
                    MessageBox.Show($"You won!\n" +
                                    $"Wasted time: {wastedTime} seconds", "Victory");
                    Close();
                }
            }
            else
            {
                clickedButton.BackColor = Color.Salmon;
            }
        }    
    }
}
