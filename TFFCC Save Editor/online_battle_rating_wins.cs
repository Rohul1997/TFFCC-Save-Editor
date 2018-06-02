/*
 *   This file is part of TFFCC Save Editor
 *   Copyright (C) 2017-2018 Rohul1997
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, version 3 of the License
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 *   Additional Terms 7.b and 7.c of GPLv3 apply to this file:
 *       * Requiring preservation of specified reasonable legal notices or
 *         author attributions in that material or in the Appropriate Legal
 *         Notices displayed by works containing it.
 *       * Prohibiting misrepresentation of the origin of that material,
 *         or requiring that modified versions of such material be marked in
 *         reasonable ways as different from the original version.
 */

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
