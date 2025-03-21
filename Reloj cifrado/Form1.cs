using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Reloj_cifrado
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer timer1;
        private static readonly byte[] key = Encoding.UTF8.GetBytes("0123456789abcdef");
        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font("Arial", 24, FontStyle.Bold); 


            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(T_tick);
            timer1.Start();
        }

        private void T_tick(object sender, EventArgs e)
        {
            if (label1 != null)
            {
                string horaActual = DateTime.Now.ToString("HH:mm:ss");
                string horaCifrada = Convert.ToBase64String(Encoding.UTF8.GetBytes(horaActual));
                label1.Text = horaCifrada;
                
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
