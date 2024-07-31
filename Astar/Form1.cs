using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Astar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cozum_Click(object sender, EventArgs e)
        {
            string userInput = sonuc.Text;
            if (ValidateUserInput(userInput))
            {
                // Kullanıcının girdisini 3x3 bir matrise yerleştir
                int[,] matrix = new int[3, 3];
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrix[i, j] = int.Parse(userInput[index].ToString());
                        index++;
                    }
                }

                // Matrisi çözülen oyun tahtası şeklinde butonlara yerleştir
                button1.Text = matrix[0, 0].ToString();
                button2.Text = matrix[0, 1].ToString();
                button3.Text = matrix[0, 2].ToString();
                button4.Text = matrix[1, 0].ToString();
                button5.Text = matrix[1, 1].ToString();
                button6.Text = matrix[1, 2].ToString();
                button7.Text = matrix[2, 0].ToString();
                button8.Text = matrix[2, 1].ToString();
                button9.Text = matrix[2, 2].ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Oyundan çıkmak istediğinden emin misin? ", "Çıkış ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void yenioyun_Click(object sender, EventArgs e)
        {
            string userInput = amac.Text;
            if (ValidateUserInput(userInput))
            {
                OyunTahtasiniOlustur(userInput);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateUserInput(string input)
        {
            // Boş girişi kontrol et
            if (string.IsNullOrWhiteSpace(input))
                return false;

            // Girişin uzunluğunu kontrol et ve 9 sayıdan fazla olup olmadığını kontrol et
            if (input.Length != 9)
                return false;

            // Her karakterin bir sayı olup olmadığını kontrol et
            foreach (var character in input)
            {
                if (!char.IsDigit(character))
                    return false;
            }

            return true;
        }


        private void OyunTahtasiniOlustur(string userInput)
        {
            button1.Text = userInput[0].ToString();
            button2.Text = userInput[1].ToString();
            button3.Text = userInput[2].ToString();
            button4.Text = userInput[3].ToString();
            button5.Text = userInput[4].ToString();
            button6.Text = userInput[5].ToString();
            button7.Text = userInput[6].ToString();
            button8.Text = userInput[7].ToString();
            button9.Text = userInput[8].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
