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
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TFFCC_Save_Editor
{
    public partial class Main_Form : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=Database.sqlite3;Read Only=True");
        Assembly assembly = Assembly.GetExecutingAssembly();
        OpenFileDialog open_extsavedata = new OpenFileDialog();
        OpenFileDialog open_savedata = new OpenFileDialog();
        SaveFileDialog save_savedata = new SaveFileDialog();
        SaveFileDialog save_extsavedata = new SaveFileDialog();
        bool savedata_loaded;
        bool extsavedata_loaded;
        byte[] savedata;
        byte[] extsavedata;

        public Main_Form()
        {
            InitializeComponent();
            CharEditor_levelResets_picturebox.Parent = CharEditor_character_pictureBox;
            CharEditor_levelResets_picturebox.Location = new Point(62, 0);

            try
            {
                File.WriteAllBytes("Database.sqlite3", Properties.Resources.Database);
                File.SetAttributes("Database.sqlite3", File.GetAttributes("Database.sqlite3") | FileAttributes.Hidden);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to create the database files or while trying to open the SQL connection\n\n{ex}", "Error");
            }
        }


        //Open savedata.bk and extsavedata.bk file and store as savadata byte array
        private void Open_files_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Disable savedata.bk & extsavedata.bk stuff
                Save_files_ToolStripMenuItem.Enabled = Save_files_as_ToolStripMenuItem.Enabled = online_battle_rating_wins_button.Enabled = max_items_button.Enabled = max_normal_cards_button.Enabled = max_rare_cards_button.Enabled = max_premium_cards_button.Enabled = max_all_cards_button.Enabled = CharEditor_character_comboBox.Enabled = Max_character_stats_button.Enabled = Max_all_characters_stats_button.Enabled = savedata_loaded = extsavedata_loaded = false;

                open_savedata.Filter = " savedata.bk Files|savedata.bk|All Files (*.*)|*.*";
                if (open_savedata.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("You must open a savedata.bk file", "savedata.bk not found");
                    return;
                }

                open_extsavedata.Filter = " extsavedata.bk Files|extsavedata.bk|All Files (*.*)|*.*";
                if (open_extsavedata.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("You must open a extsavedata.bk file", "extsavedata.bk not found");
                    return;
                }

                savedata = File.ReadAllBytes(open_savedata.FileName);
                extsavedata = File.ReadAllBytes(open_extsavedata.FileName);

                Items_dataGridView.Rows.Clear();
                Cards_dataGridView.Rows.Clear();
                Songs_dataGridView.Rows.Clear();

                Read_records(null, null);
                Read_items(null, null);
                Read_collectacards(null, null);
                Read_characters(null, null);
                Read_write_top_characters_used();
                Read_songs(null, null);

                //Enable savedata.bk & extsavedata.bk stuff
                Save_files_ToolStripMenuItem.Enabled = Save_files_as_ToolStripMenuItem.Enabled = online_battle_rating_wins_button.Enabled = max_items_button.Enabled = max_normal_cards_button.Enabled = max_rare_cards_button.Enabled = max_premium_cards_button.Enabled = max_all_cards_button.Enabled = CharEditor_character_comboBox.Enabled = Max_character_stats_button.Enabled = Max_all_characters_stats_button.Enabled = savedata_loaded = extsavedata_loaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid save(s)\n\n{ex}", "Failed to open the file(s)");
            }
        }

        //Save to savadata.bk
        private void Save_files_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Write all values onto save one last time
                Write_records(null, null);
                Write_characters(null, null);
                Write_items(null, null);

                File.WriteAllBytes(open_savedata.FileName, savedata);
                File.WriteAllBytes(open_extsavedata.FileName, extsavedata);
                MessageBox.Show($"Successfully saved to:\n{open_savedata.FileName}\n\n{open_extsavedata.FileName}", "Successfully saved the file");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save to:\n{open_savedata.FileName}\n\n{open_extsavedata.FileName}\n\n{ex}", "Failed to save the file");
            }
        }

        //Save to savadata.bk as
        private void Save_files_as_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Write all values onto save one last time
                Write_records(null, null);
                Write_characters(null, null);
                Write_items(null, null);

                save_savedata.Filter = "savedata.bk Files | *.bk";
                if (save_savedata.ShowDialog() != DialogResult.OK) return;
                save_extsavedata.Filter = "extsavedata.bk Files | *.bk";
                if (save_extsavedata.ShowDialog() != DialogResult.OK) return;

                open_savedata.FileName = save_savedata.FileName;
                File.WriteAllBytes(save_savedata.FileName, savedata);
                open_savedata.FileName = save_extsavedata.FileName;
                File.WriteAllBytes(save_extsavedata.FileName, extsavedata);

                MessageBox.Show($"Successfully saved to:\n{save_savedata.FileName}\n\n{save_extsavedata.FileName}", "Successfully saved the file");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save to:\n{save_savedata.FileName}\n\n{save_extsavedata.FileName}\n{ex}", "Failed to save the file");
            }
        }


        //Read Records tab
        private void Read_records(object sender, EventArgs e)
        {
            try
            {
                //Profile
                //Read player name
                Player_name_textBox.Text = Encoding.Unicode.GetString(savedata, 0x12, 0x0C);

                //Read Rhythmia
                Rhythmia_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x2C);

                //Read Progress
                switch (savedata[0x40])
                {
                    case 0x00:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x01:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x02:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x03:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x04:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x05:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x06:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Empty;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x07:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Half;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x08:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Empty;
                        break;
                    case 0x09:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Half;
                        break;
                    case 0x0A:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star;
                        break;
                    case 0x0B:
                        Progress_star1_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star2_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star3_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star4_pictureBox.Image = Properties.Resources.Star_Shiny;
                        Progress_star5_pictureBox.Image = Properties.Resources.Star_Shiny;
                        break;
                }

                //Read Trophies
                Trophies_textBox.Text = savedata[0x3962].ToString() + "/96";

                //Total Counts
                //Read total playtime
                TimeSpan time = TimeSpan.FromSeconds(BitConverter.ToUInt32(savedata, 0x38));
                Total_playtime_hours_numericUpDown.Value = Convert.ToUInt16(Math.Floor(time.TotalHours));
                Total_playtime_minutes_numericUpDown.Value = time.Minutes;
                Total_playtime_seconds_numericUpDown.Value = time.Seconds;

                //Read songs played
                Songs_played_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3738);

                //Read enemies defeated
                Enemies_defeated_numericUpDown1.Value = BitConverter.ToUInt32(savedata, 0x373C);

                //Read distance travelled
                Distance_traveled_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3740);

                //Read chained triggers
                Chained_triggers_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3748);

                //Read critical triggers
                Critical_triggers_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x374C);

                //Read proficards recieved
                ProfiCards_received_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3750);

                //Read streetpasses
                StreetPasses_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3754);

                //Music Stages
                //Read total songs
                Total_songs_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3780);

                //Read basic scores cleared
                Basic_scores_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3784);

                //Read expert scores cleared
                Expert_scores_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3788);

                //Read ultimate scores cleared
                Ultimate_scores_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x378C);

                //Read perfect chains achieved
                Perfect_chains_achieved_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3790);

                //Read daily specials cleared
                Daily_specials_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3794);

                //Read crowns recieved
                Crowns_received_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3798);

                //Read sss ranks recieved
                SSS_ranks_received_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x379C);

                //Quest Medleys
                //Read short quests cleared
                Short_quests_cleared_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37B8);

                //Read medium quests cleared
                Medium_quests_cleared_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37BA);

                //Read long quests cleared
                Long_quests_cleared_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37BC);

                //Read inherited quests cleared
                Inherited_quests_cleared_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37BE);

                //Read total quests cleared
                Total_quests_cleared_textBox.Text = (Short_quests_cleared_numericUpDown.Value + Medium_quests_cleared_numericUpDown.Value + Long_quests_cleared_numericUpDown.Value + Inherited_quests_cleared_numericUpDown.Value).ToString();

                //Read bosses conquered
                Bosses_conquered_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x37C0);

                //Read stages cleared
                Stages_cleared_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x37C4);

                //Read keys used
                Keys_used_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x37C8);

                //Versus Mode
                //Read online battle rating score
                Online_battle_rating_score_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x56);

                //Read online battle rating losses
                Online_battle_rating_losses_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37E8);

                //Read online battle rating ties
                Online_battle_rating_ties_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37EA);

                //Read local battle rating score
                Local_battle_rating_score_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x54);

                //Read local battle rating wins
                Local_battle_rating_wins_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37EE);

                //Read local battle rating losses
                Local_battle_rating_losses_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37F0);

                //Read local battle rating ties
                Local_battle_rating_ties_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37F2);

                //set total rating score
                Total_rating_score_textBox.Text = (Online_battle_rating_score_numericUpDown.Value + Local_battle_rating_score_numericUpDown.Value).ToString();

                //set total rating wins
                Total_rating_wins_textBox.Text = (BitConverter.ToUInt16(savedata, 0x37E6) + Local_battle_rating_wins_numericUpDown.Value).ToString();

                //set total rating losses
                Total_rating_losses_textBox.Text = (Online_battle_rating_losses_numericUpDown.Value + Local_battle_rating_losses_numericUpDown.Value).ToString();

                //set total rating ties
                Total_rating_ties_textBox.Text = (Online_battle_rating_ties_numericUpDown.Value + Local_battle_rating_ties_numericUpDown.Value).ToString();

                //Read ai battle victories
                AI_battle_victories_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37F6);

                //Read highest rank
                switch (savedata[0x37FA])
                {
                    case 0x00:
                        Highest_rank_comboBox.SelectedIndex = 0;
                        Highest_rank_pictureBox.Image = Properties.Resources.Bronze_Rank;
                        break;
                    case 0x01:
                        Highest_rank_comboBox.SelectedIndex = 1;
                        Highest_rank_pictureBox.Image = Properties.Resources.Silver_Rank;
                        break;
                    case 0x02:
                        Highest_rank_comboBox.SelectedIndex = 2;
                        Highest_rank_pictureBox.Image = Properties.Resources.Gold_Rank;
                        break;
                    case 0x03:
                        Highest_rank_comboBox.SelectedIndex = 3;
                        Highest_rank_pictureBox.Image = Properties.Resources.Platinum_Rank;
                        break;
                }

                //Read highest rank class
                switch (savedata[0x37FC])
                {
                    case 0x01:
                        Highest_rank_class_comboBox.SelectedIndex = 0;
                        break;
                    case 0x02:
                        Highest_rank_class_comboBox.SelectedIndex = 1;
                        break;
                    case 0x03:
                        Highest_rank_class_comboBox.SelectedIndex = 2;
                        break;
                    case 0x04:
                        Highest_rank_class_comboBox.SelectedIndex = 3;
                        break;
                    case 0x05:
                        Highest_rank_class_comboBox.SelectedIndex = 4;
                        break;
                    case 0x06:
                        Highest_rank_class_comboBox.SelectedIndex = 5;
                        break;
                    case 0x07:
                        Highest_rank_class_comboBox.SelectedIndex = 6;
                        break;
                    case 0x08:
                        Highest_rank_class_comboBox.SelectedIndex = 7;
                        break;
                    case 0x09:
                        Highest_rank_class_comboBox.SelectedIndex = 8;
                        break;
                    case 0x0A:
                        Highest_rank_class_comboBox.SelectedIndex = 9;
                        break;
                    case 0x0B:
                        Highest_rank_class_comboBox.SelectedIndex = 10;
                        break;
                    case 0x0C:
                        Highest_rank_class_comboBox.SelectedIndex = 11;
                        break;
                    case 0x0D:
                        Highest_rank_class_comboBox.SelectedIndex = 12;
                        break;
                    case 0x0E:
                        Highest_rank_class_comboBox.SelectedIndex = 13;
                        break;
                    case 0x0F:
                        Highest_rank_class_comboBox.SelectedIndex = 14;
                        break;
                    case 0x10:
                        Highest_rank_class_comboBox.SelectedIndex = 15;
                        break;
                    case 0x11:
                        Highest_rank_class_comboBox.SelectedIndex = 16;
                        break;
                }

                //Read scores played online basic
                Scores_played_online_basic_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37FE);

                //Read scores played online expert
                Scores_played_online_expert_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3800);

                //Read scores played online ultimate
                Scores_played_online_ultimate_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3802);

                //Read scores played online ultimate no-ex
                Scores_played_online_ultimatenex_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3804);

                //Read scores played local basic
                Scores_played_local_basic_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3806);

                //Read scores played local expert
                Scores_played_local_expert_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x3808);

                //Read scores played local ultimate
                Scores_played_local_ultimate_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x380A);

                //Read scores played local ultimate no-ex
                Scores_played_local_ultimatenex_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x380C);

                //Set scores played total basic
                Scores_played_total_basic_textBox.Text = (Scores_played_online_basic_numericUpDown.Value + Scores_played_local_basic_numericUpDown.Value).ToString();

                //Set scores played total expert
                Scores_played_total_expert_textBox.Text = (Scores_played_online_expert_numericUpDown.Value + Scores_played_local_expert_numericUpDown.Value).ToString();

                //Set scores played total ultimate
                Scores_played_total_ultimate_textBox.Text = (Scores_played_online_ultimate_numericUpDown.Value + Scores_played_local_ultimate_numericUpDown.Value).ToString();

                //Set scores played total ultimate no-ex
                Scores_played_total_ultimatenex_textBox.Text = (Scores_played_online_ultimatenex_numericUpDown.Value + Scores_played_local_ultimatenex_numericUpDown.Value).ToString();

                //Read ex bursts used
                EX_bursts_used_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3810);

                //Battle Party
                //Read levels reset
                Levels_reset_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3820);

                //Read collectacards obtained
                Collectacards_obtained_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3824);

                //Read parameter boosts performed
                Parameter_boosts_performed_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3828);

                //Read critical boosts achieved
                Critical_boosts_achieved_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x382C);

                //Read items used
                Items_used_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3830);

                //Read abilities triggered
                Abilities_triggered_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3834);

                //Read fat chocobo encounters
                Fat_chocobo_encounters_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x3838);

                //Read treasure chests earned
                Treasure_chests_earned_numericUpDown.Value = BitConverter.ToUInt32(savedata, 0x383C);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Records\n\n{ex}", "Error");
            }
        }

        //Write Records tab
        private void Write_records(object sender, EventArgs e)
        {
            if (!savedata_loaded) return;
            try
            {
                //Write rhythmia
                Array.Copy(BitConverter.GetBytes((uint)Rhythmia_numericUpDown.Value), 0, savedata, 0x2C, 4);

                //Total Counts
                //write total playtime
                Array.Copy(BitConverter.GetBytes((uint)(TimeSpan.FromHours((ushort)Total_playtime_hours_numericUpDown.Value).TotalSeconds + TimeSpan.FromMinutes((byte)Total_playtime_minutes_numericUpDown.Value).TotalSeconds + (byte)Total_playtime_seconds_numericUpDown.Value)), 0, savedata, 0x38, 4);

                //Write songs played
                Array.Copy(BitConverter.GetBytes((uint)Songs_played_numericUpDown.Value), 0, savedata, 0x3738, 4);

                //Write enemies defeated
                Array.Copy(BitConverter.GetBytes((uint)Enemies_defeated_numericUpDown1.Value), 0, savedata, 0x373C, 4);

                //Write distance travelled
                Array.Copy(BitConverter.GetBytes((uint)Distance_traveled_numericUpDown.Value), 0, savedata, 0x3740, 4);

                //Write chained triggers
                Array.Copy(BitConverter.GetBytes((uint)Chained_triggers_numericUpDown.Value), 0, savedata, 0x3748, 4);

                //Write critical triggers
                Array.Copy(BitConverter.GetBytes((uint)Critical_triggers_numericUpDown.Value), 0, savedata, 0x374C, 4);

                //Write proficards recieved
                Array.Copy(BitConverter.GetBytes((uint)ProfiCards_received_numericUpDown.Value), 0, savedata, 0x3750, 4);

                //Write streetpasses
                Array.Copy(BitConverter.GetBytes((ushort)StreetPasses_numericUpDown.Value), 0, savedata, 0x3754, 2);

                //Music Stages
                //Write total songs
                Array.Copy(BitConverter.GetBytes((uint)Total_songs_cleared_numericUpDown.Value), 0, savedata, 0x3780, 4);

                //Write basic scores cleared
                Array.Copy(BitConverter.GetBytes((ushort)Basic_scores_cleared_numericUpDown.Value), 0, savedata, 0x3784, 2);

                //Write expert scores cleared
                Array.Copy(BitConverter.GetBytes((ushort)Expert_scores_cleared_numericUpDown.Value), 0, savedata, 0x3788, 2);

                //Write ultimate scores cleared
                Array.Copy(BitConverter.GetBytes((ushort)Ultimate_scores_cleared_numericUpDown.Value), 0, savedata, 0x378C, 2);

                //Write perfect chains achieved
                Array.Copy(BitConverter.GetBytes((uint)Perfect_chains_achieved_numericUpDown.Value), 0, savedata, 0x3790, 4);

                //Write daily specials cleared
                Array.Copy(BitConverter.GetBytes((uint)Daily_specials_cleared_numericUpDown.Value), 0, savedata, 0x3794, 4);

                //Write crowns recieved
                Array.Copy(BitConverter.GetBytes((uint)Crowns_received_numericUpDown.Value), 0, savedata, 0x3798, 4);

                //Write sss ranks recieved
                Array.Copy(BitConverter.GetBytes((uint)SSS_ranks_received_numericUpDown.Value), 0, savedata, 0x379C, 4);

                //Quest Medleys
                //Write short quests cleared
                Array.Copy(BitConverter.GetBytes((ushort)Short_quests_cleared_numericUpDown.Value), 0, savedata, 0x37B8, 2);

                //Write medium quests cleared
                Array.Copy(BitConverter.GetBytes((ushort)Medium_quests_cleared_numericUpDown.Value), 0, savedata, 0x37BA, 2);

                //Write long quests cleared
                Array.Copy(BitConverter.GetBytes((ushort)Long_quests_cleared_numericUpDown.Value), 0, savedata, 0x37BC, 2);

                //Write inherited quests cleared
                Array.Copy(BitConverter.GetBytes((ushort)Inherited_quests_cleared_numericUpDown.Value), 0, savedata, 0x37BE, 2);

                //Write bosses conquered
                Array.Copy(BitConverter.GetBytes((uint)Bosses_conquered_numericUpDown.Value), 0, savedata, 0x37C0, 4);

                //Write stages cleared
                Array.Copy(BitConverter.GetBytes((uint)Stages_cleared_numericUpDown.Value), 0, savedata, 0x37C4, 4);

                //Write keys used
                Array.Copy(BitConverter.GetBytes((uint)Keys_used_numericUpDown.Value), 0, savedata, 0x37C8, 4);

                //Versus Mode
                //Write online battle rating score
                Array.Copy(BitConverter.GetBytes((ushort)Online_battle_rating_score_numericUpDown.Value), 0, savedata, 0x56, 2);

                //Write online battle rating losses
                Array.Copy(BitConverter.GetBytes((ushort)Online_battle_rating_losses_numericUpDown.Value), 0, savedata, 0x37E8, 2);

                //Write online battle rating ties
                Array.Copy(BitConverter.GetBytes((ushort)Online_battle_rating_ties_numericUpDown.Value), 0, savedata, 0x37EA, 2);

                //Write local battle rating score
                Array.Copy(BitConverter.GetBytes((ushort)Local_battle_rating_score_numericUpDown.Value), 0, savedata, 0x54, 2);

                //Write local battle rating wins
                Array.Copy(BitConverter.GetBytes((ushort)Local_battle_rating_wins_numericUpDown.Value), 0, savedata, 0x37EE, 2);

                //Write local battle rating losses
                Array.Copy(BitConverter.GetBytes((ushort)Local_battle_rating_losses_numericUpDown.Value), 0, savedata, 0x37F0, 2);

                //Write local battle rating ties
                Array.Copy(BitConverter.GetBytes((ushort)Local_battle_rating_ties_numericUpDown.Value), 0, savedata, 0x37F2, 2);

                //Write ai battle victories
                Array.Copy(BitConverter.GetBytes((ushort)AI_battle_victories_numericUpDown.Value), 0, savedata, 0x37F6, 2);

                //Write highest rank
                switch (Highest_rank_comboBox.SelectedIndex)
                {
                    case 0:
                        savedata[0x37FA] = 0x00;
                        break;
                    case 1:
                        savedata[0x37FA] = 0x01;
                        break;
                    case 2:
                        savedata[0x37FA] = 0x02;
                        break;
                    case 3:
                        savedata[0x37FA] = 0x03;
                        break;
                }

                //Write highest rank class
                switch (Highest_rank_class_comboBox.SelectedIndex)
                {
                    case 0:
                        savedata[0x37FC] = 0x01;
                        break;
                    case 1:
                        savedata[0x37FC] = 0x02;
                        break;
                    case 2:
                        savedata[0x37FC] = 0x03;
                        break;
                    case 3:
                        savedata[0x37FC] = 0x04;
                        break;
                    case 4:
                        savedata[0x37FC] = 0x05;
                        break;
                    case 5:
                        savedata[0x37FC] = 0x06;
                        break;
                    case 6:
                        savedata[0x37FC] = 0x07;
                        break;
                    case 7:
                        savedata[0x37FC] = 0x08;
                        break;
                    case 8:
                        savedata[0x37FC] = 0x09;
                        break;
                    case 9:
                        savedata[0x37FC] = 0x0A;
                        break;
                    case 10:
                        savedata[0x37FC] = 0x0B;
                        break;
                    case 11:
                        savedata[0x37FC] = 0x0C;
                        break;
                    case 12:
                        savedata[0x37FC] = 0x0D;
                        break;
                    case 13:
                        savedata[0x37FC] = 0x0E;
                        break;
                    case 14:
                        savedata[0x37FC] = 0x0F;
                        break;
                    case 15:
                        savedata[0x37FC] = 0x10;
                        break;
                    case 16:
                        savedata[0x37FC] = 0x11;
                        break;
                }

                //Write scores played online basic
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_online_basic_numericUpDown.Value), 0, savedata, 0x37FE, 2);

                //Write scores played online expert
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_online_expert_numericUpDown.Value), 0, savedata, 0x3800, 2);

                //Write scores played online ultimate
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_online_ultimate_numericUpDown.Value), 0, savedata, 0x3802, 2);

                //Write scores played online ultimate no-ex
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_online_ultimatenex_numericUpDown.Value), 0, savedata, 0x3804, 2);

                //Write scores played local basic
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_local_basic_numericUpDown.Value), 0, savedata, 0x3806, 2);

                //Write scores played local expert
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_local_expert_numericUpDown.Value), 0, savedata, 0x3808, 2);

                //Write scores played local ultimate
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_local_ultimate_numericUpDown.Value), 0, savedata, 0x380A, 2);

                //Write scores played local ultimate no-ex
                Array.Copy(BitConverter.GetBytes((ushort)Scores_played_local_ultimatenex_numericUpDown.Value), 0, savedata, 0x380C, 2);

                //Write ex bursts used
                Array.Copy(BitConverter.GetBytes((uint)EX_bursts_used_numericUpDown.Value), 0, savedata, 0x3810, 4);

                //Battle Party
                //Write levels reset
                Array.Copy(BitConverter.GetBytes((uint)Levels_reset_numericUpDown.Value), 0, savedata, 0x3820, 4);

                //Write collectacards obtained
                Array.Copy(BitConverter.GetBytes((uint)Collectacards_obtained_numericUpDown.Value), 0, savedata, 0x3824, 4);

                //Write parameter boosts performed
                Array.Copy(BitConverter.GetBytes((uint)Parameter_boosts_performed_numericUpDown.Value), 0, savedata, 0x3828, 4);

                //Write critical boosts achieved
                Array.Copy(BitConverter.GetBytes((uint)Critical_boosts_achieved_numericUpDown.Value), 0, savedata, 0x382C, 4);

                //Write items used
                Array.Copy(BitConverter.GetBytes((uint)Items_used_numericUpDown.Value), 0, savedata, 0x3830, 4);

                //Write abilities triggered
                Array.Copy(BitConverter.GetBytes((uint)Abilities_triggered_numericUpDown.Value), 0, savedata, 0x3834, 4);

                //Write fat chocobo encounters
                Array.Copy(BitConverter.GetBytes((uint)Fat_chocobo_encounters_numericUpDown.Value), 0, savedata, 0x3838, 4);

                //Write treasure chests earned
                Array.Copy(BitConverter.GetBytes((uint)Treasure_chests_earned_numericUpDown.Value), 0, savedata, 0x383C, 4);

                Read_records(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Records changes\n\n{ex}", "Error");
            }
        }

        //Read/Write online battle rating wins
        private void online_battle_rating_wins_button_Click(object sender, EventArgs e)
        {
            if (!savedata_loaded) return;
            (new online_battle_rating_wins(ref savedata)).ShowDialog();
            Read_records(null, null);
        }


        //Read Top Songs Played
        private void Read_top_songs_played()
        {
            try
            {
                PictureBox[] typeArray = new PictureBox[] { Top_songs_played_1_type_pictureBox, Top_songs_played_2_type_pictureBox, Top_songs_played_3_type_pictureBox, Top_songs_played_4_type_pictureBox, Top_songs_played_5_type_pictureBox, Top_songs_played_6_type_pictureBox, Top_songs_played_7_type_pictureBox, Top_songs_played_8_type_pictureBox };
                RichTextBox[] nameArray = new RichTextBox[] { Top_songs_played_1_name_richTextBox, Top_songs_played_2_name_richTextBox, Top_songs_played_3_name_richTextBox, Top_songs_played_4_name_richTextBox, Top_songs_played_5_name_richTextBox, Top_songs_played_6_name_richTextBox, Top_songs_played_7_name_richTextBox, Top_songs_played_8_name_richTextBox };
                PictureBox[] difficultyArray = new PictureBox[] { Top_songs_played_1_difficulty_pictureBox, Top_songs_played_2_difficulty_pictureBox, Top_songs_played_3_difficulty_pictureBox, Top_songs_played_4_difficulty_pictureBox, Top_songs_played_5_difficulty_pictureBox, Top_songs_played_6_difficulty_pictureBox, Top_songs_played_7_difficulty_pictureBox, Top_songs_played_8_difficulty_pictureBox };
                TextBox[] timesplayedArray = new TextBox[] { Top_songs_played_1_timesplayed_textBox, Top_songs_played_2_timesplayed_textBox, Top_songs_played_3_timesplayed_textBox, Top_songs_played_4_timesplayed_textBox, Top_songs_played_5_timesplayed_textBox, Top_songs_played_6_timesplayed_textBox, Top_songs_played_7_timesplayed_textBox, Top_songs_played_8_timesplayed_textBox };

                ushort topSongOffset = 0x3854;
                for (int i = 0; i < 8; i++)
                {
                    SQLiteDataReader reader = new SQLiteCommand($"SELECT Series, Song, Type FROM Songs WHERE Value = '0x{(BitConverter.ToUInt16(savedata, topSongOffset)).ToString("X2")}'", connection).ExecuteReader();
                    reader.Read();

                    if (savedata[topSongOffset] != 0xFF)
                    {
                        //Set song type image
                        if (reader["Type"].ToString() == "BMS") typeArray[i].Image = Properties.Resources.Song_BMS;
                        if (reader["Type"].ToString() == "FMS") typeArray[i].Image = Properties.Resources.Song_FMS;
                        if (reader["Type"].ToString() == "EMS") typeArray[i].Image = Properties.Resources.Song_EMS;

                        //Set series and song name
                        nameArray[i].Rtf = $@"{{\rtf \b {reader["Series"]}\b0 \line {reader["Song"]}}}";

                        //Set song difficulty image
                        if (savedata[topSongOffset + 4] == 0x00) difficultyArray[i].Image = Properties.Resources.Song_Icon_Basic;
                        if (savedata[topSongOffset + 4] == 0x01) difficultyArray[i].Image = Properties.Resources.Song_Icon_Expert;
                        if (savedata[topSongOffset + 4] == 0x02) difficultyArray[i].Image = Properties.Resources.Song_Icon_Ultimate;

                        //Set times played
                        timesplayedArray[i].Text = (BitConverter.ToUInt16(savedata, topSongOffset + 6)).ToString();
                    }
                    else
                    {
                        //Set all to blank
                        typeArray[i].Image = null;
                        nameArray[i].Text = "N/A";
                        difficultyArray[i].Image = null;
                        timesplayedArray[i].Text = "N/A";
                    }
                    topSongOffset += 8;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Top Songs Played\n\n{ex}", "Error");
            }
        }


        //For top characters used when reading characters
        public class Character : IComparable<Character>
        {
            public UInt32 TimesUsed { get; set; }
            public string CharacterName { get; set; }
            public string Value { get; set; }
            public byte Level { get; set; }
            public byte LevelResets { get; set; }

            public int CompareTo(Character other)
            {
                return TimesUsed.CompareTo(other.TimesUsed);
            }
        }

        //Read and write Top Characters used
        private void Read_write_top_characters_used()
        {
            try
            {
                SQLiteDataReader reader = new SQLiteCommand("SELECT Character, DLC, Value, Level, [Level Resets], [Times Used] FROM Characters", connection).ExecuteReader();
                List<Character> Characters_list = new List<Character>();
                while (reader.Read())
                {
                    Characters_list.Add(new Character() { CharacterName = reader["Character"].ToString(), TimesUsed = BitConverter.ToUInt32(reader["DLC"].ToString() == "true" ? extsavedata : savedata, Convert.ToInt32(reader["Times Used"].ToString(), 16)), Value = reader["Value"].ToString(), Level = (reader["DLC"].ToString() == "true" ? extsavedata : savedata)[Convert.ToUInt32(reader["Level"].ToString(), 16)], LevelResets = (reader["DLC"].ToString() == "true" ? extsavedata : savedata)[Convert.ToUInt32(reader["Level Resets"].ToString(), 16)] });
                }
                reader.Close();

                //Write top characters used values onto save and read values on editor
                Characters_list.Sort();
                Characters_list.Reverse();
                ushort topCharacterOffset = 0x38DC;
                for (int i = 0; i < 8; i++)
                {
                    if (Characters_list[i].TimesUsed != 0)
                    {
                        savedata[topCharacterOffset] = Convert.ToByte(Characters_list[i].Value, 16);
                        savedata[topCharacterOffset + 4] = Characters_list[i].Level;
                        Array.Copy(BitConverter.GetBytes(Characters_list[i].TimesUsed), 0, savedata, topCharacterOffset + 6, 2);

                        if (i == 0)
                        {
                            Top_characters_used_1_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_1_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_1_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_1_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_1_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_1_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_1_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 1)
                        {
                            Top_characters_used_2_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_2_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_2_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_2_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_2_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_2_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_2_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 2)
                        {
                            Top_characters_used_3_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_3_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_3_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_3_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_3_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_3_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_3_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 3)
                        {
                            Top_characters_used_4_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_4_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_4_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_4_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_4_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_4_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_4_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 4)
                        {
                            Top_characters_used_5_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_5_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_5_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_5_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_5_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_5_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_5_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 5)
                        {
                            Top_characters_used_6_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_6_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_6_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_6_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_6_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_6_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_6_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 6)
                        {
                            Top_characters_used_7_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_7_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_7_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_7_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_7_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_7_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_7_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                        if (i == 7)
                        {
                            Top_characters_used_8_character_textBox.Text = Characters_list[i].CharacterName;
                            Top_characters_used_8_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{Characters_list[i].CharacterName}.png"));
                            Top_characters_used_8_level_textBox.Text = $"Level {Characters_list[i].Level.ToString()}";
                            Top_characters_used_8_timesUsed_textBox.Text = Characters_list[i].TimesUsed.ToString();
                            if (Characters_list[i].LevelResets == 0) Top_characters_used_8_levelResets_pictureBox.Image = null;
                            if (Characters_list[i].LevelResets < 10 && Characters_list[i].LevelResets > 0) Top_characters_used_8_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{Characters_list[i].LevelResets}.png"));
                            if (Characters_list[i].LevelResets > 9) Top_characters_used_8_levelResets_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                        }
                    }
                    else
                    {
                        Array.Copy(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, 0, savedata, topCharacterOffset, 8);
                    }
                    topCharacterOffset += 8;
                }
                Characters_list.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Top Characters Used\n\n{ex}", "Error");
            }
        }


        //Characters Tab
        bool CharEditor_character_changed;
        //Read Characters tab
        private void Read_characters(object sender, EventArgs e)
        {
            try
            {
                var savetype = savedata;
                //Party
                //Leader
                SQLiteDataReader readerChar = new SQLiteCommand($"SELECT Character, DLC, Value, [Ability 1], [Ability 2], [Ability 3], [Ability 4] FROM Characters WHERE Value = '0x{savedata[0xC98].ToString("X2")}'", connection).ExecuteReader();
                while (readerChar.Read())
                {
                    Party1_character_comboBox.SelectedItem = readerChar["Character"].ToString();
                    Party1_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{readerChar["Character"].ToString()}.png"));

                    savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                    SQLiteDataReader readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 1"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party1_ability1_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 2"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party1_ability2_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 3"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party1_ability3_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 4"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party1_ability4_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();
                }
                readerChar.Close();

                //Party 2
                readerChar = new SQLiteCommand($"SELECT Character, DLC, Value, [Ability 1], [Ability 2], [Ability 3], [Ability 4] FROM Characters WHERE Value = '0x{savedata[0xC9A].ToString("X2")}'", connection).ExecuteReader();
                while (readerChar.Read())
                {
                    Party2_character_comboBox.SelectedItem = readerChar["Character"].ToString();
                    Party2_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{readerChar["Character"].ToString()}.png"));

                    savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                    SQLiteDataReader readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 1"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party2_ability1_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 2"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party2_ability2_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 3"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party2_ability3_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 4"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party2_ability4_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();
                }
                readerChar.Close();

                //Party 3
                readerChar = new SQLiteCommand($"SELECT Character, DLC, Value, [Ability 1], [Ability 2], [Ability 3], [Ability 4] FROM Characters WHERE Value = '0x{savedata[0xC9C].ToString("X2")}'", connection).ExecuteReader();
                while (readerChar.Read())
                {
                    Party3_character_comboBox.SelectedItem = readerChar["Character"].ToString();
                    Party3_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{readerChar["Character"].ToString()}.png"));

                    savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                    SQLiteDataReader readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 1"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party3_ability1_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 2"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party3_ability2_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 3"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party3_ability3_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 4"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party3_ability4_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();
                }
                readerChar.Close();

                //Party 4
                readerChar = new SQLiteCommand($"SELECT Character, DLC, Value, [Ability 1], [Ability 2], [Ability 3], [Ability 4] FROM Characters WHERE Value = '0x{savedata[0xC9E].ToString("X2")}'", connection).ExecuteReader();
                while (readerChar.Read())
                {
                    Party4_character_comboBox.SelectedItem = readerChar["Character"].ToString();
                    Party4_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{readerChar["Character"].ToString()}.png"));

                    savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                    SQLiteDataReader readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 1"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party4_ability1_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 2"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party4_ability2_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 3"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party4_ability3_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();

                    readerAbility = new SQLiteCommand($"SELECT Ability FROM Abilities WHERE Value = '0x{BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Ability 4"].ToString(), 16)).ToString("X2")}'", connection).ExecuteReader();
                    readerAbility.Read();
                    Party4_ability4_textBox.Text = readerAbility["Ability"].ToString();
                    readerAbility.Close();
                }
                readerChar.Close();

                //Character Editor
                CharEditor_character_changed = false;
                //if the character is changed or if max button is pressed in the character editor then set CharEditor_character_changed to true
                if (sender != null && sender.ToString() == "Max Button Pressed" || ((ComboBox)sender) != null && ((ComboBox)sender).Name == "CharEditor_character_comboBox") CharEditor_character_changed = true;

                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Characters WHERE Character = @character", connection);
                cmd.Parameters.AddWithValue("@character", CharEditor_character_comboBox.SelectedItem.ToString());
                readerChar = cmd.ExecuteReader();
                readerChar.Read();
                savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                //Read Charcter Name for max stats button
                Max_character_stats_button.Text = $"Max {readerChar["Character"].ToString()} Stats";
                //Read Character Image
                CharEditor_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{readerChar["Character"].ToString()}.png"));
                //Read Level
                CharEditor_level_textBox.Text = savetype[Convert.ToUInt32(readerChar["Level"].ToString(), 16)].ToString();
                //Read EXP
                CharEditor_exp_textBox.Text = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["EXP"].ToString(), 16)).ToString();
                //Read HP
                CharEditor_hp_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["HP"].ToString(), 16));
                //Read Level Resets
                CharEditor_levelResets_numericUpDown.Value = savetype[Convert.ToUInt32(readerChar["Level Resets"].ToString(), 16)];
                //Read Total CP
                CharEditor_totalCP_numericUpDown.Value = savetype[Convert.ToUInt32(readerChar["Total CP"].ToString(), 16)];
                //Read Strength
                CharEditor_strength_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Strength"].ToString(), 16));
                //Read Magic
                CharEditor_magic_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Magic"].ToString(), 16));
                //Read Agility
                CharEditor_agility_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Agility"].ToString(), 16));
                //Read Luck
                CharEditor_luck_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Luck"].ToString(), 16));
                //Read Stamina
                CharEditor_stamina_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Stamina"].ToString(), 16));
                //Read Spirit
                CharEditor_spirit_numericUpDown.Value = BitConverter.ToUInt16(savetype, Convert.ToInt32(readerChar["Spirit"].ToString(), 16));
                readerChar.Close();

                //Read Level Resets Image
                Set_LvReset_totalCP("reading level reset", null);
                if (CharEditor_levelResets_numericUpDown.Value == 0) CharEditor_levelResets_picturebox.Image = null;
                if (CharEditor_levelResets_numericUpDown.Value < 10 && CharEditor_levelResets_numericUpDown.Value > 0) CharEditor_levelResets_picturebox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Level_Resets_{CharEditor_levelResets_numericUpDown.Value}.png"));
                if (CharEditor_levelResets_numericUpDown.Value > 9) CharEditor_levelResets_picturebox.Image = Image.FromStream(assembly.GetManifestResourceStream("TFFCC_Save_Editor.Resources.Level_Resets_10.png"));
                CharEditor_character_changed = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Characters\n\n{ex}", "Error");
            }
        }

        //Write Characters tab
        private void Write_characters(object sender, EventArgs e)
        {
            if (!savedata_loaded || !extsavedata_loaded || CharEditor_character_changed) return;
            try
            {
                //Check if a character is used more than once
                if (Party1_character_comboBox.SelectedIndex == Party2_character_comboBox.SelectedIndex || Party1_character_comboBox.SelectedIndex == Party3_character_comboBox.SelectedIndex || Party1_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex || Party2_character_comboBox.SelectedIndex == Party3_character_comboBox.SelectedIndex || Party2_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex || Party3_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex)
                {
                    MessageBox.Show("The chosen character has already been set as a member!", "You cannot use the same character more than once!");
                    Read_characters(null, null);
                    return;
                }

                //Write Party
                SQLiteDataReader readerChar = new SQLiteCommand("SELECT Character, Value FROM Characters", connection).ExecuteReader();
                for (int i = 0; readerChar.Read(); i++)
                {
                    if (readerChar["Character"].ToString() == Party1_character_comboBox.SelectedItem.ToString()) savedata[0xC98] = Convert.ToByte(readerChar["Value"].ToString(), 16);
                    if (readerChar["Character"].ToString() == Party2_character_comboBox.SelectedItem.ToString()) savedata[0xC9A] = Convert.ToByte(readerChar["Value"].ToString(), 16);
                    if (readerChar["Character"].ToString() == Party3_character_comboBox.SelectedItem.ToString()) savedata[0xC9C] = Convert.ToByte(readerChar["Value"].ToString(), 16);
                    if (readerChar["Character"].ToString() == Party4_character_comboBox.SelectedItem.ToString()) savedata[0xC9E] = Convert.ToByte(readerChar["Value"].ToString(), 16);
                }
                readerChar.Close();

                //Write Character Editor
                SQLiteCommand cmd = new SQLiteCommand("SELECT DLC, [Level Resets], HP, [Total CP], Strength, Agility, Magic, Luck, Stamina, Spirit FROM Characters WHERE Character = @character", connection);
                cmd.Parameters.AddWithValue("@character", CharEditor_character_comboBox.SelectedItem.ToString());
                readerChar = cmd.ExecuteReader();
                readerChar.Read();
                var savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                //Write HP
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_hp_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["HP"].ToString(), 16), 2);
                //Write Level Resets
                savetype[Convert.ToUInt32(readerChar["Level Resets"].ToString(), 16)] = (byte)CharEditor_levelResets_numericUpDown.Value;
                //Write Total CP
                savetype[Convert.ToUInt32(readerChar["Total CP"].ToString(), 16)] = (byte)CharEditor_totalCP_numericUpDown.Value;
                //Write Strength
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_strength_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Strength"].ToString(), 16), 2);
                //Write Magic
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_magic_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Magic"].ToString(), 16), 2);
                //Write Agility
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_agility_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Agility"].ToString(), 16), 2);
                //Write Luck
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_luck_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Luck"].ToString(), 16), 2);
                //Write Stamina
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_stamina_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Stamina"].ToString(), 16), 2);
                //Write Spirit
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_spirit_numericUpDown.Value), 0, savetype, Convert.ToInt32(readerChar["Spirit"].ToString(), 16), 2);
                readerChar.Close();

                Read_characters(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters changes\n\n{ex}", "Error");
            }
        }

        //Set minimum Total CP value
        private void Set_LvReset_totalCP(object sender, EventArgs e)
        {
            if (!savedata_loaded || !extsavedata_loaded || CharEditor_character_changed) return;
            try
            {
                switch (CharEditor_levelResets_numericUpDown.Value)
                {
                    case 0:
                        CharEditor_totalCP_numericUpDown.Minimum = 0;
                        break;
                    case 1:
                        CharEditor_totalCP_numericUpDown.Minimum = 10;
                        break;
                    case 2:
                        CharEditor_totalCP_numericUpDown.Minimum = 18;
                        break;
                    case 3:
                        CharEditor_totalCP_numericUpDown.Minimum = 26;
                        break;
                    case 4:
                        CharEditor_totalCP_numericUpDown.Minimum = 32;
                        break;
                    case 5:
                        CharEditor_totalCP_numericUpDown.Minimum = 38;
                        break;
                    case 6:
                        CharEditor_totalCP_numericUpDown.Minimum = 42;
                        break;
                    case 7:
                        CharEditor_totalCP_numericUpDown.Minimum = 44;
                        break;
                    case 8:
                        CharEditor_totalCP_numericUpDown.Minimum = 46;
                        break;
                    case 9:
                        CharEditor_totalCP_numericUpDown.Minimum = 48;
                        break;
                    default:
                        CharEditor_totalCP_numericUpDown.Minimum = 49;
                        break;
                }

                if (sender.ToString() != "reading level reset")
                {
                    Write_characters(null, null);
                    Read_write_top_characters_used();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters Editor changes\n\n{ex}", "Error");
            }
        }

        //Max current character stats
        private void Max_character_stats_button_Click(object sender, EventArgs e)
        {
            if (!savedata_loaded || !extsavedata_loaded || CharEditor_character_changed) return;
            try
            {
                //Write Character Editor
                SQLiteCommand cmd = new SQLiteCommand("SELECT DLC, [Level Resets], HP, [Total CP], Strength, Agility, Magic, Luck, Stamina, Spirit FROM Characters WHERE Character = @character", connection);
                cmd.Parameters.AddWithValue("@character", CharEditor_character_comboBox.SelectedItem.ToString());
                SQLiteDataReader readerChar = cmd.ExecuteReader();
                readerChar.Read();
                var savetype = readerChar["DLC"].ToString() == "true" ? extsavedata : savedata;

                //Write Max HP
                Array.Copy(new byte[] { 0x0F, 0x27 }, 0, savetype, Convert.ToInt32(readerChar["HP"].ToString(), 16), 2);
                //Write Max Level Resets
                savetype[Convert.ToUInt32(readerChar["Level Resets"].ToString(), 16)] = 0x0A;
                //Write Max Total CP
                savetype[Convert.ToUInt32(readerChar["Total CP"].ToString(), 16)] = 0x63;
                //Write Max Strength
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Strength"].ToString(), 16), 2);
                //Write Max Magic
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Magic"].ToString(), 16), 2);
                //Write Max Agility
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Agility"].ToString(), 16), 2);
                //Write Max Luck
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Luck"].ToString(), 16), 2);
                //Write Max Stamina
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Stamina"].ToString(), 16), 2);
                //Write Max Spirit
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(readerChar["Spirit"].ToString(), 16), 2);

                Read_characters("Max Button Pressed", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters changesn\n\n{ex}", "Error");
            }
        }

        //Max all characters stats
        private void Max_all_characters_stats_button_Click(object sender, EventArgs e)
        {
            if (!savedata_loaded || !extsavedata_loaded || CharEditor_character_changed) return;
            try
            {
                SQLiteDataReader reader = new SQLiteCommand("SELECT DLC, [Level Resets], HP, [Total CP], Strength, Agility, Magic, Luck, Stamina, Spirit FROM Characters", connection).ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    var savetype = reader["DLC"].ToString() == "true" ? extsavedata : savedata;

                    //Write Max HP
                    Array.Copy(new byte[] { 0x0F, 0x27 }, 0, savetype, Convert.ToInt32(reader["HP"].ToString(), 16), 2);
                    //Write Max Level Resets
                    (savetype)[Convert.ToUInt32(reader["Level Resets"].ToString(), 16)] = 0x0A;
                    //Write Max Total CP
                    (savetype)[Convert.ToUInt32(reader["Total CP"].ToString(), 16)] = 0x63;
                    //Write Max Strength
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Strength"].ToString(), 16), 2);
                    //Write Max Magic
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Magic"].ToString(), 16), 2);
                    //Write Max Agility
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Agility"].ToString(), 16), 2);
                    //Write Max Luck
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Luck"].ToString(), 16), 2);
                    //Write Max Stamina
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Stamina"].ToString(), 16), 2);
                    //Write Max Spirit
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, savetype, Convert.ToInt32(reader["Spirit"].ToString(), 16), 2);

                }
                reader.Close();

                MessageBox.Show("All characters stats maxed successfully!", "All Maxed!");
                Read_characters("Max Button Pressed", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters changes\n\n{ex}", "Error");
            }
        }


        //Read Items tab
        private void Read_items(object sender, EventArgs e)
        {
            try
            {
                //Read and initialise Items datagrid
                SQLiteDataReader reader = new SQLiteCommand("SELECT Item, Offset FROM Items", connection).ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    Items_dataGridView.Rows[Items_dataGridView.Rows.Add()].Cells["Item"].Value = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Items.{reader["Item"].ToString()}.png"));
                    Items_dataGridView.Rows[i].Cells["Item"].Tag = reader["Item"].ToString();

                    Items_dataGridView.Rows[i].Cells["Quantity"].Value = savedata[Convert.ToUInt16(reader["Offset"].ToString(), 16)] - 0x80;
                    Items_dataGridView.Rows[i].Cells["Quantity"].Value = (int)Items_dataGridView.Rows[i].Cells["Quantity"].Value < 0 ? 0 : Items_dataGridView.Rows[i].Cells["Quantity"].Value;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Items\n\n{ex}", "Error");
            }
        }

        //Write Items tab
        private void Write_items(object sender, EventArgs e)
        {
            if (!savedata_loaded) return;
            try
            {
                for (int i = 0; i < Items_dataGridView.RowCount; i++)
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT Offset FROM Items WHERE Item = @item", connection);
                    cmd.Parameters.AddWithValue("@item", Items_dataGridView.Rows[i].Cells["Item"].Tag.ToString());
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    savedata[Convert.ToUInt16(reader["Offset"].ToString(), 16)] = (byte)(Convert.ToByte(Items_dataGridView.Rows[i].Cells["Quantity"].Value) + 0x80);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Items changes\n\n{ex}", "Error");
            }
        }

        //Set item description
        private void Set_item_desc(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string iName = ((DataGridView)sender)[0, e.RowIndex].Tag == null ? "Potion" : ((DataGridView)sender)[0, e.RowIndex].Tag.ToString();

                SQLiteCommand cmd = new SQLiteCommand("SELECT Equip, [Quest Medley] FROM Items WHERE Item = @item", connection);
                cmd.Parameters.AddWithValue("@item", iName);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item_equip_richTextBox.Text = reader["Equip"].ToString();
                    Item_quest_med_richTextBox.Text = reader["Quest Medley"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Items description\n\n{ex}", "Error");
            }
        }


        //Read CollectaCards tab
        private void Read_collectacards(object sender, EventArgs e)
        {
            try
            {
                //Read and initialise CollectaCards datagrid
                SQLiteDataReader reader = new SQLiteCommand("SELECT CollectaCard, [Normal Offset], [Rare Offset], [Premium Offset] FROM CollectaCards", connection).ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    Cards_dataGridView.Rows[Cards_dataGridView.Rows.Add()].Cells["Card_name"].Value = reader["CollectaCard"].ToString();

                    Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = savedata[Convert.ToUInt16(reader["Normal Offset"].ToString(), 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_normal"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_normal"].Value;

                    Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = savedata[Convert.ToUInt16(reader["Rare Offset"].ToString(), 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_rare"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_rare"].Value;

                    Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = savedata[Convert.ToUInt16(reader["Premium Offset"].ToString(), 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_premium"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_premium"].Value;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update CollectaCards\n\n{ex}", "Error");
            }
        }

        //Write CollectaCards tab
        private void Write_collectacards(object sender, EventArgs e)
        {
            if (!savedata_loaded) return;
            try
            {
                for (int i = 0; i < Cards_dataGridView.RowCount; i++)
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT [Normal Offset], [Rare Offset], [Premium Offset] FROM CollectaCards WHERE CollectaCard = @collectaCard", connection);
                    cmd.Parameters.AddWithValue("@collectaCard", Cards_dataGridView.Rows[i].Cells["Card_name"].Value.ToString());
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    savedata[Convert.ToUInt16(reader["Normal Offset"].ToString(), 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_normal"].Value) + 0x80);
                    savedata[Convert.ToUInt16(reader["Rare Offset"].ToString(), 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_rare"].Value) + 0x80);
                    savedata[Convert.ToUInt16(reader["Premium Offset"].ToString(), 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_premium"].Value) + 0x80);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store CollectaCards changes\n\n{ex}", "Error");
            }
        }

        //Set card description
        private void Set_card_desc(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cName = ((DataGridView)sender)[0, e.RowIndex].Value == null ? "#001 Warrior of Light" : ((DataGridView)sender)[0, e.RowIndex].Value.ToString();

                SQLiteCommand cmd = new SQLiteCommand("SELECT [Normal Description], [Rare Description], [Premium Description] FROM CollectaCards WHERE CollectaCard = @collectaCard", connection);
                cmd.Parameters.AddWithValue("@collectaCard", cName);
                SQLiteDataReader reader = cmd.ExecuteReader();

                card_normal_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.CollectaCards.Normal.{cName} Normal.png"));
                card_rare_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.CollectaCards.Rare.{cName} Rare.png"));
                card_premium_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.CollectaCards.Premium.{cName} Premium.png"));
                card_back_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.CollectaCards.Back.{cName} Back.png"));

                while (reader.Read())
                {
                    card_normal_description_richTextBox.Rtf = $@"{{\rtf {reader["Normal Description"].ToString()}}}";
                    card_rare_description_richTextBox.Rtf = $@"{{\rtf {reader["Rare Description"].ToString()}}}";
                    card_premium_description_richTextBox.Rtf = $@"{{\rtf {reader["Premium Description"].ToString()}}}";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update CollectaCards description\n\n{ex}", "Error");
            }
        }

        bool max_button_pressed;
        //Max all items
        private void max_items_button_Click(object sender, EventArgs e)
        {
            max_button_pressed = true;
            for (int i = 0; i < Items_dataGridView.RowCount; i++)
            {
                Items_dataGridView.Rows[i].Cells["Quantity"].Value = 99;
            }
            Write_items(null, null);
            max_button_pressed = false;
        }

        //Max all normal cards
        private void max_normal_cards_button_Click(object sender, EventArgs e)
        {
            max_button_pressed = true;
            for (int i = 0; i < Cards_dataGridView.RowCount; i++)
            {
                Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = 99;
            }
            Write_collectacards(null, null);
            max_button_pressed = false;
        }

        //Max all rare cards
        private void max_rare_cards_button_Click(object sender, EventArgs e)
        {
            max_button_pressed = true;
            for (int i = 0; i < Cards_dataGridView.RowCount; i++)
            {
                Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = 99;
            }
            Write_collectacards(null, null);
            max_button_pressed = false;
        }

        //Max all premium cards
        private void max_premium_cards_button_Click(object sender, EventArgs e)
        {
            max_button_pressed = true;
            for (int i = 0; i < Cards_dataGridView.RowCount; i++)
            {
                Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = 99;
            }
            Write_collectacards(null, null);
            max_button_pressed = false;
        }

        //Max all cards
        private void max_all_cards_button_Click(object sender, EventArgs e)
        {
            max_button_pressed = true;
            for (int i = 0; i < Cards_dataGridView.RowCount; i++)
            {
                Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = 99;
                Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = 99;
                Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = 99;
            }
            Write_collectacards(null, null);
            max_button_pressed = false;
        }


        //For top songs when reading songs
        public class Song : IComparable<Song>
        {
            public UInt32 TimesPlayed { get; set; }
            public string Value { get; set; }
            public string Difficulty { get; set; }

            public int CompareTo(Song other)
            {
                return TimesPlayed.CompareTo(other.TimesPlayed);
            }
        }

        //Get song rank
        public string rank(byte[] rank)
        {
            switch (rank[0])
            {
                case 0x00:
                    return "SSS";
                case 0x01:
                    return "SS";
                case 0x02:
                    return "S";
                case 0x03:
                    return "A";
                case 0x04:
                    return "B";
                case 0x05:
                    return "C";
                case 0x06:
                    return "D";
                case 0x07:
                    return "E";
                case 0x08:
                    switch (rank[4])
                    {
                        case 0x00:
                            return "Unplayed";
                        default:
                            return "F";
                    }
                default:
                    return "Unknown";
            }
        }

        //Get song status
        public string status(byte[] status)
        {
            switch (status[0])
            {
                case 0x00:
                    return "All-Critical";
                case 0x01:
                    return "Perfect Chain";
                case 0x02:
                    return "Clear";
                case 0x03:
                    switch (status[3])
                    {
                        case 0x00:
                            return "Unplayed";
                        default:
                            return "Failed";
                    }
                default:
                    return "Unknown";
            }
        }

        //Get song play style
        public string playstyle(byte playstyle)
        {
            switch (playstyle)
            {
                case 0x01:
                    return "Stylus";
                case 0x02:
                    return "Button";
                case 0x03:
                    return "Hybrid";
                case 0x04:
                    return "One-Handed";
                default:
                    return "Unplayed";
            }
        }

        //Read Songs tab
        private void Read_songs(object sender, EventArgs e)
        {
            try
            {
                //Read and intitalise songs datagrid
                int songIndex = 0;
                int Total_cleared = 0;
                int Total_played = 0;
                int Total_basic_all_criticals = 0;
                int Total_expert_all_criticals = 0;
                int Total_ultimate_all_criticals = 0;
                List<Song> Songs_list = new List<Song>();
                SQLiteDataReader reader = new SQLiteCommand("SELECT * FROM Songs", connection).ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Basic";
                    Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Expert";
                    Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Ultimate";

                    Songs_dataGridView.Rows[songIndex].Cells["songs_Series"].Value = reader["Series"].ToString();
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Series"].Tag = reader["Value"].ToString();
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Series"].Value = reader["Series"].ToString();
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Series"].Tag = reader["Value"].ToString();
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Series"].Value = reader["Series"].ToString();
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Series"].Tag = reader["Value"].ToString();

                    Songs_dataGridView.Rows[songIndex].Cells["songs_Song_name"].Value = reader["Song"].ToString();
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Song_name"].Value = reader["Song"].ToString();
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Song_name"].Value = reader["Song"].ToString();

                    Songs_dataGridView.Rows[songIndex].Cells["songs_Type"].Value = reader["Type"].ToString();
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Type"].Value = reader["Type"].ToString();
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Type"].Value = reader["Type"].ToString();

                    //Read Score value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Score"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Score"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Score"].ToString(), 16));

                    //Read chain value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Chain"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Chain"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Chain"].ToString(), 16));

                    //Read rank value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(reader["Basic Rank"].ToString(), 16))));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(reader["Expert Rank"].ToString(), 16))));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(reader["Ultimate Rank"].ToString(), 16))));

                    //Read status value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Status"].ToString(), 16))));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Status"].ToString(), 16))));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Status"].ToString(), 16))));

                    //Read playstyle value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(reader["Basic Play Style"].ToString(), 16)]);
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(reader["Expert Play Style"].ToString(), 16)]);
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(reader["Ultimate Play Style"].ToString(), 16)]);

                    //Read times played value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Times Played"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Times Played"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Times Played"].ToString(), 16));

                    //Read times cleared value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Times Cleared"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Times Cleared"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Times Cleared"].ToString(), 16));

                    //Read song picked online value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_song_picked_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Basic Song Picked (Online)"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_song_picked_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Expert Song Picked (Online)"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_song_picked_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Ultimate Song Picked (Online)"].ToString(), 16));

                    //Read song picked online no ex value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_song_picked_online_noEX"].ReadOnly = true;
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_song_picked_online_noEX"].ReadOnly = true;
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_song_picked_online_noEX"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Ultimate Song Picked (Online, No-EX)"].ToString(), 16));

                    //Read times played online value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_times_played_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Basic Times Played (Online)"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_times_played_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Expert Times Played (Online)"].ToString(), 16));
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_times_played_online"].Value = BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Ultimate Times Played (Online)"].ToString(), 16));

                    //Read date value for song
                    Songs_dataGridView.Rows[songIndex].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(reader["Basic Date"].ToString(), 16) + 2]}.{extsavedata[Convert.ToInt32(reader["Basic Date"].ToString(), 16) + 3]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Basic Date"].ToString(), 16))}";
                    Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(reader["Expert Date"].ToString(), 16) + 2]}.{extsavedata[Convert.ToInt32(reader["Expert Date"].ToString(), 16) + 3]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Expert Date"].ToString(), 16))}";
                    Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(reader["Ultimate Date"].ToString(), 16) + 2]}.{extsavedata[Convert.ToInt32(reader["Ultimate Date"].ToString(), 16) + 3]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Ultimate Date"].ToString(), 16))}";

                    //Add cleared and played values
                    Total_played += Convert.ToInt32(Songs_dataGridView.Rows[songIndex].Cells["songs_Times_played"].Value);
                    Total_played += Convert.ToInt32(Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Times_played"].Value);
                    Total_played += Convert.ToInt32(Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Times_played"].Value);
                    Total_cleared += Convert.ToInt32(Songs_dataGridView.Rows[songIndex].Cells["songs_TImes_cleared"].Value);
                    Total_cleared += Convert.ToInt32(Songs_dataGridView.Rows[songIndex + 1].Cells["songs_TImes_cleared"].Value);
                    Total_cleared += Convert.ToInt32(Songs_dataGridView.Rows[songIndex + 2].Cells["songs_TImes_cleared"].Value);

                    //Add total All-Critical values
                    if (Songs_dataGridView.Rows[songIndex].Cells["songs_Difficulty"].Value.ToString() == "Basic" && Songs_dataGridView.Rows[songIndex].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_basic_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Difficulty"].Value.ToString() == "Basic" && Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_basic_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Difficulty"].Value.ToString() == "Basic" && Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_basic_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex].Cells["songs_Difficulty"].Value.ToString() == "Expert" && Songs_dataGridView.Rows[songIndex].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_expert_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Difficulty"].Value.ToString() == "Expert" && Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_expert_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Difficulty"].Value.ToString() == "Expert" && Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_expert_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex].Cells["songs_Difficulty"].Value.ToString() == "Ultimate" && Songs_dataGridView.Rows[songIndex].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_ultimate_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Difficulty"].Value.ToString() == "Ultimate" && Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_ultimate_all_criticals++;
                    if (Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Difficulty"].Value.ToString() == "Ultimate" && Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Status"].Value.ToString() == "All-Critical") Total_ultimate_all_criticals++;

                    label1.Text = $"Total Basic All-Criticals: {Total_basic_all_criticals}";
                    label2.Text = $"Total Expert All-Criticals: {Total_expert_all_criticals}";
                    label3.Text = $"Total Ultimate All-Criticals: {Total_ultimate_all_criticals}";
                    label11.Text = $"Total Times Played: {Total_played}";
                    label10.Text = $"Total Times Cleared: {Total_cleared}";

                    //Store top songs data
                    Songs_list.Add(new Song() { TimesPlayed = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Basic Times Played"].ToString(), 16)) + BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Basic Times Played (Online)"].ToString(), 16)), Value = reader["Value"].ToString(), Difficulty = "basic" });
                    Songs_list.Add(new Song() { TimesPlayed = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Expert Times Played"].ToString(), 16)) + BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Expert Times Played (Online)"].ToString(), 16)), Value = reader["Value"].ToString(), Difficulty = "expert" });
                    Songs_list.Add(new Song() { TimesPlayed = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(reader["Ultimate Times Played"].ToString(), 16)) + BitConverter.ToUInt16(extsavedata, Convert.ToInt32(reader["Ultimate Times Played (Online)"].ToString(), 16)), Value = reader["Value"].ToString(), Difficulty = "ultimate" });

                    songIndex += 3;
                }

                //Write top songs values onto save
                Songs_list.Sort();
                Songs_list.Reverse();
                ushort topSongOffset = 0x3854;
                for (int i = 0; i < 8; i++)
                {
                    if (Songs_list[i].TimesPlayed != 0)
                    {
                        Array.Copy(BitConverter.GetBytes(Convert.ToUInt16(Songs_list[i].Value, 16)), 0, savedata, topSongOffset, 2);
                        if (Songs_list[i].Difficulty == "basic") savedata[topSongOffset + 4] = 0x00;
                        if (Songs_list[i].Difficulty == "expert") savedata[topSongOffset + 4] = 0x01;
                        if (Songs_list[i].Difficulty == "ultimate") savedata[topSongOffset + 4] = 0x02;
                        Array.Copy(BitConverter.GetBytes(Songs_list[i].TimesPlayed), 0, savedata, topSongOffset + 6, 2);
                    }
                    else
                    {
                        Array.Copy(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, 0, savedata, topSongOffset, 8);
                    }
                    topSongOffset += 8;
                }
                Songs_list.Clear();
                Read_top_songs_played();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to update Songs\n\n{ex}", "Error");
            }
        }


        //Real time changes and checks
        private void dataGridView_integer_check(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            tb.KeyPress -= new KeyPressEventHandler(notInteger);
            if (((DataGridView)sender).CurrentCell.ColumnIndex > 0)
            {
                if (tb != null) tb.KeyPress += new KeyPressEventHandler(notInteger);
            }
        }

        private void notInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void cellCheck(object sender, DataGridViewCellEventArgs e)
        {
            if (max_button_pressed) return;
            if (e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                uint i;
                if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value == null || !uint.TryParse(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString(), out i))
                {
                    ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value = 0;
                }
                else
                {
                    ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value = (int)i;
                }
            }
            Write_items(null, null);
            Write_collectacards(null, null);
        }


        //Before form is closed kill SQL processes and delete SQL database files 
        private void Kill_SQL(object sender, FormClosingEventArgs e)
        {
            try
            {
                while (connection.State.ToString() == "Open")
                {
                    connection.Close();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete("Database.sqlite3");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to close/kill the SQL process or trying to delete the database files\n\n{ex}", "Error");
            }
        }
    }
}