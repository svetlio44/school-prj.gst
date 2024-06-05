using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadedTimersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Код за изпълнение при всяко "тикване" на таймера 1
            MessageBox.Show("Таймер 1 активен!", "Информация");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Код за изпълнение при всяко "тикване" на таймера 2
            MessageBox.Show("Таймер 2 активен!", "Информация");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Стартиране на таймерите в различни нишки
            Task.Run(() => timer1.Start());
            Task.Run(() => timer2.Start());
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }
    }
}
