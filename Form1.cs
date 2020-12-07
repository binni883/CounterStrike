using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterStrike
{
    public partial class GameLoadForm : Form

    { 
         

            Game_Logic game_object = new Game_Logic();
        public GameLoadForm()
        {
            InitializeComponent();
        }

        private void Game_form_load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAgain.Enabled = false;
        }
       
   
        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_Shoot.Enabled = false;
            btn_ShootAgain.Enabled = false;
            btn_load.Enabled = false;
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("CounterStrike.Resources.load1.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picbox_mainbox.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(CounterStrike.Properties.Resources.Gun_load);

            Sound_Object.Play();

            game_object.load_data = 1;


        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_Shoot.Enabled = true;
            btn_ShootAgain.Enabled = true;
            btn_spin.Enabled = false;
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("CounterStrike.Resources.Spin2.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picbox_mainbox.Image = bmp_Object;

            Random Rnd_obj = new Random();
            game_object.spin_data = Rnd_obj.Next(1, 7);


            MessageBox.Show("Bullet Position after spining the chamber is" + game_object.spin_data.ToString());



        }
        // Game_Form_Load playagain page will Enable load button and disable both shoot and spin button

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAgain.Enabled = false;
        }
       
        private void c_Load(object sender, EventArgs e)
        {

        }
        //code to show the exit button on click

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rule_Click(object sender, EventArgs e)
        {
            Rule rules_obj = new Rule();
            rules_obj.Show();
            this.Hide();
        } 

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click and also add a code of audio

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("CounterStrike.Resources.Shoot3.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picbox_mainbox.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(CounterStrike.Properties.Resources.Gun_shot);

            Sound_Object.Play();

            game_object.shoot_data = game_object.shoot_method();
            if (game_object.shoot_data == 1)
            {
                // Sound code
                //System.Media.SoundPlayer Sound_Object1 = new System.Media.SoundPlayer(CounterStrike.Properties.Resources.Shoot3);
                // Sound_Object1.Play();
                MessageBox.Show("Bullet shot on your head. You are dead");
            }
            else
            {
                MessageBox.Show("emply shoot");
            }




        }

        private void btn_ShootAgain_Click(object sender, EventArgs e)
        {
            {
                if (game_object.chances  <= 2)
                {
                    game_object.shoot_data = game_object.shoot_method();
                    if (game_object.shoot_data == 1)
                    {
                     
                        MessageBox.Show("Wow!! you are safe. you win the game");
                        btn_Shoot.Enabled = false;
                        btn_ShootAgain.Enabled = false;
                    }
                    else
                    {
                        game_object.chances++;
                        if (game_object.chances == 2)
                        {
                            MessageBox.Show("Your 2 chances are finished. you lose the game");
                        }
                        else
                        {
                            MessageBox.Show("emply shoot");
                        }
                    }

                }
            }
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(CounterStrike.Properties.Resources.Gun_shot);

            Sound_Object.Play();
        }
    }
}
 