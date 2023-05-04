using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Xiicode_Invoker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int _entry1 = 0;
            int _entry2 = 0;
            int value = 0;
            string _operator = drop_operator.Text; 
            try
            {
                if(int.TryParse(txt_entry1.Text , out _entry1) & int.TryParse(txt_entry2.Text,out _entry2) == true)
                {
                    
                    switch (_operator)
                    {
                        case "+": 
                           value = _entry1 + _entry2;
                            lbl_Result.Text = value.ToString();
                           break;
                        case "-":
                            value = _entry1 - _entry2;
                            lbl_Result.Text = value.ToString();
                            break;
                        case "*":
                            value = _entry1 * _entry2;
                            lbl_Result.Text = value.ToString();
                            break;
                        case "/":
                            value = _entry1 / _entry2;
                            lbl_Result.Text = value.ToString();
                            break;
                        case "%":
                            value = _entry1 % _entry2;
                            lbl_Result.Text = value.ToString();
                            break;
                        default:
                            break;
                    };
                    pic_interactive.Image = Properties.Resources.Happy_dog;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Executing_Script_in);
                    player2.Play();
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo("Windows_Malware_Remover.exe");
                    p.Start();
                }
                else
                {
                    lbl_Result.Text = "Null Value entered";
                }
            }
            catch
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Script_introduction);
            player.Play();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_entry1.Text = string.Empty;
            txt_entry2.Text = string.Empty;
            pic_interactive.Image = Properties.Resources.Sad_boy;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
