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
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TFFCC_Save_Editor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            //intitalise songs datagrid
            for (int i = 0; i < 963; i++)
            {
                var index = Songs_dataGridView.Rows.Add();
                Songs_dataGridView.Rows[index].Cells["Series"].Value = Databases.songs_series[index];
                Songs_dataGridView.Rows[index].Cells["Type"].Value = Databases.songs_type[index];
                Songs_dataGridView.Rows[index].Cells["Level_name"].Value = Databases.songs_level_name[index];
                Songs_dataGridView.Rows[index].Cells["Difficulty"].Value = Databases.songs_difficulty[index];
            }

            //initialise items datagrid
            for (int i = 0; i < 92; i++)
            {
                var index = Items_dataGridView.Rows.Add();
                Items_dataGridView.Rows[index].Cells["Item"].Value = Databases.items[index];
            }

            //initialise cards datagrid
            for (int i = 0; i < 486; i++)
            {
                var index = Cards_dataGridView.Rows.Add();
                Cards_dataGridView.Rows[index].Cells["Card_name"].Value = Databases.collectacards[index];

                if (Cards_dataGridView.Rows[index].Cells["Card_name"].Value.ToString().Contains("[N]"))
                {
                    Cards_dataGridView.Rows[index].Cells["Rarity"].Value = "Normal";
                }
                else if (Cards_dataGridView.Rows[index].Cells["Card_name"].Value.ToString().Contains("[R]"))
                {
                    Cards_dataGridView.Rows[index].Cells["Rarity"].Value = "Rare";
                }
                else if (Cards_dataGridView.Rows[index].Cells["Card_name"].Value.ToString().Contains("[P]"))
                {
                    Cards_dataGridView.Rows[index].Cells["Rarity"].Value = "Premium";
                }
            }
        }

        OpenFileDialog open_extsavedata = new OpenFileDialog();
        OpenFileDialog open_savedata = new OpenFileDialog();

        private void Open_extsavedata_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                open_extsavedata.Filter = " extsavedata.bk Files|extsavedata.bk|All Files (*.*)|*.*";
                if (open_extsavedata.ShowDialog() == DialogResult.OK)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(open_extsavedata.FileName));

                    //Main songs
                    int Total_cleared = 0;
                    int Total_played = 0;
                    int Main_count = 0;
                    int index = 0;
                    for (int i = 0x5FD54; i < 0x66F48; i += 0x2C)
                    {
                        //Read Score value for song
                        br.BaseStream.Position = i;
                        Songs_dataGridView.Rows[index].Cells["Score"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read chain value for song
                        br.BaseStream.Position = i + 0x04;
                        Songs_dataGridView.Rows[index].Cells["Chain"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read rank value for song
                        br.BaseStream.Position = i + 0x08;
                        var rank = br.ReadBytes(0x05);
                        if (rank[0] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "SSS";
                        }
                        else if (rank[0] == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "SS";
                        }
                        else if (rank[0] == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "S";
                        }
                        else if (rank[0] == 0x03)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "A";
                        }
                        else if (rank[0] == 0x04)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "B";
                        }
                        else if (rank[0] == 0x05)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "C";
                        }
                        else if (rank[0] == 0x06)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "D";
                        }
                        else if (rank[0] == 0x07)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "E";
                        }
                        else if (rank[0] == 0x08 && rank[4] != 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "F";
                        }
                        else if (rank[0] == 0x08 && rank[4] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "Unplayed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "Unknown";
                        }

                        //Read status value for song
                        br.BaseStream.Position = i + 0x09;
                        var status = br.ReadBytes(0x04);
                        if (status[0] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "All-Critical";
                        }
                        else if (status[0] == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Perfect Chain";
                        }
                        else if (status[0] == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Clear";
                        }
                        else if (status[0] == 0x03 && status[3] != 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Failed";
                        }
                        else if (status[0] == 0x03 && status[3] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unplayed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unknown";
                        }

                        //Read playstyle value for song
                        br.BaseStream.Position = i + 0x0A;
                        var playstyle = br.ReadByte();
                        if (playstyle == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Stylus";
                        }
                        else if (playstyle == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Button";
                        }
                        else if (playstyle == 0x03)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Hybrid";
                        }
                        else if (playstyle == 0x04)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "One-Handed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Unplayed";
                        }

                        //Read times played value for song
                        br.BaseStream.Position = i + 0x0C;
                        Songs_dataGridView.Rows[index].Cells["Times_played"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read times cleared value for song
                        br.BaseStream.Position = i + 0x10;
                        Songs_dataGridView.Rows[index].Cells["Times_cleared"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read date value for song
                        br.BaseStream.Position = i + 0x26;
                        var year = BitConverter.ToInt16(br.ReadBytes(0x02), 0);
                        br.BaseStream.Position = i + 0x28;
                        var month = br.ReadByte();
                        br.BaseStream.Position = i + 0x29;
                        var day = br.ReadByte();
                        Songs_dataGridView.Rows[index].Cells["Date"].Value = $"{day}.{month}.{year}";

                        Total_played += Convert.ToInt32(Songs_dataGridView.Rows[index].Cells["Times_played"].Value);
                        Total_cleared += Convert.ToInt32(Songs_dataGridView.Rows[index].Cells["Times_cleared"].Value);
                        index++;
                        ++Main_count;
                    }
                    label1.Text = $"Main Songs Found: {Main_count}";

                    //DLC songs
                    int DLC_count = 0;
                    for (int i = 0x670D4; i < 0x6A464; i += 0x2C)
                    {
                        //Read Score value for song
                        br.BaseStream.Position = i;
                        Songs_dataGridView.Rows[index].Cells["Score"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read chain value for song
                        br.BaseStream.Position = i + 0x04;
                        Songs_dataGridView.Rows[index].Cells["Chain"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read rank value for song
                        br.BaseStream.Position = i + 0x08;
                        var rank = br.ReadBytes(0x05);
                        if (rank[0] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "SSS";
                        }
                        else if (rank[0] == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "SS";
                        }
                        else if (rank[0] == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "S";
                        }
                        else if (rank[0] == 0x03)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "A";
                        }
                        else if (rank[0] == 0x04)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "B";
                        }
                        else if (rank[0] == 0x05)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "C";
                        }
                        else if (rank[0] == 0x06)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "D";
                        }
                        else if (rank[0] == 0x07)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "E";
                        }
                        else if (rank[0] == 0x08 && rank[4] != 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "F";
                        }
                        else if (rank[0] == 0x08 && rank[4] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "Unplayed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Rank"].Value = "Unknown";
                        }

                        //Read status value for song
                        br.BaseStream.Position = i + 0x09;
                        var status = br.ReadBytes(0x04);
                        if (status[0] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "All-Critical";
                        }
                        else if (status[0] == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Perfect Chain";
                        }
                        else if (status[0] == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Clear";
                        }
                        else if (status[0] == 0x03 && status[3] != 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Failed";
                        }
                        else if (status[0] == 0x03 && status[3] == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unplayed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unknown";
                        }

                        //Read playstyle value for song
                        br.BaseStream.Position = i + 0x0A;
                        var playstyle = br.ReadByte();
                        if (playstyle == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Stylus";
                        }
                        else if (playstyle == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Button";
                        }
                        else if (playstyle == 0x03)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Hybrid";
                        }
                        else if (playstyle == 0x04)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "One-Handed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Unplayed";
                        }

                        //Read times played value for song
                        br.BaseStream.Position = i + 0x0C;
                        Songs_dataGridView.Rows[index].Cells["Times_played"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read times cleared value for song
                        br.BaseStream.Position = i + 0x10;
                        Songs_dataGridView.Rows[index].Cells["Times_cleared"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read date value for song
                        br.BaseStream.Position = i + 0x26;
                        var year = BitConverter.ToInt16(br.ReadBytes(0x02), 0);
                        br.BaseStream.Position = i + 0x28;
                        var month = br.ReadByte();
                        br.BaseStream.Position = i + 0x29;
                        var day = br.ReadByte();
                        Songs_dataGridView.Rows[index].Cells["Date"].Value = $"{day}.{month}.{year}";

                        Total_played += Convert.ToInt32(Songs_dataGridView.Rows[index].Cells["Times_played"].Value);
                        Total_cleared += Convert.ToInt32(Songs_dataGridView.Rows[index].Cells["Times_cleared"].Value);
                        index++;
                        ++DLC_count;
                    }
                    label2.Text = $"DLC Songs Found: {DLC_count}";
                    label3.Text = $"Total Songs Found: {Main_count + DLC_count}";
                    label10.Text = $"Total Times Played: {Total_played}";
                    label11.Text = $"Total Times Cleared: {Total_cleared}";
                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid extsavedata.bk", "Failed to open the file");
            }
        }

        private void Open_savedata_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////Set the combobox items from the monsters database
            //comboBox1.DataSource = Databases.monsters;

            ////Set the combobox items from the characters database
            //comboBox4.DataSource = Databases.characters;

            ////create list from items remove cards.
            //List<string> ItemsCardsRemoved = new List<string>(Databases.items);

            ////Find N and R cards from the items database
            //var itemN = ItemsCardsRemoved.FindAll(i => i.Substring(4).StartsWith(" [N]"));
            //var itemR = ItemsCardsRemoved.FindAll(i => i.Substring(4).StartsWith(" [R]"));

            ////Remove N and R cards from the items database
            //foreach (string i in itemN)
            //{
            //    ItemsCardsRemoved.Remove(i);
            //}
            //foreach (string i in itemR)
            //{
            //    ItemsCardsRemoved.Remove(i);
            //}

            ////Set the combobox items from the items database with the N and R cards removed
            //comboBox2.DataSource = ItemsCardsRemoved;

            ////Set the combobox items from the items database without anything removed
            //comboBox3.DataSource = Databases.items;

            ////This would be to check what is the current item selected on the items combobox and then get the index for its position on the original database
            //Console.WriteLine(Databases.items.FindIndex(i => i.Equals("#001 [N] CollectaCard")));

            try
            {
                open_savedata.Filter = " savedata.bk Files|savedata.bk|All Files (*.*)|*.*";
                if (open_savedata.ShowDialog() == DialogResult.OK)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(open_savedata.FileName));

                    //Items
                    int Item_count = 0;
                    int index = 0;
                    for (int i = 0xCA0; i < 0xCFC; i++)
                    {
                        //Read item quantity
                        br.BaseStream.Position = i;
                        Items_dataGridView.Rows[index].Cells["Quantity"].Value = br.ReadByte() - 0x80;
                        index++;
                        ++Item_count;
                    }
                    label8.Text = $"Items Found: {Item_count}";

                    //CollectaCards
                    int Card_count = 0;
                    index = 0;
                    for (int i = 0x3497; i < 0x367D; i++)
                    {
                        //Read card quantity
                        br.BaseStream.Position = i;
                        Cards_dataGridView.Rows[index].Cells["Card_quantity"].Value = br.ReadByte() - 0x80;
                        index++;
                        ++Card_count;
                    }
                    label9.Text = $"Cards Found: {Card_count}";

                    //Profile
                    //Read player name
                    br.BaseStream.Position = 0x12;
                    Player_name_textBox.Text = Encoding.Unicode.GetString(br.ReadBytes(0x0C));

                    //Read Rhythmia
                    br.BaseStream.Position = 0x2C;
                    Rhythmia_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read Progress
                    br.BaseStream.Position = 0x40;
                    var star = br.ReadByte();
                    if (star == 0x00)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x01)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x02)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x03)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x04)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x05)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x06)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x07)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x08)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                    }
                    else if (star == 0x09)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Half;
                    }
                    else if (star == 0x0A)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star;
                    }
                    else if (star == 0x0B)
                    {
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Shiny;
                    }

                    //Read Trophies
                    br.BaseStream.Position = 0x3962;
                    Trophies_textBox.Text = br.ReadByte().ToString() + "/96";

                    //Total Counts
                    //Read total playtime
                    br.BaseStream.Position = 0x38;
                    TimeSpan time = TimeSpan.FromSeconds(BitConverter.ToInt32(br.ReadBytes(0x04), 0));
                    Total_playtime_hours_numericUpDown.Value = Convert.ToInt16(Math.Floor(time.TotalHours));
                    Total_playtime_minutes_numericUpDown.Value = time.Minutes;
                    Total_playtime_seconds_numericUpDown.Value = time.Seconds;

                    //Read songs played
                    br.BaseStream.Position = 0x3738;
                    Songs_played_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read enemies defeated
                    br.BaseStream.Position = 0x373C;
                    Enemies_defeated_numericUpDown1.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read distance travelled
                    br.BaseStream.Position = 0x3740;
                    Distance_traveled_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read chained triggers
                    br.BaseStream.Position = 0x3748;
                    Chained_triggers_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read critical triggers
                    br.BaseStream.Position = 0x374C;
                    Critical_triggers_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read proficards recieved
                    br.BaseStream.Position = 0x3750;
                    ProfiCards_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read streetpasses
                    br.BaseStream.Position = 0x3754;
                    StreetPasses_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Music Stages
                    //Read total songs
                    br.BaseStream.Position = 0x3780;
                    Total_songs_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read basic scores cleared
                    br.BaseStream.Position = 0x3784;
                    Basic_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read expert scores cleared
                    br.BaseStream.Position = 0x3788;
                    Expert_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read ultimate scores cleared
                    br.BaseStream.Position = 0x378C;
                    Ultimate_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read perfect chains achieved
                    br.BaseStream.Position = 0x3790;
                    Perfect_chains_achieved_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read daily specials cleared
                    br.BaseStream.Position = 0x3794;
                    Daily_specials_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read crowns recieved
                    br.BaseStream.Position = 0x3798;
                    Crowns_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read sss ranks recieved
                    br.BaseStream.Position = 0x379C;
                    SSS_ranks_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Quest Medleys
                    //Read short quests cleared
                    br.BaseStream.Position = 0x37B8;
                    Short_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read medium quests cleared
                    br.BaseStream.Position = 0x37BA;
                    Medium_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read long quests cleared
                    br.BaseStream.Position = 0x37BC;
                    Long_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read inherited quests cleared
                    br.BaseStream.Position = 0x37BE;
                    Inherited_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read total quests cleared
                    Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();

                    //Read bosses conquered
                    br.BaseStream.Position = 0x37C0;
                    Bosses_conquered_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read stages cleared
                    br.BaseStream.Position = 0x37C4;
                    Stages_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read keys used
                    br.BaseStream.Position = 0x37C8;
                    Keys_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Versus Mode
                    //Read online battle rating score
                    br.BaseStream.Position = 0x56;
                    Online_battle_rating_score_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read online battle rating wins
                    br.BaseStream.Position = 0x37E6;
                    Online_battle_rating_wins_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read online battle rating losses
                    br.BaseStream.Position = 0x37E8;
                    Online_battle_rating_losses_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read online battle rating ties
                    br.BaseStream.Position = 0x37EA;
                    Online_battle_rating_ties_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read local battle rating score
                    br.BaseStream.Position = 0x54;
                    Local_battle_rating_score_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read local battle rating wins
                    br.BaseStream.Position = 0x37EE;
                    Local_battle_rating_wins_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read local battle rating losses
                    br.BaseStream.Position = 0x37F0;
                    Local_battle_rating_losses_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read local battle rating ties
                    br.BaseStream.Position = 0x37F2;
                    Local_battle_rating_ties_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //set total rating score
                    Total_rating_score_textBox.Text = (Online_battle_rating_score_numericUpDown.Value + Local_battle_rating_score_numericUpDown.Value).ToString();

                    //set total rating wins
                    Total_rating_wins_textBox.Text = (Online_battle_rating_wins_numericUpDown.Value + Local_battle_rating_wins_numericUpDown.Value).ToString();

                    //set total rating losses
                    Total_rating_losses_textBox.Text = (Online_battle_rating_losses_numericUpDown.Value + Local_battle_rating_losses_numericUpDown.Value).ToString();

                    //set total rating ties
                    Total_rating_ties_textBox.Text = (Online_battle_rating_ties_numericUpDown.Value + Local_battle_rating_ties_numericUpDown.Value).ToString();

                    //Read ai battle victories
                    br.BaseStream.Position = 0x37F6;
                    AI_battle_victories_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read highest rank
                    br.BaseStream.Position = 0x37FA;
                    var rank = br.ReadBytes(0x03);
                    if (rank[0] == 0x00)
                    {
                        Highest_rank_comboBox.SelectedIndex = 0;
                    }
                    else if (rank[0] == 0x01)
                    {
                        Highest_rank_comboBox.SelectedIndex = 1;
                    }
                    else if (rank[0] == 0x02)
                    {
                        Highest_rank_comboBox.SelectedIndex = 2;
                    }
                    else if (rank[0] == 0x03)
                    {
                        Highest_rank_comboBox.SelectedIndex = 3;
                    }

                    //Read highest rank class
                    if (rank[2] == 0x01)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 0;
                    }
                    else if (rank[2] == 0x02)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 1;
                    }
                    else if (rank[2] == 0x03)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 2;
                    }
                    else if (rank[2] == 0x04)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 3;
                    }
                    else if (rank[2] == 0x05)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 4;
                    }
                    else if (rank[2] == 0x06)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 5;
                    }
                    else if (rank[2] == 0x07)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 6;
                    }
                    else if (rank[2] == 0x08)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 7;
                    }
                    else if (rank[2] == 0x09)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 8;
                    }
                    else if (rank[2] == 0x0A)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 9;
                    }
                    else if (rank[2] == 0x0B)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 10;
                    }
                    else if (rank[2] == 0x0C)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 11;
                    }
                    else if (rank[2] == 0x0D)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 12;
                    }
                    else if (rank[2] == 0x0E)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 13;
                    }
                    else if (rank[2] == 0x0F)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 14;
                    }
                    else if (rank[2] == 010)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 15;
                    }
                    else if (rank[2] == 0x11)
                    {
                        Highest_rank_class_comboBox.SelectedIndex = 16;
                    }

                    //Read scores played online basic
                    br.BaseStream.Position = 0x37FE;
                    Scores_played_online_basic_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played online expert
                    br.BaseStream.Position = 0x3800;
                    Scores_played_online_expert_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played online ultimate
                    br.BaseStream.Position = 0x3802;
                    Scores_played_online_ultimate_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played online ultimate no-ex
                    br.BaseStream.Position = 0x3804;
                    Scores_played_online_ultimatenex_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played local basic
                    br.BaseStream.Position = 0x3806;
                    Scores_played_local_basic_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played local expert
                    br.BaseStream.Position = 0x3808;
                    Scores_played_local_expert_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played local ultimate
                    br.BaseStream.Position = 0x380A;
                    Scores_played_local_ultimate_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Read scores played local ultimate no-ex
                    br.BaseStream.Position = 0x380C;
                    Scores_played_local_ultimatenex_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    //Set scores played total basic
                    Scores_played_total_basic_textBox.Text = (Scores_played_online_basic_numericUpDown.Value + Scores_played_local_basic_numericUpDown.Value).ToString();

                    //Set scores played total expert
                    Scores_played_total_expert_textBox.Text = (Scores_played_online_expert_numericUpDown.Value + Scores_played_local_expert_numericUpDown.Value).ToString();

                    //Set scores played total ultimate
                    Scores_played_total_ultimate_textBox.Text = (Scores_played_online_ultimate_numericUpDown.Value + Scores_played_local_ultimate_numericUpDown.Value).ToString();

                    //Set scores played total ultimate no-ex
                    Scores_played_total_ultimatenex_textBox.Text = (Scores_played_online_ultimatenex_numericUpDown.Value + Scores_played_local_ultimatenex_numericUpDown.Value).ToString();

                    //Read ex bursts used
                    br.BaseStream.Position = 0x3810;
                    EX_bursts_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Battle Party
                    //Read levels reset
                    br.BaseStream.Position = 0x3820;
                    Levels_reset_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read collectacards obtained
                    br.BaseStream.Position = 0x3824;
                    Collectacards_obtained_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read parameter boosts performed
                    br.BaseStream.Position = 0x3828;
                    Parameter_boosts_performed_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read critical boosts achieved
                    br.BaseStream.Position = 0x382C;
                    Critical_boosts_achieved_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read items used
                    br.BaseStream.Position = 0x3830;
                    Items_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read abilities triggered
                    br.BaseStream.Position = 0x3834;
                    Abilities_triggered_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read fat chocobo encounters
                    br.BaseStream.Position = 0x3838;
                    Fat_chocobo_encounters_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read treasure chests earned
                    br.BaseStream.Position = 0x383C;
                    Treasure_chests_earned_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid savedata.bk", "Failed to open the file");
            }
        }

        private void Save_savedata_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.OpenWrite(open_savedata.FileName));
                //Write rhythmia
                bw.BaseStream.Position = 0x2C;
                bw.Write((uint)Rhythmia_numericUpDown.Value);

                ////Total Counts
                //write total playtime
                bw.BaseStream.Position = 0x38;
                bw.Write((uint)(TimeSpan.FromHours((ushort)Total_playtime_hours_numericUpDown.Value).TotalSeconds + TimeSpan.FromMinutes((byte)Total_playtime_minutes_numericUpDown.Value).TotalSeconds + (byte)Total_playtime_seconds_numericUpDown.Value));

                //Write songs played
                bw.BaseStream.Position = 0x3738;
                bw.Write((uint)Songs_played_numericUpDown.Value);

                //Write enemies defeated
                bw.BaseStream.Position = 0x373C;
                bw.Write((uint)Enemies_defeated_numericUpDown1.Value);

                //Write distance travelled
                bw.BaseStream.Position = 0x3740;
                bw.Write((uint)Distance_traveled_numericUpDown.Value);

                //Write chained triggers
                bw.BaseStream.Position = 0x3748;
                bw.Write((uint)Chained_triggers_numericUpDown.Value);

                //Write critical triggers
                bw.BaseStream.Position = 0x374C;
                bw.Write((uint)Critical_triggers_numericUpDown.Value);

                //Write proficards recieved
                bw.BaseStream.Position = 0x3750;
                bw.Write((uint)ProfiCards_received_numericUpDown.Value);

                //Write streetpasses
                bw.BaseStream.Position = 0x3754;
                bw.Write((ushort)StreetPasses_numericUpDown.Value);

                //Music Stages
                //Write total songs
                bw.BaseStream.Position = 0x3780;
                bw.Write((uint)Total_songs_cleared_numericUpDown.Value);

                //Write basic scores cleared
                bw.BaseStream.Position = 0x3784;
                bw.Write((ushort)Basic_scores_cleared_numericUpDown.Value);

                //Write expert scores cleared
                bw.BaseStream.Position = 0x3788;
                bw.Write((ushort)Expert_scores_cleared_numericUpDown.Value);

                //Write ultimate scores cleared
                bw.BaseStream.Position = 0x378C;
                bw.Write((ushort)Ultimate_scores_cleared_numericUpDown.Value);

                //Write perfect chains achieved
                bw.BaseStream.Position = 0x3790;
                bw.Write((uint)Perfect_chains_achieved_numericUpDown.Value);

                //Write daily specials cleared
                bw.BaseStream.Position = 0x3794;
                bw.Write((uint)Daily_specials_cleared_numericUpDown.Value);

                //Write crowns recieved
                bw.BaseStream.Position = 0x3798;
                bw.Write((uint)Crowns_received_numericUpDown.Value);

                //Write sss ranks recieved
                bw.BaseStream.Position = 0x379C;
                bw.Write((uint)SSS_ranks_received_numericUpDown.Value);

                //Quest Medleys
                //Write short quests cleared
                bw.BaseStream.Position = 0x37B8;
                bw.Write((ushort)Short_quests_cleared_numericUpDown.Value);

                //Write medium quests cleared
                bw.BaseStream.Position = 0x37BA;
                bw.Write((ushort)Medium_quests_cleared_numericUpDown.Value);

                //Write long quests cleared
                bw.BaseStream.Position = 0x37BC;
                bw.Write((ushort)Long_quests_cleared_numericUpDown.Value);

                //Write inherited quests cleared
                bw.BaseStream.Position = 0x37BE;
                bw.Write((ushort)Inherited_quests_cleared_numericUpDown.Value);

                //Write bosses conquered
                bw.BaseStream.Position = 0x37C0;
                bw.Write((uint)Bosses_conquered_numericUpDown.Value);

                //Write stages cleared
                bw.BaseStream.Position = 0x37C4;
                bw.Write((uint)Stages_cleared_numericUpDown.Value);

                //Write keys used
                bw.BaseStream.Position = 0x37C8;
                bw.Write((uint)Keys_used_numericUpDown.Value);

                //Versus Mode
                //Write online battle rating score
                bw.BaseStream.Position = 0x56;
                bw.Write((ushort)Online_battle_rating_score_numericUpDown.Value);

                //Write online battle rating wins
                bw.BaseStream.Position = 0x37E6;
                bw.Write((ushort)Online_battle_rating_wins_numericUpDown.Value);

                //Write online battle rating losses
                bw.BaseStream.Position = 0x37E8;
                bw.Write((ushort)Online_battle_rating_losses_numericUpDown.Value);

                //Write online battle rating ties
                bw.BaseStream.Position = 0x37EA;
                bw.Write((ushort)Online_battle_rating_ties_numericUpDown.Value);

                //Write local battle rating score
                bw.BaseStream.Position = 0x54;
                bw.Write((ushort)Local_battle_rating_score_numericUpDown.Value);

                //Write local battle rating wins
                bw.BaseStream.Position = 0x37EE;
                bw.Write((ushort)Local_battle_rating_wins_numericUpDown.Value);

                //Write local battle rating losses
                bw.BaseStream.Position = 0x37F0;
                bw.Write((ushort)Local_battle_rating_losses_numericUpDown.Value);

                //Write local battle rating ties
                bw.BaseStream.Position = 0x37F2;
                bw.Write((ushort)Local_battle_rating_ties_numericUpDown.Value);

                //Write ai battle victories
                bw.BaseStream.Position = 0x37F6;
                bw.Write((ushort)AI_battle_victories_numericUpDown.Value);

                //Write highest rank
                bw.BaseStream.Position = 0x37FA;
                if (Highest_rank_comboBox.SelectedIndex == 0)
                {
                    bw.Write(0x00);
                }
                else if (Highest_rank_comboBox.SelectedIndex == 1)
                {
                    bw.Write(0x01);
                }
                else if (Highest_rank_comboBox.SelectedIndex == 2)
                {
                    bw.Write(0x02);
                }
                else if (Highest_rank_comboBox.SelectedIndex == 3)
                {
                    bw.Write(0x03);
                }

                //Write highest rank class
                bw.BaseStream.Position = 0x37FC;
                if (Highest_rank_class_comboBox.SelectedIndex == 0)
                {
                    bw.Write(0x01);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 1)
                {
                    bw.Write(0x02);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 2)
                {
                    bw.Write(0x03);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 3)
                {
                    bw.Write(0x04);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 4)
                {
                    bw.Write(0x05);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 5)
                {
                    bw.Write(0x06);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 6)
                {
                    bw.Write(0x07);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 7)
                {
                    bw.Write(0x08);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 8)
                {
                    bw.Write(0x09);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 9)
                {
                    bw.Write(0x0A);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 10)
                {
                    bw.Write(0x0B);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 11)
                {
                    bw.Write(0x0C);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 12)
                {
                    bw.Write(0x0D);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 13)
                {
                    bw.Write(0x0E);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 14)
                {
                    bw.Write(0x0F);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 15)
                {
                    bw.Write(0x10);
                }
                else if (Highest_rank_class_comboBox.SelectedIndex == 16)
                {
                    bw.Write(0x11);
                }

                //Write scores played online basic
                bw.BaseStream.Position = 0x37FE;
                bw.Write((ushort)Scores_played_online_basic_numericUpDown.Value);

                //Write scores played online expert
                bw.BaseStream.Position = 0x3800;
                bw.Write((ushort)Scores_played_online_expert_numericUpDown.Value);

                //Write scores played online ultimate
                bw.BaseStream.Position = 0x3802;
                bw.Write((ushort)Scores_played_online_ultimate_numericUpDown.Value);

                //Write scores played online ultimate no-ex
                bw.BaseStream.Position = 0x3804;
                bw.Write((ushort)Scores_played_online_ultimatenex_numericUpDown.Value);

                //Write scores played local basic
                bw.BaseStream.Position = 0x3806;
                bw.Write((ushort)Scores_played_local_basic_numericUpDown.Value);

                //Write scores played local expert
                bw.BaseStream.Position = 0x3808;
                bw.Write((ushort)Scores_played_local_expert_numericUpDown.Value);

                //Write scores played local ultimate
                bw.BaseStream.Position = 0x380A;
                bw.Write((ushort)Scores_played_local_ultimate_numericUpDown.Value);

                //Write scores played local ultimate no-ex
                bw.BaseStream.Position = 0x380C;
                bw.Write((ushort)Scores_played_local_ultimatenex_numericUpDown.Value);

                //Write ex bursts used
                bw.BaseStream.Position = 0x3810;
                bw.Write((ushort)EX_bursts_used_numericUpDown.Value);

                //Battle Party
                //Write levels reset
                bw.BaseStream.Position = 0x3820;
                bw.Write((uint)Levels_reset_numericUpDown.Value);

                //Write collectacards obtained
                bw.BaseStream.Position = 0x3824;
                bw.Write((uint)Collectacards_obtained_numericUpDown.Value);

                //Write parameter boosts performed
                bw.BaseStream.Position = 0x3828;
                bw.Write((uint)Parameter_boosts_performed_numericUpDown.Value);

                //Write critical boosts achieved
                bw.BaseStream.Position = 0x382C;
                bw.Write((uint)Critical_boosts_achieved_numericUpDown.Value);

                //Write items used
                bw.BaseStream.Position = 0x3830;
                bw.Write((uint)Items_used_numericUpDown.Value);

                //Write abilities triggered
                bw.BaseStream.Position = 0x3834;
                bw.Write((uint)Abilities_triggered_numericUpDown.Value);

                //Write fat chocobo encounters
                bw.BaseStream.Position = 0x3838;
                bw.Write((uint)Fat_chocobo_encounters_numericUpDown.Value);

                //Write treasure chests earned
                bw.BaseStream.Position = 0x383C;
                bw.Write((uint)Treasure_chests_earned_numericUpDown.Value);

                bw.Close();

                MessageBox.Show("Successfully saved to savedata.bk", "Successfully saved the file");
            }
            catch
            {
                MessageBox.Show("Failed to save to savedata.bk", "Failed to save the file");
            }
        }

        private void Short_quests_cleared_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Read total quests cleared
            Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();
        }

        private void Medium_quests_cleared_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Read total quests cleared
            Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();
        }

        private void Long_quests_cleared_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Read total quests cleared
            Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();
        }

        private void Inherited_quests_cleared_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Read total quests cleared
            Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();
        }

        private void Online_battle_rating_score_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating score
            Total_rating_score_textBox.Text = (Online_battle_rating_score_numericUpDown.Value + Local_battle_rating_score_numericUpDown.Value).ToString();
        }

        private void Local_battle_rating_score_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating score
            Total_rating_score_textBox.Text = (Online_battle_rating_score_numericUpDown.Value + Local_battle_rating_score_numericUpDown.Value).ToString();
        }

        private void Online_battle_rating_wins_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating wins
            Total_rating_wins_textBox.Text = (Online_battle_rating_wins_numericUpDown.Value + Local_battle_rating_wins_numericUpDown.Value).ToString();
        }

        private void Local_battle_rating_wins_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating wins
            Total_rating_wins_textBox.Text = (Online_battle_rating_wins_numericUpDown.Value + Local_battle_rating_wins_numericUpDown.Value).ToString();
        }

        private void Online_battle_rating_losses_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating losses
            Total_rating_losses_textBox.Text = (Online_battle_rating_losses_numericUpDown.Value + Local_battle_rating_losses_numericUpDown.Value).ToString();
        }

        private void Local_battle_rating_losses_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating losses
            Total_rating_losses_textBox.Text = (Online_battle_rating_losses_numericUpDown.Value + Local_battle_rating_losses_numericUpDown.Value).ToString();
        }

        private void Online_battle_rating_ties_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating ties
            Total_rating_ties_textBox.Text = (Online_battle_rating_ties_numericUpDown.Value + Local_battle_rating_ties_numericUpDown.Value).ToString();
        }

        private void Local_battle_rating_ties_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //set total rating ties
            Total_rating_ties_textBox.Text = (Online_battle_rating_ties_numericUpDown.Value + Local_battle_rating_ties_numericUpDown.Value).ToString();
        }

        private void Scores_played_online_basic_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total basic
            Scores_played_total_basic_textBox.Text = (Scores_played_online_basic_numericUpDown.Value + Scores_played_local_basic_numericUpDown.Value).ToString();
        }

        private void Scores_played_local_basic_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total basic
            Scores_played_total_basic_textBox.Text = (Scores_played_online_basic_numericUpDown.Value + Scores_played_local_basic_numericUpDown.Value).ToString();
        }

        private void Scores_played_online_expert_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total expert
            Scores_played_total_expert_textBox.Text = (Scores_played_online_expert_numericUpDown.Value + Scores_played_local_expert_numericUpDown.Value).ToString();
        }

        private void Scores_played_local_expert_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total expert
            Scores_played_total_expert_textBox.Text = (Scores_played_online_expert_numericUpDown.Value + Scores_played_local_expert_numericUpDown.Value).ToString();
        }

        private void Scores_played_online_ultimate_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total ultimate
            Scores_played_total_ultimate_textBox.Text = (Scores_played_online_ultimate_numericUpDown.Value + Scores_played_local_ultimate_numericUpDown.Value).ToString();
        }

        private void Scores_played_local_ultimate_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total ultimate
            Scores_played_total_ultimate_textBox.Text = (Scores_played_online_ultimate_numericUpDown.Value + Scores_played_local_ultimate_numericUpDown.Value).ToString();
        }

        private void Scores_played_online_ultimatenex_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total ultimate no-ex
            Scores_played_total_ultimatenex_textBox.Text = (Scores_played_online_ultimatenex_numericUpDown.Value + Scores_played_local_ultimatenex_numericUpDown.Value).ToString();
        }

        private void Scores_played_local_ultimatenex_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Set scores played total ultimate no-ex
            Scores_played_total_ultimatenex_textBox.Text = (Scores_played_online_ultimatenex_numericUpDown.Value + Scores_played_local_ultimatenex_numericUpDown.Value).ToString();
        }
    }
}
