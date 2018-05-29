using System;
using System.Windows.Forms;

namespace TFFCC_Save_Editor
{
    public partial class online_battle_rating_wins : Form
    {
        byte[] savedata;
        bool reading = true;
        public online_battle_rating_wins(ref byte[] sd)
        {
            InitializeComponent();

            savedata = sd;
            total_numericUpDown.Enabled = anyone_numericUpDown.Enabled = friends_numericUpDown.Enabled = true;
            Read_rating();
            reading = false;
        }

        private void Read_rating()
        {
            try
            {
                //Read total wins
                total_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37E6);

                //Read anyone wins
                anyone_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x381C);

                //Read friends wins
                friends_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x381E);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to read online battle rating wins\n\n{ex}", "Error");
            }
        }

        private void Write_rating(object sender, EventArgs e)
        {
            if (reading) return;
            try
            {
                //Write total wins
                Array.Copy(BitConverter.GetBytes((ushort)total_numericUpDown.Value), 0, savedata, 0x37E6, 2);

                //Write anyone wins
                Array.Copy(BitConverter.GetBytes((ushort)anyone_numericUpDown.Value), 0, savedata, 0x381C, 2);

                //Write friends wins
                Array.Copy(BitConverter.GetBytes((ushort)friends_numericUpDown.Value), 0, savedata, 0x381E, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to write online battle rating wins\n\n{ex}", "Error");
            }
        }
    }
}
