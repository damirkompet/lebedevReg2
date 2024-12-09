using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lebedevReg2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Закрытие формы через 3 секунды (3000 миллисекунд)
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 секунды
            timer.Tick += (s, args) =>
            {
                timer.Stop(); // Останавливаем таймер
                this.Close(); // Закрываем форму
            };
            timer.Start();
        }
    }
}
