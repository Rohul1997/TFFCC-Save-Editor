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
using System.Web.Script.Serialization;
using System.Linq;
using System.Drawing;
using System.Reflection;

namespace TFFCC_Save_Editor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            CharEditor_levelResets_picturebox.Parent = CharEditor_character_pictureBox;
            CharEditor_levelResets_picturebox.Location = new Point(62, 0);
        }

        Assembly assembly = Assembly.GetExecutingAssembly();
        OpenFileDialog open_extsavedata = new OpenFileDialog();
        OpenFileDialog open_savedata = new OpenFileDialog();
        SaveFileDialog save_savedata = new SaveFileDialog();
        SaveFileDialog save_extsavedata = new SaveFileDialog();

        public dynamic dbJson(string type)
        {
            dynamic json = new JavaScriptSerializer().DeserializeObject((new StreamReader(new MemoryStream(Properties.Resources.Databases))).ReadToEnd());
            switch (type)
            {
                case "items":
                    return json["items"];
                case "characters":
                    return json["characters"];
                case "abilities":
                    return json["abilities"];
                case "monsters":
                    return json["monsters"];
                case "songs":
                    return json["songs"];
                default:
                    return null;
            }
        }

        bool savedata_loaded;
        bool extsavedata_loaded;
        byte[] savedata;
        byte[] extsavedata;
        //Open savedata.bk and extsavedata.bk file and store as savadata byte array
        private void Open_files_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Disable savedata.bk & extsavedata.bk stuff
                Save_files_ToolStripMenuItem.Enabled = Save_files_as_ToolStripMenuItem.Enabled = max_items_button.Enabled = max_normal_cards_button.Enabled = max_rare_cards_button.Enabled = max_premium_cards_button.Enabled = max_all_cards_button.Enabled = CharEditor_character_comboBox.Enabled = Max_character_stats_button.Enabled = Max_all_characters_stats_button.Enabled = savedata_loaded = extsavedata_loaded = false;

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
                Read_songs(null, null);

                //Enable savedata.bk & extsavedata.bk stuff
                Save_files_ToolStripMenuItem.Enabled = Save_files_as_ToolStripMenuItem.Enabled = max_items_button.Enabled = max_normal_cards_button.Enabled = max_rare_cards_button.Enabled = max_premium_cards_button.Enabled = max_all_cards_button.Enabled = CharEditor_character_comboBox.Enabled = Max_character_stats_button.Enabled = Max_all_characters_stats_button.Enabled = savedata_loaded = extsavedata_loaded = true;
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

                //Read online battle rating wins
                Online_battle_rating_wins_numericUpDown.Value = BitConverter.ToUInt16(savedata, 0x37E6);

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
                Total_rating_wins_textBox.Text = (Online_battle_rating_wins_numericUpDown.Value + Local_battle_rating_wins_numericUpDown.Value).ToString();

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

                //Write online battle rating wins
                Array.Copy(BitConverter.GetBytes((ushort)Online_battle_rating_wins_numericUpDown.Value), 0, savedata, 0x37E6, 2);

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


        //Characters Tab
        bool CharEditor_character_changed;
        //DLC character check
        public string charType(string charType)
        {
            switch (charType)
            {
                case "Yuffie":
                    return "DLC";
                case "Rosa":
                    return "DLC";
                case "Cloud #2":
                    return "DLC";
                case "Orlandeau":
                    return "DLC";
                case "Auron #2":
                    return "DLC";
                case "Vincent":
                    return "DLC";
                default:
                    return "Normal";
            }
        }
        //Read Characters tab
        private void Read_characters(object sender, EventArgs e)
        {
            try
            {
                var dbCharactersJSON = dbJson("characters");
                Dictionary<string, object> dbAbilitiesJSON = dbJson("abilities");
                if (dbCharactersJSON == null || dbAbilitiesJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //Party
                for (int i = 0; i < 71; i++)
                {
                    var character = ((Dictionary<string, object>)dbCharactersJSON).ToList()[i].Key;
                    if (Convert.ToByte(dbCharactersJSON[character]["value"], 16) == savedata[0xC98])
                    {
                        Party1_character_comboBox.SelectedItem = character;
                        Party1_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{character}.png"));
                        Party1_ability1_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 1"], 16))).First().Key;
                        Party1_ability2_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 2"], 16))).First().Key;
                        Party1_ability3_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 3"], 16))).First().Key;
                        Party1_ability4_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 4"], 16))).First().Key;
                    }
                    if (Convert.ToByte(dbCharactersJSON[character]["value"], 16) == savedata[0xC9A])
                    {
                        Party2_character_comboBox.SelectedItem = character;
                        Party2_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{character}.png"));
                        Party2_ability1_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 1"], 16))).First().Key;
                        Party2_ability2_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 2"], 16))).First().Key;
                        Party2_ability3_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 3"], 16))).First().Key;
                        Party2_ability4_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 4"], 16))).First().Key;
                    }
                    if (Convert.ToByte(dbCharactersJSON[character]["value"], 16) == savedata[0xC9C])
                    {
                        Party3_character_comboBox.SelectedItem = character;
                        Party3_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{character}.png"));
                        Party3_ability1_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 1"], 16))).First().Key;
                        Party3_ability2_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 2"], 16))).First().Key;
                        Party3_ability3_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 3"], 16))).First().Key;
                        Party3_ability4_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 4"], 16))).First().Key;
                    }
                    if (Convert.ToByte(dbCharactersJSON[character]["value"], 16) == savedata[0xC9E])
                    {
                        Party4_character_comboBox.SelectedItem = character;
                        Party4_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.{character}.png"));
                        Party4_ability1_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 1"], 16))).First().Key;
                        Party4_ability2_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 2"], 16))).First().Key;
                        Party4_ability3_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 3"], 16))).First().Key;
                        Party4_ability4_textBox.Text = dbAbilitiesJSON.Where(a => Convert.ToUInt16(a.Value.ToString(), 16) == BitConverter.ToUInt16(charType(character) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character]["ability 4"], 16))).First().Key;
                    }
                }

                //Character Editor
                CharEditor_character_changed = false;
                //if the character is changedor if max button is pressed in the character editor then set CharEditor_character_changed to true
                if (sender != null && sender.ToString() == "Max Button Pressed" || ((ComboBox)sender) != null && ((ComboBox)sender).Name == "CharEditor_character_comboBox") CharEditor_character_changed = true;

                Max_character_stats_button.Text = $"Max {CharEditor_character_comboBox.SelectedItem} Stats";
                CharEditor_character_pictureBox.Image = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Characters.Characters_Small.{CharEditor_character_comboBox.SelectedItem}.png"));
                CharEditor_level_textBox.Text = (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["level"], 16)].ToString();
                CharEditor_exp_textBox.Text = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["exp"], 16)).ToString();
                CharEditor_hp_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["hp"], 16));
                CharEditor_levelResets_numericUpDown.Value = (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["level resets"], 16)];
                CharEditor_totalCP_numericUpDown.Value = (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["total cp"], 16)];
                CharEditor_strength_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["strength"], 16));
                CharEditor_magic_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["magic"], 16));
                CharEditor_agility_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["agility"], 16));
                CharEditor_luck_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["luck"], 16));
                CharEditor_stamina_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["stamina"], 16));
                CharEditor_spirit_numericUpDown.Value = BitConverter.ToUInt16(charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["spirit"], 16));
                Set_LvReset_totalCP("reading level reset", null);
                switch (CharEditor_levelResets_numericUpDown.Value)
                {
                    case 0:
                        CharEditor_levelResets_picturebox.Image = null;
                        break;
                    case 1:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_1;
                        break;
                    case 2:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_2;
                        break;
                    case 3:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_3;
                        break;
                    case 4:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_4;
                        break;
                    case 5:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_5;
                        break;
                    case 6:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_6;
                        break;
                    case 7:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_7;
                        break;
                    case 8:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_8;
                        break;
                    case 9:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_9;
                        break;
                    default:
                        CharEditor_levelResets_picturebox.Image = Properties.Resources.Level_Resets_10;
                        break;
                }

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
                var dbCharactersJSON = dbJson("characters");
                if (dbCharactersJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //Check if a character is used more than once
                if (Party1_character_comboBox.SelectedIndex == Party2_character_comboBox.SelectedIndex || Party1_character_comboBox.SelectedIndex == Party3_character_comboBox.SelectedIndex || Party1_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex || Party2_character_comboBox.SelectedIndex == Party3_character_comboBox.SelectedIndex || Party2_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex || Party3_character_comboBox.SelectedIndex == Party4_character_comboBox.SelectedIndex)
                {
                    MessageBox.Show("The chosen character has already been set as a member!", "You cannot use the same character more than once!");
                    Read_characters(null, null);
                    return;
                }

                //Write Party
                savedata[0xC98] = Convert.ToByte(dbCharactersJSON[Party1_character_comboBox.SelectedItem.ToString()]["value"], 16);
                savedata[0xC9A] = Convert.ToByte(dbCharactersJSON[Party2_character_comboBox.SelectedItem.ToString()]["value"], 16);
                savedata[0xC9C] = Convert.ToByte(dbCharactersJSON[Party3_character_comboBox.SelectedItem.ToString()]["value"], 16);
                savedata[0xC9E] = Convert.ToByte(dbCharactersJSON[Party4_character_comboBox.SelectedItem.ToString()]["value"], 16);

                //Write Character Editor
                //Write HP
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_hp_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["hp"], 16), 2);
                //Write Level Resets
                (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["level resets"], 16)] = (byte)CharEditor_levelResets_numericUpDown.Value;
                //Write Total CP
                (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["total cp"], 16)] = (byte)CharEditor_totalCP_numericUpDown.Value;
                //Write Strength
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_strength_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["strength"], 16), 2);
                //Write Magic
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_magic_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["magic"], 16), 2);
                //Write Agility
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_agility_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["agility"], 16), 2);
                //Write Luck
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_luck_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["luck"], 16), 2);
                //Write Stamina
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_stamina_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["stamina"], 16), 2);
                //Write Spirit
                Array.Copy(BitConverter.GetBytes((ushort)CharEditor_spirit_numericUpDown.Value), 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["spirit"], 16), 2);

                Read_characters(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters changes\n\n{ex}", "Error");
            }
        }

        //Set level reset value, level reset image and minimum Total CP value
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
                var dbCharactersJSON = dbJson("characters");
                if (dbCharactersJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //Write Max HP
                Array.Copy(new byte[] { 0x0F, 0x27 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["hp"], 16), 2);
                //Write Max Level Resets
                (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["level resets"], 16)] = 0x0A;
                //Write Max Total CP
                (charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["total cp"], 16)] = 0x63;
                //Write Max Strength
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["strength"], 16), 2);
                //Write Max Magic
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["magic"], 16), 2);
                //Write Max Agility
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["agility"], 16), 2);
                //Write Max Luck
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["luck"], 16), 2);
                //Write Max Stamina
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["stamina"], 16), 2);
                //Write Max Spirit
                Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(CharEditor_character_comboBox.SelectedItem.ToString()) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[CharEditor_character_comboBox.SelectedItem.ToString()]["spirit"], 16), 2);

                Read_characters("Max Button Pressed", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Characters changesn\n{ex}", "Error");
            }
        }
        //Max all characters stats
        private void Max_all_characters_stats_button_Click(object sender, EventArgs e)
        {
            if (!savedata_loaded || !extsavedata_loaded || CharEditor_character_changed) return;
            try
            {
                var dbCharactersJSON = dbJson("characters");
                if (dbCharactersJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                foreach (KeyValuePair<string, object> character in dbCharactersJSON)
                {
                    //Write Max HP
                    Array.Copy(new byte[] { 0x0F, 0x27 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["hp"], 16), 2);
                    //Write Max Level Resets
                    (charType(character.Key) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[character.Key]["level resets"], 16)] = 0x0A;
                    //Write Max Total CP
                    (charType(character.Key) == "DLC" ? extsavedata : savedata)[Convert.ToUInt32(dbCharactersJSON[character.Key]["total cp"], 16)] = 0x63;
                    //Write Max Strength
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["strength"], 16), 2);
                    //Write Max Magic
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["magic"], 16), 2);
                    //Write Max Agility
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["agility"], 16), 2);
                    //Write Max Luck
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["luck"], 16), 2);
                    //Write Max Stamina
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["stamina"], 16), 2);
                    //Write Max Spirit
                    Array.Copy(new byte[] { 0xE7, 0x03 }, 0, charType(character.Key) == "DLC" ? extsavedata : savedata, Convert.ToInt32(dbCharactersJSON[character.Key]["spirit"], 16), 2);
                }

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
                var dbItemsJSON = dbJson("items");
                if (dbItemsJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //Read and initialise Items datagrid
                for (int i = 0; i < 92; i++)
                {
                    var item = ((Dictionary<string, object>)dbItemsJSON).ToList()[i].Key;
                    Items_dataGridView.Rows[Items_dataGridView.Rows.Add()].Cells["Item"].Value = Image.FromStream(assembly.GetManifestResourceStream($"TFFCC_Save_Editor.Resources.Items.{item}.png"));
                    Items_dataGridView.Rows[i].Cells["Item"].Tag = item;

                    Items_dataGridView.Rows[i].Cells["Quantity"].Value = savedata[Convert.ToUInt16(dbItemsJSON[item]["offset"], 16)] - 0x80;
                    Items_dataGridView.Rows[i].Cells["Quantity"].Value = (int)Items_dataGridView.Rows[i].Cells["Quantity"].Value < 0 ? 0 : Items_dataGridView.Rows[i].Cells["Quantity"].Value;
                }
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
                var dbItemsJSON = dbJson("items");
                if (dbItemsJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                for (int i = 0; i < Items_dataGridView.RowCount; i++)
                {
                    savedata[Convert.ToUInt16(dbItemsJSON[Items_dataGridView.Rows[i].Cells["Item"].Tag.ToString()]["offset"], 16)] = (byte)(Convert.ToByte(Items_dataGridView.Rows[i].Cells["Quantity"].Value) + 0x80);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store Items changes\n\n{ex}", "Error");
            }
        }

        //Read CollectaCards tab
        private void Read_collectacards(object sender, EventArgs e)
        {
            try
            {
                var dbItemsJSON = dbJson("items");
                //Read and initialise CollectaCards datagrid
                for (int i = 0; i < 162; i++)
                {
                    var card = ((Dictionary<string, object>)dbItemsJSON).ToList()[i + 92].Key;
                    Cards_dataGridView.Rows[Cards_dataGridView.Rows.Add()].Cells["Card_name"].Value = card;

                    Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = savedata[Convert.ToUInt16(dbItemsJSON[card]["normal offset"], 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_normal"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_normal"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_normal"].Value;

                    Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = savedata[Convert.ToUInt16(dbItemsJSON[card]["rare offset"], 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_rare"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_rare"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_rare"].Value;

                    Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = savedata[Convert.ToUInt16(dbItemsJSON[card]["premium offset"], 16)] - 0x80;
                    Cards_dataGridView.Rows[i].Cells["Card_premium"].Value = (int)Cards_dataGridView.Rows[i].Cells["Card_premium"].Value < 0 ? 0 : Cards_dataGridView.Rows[i].Cells["Card_premium"].Value;
                }
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
                var dbItemsJSON = dbJson("items");
                if (dbItemsJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //CollectaCards tab
                //Write CollectaCards
                for (int i = 0; i < Cards_dataGridView.RowCount; i++)
                {
                    savedata[Convert.ToUInt16(dbItemsJSON[Cards_dataGridView.Rows[i].Cells["Card_name"].Value.ToString()]["normal offset"], 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_normal"].Value) + 0x80);
                    savedata[Convert.ToUInt16(dbItemsJSON[Cards_dataGridView.Rows[i].Cells["Card_name"].Value.ToString()]["rare offset"], 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_rare"].Value) + 0x80);
                    savedata[Convert.ToUInt16(dbItemsJSON[Cards_dataGridView.Rows[i].Cells["Card_name"].Value.ToString()]["premium offset"], 16)] = (byte)(Convert.ToByte(Cards_dataGridView.Rows[i].Cells["Card_premium"].Value) + 0x80);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to store CollectaCards changes\n\n{ex}", "Error");
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


        //Read songs tab
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
        private void Read_songs(object sender, EventArgs e)
        {
            try
            {
                //Songs tab
                var dbSongsJSON = dbJson("songs");
                if (dbSongsJSON == null)
                {
                    MessageBox.Show("Failed loading database", "Error");
                    return;
                }

                //Read and intitalise songs datagrid
                int songIndex = 0;
                int Total_cleared = 0;
                int Total_played = 0;
                int Total_basic_all_criticals = 0;
                int Total_expert_all_criticals = 0;
                int Total_ultimate_all_criticals = 0;
                foreach (KeyValuePair<string, object> series in dbSongsJSON)
                {
                    foreach (KeyValuePair<string, object> songName in (Dictionary<string, object>)series.Value)
                    {
                        Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Basic";
                        Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Expert";
                        Songs_dataGridView.Rows[Songs_dataGridView.Rows.Add()].Cells["songs_Difficulty"].Value = "Ultimate";

                        Songs_dataGridView.Rows[songIndex].Cells["songs_Series"].Value = series.Key;
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Series"].Value = series.Key;
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Series"].Value = series.Key;

                        Songs_dataGridView.Rows[songIndex].Cells["songs_Song_name"].Value = songName.Key;
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Song_name"].Value = songName.Key;
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Song_name"].Value = songName.Key;

                        Songs_dataGridView.Rows[songIndex].Cells["songs_Type"].Value = dbSongsJSON[series.Key][songName.Key]["type"];
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Type"].Value = dbSongsJSON[series.Key][songName.Key]["type"];
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Type"].Value = dbSongsJSON[series.Key][songName.Key]["type"];

                        //Read Score value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic score"], 16));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert score"], 16));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Score"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate score"], 16));

                        //Read chain value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic chain"], 16));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert chain"], 16));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Chain"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate chain"], 16));

                        //Read rank value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic rank"], 16))));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert rank"], 16))));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Rank"].Value = rank(BitConverter.GetBytes(BitConverter.ToUInt64(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate rank"], 16))));

                        //Read status value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic status"], 16))));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert status"], 16))));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Status"].Value = status(BitConverter.GetBytes(BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate status"], 16))));

                        //Read playstyle value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic play style"], 16)]);
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert play style"], 16)]);
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Play_style"].Value = playstyle(extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate play style"], 16)]);

                        //Read times played value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic times played"], 16));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert times played"], 16));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Times_played"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate times played"], 16));

                        //Read times cleared value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic times cleared"], 16));
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert times cleared"], 16));
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_TImes_cleared"].Value = BitConverter.ToUInt32(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate times cleared"], 16));

                        //Read date value for song
                        Songs_dataGridView.Rows[songIndex].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic date"], 16) + 3]}.{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic date"], 16) + 2]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["basic date"], 16))}";
                        Songs_dataGridView.Rows[songIndex + 1].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert date"], 16) + 3]}.{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert date"], 16) + 2]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["expert date"], 16))}";
                        Songs_dataGridView.Rows[songIndex + 2].Cells["songs_Date"].Value = $"{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate date"], 16) + 3]}.{extsavedata[Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate date"], 16) + 2]}.{BitConverter.ToUInt16(extsavedata, Convert.ToInt32(dbSongsJSON[series.Key][songName.Key]["ultimate date"], 16))}";

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

                        songIndex += 3;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid extsavedata.bk\n\n{ex}", "Failed to open the file");
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
    }
}