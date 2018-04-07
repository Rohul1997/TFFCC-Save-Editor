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

namespace TFFCC_Save_Editor
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox Profile_groupBox;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.Progress_label = new System.Windows.Forms.Label();
            this.Player_name_label = new System.Windows.Forms.Label();
            this.Rhythmia_label = new System.Windows.Forms.Label();
            this.Player_name_textBox = new System.Windows.Forms.TextBox();
            this.Rhythmia_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Trophies_textBox = new System.Windows.Forms.TextBox();
            this.Songs_dataGridView = new System.Windows.Forms.DataGridView();
            this.songs_Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Chain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Play_style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Times_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_TImes_cleared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songs_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Records_tabPage = new System.Windows.Forms.TabPage();
            this.Battle_party_groupBox = new System.Windows.Forms.GroupBox();
            this.Levels_resets_label = new System.Windows.Forms.Label();
            this.Collectacards_obtained_label = new System.Windows.Forms.Label();
            this.Critical_boosts_achieved_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Parameter_boosts_performed_label = new System.Windows.Forms.Label();
            this.Parameter_boosts_performed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Critical_boosts_achieved_label = new System.Windows.Forms.Label();
            this.Items_used_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Items_used_label = new System.Windows.Forms.Label();
            this.Treasure_chests_earned_label = new System.Windows.Forms.Label();
            this.Treasure_chests_earned_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Collectacards_obtained_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Abilities_triggered_label = new System.Windows.Forms.Label();
            this.Fat_chocobo_encounters_label = new System.Windows.Forms.Label();
            this.Fat_chocobo_encounters_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Abilities_triggered_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Levels_reset_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Versus_mode_groupBox = new System.Windows.Forms.GroupBox();
            this.Highest_rank_class_comboBox = new System.Windows.Forms.ComboBox();
            this.Highest_rank_comboBox = new System.Windows.Forms.ComboBox();
            this.Local_battle_rating_ties_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Online_battle_rating_ties_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Local_battle_rating_losses_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Online_battle_rating_losses_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Local_battle_rating_wins_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Online_battle_rating_wins_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Local_battle_rating_score_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Online_battle_rating_score_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AI_battle_victories_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EX_bursts_used_label = new System.Windows.Forms.Label();
            this.Scores_played_total_ultimatenex_textBox = new System.Windows.Forms.TextBox();
            this.Total_rating_ties_textBox = new System.Windows.Forms.TextBox();
            this.Scores_played_total_ultimate_textBox = new System.Windows.Forms.TextBox();
            this.Total_rating_losses_textBox = new System.Windows.Forms.TextBox();
            this.Scores_played_total_expert_textBox = new System.Windows.Forms.TextBox();
            this.Total_rating_wins_textBox = new System.Windows.Forms.TextBox();
            this.Local_battle_rating_label = new System.Windows.Forms.Label();
            this.Online_battle_rating_label = new System.Windows.Forms.Label();
            this.Scores_played_total_basic_textBox = new System.Windows.Forms.TextBox();
            this.Total_rating_score_textBox = new System.Windows.Forms.TextBox();
            this.Highest_rank_class_label = new System.Windows.Forms.Label();
            this.Highest_rank_hash_label = new System.Windows.Forms.Label();
            this.Total_rating_ties_label = new System.Windows.Forms.Label();
            this.Total_rating_losses_label = new System.Windows.Forms.Label();
            this.Total_rating_wins_label = new System.Windows.Forms.Label();
            this.Total_rating_score_label = new System.Windows.Forms.Label();
            this.Total_rating_label = new System.Windows.Forms.Label();
            this.Highest_rank_label = new System.Windows.Forms.Label();
            this.AI_battle_victories_label = new System.Windows.Forms.Label();
            this.Scores_played_local_label = new System.Windows.Forms.Label();
            this.Scores_played_total_label = new System.Windows.Forms.Label();
            this.Scores_played_online_label = new System.Windows.Forms.Label();
            this.Scores_played_local_ultimatenex_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_online_ultimatenex_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_local_ultimate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EX_bursts_used_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_local_expert_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_online_ultimate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_local_basic_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_online_expert_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Scores_played_online_basic_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Quest_medleys_groupBox = new System.Windows.Forms.GroupBox();
            this.Total_quests_cleared_label = new System.Windows.Forms.Label();
            this.Short_quests_cleared_label = new System.Windows.Forms.Label();
            this.Medium_quests_cleared_label = new System.Windows.Forms.Label();
            this.Long_quests_cleared_label = new System.Windows.Forms.Label();
            this.Inherited_quests_cleared_label = new System.Windows.Forms.Label();
            this.Keys_used_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Bosses_conquered_label = new System.Windows.Forms.Label();
            this.Stages_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Bosses_conquered_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Stages_cleared_label = new System.Windows.Forms.Label();
            this.Short_quests_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Keys_used_label = new System.Windows.Forms.Label();
            this.Inherited_quests_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Medium_quests_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Long_quests_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Total_quests_cleared_textBox = new System.Windows.Forms.TextBox();
            this.Music_stages_groupBox = new System.Windows.Forms.GroupBox();
            this.Total_songs_cleared_label = new System.Windows.Forms.Label();
            this.Basic_scores_cleared_label = new System.Windows.Forms.Label();
            this.Expert_scores_cleared_label = new System.Windows.Forms.Label();
            this.Ultimate_scores_cleared_label = new System.Windows.Forms.Label();
            this.Perfect_chains_achieved_label = new System.Windows.Forms.Label();
            this.Daily_specials_cleared_label = new System.Windows.Forms.Label();
            this.Crowns_received_label = new System.Windows.Forms.Label();
            this.Total_songs_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Basic_scores_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Expert_scores_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Ultimate_scores_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Perfect_chains_achieved_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Daily_specials_cleared_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Crowns_received_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SSS_ranks_received_label = new System.Windows.Forms.Label();
            this.SSS_ranks_received_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Total_counts_groupBox = new System.Windows.Forms.GroupBox();
            this.Total_playtime_label = new System.Windows.Forms.Label();
            this.Total_playtime_seconds_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Total_playtime_hours_label = new System.Windows.Forms.Label();
            this.Total_playtime_minutes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Total_playtime_minutes_label = new System.Windows.Forms.Label();
            this.Total_playtime_hours_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Total_playtime_seconds_label = new System.Windows.Forms.Label();
            this.Songs_played_label = new System.Windows.Forms.Label();
            this.Enemies_defeated_label = new System.Windows.Forms.Label();
            this.Distance_traveled_label = new System.Windows.Forms.Label();
            this.Chained_triggers_label = new System.Windows.Forms.Label();
            this.Critical_triggers_label = new System.Windows.Forms.Label();
            this.ProfiCards_received_label = new System.Windows.Forms.Label();
            this.StreetPasses_label = new System.Windows.Forms.Label();
            this.Songs_played_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Enemies_defeated_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Distance_traveled_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Chained_triggers_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Critical_triggers_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProfiCards_received_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StreetPasses_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Characters_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Max_all_characters_stats_button = new System.Windows.Forms.Button();
            this.Max_character_stats_button = new System.Windows.Forms.Button();
            this.CharEditor_totalCPlabel = new System.Windows.Forms.Label();
            this.CharEditor_levelResets_label = new System.Windows.Forms.Label();
            this.CharEditor_exp_textBox = new System.Windows.Forms.TextBox();
            this.CharEditor_level_textBox = new System.Windows.Forms.TextBox();
            this.CharEditor_spirit_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_totalCP_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_levelResets_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_stamina_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_luck_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_hp_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_agility_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_magic_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_strength_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEditor_character_comboBox = new System.Windows.Forms.ComboBox();
            this.CharEditor_spirit_label = new System.Windows.Forms.Label();
            this.CharEditor_stamina_label = new System.Windows.Forms.Label();
            this.CharEditor_luck_label = new System.Windows.Forms.Label();
            this.CharEditor_hp_label = new System.Windows.Forms.Label();
            this.CharEditor_agility_label = new System.Windows.Forms.Label();
            this.CharEditor_magic_label = new System.Windows.Forms.Label();
            this.CharEditor_strength_label = new System.Windows.Forms.Label();
            this.CharEditor_exp_label = new System.Windows.Forms.Label();
            this.CharEditor_character_label = new System.Windows.Forms.Label();
            this.CharEditor_level_label = new System.Windows.Forms.Label();
            this.Member3_groupBox = new System.Windows.Forms.GroupBox();
            this.Party4_ability4_textBox = new System.Windows.Forms.TextBox();
            this.Party4_ability1_label = new System.Windows.Forms.Label();
            this.Party4_ability2_label = new System.Windows.Forms.Label();
            this.Party4_ability1_textBox = new System.Windows.Forms.TextBox();
            this.Party4_ability2_textBox = new System.Windows.Forms.TextBox();
            this.Party4_ability3_textBox = new System.Windows.Forms.TextBox();
            this.Party4_ability4_label = new System.Windows.Forms.Label();
            this.Party4_ability3_label = new System.Windows.Forms.Label();
            this.Party4_character_comboBox = new System.Windows.Forms.ComboBox();
            this.Member2_groupBox = new System.Windows.Forms.GroupBox();
            this.Party3_ability4_textBox = new System.Windows.Forms.TextBox();
            this.Party3_ability2_label = new System.Windows.Forms.Label();
            this.Party3_ability2_textBox = new System.Windows.Forms.TextBox();
            this.Party3_ability4_label = new System.Windows.Forms.Label();
            this.Party3_character_comboBox = new System.Windows.Forms.ComboBox();
            this.Party3_ability3_label = new System.Windows.Forms.Label();
            this.Party3_ability3_textBox = new System.Windows.Forms.TextBox();
            this.Party3_ability1_textBox = new System.Windows.Forms.TextBox();
            this.Party3_ability1_label = new System.Windows.Forms.Label();
            this.Member1_groupBox = new System.Windows.Forms.GroupBox();
            this.Party2_ability4_textBox = new System.Windows.Forms.TextBox();
            this.Party2_ability2_textBox = new System.Windows.Forms.TextBox();
            this.Party2_character_comboBox = new System.Windows.Forms.ComboBox();
            this.Party2_ability3_textBox = new System.Windows.Forms.TextBox();
            this.Party2_ability1_label = new System.Windows.Forms.Label();
            this.Party2_ability1_textBox = new System.Windows.Forms.TextBox();
            this.Party2_ability3_label = new System.Windows.Forms.Label();
            this.Party2_ability4_label = new System.Windows.Forms.Label();
            this.Party2_ability2_label = new System.Windows.Forms.Label();
            this.Leader_groupBox = new System.Windows.Forms.GroupBox();
            this.Party1_ability4_textBox = new System.Windows.Forms.TextBox();
            this.Party1_ability2_textBox = new System.Windows.Forms.TextBox();
            this.Party1_ability3_textBox = new System.Windows.Forms.TextBox();
            this.Party1_ability1_textBox = new System.Windows.Forms.TextBox();
            this.Party1_ability4_label = new System.Windows.Forms.Label();
            this.Party1_ability2_label = new System.Windows.Forms.Label();
            this.Party1_ability3_label = new System.Windows.Forms.Label();
            this.Party1_ability1_label = new System.Windows.Forms.Label();
            this.Party1_character_comboBox = new System.Windows.Forms.ComboBox();
            this.Items_tabPage = new System.Windows.Forms.TabPage();
            this.Item_quest_med_groupBox = new System.Windows.Forms.GroupBox();
            this.Item_quest_med_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Item_equip_groupBox = new System.Windows.Forms.GroupBox();
            this.Item_equip_richTextBox = new System.Windows.Forms.RichTextBox();
            this.max_items_button = new System.Windows.Forms.Button();
            this.Items_dataGridView = new System.Windows.Forms.DataGridView();
            this.CollectaCards_tabPage = new System.Windows.Forms.TabPage();
            this.max_all_cards_button = new System.Windows.Forms.Button();
            this.max_premium_cards_button = new System.Windows.Forms.Button();
            this.max_rare_cards_button = new System.Windows.Forms.Button();
            this.max_normal_cards_button = new System.Windows.Forms.Button();
            this.Cards_dataGridView = new System.Windows.Forms.DataGridView();
            this.Songs_tabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_files_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_files_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_files_as_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.card_normal_description_groupBox = new System.Windows.Forms.GroupBox();
            this.card_rare_description_groupBox = new System.Windows.Forms.GroupBox();
            this.card_premium_description_groupBox = new System.Windows.Forms.GroupBox();
            this.card_normal_description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.card_rare_description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.card_premium_description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Highest_rank_pictureBox = new System.Windows.Forms.PictureBox();
            this.Song_icon_ultimatenex_pictureBox = new System.Windows.Forms.PictureBox();
            this.Song_icon_ultimate_pictureBox = new System.Windows.Forms.PictureBox();
            this.Song_icon_expert_pictureBox = new System.Windows.Forms.PictureBox();
            this.Song_icon_basic_pictureBox = new System.Windows.Forms.PictureBox();
            this.Progress_star5_pictureBox = new System.Windows.Forms.PictureBox();
            this.Progress_star4_pictureBox = new System.Windows.Forms.PictureBox();
            this.Progress_star3_pictureBox = new System.Windows.Forms.PictureBox();
            this.Progress_star1_pictureBox = new System.Windows.Forms.PictureBox();
            this.Progress_star2_pictureBox = new System.Windows.Forms.PictureBox();
            this.Crowns_pictureBox = new System.Windows.Forms.PictureBox();
            this.CharEditor_levelResets_picturebox = new System.Windows.Forms.PictureBox();
            this.CharEditor_character_pictureBox = new System.Windows.Forms.PictureBox();
            this.Party4_character_pictureBox = new System.Windows.Forms.PictureBox();
            this.Party3_character_pictureBox = new System.Windows.Forms.PictureBox();
            this.Party2_character_pictureBox = new System.Windows.Forms.PictureBox();
            this.Party1_character_pictureBox = new System.Windows.Forms.PictureBox();
            this.card_back_pictureBox = new System.Windows.Forms.PictureBox();
            this.card_rare_pictureBox = new System.Windows.Forms.PictureBox();
            this.card_premium_pictureBox = new System.Windows.Forms.PictureBox();
            this.card_normal_pictureBox = new System.Windows.Forms.PictureBox();
            this.Card_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card_normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card_rare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card_premium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Item = new System.Windows.Forms.DataGridViewImageColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profile_groupBox = new System.Windows.Forms.GroupBox();
            Profile_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rhythmia_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Songs_dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Records_tabPage.SuspendLayout();
            this.Battle_party_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Critical_boosts_achieved_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parameter_boosts_performed_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_used_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Treasure_chests_earned_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Collectacards_obtained_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fat_chocobo_encounters_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abilities_triggered_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Levels_reset_numericUpDown)).BeginInit();
            this.Versus_mode_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_ties_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_ties_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_losses_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_losses_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_wins_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_wins_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_score_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_score_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_battle_victories_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_ultimatenex_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_ultimatenex_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_ultimate_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EX_bursts_used_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_expert_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_ultimate_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_basic_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_expert_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_basic_numericUpDown)).BeginInit();
            this.Quest_medleys_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Keys_used_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stages_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bosses_conquered_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Short_quests_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inherited_quests_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium_quests_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Long_quests_cleared_numericUpDown)).BeginInit();
            this.Music_stages_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_songs_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basic_scores_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expert_scores_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate_scores_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfect_chains_achieved_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily_specials_cleared_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crowns_received_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSS_ranks_received_numericUpDown)).BeginInit();
            this.Total_counts_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_seconds_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_minutes_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_hours_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Songs_played_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemies_defeated_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance_traveled_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chained_triggers_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Critical_triggers_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfiCards_received_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetPasses_numericUpDown)).BeginInit();
            this.Characters_tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_spirit_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_totalCP_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_levelResets_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_stamina_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_luck_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_hp_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_agility_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_magic_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_strength_numericUpDown)).BeginInit();
            this.Member3_groupBox.SuspendLayout();
            this.Member2_groupBox.SuspendLayout();
            this.Member1_groupBox.SuspendLayout();
            this.Leader_groupBox.SuspendLayout();
            this.Items_tabPage.SuspendLayout();
            this.Item_quest_med_groupBox.SuspendLayout();
            this.Item_equip_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_dataGridView)).BeginInit();
            this.CollectaCards_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cards_dataGridView)).BeginInit();
            this.Songs_tabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.card_normal_description_groupBox.SuspendLayout();
            this.card_rare_description_groupBox.SuspendLayout();
            this.card_premium_description_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Highest_rank_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_ultimatenex_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_ultimate_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_expert_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_basic_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star5_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star4_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star3_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crowns_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_levelResets_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party4_character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party3_character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party2_character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party1_character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_back_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_rare_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_premium_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_normal_pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile_groupBox
            // 
            Profile_groupBox.Controls.Add(this.Progress_star5_pictureBox);
            Profile_groupBox.Controls.Add(this.Progress_star4_pictureBox);
            Profile_groupBox.Controls.Add(this.Progress_star3_pictureBox);
            Profile_groupBox.Controls.Add(this.Progress_star1_pictureBox);
            Profile_groupBox.Controls.Add(this.Progress_star2_pictureBox);
            Profile_groupBox.Controls.Add(this.label12);
            Profile_groupBox.Controls.Add(this.Progress_label);
            Profile_groupBox.Controls.Add(this.Player_name_label);
            Profile_groupBox.Controls.Add(this.Rhythmia_label);
            Profile_groupBox.Controls.Add(this.Player_name_textBox);
            Profile_groupBox.Controls.Add(this.Rhythmia_numericUpDown);
            Profile_groupBox.Controls.Add(this.Trophies_textBox);
            Profile_groupBox.Location = new System.Drawing.Point(4, 4);
            Profile_groupBox.Name = "Profile_groupBox";
            Profile_groupBox.Size = new System.Drawing.Size(225, 188);
            Profile_groupBox.TabIndex = 2;
            Profile_groupBox.TabStop = false;
            Profile_groupBox.Text = "Profile";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trophies:";
            // 
            // Progress_label
            // 
            this.Progress_label.AutoSize = true;
            this.Progress_label.Location = new System.Drawing.Point(4, 100);
            this.Progress_label.Name = "Progress_label";
            this.Progress_label.Size = new System.Drawing.Size(51, 13);
            this.Progress_label.TabIndex = 0;
            this.Progress_label.Text = "Progress:";
            // 
            // Player_name_label
            // 
            this.Player_name_label.AutoSize = true;
            this.Player_name_label.Location = new System.Drawing.Point(4, 16);
            this.Player_name_label.Name = "Player_name_label";
            this.Player_name_label.Size = new System.Drawing.Size(70, 13);
            this.Player_name_label.TabIndex = 0;
            this.Player_name_label.Text = "Player Name:";
            // 
            // Rhythmia_label
            // 
            this.Rhythmia_label.AutoSize = true;
            this.Rhythmia_label.Location = new System.Drawing.Point(4, 42);
            this.Rhythmia_label.Name = "Rhythmia_label";
            this.Rhythmia_label.Size = new System.Drawing.Size(54, 13);
            this.Rhythmia_label.TabIndex = 0;
            this.Rhythmia_label.Text = "Rhythmia:";
            // 
            // Player_name_textBox
            // 
            this.Player_name_textBox.Location = new System.Drawing.Point(138, 13);
            this.Player_name_textBox.MaxLength = 6;
            this.Player_name_textBox.Name = "Player_name_textBox";
            this.Player_name_textBox.ReadOnly = true;
            this.Player_name_textBox.Size = new System.Drawing.Size(83, 20);
            this.Player_name_textBox.TabIndex = 2;
            // 
            // Rhythmia_numericUpDown
            // 
            this.Rhythmia_numericUpDown.Location = new System.Drawing.Point(138, 39);
            this.Rhythmia_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Rhythmia_numericUpDown.Name = "Rhythmia_numericUpDown";
            this.Rhythmia_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Rhythmia_numericUpDown.TabIndex = 3;
            this.Rhythmia_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Trophies_textBox
            // 
            this.Trophies_textBox.Location = new System.Drawing.Point(138, 67);
            this.Trophies_textBox.MaxLength = 6;
            this.Trophies_textBox.Name = "Trophies_textBox";
            this.Trophies_textBox.ReadOnly = true;
            this.Trophies_textBox.Size = new System.Drawing.Size(83, 20);
            this.Trophies_textBox.TabIndex = 4;
            // 
            // Songs_dataGridView
            // 
            this.Songs_dataGridView.AllowUserToAddRows = false;
            this.Songs_dataGridView.AllowUserToDeleteRows = false;
            this.Songs_dataGridView.AllowUserToResizeRows = false;
            this.Songs_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Songs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Songs_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songs_Series,
            this.songs_Type,
            this.songs_Song_name,
            this.songs_Difficulty,
            this.songs_Score,
            this.songs_Chain,
            this.songs_Rank,
            this.songs_Status,
            this.songs_Play_style,
            this.songs_Times_played,
            this.songs_TImes_cleared,
            this.songs_Date});
            this.Songs_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Songs_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Songs_dataGridView.Location = new System.Drawing.Point(3, 21);
            this.Songs_dataGridView.Name = "Songs_dataGridView";
            this.Songs_dataGridView.RowHeadersVisible = false;
            this.Songs_dataGridView.Size = new System.Drawing.Size(818, 419);
            this.Songs_dataGridView.TabIndex = 2;
            // 
            // songs_Series
            // 
            this.songs_Series.HeaderText = "Series";
            this.songs_Series.Name = "songs_Series";
            this.songs_Series.ReadOnly = true;
            this.songs_Series.Width = 68;
            // 
            // songs_Type
            // 
            this.songs_Type.HeaderText = "Type";
            this.songs_Type.Name = "songs_Type";
            this.songs_Type.ReadOnly = true;
            this.songs_Type.Width = 68;
            // 
            // songs_Song_name
            // 
            this.songs_Song_name.HeaderText = "Song Name";
            this.songs_Song_name.Name = "songs_Song_name";
            this.songs_Song_name.ReadOnly = true;
            this.songs_Song_name.Width = 68;
            // 
            // songs_Difficulty
            // 
            this.songs_Difficulty.HeaderText = "Difficulty";
            this.songs_Difficulty.Name = "songs_Difficulty";
            this.songs_Difficulty.ReadOnly = true;
            this.songs_Difficulty.Width = 68;
            // 
            // songs_Score
            // 
            this.songs_Score.HeaderText = "Score";
            this.songs_Score.Name = "songs_Score";
            this.songs_Score.Width = 68;
            // 
            // songs_Chain
            // 
            this.songs_Chain.HeaderText = "Chain";
            this.songs_Chain.Name = "songs_Chain";
            this.songs_Chain.Width = 67;
            // 
            // songs_Rank
            // 
            this.songs_Rank.HeaderText = "Rank";
            this.songs_Rank.Name = "songs_Rank";
            this.songs_Rank.Width = 68;
            // 
            // songs_Status
            // 
            this.songs_Status.HeaderText = "Status";
            this.songs_Status.Name = "songs_Status";
            this.songs_Status.Width = 68;
            // 
            // songs_Play_style
            // 
            this.songs_Play_style.HeaderText = "Play Style";
            this.songs_Play_style.Name = "songs_Play_style";
            this.songs_Play_style.Width = 68;
            // 
            // songs_Times_played
            // 
            this.songs_Times_played.HeaderText = "Times Played";
            this.songs_Times_played.Name = "songs_Times_played";
            this.songs_Times_played.Width = 68;
            // 
            // songs_TImes_cleared
            // 
            this.songs_TImes_cleared.HeaderText = "Times Cleared";
            this.songs_TImes_cleared.Name = "songs_TImes_cleared";
            this.songs_TImes_cleared.Width = 68;
            // 
            // songs_Date
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.songs_Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.songs_Date.HeaderText = "Date";
            this.songs_Date.Name = "songs_Date";
            this.songs_Date.Width = 68;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Records_tabPage);
            this.tabControl1.Controls.Add(this.Characters_tabPage);
            this.tabControl1.Controls.Add(this.Items_tabPage);
            this.tabControl1.Controls.Add(this.CollectaCards_tabPage);
            this.tabControl1.Controls.Add(this.Songs_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 469);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // Records_tabPage
            // 
            this.Records_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Records_tabPage.Controls.Add(this.Battle_party_groupBox);
            this.Records_tabPage.Controls.Add(this.Versus_mode_groupBox);
            this.Records_tabPage.Controls.Add(Profile_groupBox);
            this.Records_tabPage.Controls.Add(this.Quest_medleys_groupBox);
            this.Records_tabPage.Controls.Add(this.Music_stages_groupBox);
            this.Records_tabPage.Controls.Add(this.Total_counts_groupBox);
            this.Records_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Records_tabPage.Name = "Records_tabPage";
            this.Records_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Records_tabPage.Size = new System.Drawing.Size(824, 443);
            this.Records_tabPage.TabIndex = 0;
            this.Records_tabPage.Text = "Records";
            // 
            // Battle_party_groupBox
            // 
            this.Battle_party_groupBox.Controls.Add(this.Levels_resets_label);
            this.Battle_party_groupBox.Controls.Add(this.Collectacards_obtained_label);
            this.Battle_party_groupBox.Controls.Add(this.Critical_boosts_achieved_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Parameter_boosts_performed_label);
            this.Battle_party_groupBox.Controls.Add(this.Parameter_boosts_performed_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Critical_boosts_achieved_label);
            this.Battle_party_groupBox.Controls.Add(this.Items_used_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Items_used_label);
            this.Battle_party_groupBox.Controls.Add(this.Treasure_chests_earned_label);
            this.Battle_party_groupBox.Controls.Add(this.Treasure_chests_earned_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Collectacards_obtained_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Abilities_triggered_label);
            this.Battle_party_groupBox.Controls.Add(this.Fat_chocobo_encounters_label);
            this.Battle_party_groupBox.Controls.Add(this.Fat_chocobo_encounters_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Abilities_triggered_numericUpDown);
            this.Battle_party_groupBox.Controls.Add(this.Levels_reset_numericUpDown);
            this.Battle_party_groupBox.Location = new System.Drawing.Point(463, 312);
            this.Battle_party_groupBox.Name = "Battle_party_groupBox";
            this.Battle_party_groupBox.Size = new System.Drawing.Size(361, 129);
            this.Battle_party_groupBox.TabIndex = 59;
            this.Battle_party_groupBox.TabStop = false;
            this.Battle_party_groupBox.Text = "Battle Party";
            // 
            // Levels_resets_label
            // 
            this.Levels_resets_label.AutoSize = true;
            this.Levels_resets_label.Location = new System.Drawing.Point(6, 16);
            this.Levels_resets_label.Name = "Levels_resets_label";
            this.Levels_resets_label.Size = new System.Drawing.Size(72, 13);
            this.Levels_resets_label.TabIndex = 0;
            this.Levels_resets_label.Text = "Levels Reset:";
            // 
            // Collectacards_obtained_label
            // 
            this.Collectacards_obtained_label.Location = new System.Drawing.Point(194, 10);
            this.Collectacards_obtained_label.Name = "Collectacards_obtained_label";
            this.Collectacards_obtained_label.Size = new System.Drawing.Size(75, 28);
            this.Collectacards_obtained_label.TabIndex = 0;
            this.Collectacards_obtained_label.Text = "CollectaCards Obtained:";
            this.Collectacards_obtained_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Critical_boosts_achieved_numericUpDown
            // 
            this.Critical_boosts_achieved_numericUpDown.Location = new System.Drawing.Point(275, 44);
            this.Critical_boosts_achieved_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Critical_boosts_achieved_numericUpDown.Name = "Critical_boosts_achieved_numericUpDown";
            this.Critical_boosts_achieved_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Critical_boosts_achieved_numericUpDown.TabIndex = 62;
            this.Critical_boosts_achieved_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Parameter_boosts_performed_label
            // 
            this.Parameter_boosts_performed_label.Location = new System.Drawing.Point(6, 40);
            this.Parameter_boosts_performed_label.Name = "Parameter_boosts_performed_label";
            this.Parameter_boosts_performed_label.Size = new System.Drawing.Size(93, 26);
            this.Parameter_boosts_performed_label.TabIndex = 0;
            this.Parameter_boosts_performed_label.Text = "Parameter Boosts Performed:";
            this.Parameter_boosts_performed_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Parameter_boosts_performed_numericUpDown
            // 
            this.Parameter_boosts_performed_numericUpDown.Location = new System.Drawing.Point(105, 44);
            this.Parameter_boosts_performed_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Parameter_boosts_performed_numericUpDown.Name = "Parameter_boosts_performed_numericUpDown";
            this.Parameter_boosts_performed_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Parameter_boosts_performed_numericUpDown.TabIndex = 61;
            this.Parameter_boosts_performed_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Critical_boosts_achieved_label
            // 
            this.Critical_boosts_achieved_label.Location = new System.Drawing.Point(194, 40);
            this.Critical_boosts_achieved_label.Name = "Critical_boosts_achieved_label";
            this.Critical_boosts_achieved_label.Size = new System.Drawing.Size(75, 26);
            this.Critical_boosts_achieved_label.TabIndex = 0;
            this.Critical_boosts_achieved_label.Text = "Critical Boosts Achieved:";
            this.Critical_boosts_achieved_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Items_used_numericUpDown
            // 
            this.Items_used_numericUpDown.Location = new System.Drawing.Point(105, 74);
            this.Items_used_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Items_used_numericUpDown.Name = "Items_used_numericUpDown";
            this.Items_used_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Items_used_numericUpDown.TabIndex = 63;
            this.Items_used_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Items_used_label
            // 
            this.Items_used_label.AutoSize = true;
            this.Items_used_label.Location = new System.Drawing.Point(6, 76);
            this.Items_used_label.Name = "Items_used_label";
            this.Items_used_label.Size = new System.Drawing.Size(63, 13);
            this.Items_used_label.TabIndex = 0;
            this.Items_used_label.Text = "Items Used:";
            // 
            // Treasure_chests_earned_label
            // 
            this.Treasure_chests_earned_label.Location = new System.Drawing.Point(194, 100);
            this.Treasure_chests_earned_label.Name = "Treasure_chests_earned_label";
            this.Treasure_chests_earned_label.Size = new System.Drawing.Size(81, 27);
            this.Treasure_chests_earned_label.TabIndex = 0;
            this.Treasure_chests_earned_label.Text = "Treasure Chests Earned:";
            // 
            // Treasure_chests_earned_numericUpDown
            // 
            this.Treasure_chests_earned_numericUpDown.Location = new System.Drawing.Point(275, 104);
            this.Treasure_chests_earned_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Treasure_chests_earned_numericUpDown.Name = "Treasure_chests_earned_numericUpDown";
            this.Treasure_chests_earned_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Treasure_chests_earned_numericUpDown.TabIndex = 66;
            this.Treasure_chests_earned_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Collectacards_obtained_numericUpDown
            // 
            this.Collectacards_obtained_numericUpDown.Location = new System.Drawing.Point(275, 14);
            this.Collectacards_obtained_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Collectacards_obtained_numericUpDown.Name = "Collectacards_obtained_numericUpDown";
            this.Collectacards_obtained_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Collectacards_obtained_numericUpDown.TabIndex = 60;
            this.Collectacards_obtained_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Abilities_triggered_label
            // 
            this.Abilities_triggered_label.Location = new System.Drawing.Point(194, 70);
            this.Abilities_triggered_label.Name = "Abilities_triggered_label";
            this.Abilities_triggered_label.Size = new System.Drawing.Size(57, 28);
            this.Abilities_triggered_label.TabIndex = 0;
            this.Abilities_triggered_label.Text = "Abilities Triggered:";
            this.Abilities_triggered_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fat_chocobo_encounters_label
            // 
            this.Fat_chocobo_encounters_label.Location = new System.Drawing.Point(6, 100);
            this.Fat_chocobo_encounters_label.Name = "Fat_chocobo_encounters_label";
            this.Fat_chocobo_encounters_label.Size = new System.Drawing.Size(72, 28);
            this.Fat_chocobo_encounters_label.TabIndex = 0;
            this.Fat_chocobo_encounters_label.Text = "Fat Chocobo Encounters:";
            // 
            // Fat_chocobo_encounters_numericUpDown
            // 
            this.Fat_chocobo_encounters_numericUpDown.Location = new System.Drawing.Point(105, 104);
            this.Fat_chocobo_encounters_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Fat_chocobo_encounters_numericUpDown.Name = "Fat_chocobo_encounters_numericUpDown";
            this.Fat_chocobo_encounters_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Fat_chocobo_encounters_numericUpDown.TabIndex = 65;
            this.Fat_chocobo_encounters_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Abilities_triggered_numericUpDown
            // 
            this.Abilities_triggered_numericUpDown.Location = new System.Drawing.Point(275, 74);
            this.Abilities_triggered_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Abilities_triggered_numericUpDown.Name = "Abilities_triggered_numericUpDown";
            this.Abilities_triggered_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Abilities_triggered_numericUpDown.TabIndex = 64;
            this.Abilities_triggered_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Levels_reset_numericUpDown
            // 
            this.Levels_reset_numericUpDown.Location = new System.Drawing.Point(105, 14);
            this.Levels_reset_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Levels_reset_numericUpDown.Name = "Levels_reset_numericUpDown";
            this.Levels_reset_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Levels_reset_numericUpDown.TabIndex = 59;
            this.Levels_reset_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Versus_mode_groupBox
            // 
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_pictureBox);
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_class_comboBox);
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_comboBox);
            this.Versus_mode_groupBox.Controls.Add(this.Local_battle_rating_ties_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Song_icon_ultimatenex_pictureBox);
            this.Versus_mode_groupBox.Controls.Add(this.Online_battle_rating_ties_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Song_icon_ultimate_pictureBox);
            this.Versus_mode_groupBox.Controls.Add(this.Local_battle_rating_losses_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Song_icon_expert_pictureBox);
            this.Versus_mode_groupBox.Controls.Add(this.Online_battle_rating_losses_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Song_icon_basic_pictureBox);
            this.Versus_mode_groupBox.Controls.Add(this.Local_battle_rating_wins_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Online_battle_rating_wins_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Local_battle_rating_score_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Online_battle_rating_score_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.AI_battle_victories_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.EX_bursts_used_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_total_ultimatenex_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_ties_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_total_ultimate_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_losses_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_total_expert_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_wins_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Local_battle_rating_label);
            this.Versus_mode_groupBox.Controls.Add(this.Online_battle_rating_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_total_basic_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_score_textBox);
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_class_label);
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_hash_label);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_ties_label);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_losses_label);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_wins_label);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_score_label);
            this.Versus_mode_groupBox.Controls.Add(this.Total_rating_label);
            this.Versus_mode_groupBox.Controls.Add(this.Highest_rank_label);
            this.Versus_mode_groupBox.Controls.Add(this.AI_battle_victories_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_local_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_total_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_online_label);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_local_ultimatenex_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_online_ultimatenex_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_local_ultimate_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.EX_bursts_used_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_local_expert_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_online_ultimate_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_local_basic_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_online_expert_numericUpDown);
            this.Versus_mode_groupBox.Controls.Add(this.Scores_played_online_basic_numericUpDown);
            this.Versus_mode_groupBox.Location = new System.Drawing.Point(463, 4);
            this.Versus_mode_groupBox.Name = "Versus_mode_groupBox";
            this.Versus_mode_groupBox.Size = new System.Drawing.Size(361, 304);
            this.Versus_mode_groupBox.TabIndex = 31;
            this.Versus_mode_groupBox.TabStop = false;
            this.Versus_mode_groupBox.Text = "Versus Mode";
            // 
            // Highest_rank_class_comboBox
            // 
            this.Highest_rank_class_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Highest_rank_class_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Highest_rank_class_comboBox.FormattingEnabled = true;
            this.Highest_rank_class_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "--"});
            this.Highest_rank_class_comboBox.Location = new System.Drawing.Point(290, 136);
            this.Highest_rank_class_comboBox.Name = "Highest_rank_class_comboBox";
            this.Highest_rank_class_comboBox.Size = new System.Drawing.Size(68, 21);
            this.Highest_rank_class_comboBox.TabIndex = 45;
            this.Highest_rank_class_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_records);
            // 
            // Highest_rank_comboBox
            // 
            this.Highest_rank_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Highest_rank_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Highest_rank_comboBox.FormattingEnabled = true;
            this.Highest_rank_comboBox.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum"});
            this.Highest_rank_comboBox.Location = new System.Drawing.Point(156, 136);
            this.Highest_rank_comboBox.Name = "Highest_rank_comboBox";
            this.Highest_rank_comboBox.Size = new System.Drawing.Size(84, 21);
            this.Highest_rank_comboBox.TabIndex = 44;
            this.Highest_rank_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_records);
            // 
            // Local_battle_rating_ties_numericUpDown
            // 
            this.Local_battle_rating_ties_numericUpDown.Location = new System.Drawing.Point(305, 85);
            this.Local_battle_rating_ties_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Local_battle_rating_ties_numericUpDown.Name = "Local_battle_rating_ties_numericUpDown";
            this.Local_battle_rating_ties_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Local_battle_rating_ties_numericUpDown.TabIndex = 42;
            this.Local_battle_rating_ties_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Online_battle_rating_ties_numericUpDown
            // 
            this.Online_battle_rating_ties_numericUpDown.Location = new System.Drawing.Point(305, 61);
            this.Online_battle_rating_ties_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Online_battle_rating_ties_numericUpDown.Name = "Online_battle_rating_ties_numericUpDown";
            this.Online_battle_rating_ties_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Online_battle_rating_ties_numericUpDown.TabIndex = 38;
            this.Online_battle_rating_ties_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Local_battle_rating_losses_numericUpDown
            // 
            this.Local_battle_rating_losses_numericUpDown.Location = new System.Drawing.Point(246, 85);
            this.Local_battle_rating_losses_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Local_battle_rating_losses_numericUpDown.Name = "Local_battle_rating_losses_numericUpDown";
            this.Local_battle_rating_losses_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Local_battle_rating_losses_numericUpDown.TabIndex = 41;
            this.Local_battle_rating_losses_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Online_battle_rating_losses_numericUpDown
            // 
            this.Online_battle_rating_losses_numericUpDown.Location = new System.Drawing.Point(246, 61);
            this.Online_battle_rating_losses_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Online_battle_rating_losses_numericUpDown.Name = "Online_battle_rating_losses_numericUpDown";
            this.Online_battle_rating_losses_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Online_battle_rating_losses_numericUpDown.TabIndex = 37;
            this.Online_battle_rating_losses_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Local_battle_rating_wins_numericUpDown
            // 
            this.Local_battle_rating_wins_numericUpDown.Location = new System.Drawing.Point(187, 85);
            this.Local_battle_rating_wins_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Local_battle_rating_wins_numericUpDown.Name = "Local_battle_rating_wins_numericUpDown";
            this.Local_battle_rating_wins_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Local_battle_rating_wins_numericUpDown.TabIndex = 40;
            this.Local_battle_rating_wins_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Online_battle_rating_wins_numericUpDown
            // 
            this.Online_battle_rating_wins_numericUpDown.Location = new System.Drawing.Point(187, 61);
            this.Online_battle_rating_wins_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Online_battle_rating_wins_numericUpDown.Name = "Online_battle_rating_wins_numericUpDown";
            this.Online_battle_rating_wins_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Online_battle_rating_wins_numericUpDown.TabIndex = 36;
            this.Online_battle_rating_wins_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Local_battle_rating_score_numericUpDown
            // 
            this.Local_battle_rating_score_numericUpDown.Location = new System.Drawing.Point(128, 85);
            this.Local_battle_rating_score_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Local_battle_rating_score_numericUpDown.Name = "Local_battle_rating_score_numericUpDown";
            this.Local_battle_rating_score_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Local_battle_rating_score_numericUpDown.TabIndex = 39;
            this.Local_battle_rating_score_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Online_battle_rating_score_numericUpDown
            // 
            this.Online_battle_rating_score_numericUpDown.Location = new System.Drawing.Point(128, 61);
            this.Online_battle_rating_score_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Online_battle_rating_score_numericUpDown.Name = "Online_battle_rating_score_numericUpDown";
            this.Online_battle_rating_score_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Online_battle_rating_score_numericUpDown.TabIndex = 35;
            this.Online_battle_rating_score_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // AI_battle_victories_numericUpDown
            // 
            this.AI_battle_victories_numericUpDown.Location = new System.Drawing.Point(128, 111);
            this.AI_battle_victories_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.AI_battle_victories_numericUpDown.Name = "AI_battle_victories_numericUpDown";
            this.AI_battle_victories_numericUpDown.Size = new System.Drawing.Size(112, 20);
            this.AI_battle_victories_numericUpDown.TabIndex = 43;
            this.AI_battle_victories_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // EX_bursts_used_label
            // 
            this.EX_bursts_used_label.AutoSize = true;
            this.EX_bursts_used_label.Location = new System.Drawing.Point(6, 282);
            this.EX_bursts_used_label.Name = "EX_bursts_used_label";
            this.EX_bursts_used_label.Size = new System.Drawing.Size(84, 13);
            this.EX_bursts_used_label.TabIndex = 0;
            this.EX_bursts_used_label.Text = "EX Bursts Used:";
            // 
            // Scores_played_total_ultimatenex_textBox
            // 
            this.Scores_played_total_ultimatenex_textBox.Location = new System.Drawing.Point(305, 200);
            this.Scores_played_total_ultimatenex_textBox.MaxLength = 10;
            this.Scores_played_total_ultimatenex_textBox.Name = "Scores_played_total_ultimatenex_textBox";
            this.Scores_played_total_ultimatenex_textBox.ReadOnly = true;
            this.Scores_played_total_ultimatenex_textBox.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_total_ultimatenex_textBox.TabIndex = 49;
            // 
            // Total_rating_ties_textBox
            // 
            this.Total_rating_ties_textBox.Location = new System.Drawing.Point(305, 34);
            this.Total_rating_ties_textBox.MaxLength = 6;
            this.Total_rating_ties_textBox.Name = "Total_rating_ties_textBox";
            this.Total_rating_ties_textBox.ReadOnly = true;
            this.Total_rating_ties_textBox.Size = new System.Drawing.Size(53, 20);
            this.Total_rating_ties_textBox.TabIndex = 34;
            // 
            // Scores_played_total_ultimate_textBox
            // 
            this.Scores_played_total_ultimate_textBox.Location = new System.Drawing.Point(246, 200);
            this.Scores_played_total_ultimate_textBox.MaxLength = 10;
            this.Scores_played_total_ultimate_textBox.Name = "Scores_played_total_ultimate_textBox";
            this.Scores_played_total_ultimate_textBox.ReadOnly = true;
            this.Scores_played_total_ultimate_textBox.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_total_ultimate_textBox.TabIndex = 48;
            // 
            // Total_rating_losses_textBox
            // 
            this.Total_rating_losses_textBox.Location = new System.Drawing.Point(246, 34);
            this.Total_rating_losses_textBox.MaxLength = 6;
            this.Total_rating_losses_textBox.Name = "Total_rating_losses_textBox";
            this.Total_rating_losses_textBox.ReadOnly = true;
            this.Total_rating_losses_textBox.Size = new System.Drawing.Size(53, 20);
            this.Total_rating_losses_textBox.TabIndex = 33;
            // 
            // Scores_played_total_expert_textBox
            // 
            this.Scores_played_total_expert_textBox.Location = new System.Drawing.Point(187, 200);
            this.Scores_played_total_expert_textBox.MaxLength = 10;
            this.Scores_played_total_expert_textBox.Name = "Scores_played_total_expert_textBox";
            this.Scores_played_total_expert_textBox.ReadOnly = true;
            this.Scores_played_total_expert_textBox.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_total_expert_textBox.TabIndex = 47;
            // 
            // Total_rating_wins_textBox
            // 
            this.Total_rating_wins_textBox.Location = new System.Drawing.Point(187, 34);
            this.Total_rating_wins_textBox.MaxLength = 6;
            this.Total_rating_wins_textBox.Name = "Total_rating_wins_textBox";
            this.Total_rating_wins_textBox.ReadOnly = true;
            this.Total_rating_wins_textBox.Size = new System.Drawing.Size(53, 20);
            this.Total_rating_wins_textBox.TabIndex = 32;
            // 
            // Local_battle_rating_label
            // 
            this.Local_battle_rating_label.AutoSize = true;
            this.Local_battle_rating_label.Location = new System.Drawing.Point(6, 88);
            this.Local_battle_rating_label.Name = "Local_battle_rating_label";
            this.Local_battle_rating_label.Size = new System.Drawing.Size(100, 13);
            this.Local_battle_rating_label.TabIndex = 0;
            this.Local_battle_rating_label.Text = "Local Battle Rating:";
            // 
            // Online_battle_rating_label
            // 
            this.Online_battle_rating_label.AutoSize = true;
            this.Online_battle_rating_label.Location = new System.Drawing.Point(6, 63);
            this.Online_battle_rating_label.Name = "Online_battle_rating_label";
            this.Online_battle_rating_label.Size = new System.Drawing.Size(104, 13);
            this.Online_battle_rating_label.TabIndex = 0;
            this.Online_battle_rating_label.Text = "Online Battle Rating:";
            // 
            // Scores_played_total_basic_textBox
            // 
            this.Scores_played_total_basic_textBox.Location = new System.Drawing.Point(128, 200);
            this.Scores_played_total_basic_textBox.MaxLength = 10;
            this.Scores_played_total_basic_textBox.Name = "Scores_played_total_basic_textBox";
            this.Scores_played_total_basic_textBox.ReadOnly = true;
            this.Scores_played_total_basic_textBox.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_total_basic_textBox.TabIndex = 46;
            // 
            // Total_rating_score_textBox
            // 
            this.Total_rating_score_textBox.Location = new System.Drawing.Point(128, 34);
            this.Total_rating_score_textBox.MaxLength = 6;
            this.Total_rating_score_textBox.Name = "Total_rating_score_textBox";
            this.Total_rating_score_textBox.ReadOnly = true;
            this.Total_rating_score_textBox.Size = new System.Drawing.Size(53, 20);
            this.Total_rating_score_textBox.TabIndex = 31;
            // 
            // Highest_rank_class_label
            // 
            this.Highest_rank_class_label.AutoSize = true;
            this.Highest_rank_class_label.Location = new System.Drawing.Point(246, 140);
            this.Highest_rank_class_label.Name = "Highest_rank_class_label";
            this.Highest_rank_class_label.Size = new System.Drawing.Size(32, 13);
            this.Highest_rank_class_label.TabIndex = 0;
            this.Highest_rank_class_label.Text = "Class";
            // 
            // Highest_rank_hash_label
            // 
            this.Highest_rank_hash_label.AutoSize = true;
            this.Highest_rank_hash_label.Location = new System.Drawing.Point(277, 140);
            this.Highest_rank_hash_label.Name = "Highest_rank_hash_label";
            this.Highest_rank_hash_label.Size = new System.Drawing.Size(14, 13);
            this.Highest_rank_hash_label.TabIndex = 0;
            this.Highest_rank_hash_label.Text = "#";
            // 
            // Total_rating_ties_label
            // 
            this.Total_rating_ties_label.AutoSize = true;
            this.Total_rating_ties_label.Location = new System.Drawing.Point(317, 16);
            this.Total_rating_ties_label.Name = "Total_rating_ties_label";
            this.Total_rating_ties_label.Size = new System.Drawing.Size(27, 13);
            this.Total_rating_ties_label.TabIndex = 0;
            this.Total_rating_ties_label.Text = "Ties";
            // 
            // Total_rating_losses_label
            // 
            this.Total_rating_losses_label.AutoSize = true;
            this.Total_rating_losses_label.Location = new System.Drawing.Point(252, 16);
            this.Total_rating_losses_label.Name = "Total_rating_losses_label";
            this.Total_rating_losses_label.Size = new System.Drawing.Size(40, 13);
            this.Total_rating_losses_label.TabIndex = 0;
            this.Total_rating_losses_label.Text = "Losses";
            // 
            // Total_rating_wins_label
            // 
            this.Total_rating_wins_label.AutoSize = true;
            this.Total_rating_wins_label.Location = new System.Drawing.Point(198, 16);
            this.Total_rating_wins_label.Name = "Total_rating_wins_label";
            this.Total_rating_wins_label.Size = new System.Drawing.Size(31, 13);
            this.Total_rating_wins_label.TabIndex = 0;
            this.Total_rating_wins_label.Text = "Wins";
            // 
            // Total_rating_score_label
            // 
            this.Total_rating_score_label.AutoSize = true;
            this.Total_rating_score_label.Location = new System.Drawing.Point(137, 16);
            this.Total_rating_score_label.Name = "Total_rating_score_label";
            this.Total_rating_score_label.Size = new System.Drawing.Size(35, 13);
            this.Total_rating_score_label.TabIndex = 0;
            this.Total_rating_score_label.Text = "Score";
            // 
            // Total_rating_label
            // 
            this.Total_rating_label.AutoSize = true;
            this.Total_rating_label.Location = new System.Drawing.Point(6, 37);
            this.Total_rating_label.Name = "Total_rating_label";
            this.Total_rating_label.Size = new System.Drawing.Size(68, 13);
            this.Total_rating_label.TabIndex = 0;
            this.Total_rating_label.Text = "Total Rating:";
            // 
            // Highest_rank_label
            // 
            this.Highest_rank_label.AutoSize = true;
            this.Highest_rank_label.Location = new System.Drawing.Point(6, 140);
            this.Highest_rank_label.Name = "Highest_rank_label";
            this.Highest_rank_label.Size = new System.Drawing.Size(75, 13);
            this.Highest_rank_label.TabIndex = 0;
            this.Highest_rank_label.Text = "Highest Rank:";
            // 
            // AI_battle_victories_label
            // 
            this.AI_battle_victories_label.AutoSize = true;
            this.AI_battle_victories_label.Location = new System.Drawing.Point(6, 114);
            this.AI_battle_victories_label.Name = "AI_battle_victories_label";
            this.AI_battle_victories_label.Size = new System.Drawing.Size(93, 13);
            this.AI_battle_victories_label.TabIndex = 0;
            this.AI_battle_victories_label.Text = "AI Battle Victories:";
            // 
            // Scores_played_local_label
            // 
            this.Scores_played_local_label.AutoSize = true;
            this.Scores_played_local_label.Location = new System.Drawing.Point(6, 254);
            this.Scores_played_local_label.Name = "Scores_played_local_label";
            this.Scores_played_local_label.Size = new System.Drawing.Size(113, 13);
            this.Scores_played_local_label.TabIndex = 0;
            this.Scores_played_local_label.Text = "Scores Played (Local):";
            this.Scores_played_local_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scores_played_total_label
            // 
            this.Scores_played_total_label.AutoSize = true;
            this.Scores_played_total_label.Location = new System.Drawing.Point(6, 202);
            this.Scores_played_total_label.Name = "Scores_played_total_label";
            this.Scores_played_total_label.Size = new System.Drawing.Size(111, 13);
            this.Scores_played_total_label.TabIndex = 0;
            this.Scores_played_total_label.Text = "Scores Played (Total):";
            this.Scores_played_total_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scores_played_online_label
            // 
            this.Scores_played_online_label.AutoSize = true;
            this.Scores_played_online_label.Location = new System.Drawing.Point(6, 228);
            this.Scores_played_online_label.Name = "Scores_played_online_label";
            this.Scores_played_online_label.Size = new System.Drawing.Size(117, 13);
            this.Scores_played_online_label.TabIndex = 0;
            this.Scores_played_online_label.Text = "Scores Played (Online):";
            this.Scores_played_online_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scores_played_local_ultimatenex_numericUpDown
            // 
            this.Scores_played_local_ultimatenex_numericUpDown.Location = new System.Drawing.Point(305, 252);
            this.Scores_played_local_ultimatenex_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_local_ultimatenex_numericUpDown.Name = "Scores_played_local_ultimatenex_numericUpDown";
            this.Scores_played_local_ultimatenex_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_local_ultimatenex_numericUpDown.TabIndex = 57;
            this.Scores_played_local_ultimatenex_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_online_ultimatenex_numericUpDown
            // 
            this.Scores_played_online_ultimatenex_numericUpDown.Location = new System.Drawing.Point(305, 226);
            this.Scores_played_online_ultimatenex_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_online_ultimatenex_numericUpDown.Name = "Scores_played_online_ultimatenex_numericUpDown";
            this.Scores_played_online_ultimatenex_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_online_ultimatenex_numericUpDown.TabIndex = 53;
            this.Scores_played_online_ultimatenex_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_local_ultimate_numericUpDown
            // 
            this.Scores_played_local_ultimate_numericUpDown.Location = new System.Drawing.Point(246, 252);
            this.Scores_played_local_ultimate_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_local_ultimate_numericUpDown.Name = "Scores_played_local_ultimate_numericUpDown";
            this.Scores_played_local_ultimate_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_local_ultimate_numericUpDown.TabIndex = 56;
            this.Scores_played_local_ultimate_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // EX_bursts_used_numericUpDown
            // 
            this.EX_bursts_used_numericUpDown.Location = new System.Drawing.Point(128, 279);
            this.EX_bursts_used_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.EX_bursts_used_numericUpDown.Name = "EX_bursts_used_numericUpDown";
            this.EX_bursts_used_numericUpDown.Size = new System.Drawing.Size(112, 20);
            this.EX_bursts_used_numericUpDown.TabIndex = 58;
            this.EX_bursts_used_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_local_expert_numericUpDown
            // 
            this.Scores_played_local_expert_numericUpDown.Location = new System.Drawing.Point(187, 252);
            this.Scores_played_local_expert_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_local_expert_numericUpDown.Name = "Scores_played_local_expert_numericUpDown";
            this.Scores_played_local_expert_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_local_expert_numericUpDown.TabIndex = 55;
            this.Scores_played_local_expert_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_online_ultimate_numericUpDown
            // 
            this.Scores_played_online_ultimate_numericUpDown.Location = new System.Drawing.Point(246, 226);
            this.Scores_played_online_ultimate_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_online_ultimate_numericUpDown.Name = "Scores_played_online_ultimate_numericUpDown";
            this.Scores_played_online_ultimate_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_online_ultimate_numericUpDown.TabIndex = 52;
            this.Scores_played_online_ultimate_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_local_basic_numericUpDown
            // 
            this.Scores_played_local_basic_numericUpDown.Location = new System.Drawing.Point(128, 252);
            this.Scores_played_local_basic_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_local_basic_numericUpDown.Name = "Scores_played_local_basic_numericUpDown";
            this.Scores_played_local_basic_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.Scores_played_local_basic_numericUpDown.TabIndex = 54;
            this.Scores_played_local_basic_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_online_expert_numericUpDown
            // 
            this.Scores_played_online_expert_numericUpDown.Location = new System.Drawing.Point(187, 226);
            this.Scores_played_online_expert_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_online_expert_numericUpDown.Name = "Scores_played_online_expert_numericUpDown";
            this.Scores_played_online_expert_numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.Scores_played_online_expert_numericUpDown.TabIndex = 51;
            this.Scores_played_online_expert_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Scores_played_online_basic_numericUpDown
            // 
            this.Scores_played_online_basic_numericUpDown.Location = new System.Drawing.Point(128, 226);
            this.Scores_played_online_basic_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Scores_played_online_basic_numericUpDown.Name = "Scores_played_online_basic_numericUpDown";
            this.Scores_played_online_basic_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.Scores_played_online_basic_numericUpDown.TabIndex = 50;
            this.Scores_played_online_basic_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Quest_medleys_groupBox
            // 
            this.Quest_medleys_groupBox.Controls.Add(this.Total_quests_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Short_quests_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Medium_quests_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Long_quests_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Inherited_quests_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Keys_used_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Bosses_conquered_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Stages_cleared_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Bosses_conquered_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Stages_cleared_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Short_quests_cleared_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Keys_used_label);
            this.Quest_medleys_groupBox.Controls.Add(this.Inherited_quests_cleared_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Medium_quests_cleared_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Long_quests_cleared_numericUpDown);
            this.Quest_medleys_groupBox.Controls.Add(this.Total_quests_cleared_textBox);
            this.Quest_medleys_groupBox.Location = new System.Drawing.Point(235, 224);
            this.Quest_medleys_groupBox.Name = "Quest_medleys_groupBox";
            this.Quest_medleys_groupBox.Size = new System.Drawing.Size(222, 217);
            this.Quest_medleys_groupBox.TabIndex = 23;
            this.Quest_medleys_groupBox.TabStop = false;
            this.Quest_medleys_groupBox.Text = "Quest Medleys";
            // 
            // Total_quests_cleared_label
            // 
            this.Total_quests_cleared_label.AutoSize = true;
            this.Total_quests_cleared_label.Location = new System.Drawing.Point(6, 16);
            this.Total_quests_cleared_label.Name = "Total_quests_cleared_label";
            this.Total_quests_cleared_label.Size = new System.Drawing.Size(109, 13);
            this.Total_quests_cleared_label.TabIndex = 0;
            this.Total_quests_cleared_label.Text = "Total Quests Cleared:";
            // 
            // Short_quests_cleared_label
            // 
            this.Short_quests_cleared_label.AutoSize = true;
            this.Short_quests_cleared_label.Location = new System.Drawing.Point(6, 42);
            this.Short_quests_cleared_label.Name = "Short_quests_cleared_label";
            this.Short_quests_cleared_label.Size = new System.Drawing.Size(110, 13);
            this.Short_quests_cleared_label.TabIndex = 0;
            this.Short_quests_cleared_label.Text = "Short Quests Cleared:";
            // 
            // Medium_quests_cleared_label
            // 
            this.Medium_quests_cleared_label.AutoSize = true;
            this.Medium_quests_cleared_label.Location = new System.Drawing.Point(6, 67);
            this.Medium_quests_cleared_label.Name = "Medium_quests_cleared_label";
            this.Medium_quests_cleared_label.Size = new System.Drawing.Size(122, 13);
            this.Medium_quests_cleared_label.TabIndex = 0;
            this.Medium_quests_cleared_label.Text = "Medium Quests Cleared:";
            // 
            // Long_quests_cleared_label
            // 
            this.Long_quests_cleared_label.AutoSize = true;
            this.Long_quests_cleared_label.Location = new System.Drawing.Point(6, 93);
            this.Long_quests_cleared_label.Name = "Long_quests_cleared_label";
            this.Long_quests_cleared_label.Size = new System.Drawing.Size(109, 13);
            this.Long_quests_cleared_label.TabIndex = 0;
            this.Long_quests_cleared_label.Text = "Long Quests Cleared:";
            // 
            // Inherited_quests_cleared_label
            // 
            this.Inherited_quests_cleared_label.AutoSize = true;
            this.Inherited_quests_cleared_label.Location = new System.Drawing.Point(6, 119);
            this.Inherited_quests_cleared_label.Name = "Inherited_quests_cleared_label";
            this.Inherited_quests_cleared_label.Size = new System.Drawing.Size(126, 13);
            this.Inherited_quests_cleared_label.TabIndex = 0;
            this.Inherited_quests_cleared_label.Text = "Inherited Quests Cleared:";
            // 
            // Keys_used_numericUpDown
            // 
            this.Keys_used_numericUpDown.Location = new System.Drawing.Point(136, 194);
            this.Keys_used_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Keys_used_numericUpDown.Name = "Keys_used_numericUpDown";
            this.Keys_used_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Keys_used_numericUpDown.TabIndex = 30;
            this.Keys_used_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Bosses_conquered_label
            // 
            this.Bosses_conquered_label.AutoSize = true;
            this.Bosses_conquered_label.Location = new System.Drawing.Point(6, 145);
            this.Bosses_conquered_label.Name = "Bosses_conquered_label";
            this.Bosses_conquered_label.Size = new System.Drawing.Size(99, 13);
            this.Bosses_conquered_label.TabIndex = 0;
            this.Bosses_conquered_label.Text = "Bosses Conquered:";
            // 
            // Stages_cleared_numericUpDown
            // 
            this.Stages_cleared_numericUpDown.Location = new System.Drawing.Point(136, 168);
            this.Stages_cleared_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Stages_cleared_numericUpDown.Name = "Stages_cleared_numericUpDown";
            this.Stages_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Stages_cleared_numericUpDown.TabIndex = 29;
            this.Stages_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Bosses_conquered_numericUpDown
            // 
            this.Bosses_conquered_numericUpDown.Location = new System.Drawing.Point(136, 142);
            this.Bosses_conquered_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Bosses_conquered_numericUpDown.Name = "Bosses_conquered_numericUpDown";
            this.Bosses_conquered_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Bosses_conquered_numericUpDown.TabIndex = 28;
            this.Bosses_conquered_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Stages_cleared_label
            // 
            this.Stages_cleared_label.AutoSize = true;
            this.Stages_cleared_label.Location = new System.Drawing.Point(6, 170);
            this.Stages_cleared_label.Name = "Stages_cleared_label";
            this.Stages_cleared_label.Size = new System.Drawing.Size(82, 13);
            this.Stages_cleared_label.TabIndex = 0;
            this.Stages_cleared_label.Text = "Stages Cleared:";
            // 
            // Short_quests_cleared_numericUpDown
            // 
            this.Short_quests_cleared_numericUpDown.Location = new System.Drawing.Point(136, 39);
            this.Short_quests_cleared_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Short_quests_cleared_numericUpDown.Name = "Short_quests_cleared_numericUpDown";
            this.Short_quests_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Short_quests_cleared_numericUpDown.TabIndex = 24;
            this.Short_quests_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Keys_used_label
            // 
            this.Keys_used_label.AutoSize = true;
            this.Keys_used_label.Location = new System.Drawing.Point(6, 195);
            this.Keys_used_label.Name = "Keys_used_label";
            this.Keys_used_label.Size = new System.Drawing.Size(61, 13);
            this.Keys_used_label.TabIndex = 0;
            this.Keys_used_label.Text = "Keys Used:";
            // 
            // Inherited_quests_cleared_numericUpDown
            // 
            this.Inherited_quests_cleared_numericUpDown.Location = new System.Drawing.Point(136, 117);
            this.Inherited_quests_cleared_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Inherited_quests_cleared_numericUpDown.Name = "Inherited_quests_cleared_numericUpDown";
            this.Inherited_quests_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Inherited_quests_cleared_numericUpDown.TabIndex = 27;
            this.Inherited_quests_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Medium_quests_cleared_numericUpDown
            // 
            this.Medium_quests_cleared_numericUpDown.Location = new System.Drawing.Point(136, 64);
            this.Medium_quests_cleared_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Medium_quests_cleared_numericUpDown.Name = "Medium_quests_cleared_numericUpDown";
            this.Medium_quests_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Medium_quests_cleared_numericUpDown.TabIndex = 25;
            this.Medium_quests_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Long_quests_cleared_numericUpDown
            // 
            this.Long_quests_cleared_numericUpDown.Location = new System.Drawing.Point(136, 90);
            this.Long_quests_cleared_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Long_quests_cleared_numericUpDown.Name = "Long_quests_cleared_numericUpDown";
            this.Long_quests_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Long_quests_cleared_numericUpDown.TabIndex = 26;
            this.Long_quests_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Total_quests_cleared_textBox
            // 
            this.Total_quests_cleared_textBox.Location = new System.Drawing.Point(136, 13);
            this.Total_quests_cleared_textBox.MaxLength = 6;
            this.Total_quests_cleared_textBox.Name = "Total_quests_cleared_textBox";
            this.Total_quests_cleared_textBox.ReadOnly = true;
            this.Total_quests_cleared_textBox.Size = new System.Drawing.Size(83, 20);
            this.Total_quests_cleared_textBox.TabIndex = 23;
            // 
            // Music_stages_groupBox
            // 
            this.Music_stages_groupBox.Controls.Add(this.Crowns_pictureBox);
            this.Music_stages_groupBox.Controls.Add(this.Total_songs_cleared_label);
            this.Music_stages_groupBox.Controls.Add(this.Basic_scores_cleared_label);
            this.Music_stages_groupBox.Controls.Add(this.Expert_scores_cleared_label);
            this.Music_stages_groupBox.Controls.Add(this.Ultimate_scores_cleared_label);
            this.Music_stages_groupBox.Controls.Add(this.Perfect_chains_achieved_label);
            this.Music_stages_groupBox.Controls.Add(this.Daily_specials_cleared_label);
            this.Music_stages_groupBox.Controls.Add(this.Crowns_received_label);
            this.Music_stages_groupBox.Controls.Add(this.Total_songs_cleared_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Basic_scores_cleared_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Expert_scores_cleared_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Ultimate_scores_cleared_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Perfect_chains_achieved_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Daily_specials_cleared_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.Crowns_received_numericUpDown);
            this.Music_stages_groupBox.Controls.Add(this.SSS_ranks_received_label);
            this.Music_stages_groupBox.Controls.Add(this.SSS_ranks_received_numericUpDown);
            this.Music_stages_groupBox.Location = new System.Drawing.Point(235, 4);
            this.Music_stages_groupBox.Name = "Music_stages_groupBox";
            this.Music_stages_groupBox.Size = new System.Drawing.Size(222, 217);
            this.Music_stages_groupBox.TabIndex = 15;
            this.Music_stages_groupBox.TabStop = false;
            this.Music_stages_groupBox.Text = "Music Stages";
            // 
            // Total_songs_cleared_label
            // 
            this.Total_songs_cleared_label.AutoSize = true;
            this.Total_songs_cleared_label.Location = new System.Drawing.Point(4, 16);
            this.Total_songs_cleared_label.Name = "Total_songs_cleared_label";
            this.Total_songs_cleared_label.Size = new System.Drawing.Size(106, 13);
            this.Total_songs_cleared_label.TabIndex = 0;
            this.Total_songs_cleared_label.Text = "Total Songs Cleared:";
            // 
            // Basic_scores_cleared_label
            // 
            this.Basic_scores_cleared_label.AutoSize = true;
            this.Basic_scores_cleared_label.Location = new System.Drawing.Point(4, 42);
            this.Basic_scores_cleared_label.Name = "Basic_scores_cleared_label";
            this.Basic_scores_cleared_label.Size = new System.Drawing.Size(111, 13);
            this.Basic_scores_cleared_label.TabIndex = 0;
            this.Basic_scores_cleared_label.Text = "Basic Scores Cleared:";
            // 
            // Expert_scores_cleared_label
            // 
            this.Expert_scores_cleared_label.AutoSize = true;
            this.Expert_scores_cleared_label.Location = new System.Drawing.Point(4, 67);
            this.Expert_scores_cleared_label.Name = "Expert_scores_cleared_label";
            this.Expert_scores_cleared_label.Size = new System.Drawing.Size(115, 13);
            this.Expert_scores_cleared_label.TabIndex = 0;
            this.Expert_scores_cleared_label.Text = "Expert Scores Cleared:";
            // 
            // Ultimate_scores_cleared_label
            // 
            this.Ultimate_scores_cleared_label.AutoSize = true;
            this.Ultimate_scores_cleared_label.Location = new System.Drawing.Point(4, 93);
            this.Ultimate_scores_cleared_label.Name = "Ultimate_scores_cleared_label";
            this.Ultimate_scores_cleared_label.Size = new System.Drawing.Size(123, 13);
            this.Ultimate_scores_cleared_label.TabIndex = 0;
            this.Ultimate_scores_cleared_label.Text = "Ultimate Scores Cleared:";
            // 
            // Perfect_chains_achieved_label
            // 
            this.Perfect_chains_achieved_label.AutoSize = true;
            this.Perfect_chains_achieved_label.Location = new System.Drawing.Point(4, 119);
            this.Perfect_chains_achieved_label.Name = "Perfect_chains_achieved_label";
            this.Perfect_chains_achieved_label.Size = new System.Drawing.Size(127, 13);
            this.Perfect_chains_achieved_label.TabIndex = 0;
            this.Perfect_chains_achieved_label.Text = "Perfect Chains Achieved:";
            // 
            // Daily_specials_cleared_label
            // 
            this.Daily_specials_cleared_label.AutoSize = true;
            this.Daily_specials_cleared_label.Location = new System.Drawing.Point(4, 145);
            this.Daily_specials_cleared_label.Name = "Daily_specials_cleared_label";
            this.Daily_specials_cleared_label.Size = new System.Drawing.Size(115, 13);
            this.Daily_specials_cleared_label.TabIndex = 0;
            this.Daily_specials_cleared_label.Text = "Daily Specials Cleared:";
            // 
            // Crowns_received_label
            // 
            this.Crowns_received_label.AutoSize = true;
            this.Crowns_received_label.Location = new System.Drawing.Point(32, 170);
            this.Crowns_received_label.Name = "Crowns_received_label";
            this.Crowns_received_label.Size = new System.Drawing.Size(64, 13);
            this.Crowns_received_label.TabIndex = 0;
            this.Crowns_received_label.Text = "s Received:";
            // 
            // Total_songs_cleared_numericUpDown
            // 
            this.Total_songs_cleared_numericUpDown.Location = new System.Drawing.Point(134, 14);
            this.Total_songs_cleared_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Total_songs_cleared_numericUpDown.Name = "Total_songs_cleared_numericUpDown";
            this.Total_songs_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Total_songs_cleared_numericUpDown.TabIndex = 15;
            this.Total_songs_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Basic_scores_cleared_numericUpDown
            // 
            this.Basic_scores_cleared_numericUpDown.Location = new System.Drawing.Point(134, 39);
            this.Basic_scores_cleared_numericUpDown.Maximum = new decimal(new int[] {
            321,
            0,
            0,
            0});
            this.Basic_scores_cleared_numericUpDown.Name = "Basic_scores_cleared_numericUpDown";
            this.Basic_scores_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Basic_scores_cleared_numericUpDown.TabIndex = 16;
            this.Basic_scores_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Expert_scores_cleared_numericUpDown
            // 
            this.Expert_scores_cleared_numericUpDown.Location = new System.Drawing.Point(134, 64);
            this.Expert_scores_cleared_numericUpDown.Maximum = new decimal(new int[] {
            321,
            0,
            0,
            0});
            this.Expert_scores_cleared_numericUpDown.Name = "Expert_scores_cleared_numericUpDown";
            this.Expert_scores_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Expert_scores_cleared_numericUpDown.TabIndex = 17;
            this.Expert_scores_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Ultimate_scores_cleared_numericUpDown
            // 
            this.Ultimate_scores_cleared_numericUpDown.Location = new System.Drawing.Point(134, 90);
            this.Ultimate_scores_cleared_numericUpDown.Maximum = new decimal(new int[] {
            321,
            0,
            0,
            0});
            this.Ultimate_scores_cleared_numericUpDown.Name = "Ultimate_scores_cleared_numericUpDown";
            this.Ultimate_scores_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Ultimate_scores_cleared_numericUpDown.TabIndex = 18;
            this.Ultimate_scores_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Perfect_chains_achieved_numericUpDown
            // 
            this.Perfect_chains_achieved_numericUpDown.Location = new System.Drawing.Point(134, 117);
            this.Perfect_chains_achieved_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Perfect_chains_achieved_numericUpDown.Name = "Perfect_chains_achieved_numericUpDown";
            this.Perfect_chains_achieved_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Perfect_chains_achieved_numericUpDown.TabIndex = 19;
            this.Perfect_chains_achieved_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Daily_specials_cleared_numericUpDown
            // 
            this.Daily_specials_cleared_numericUpDown.Location = new System.Drawing.Point(134, 142);
            this.Daily_specials_cleared_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Daily_specials_cleared_numericUpDown.Name = "Daily_specials_cleared_numericUpDown";
            this.Daily_specials_cleared_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Daily_specials_cleared_numericUpDown.TabIndex = 20;
            this.Daily_specials_cleared_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Crowns_received_numericUpDown
            // 
            this.Crowns_received_numericUpDown.Location = new System.Drawing.Point(134, 168);
            this.Crowns_received_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Crowns_received_numericUpDown.Name = "Crowns_received_numericUpDown";
            this.Crowns_received_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Crowns_received_numericUpDown.TabIndex = 21;
            this.Crowns_received_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // SSS_ranks_received_label
            // 
            this.SSS_ranks_received_label.AutoSize = true;
            this.SSS_ranks_received_label.Location = new System.Drawing.Point(4, 195);
            this.SSS_ranks_received_label.Name = "SSS_ranks_received_label";
            this.SSS_ranks_received_label.Size = new System.Drawing.Size(114, 13);
            this.SSS_ranks_received_label.TabIndex = 0;
            this.SSS_ranks_received_label.Text = "SSS Ranks Received:";
            // 
            // SSS_ranks_received_numericUpDown
            // 
            this.SSS_ranks_received_numericUpDown.Location = new System.Drawing.Point(134, 194);
            this.SSS_ranks_received_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.SSS_ranks_received_numericUpDown.Name = "SSS_ranks_received_numericUpDown";
            this.SSS_ranks_received_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.SSS_ranks_received_numericUpDown.TabIndex = 22;
            this.SSS_ranks_received_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Total_counts_groupBox
            // 
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_label);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_seconds_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_hours_label);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_minutes_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_minutes_label);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_hours_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Total_playtime_seconds_label);
            this.Total_counts_groupBox.Controls.Add(this.Songs_played_label);
            this.Total_counts_groupBox.Controls.Add(this.Enemies_defeated_label);
            this.Total_counts_groupBox.Controls.Add(this.Distance_traveled_label);
            this.Total_counts_groupBox.Controls.Add(this.Chained_triggers_label);
            this.Total_counts_groupBox.Controls.Add(this.Critical_triggers_label);
            this.Total_counts_groupBox.Controls.Add(this.ProfiCards_received_label);
            this.Total_counts_groupBox.Controls.Add(this.StreetPasses_label);
            this.Total_counts_groupBox.Controls.Add(this.Songs_played_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Enemies_defeated_numericUpDown1);
            this.Total_counts_groupBox.Controls.Add(this.Distance_traveled_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Chained_triggers_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.Critical_triggers_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.ProfiCards_received_numericUpDown);
            this.Total_counts_groupBox.Controls.Add(this.StreetPasses_numericUpDown);
            this.Total_counts_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Total_counts_groupBox.Location = new System.Drawing.Point(4, 193);
            this.Total_counts_groupBox.Name = "Total_counts_groupBox";
            this.Total_counts_groupBox.Size = new System.Drawing.Size(225, 248);
            this.Total_counts_groupBox.TabIndex = 5;
            this.Total_counts_groupBox.TabStop = false;
            this.Total_counts_groupBox.Text = "Total Counts";
            // 
            // Total_playtime_label
            // 
            this.Total_playtime_label.AutoSize = true;
            this.Total_playtime_label.Location = new System.Drawing.Point(9, 34);
            this.Total_playtime_label.Name = "Total_playtime_label";
            this.Total_playtime_label.Size = new System.Drawing.Size(49, 26);
            this.Total_playtime_label.TabIndex = 0;
            this.Total_playtime_label.Text = "Total \r\nPlaytime:";
            this.Total_playtime_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total_playtime_seconds_numericUpDown
            // 
            this.Total_playtime_seconds_numericUpDown.Location = new System.Drawing.Point(174, 39);
            this.Total_playtime_seconds_numericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Total_playtime_seconds_numericUpDown.Name = "Total_playtime_seconds_numericUpDown";
            this.Total_playtime_seconds_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.Total_playtime_seconds_numericUpDown.TabIndex = 7;
            this.Total_playtime_seconds_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Total_playtime_hours_label
            // 
            this.Total_playtime_hours_label.AutoSize = true;
            this.Total_playtime_hours_label.Location = new System.Drawing.Point(78, 20);
            this.Total_playtime_hours_label.Name = "Total_playtime_hours_label";
            this.Total_playtime_hours_label.Size = new System.Drawing.Size(35, 13);
            this.Total_playtime_hours_label.TabIndex = 0;
            this.Total_playtime_hours_label.Text = "Hours";
            // 
            // Total_playtime_minutes_numericUpDown
            // 
            this.Total_playtime_minutes_numericUpDown.Location = new System.Drawing.Point(123, 39);
            this.Total_playtime_minutes_numericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Total_playtime_minutes_numericUpDown.Name = "Total_playtime_minutes_numericUpDown";
            this.Total_playtime_minutes_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.Total_playtime_minutes_numericUpDown.TabIndex = 6;
            this.Total_playtime_minutes_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Total_playtime_minutes_label
            // 
            this.Total_playtime_minutes_label.AutoSize = true;
            this.Total_playtime_minutes_label.Location = new System.Drawing.Point(122, 20);
            this.Total_playtime_minutes_label.Name = "Total_playtime_minutes_label";
            this.Total_playtime_minutes_label.Size = new System.Drawing.Size(44, 13);
            this.Total_playtime_minutes_label.TabIndex = 0;
            this.Total_playtime_minutes_label.Text = "Minutes";
            // 
            // Total_playtime_hours_numericUpDown
            // 
            this.Total_playtime_hours_numericUpDown.Location = new System.Drawing.Point(72, 39);
            this.Total_playtime_hours_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Total_playtime_hours_numericUpDown.Name = "Total_playtime_hours_numericUpDown";
            this.Total_playtime_hours_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.Total_playtime_hours_numericUpDown.TabIndex = 5;
            this.Total_playtime_hours_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Total_playtime_seconds_label
            // 
            this.Total_playtime_seconds_label.AutoSize = true;
            this.Total_playtime_seconds_label.Location = new System.Drawing.Point(172, 20);
            this.Total_playtime_seconds_label.Name = "Total_playtime_seconds_label";
            this.Total_playtime_seconds_label.Size = new System.Drawing.Size(49, 13);
            this.Total_playtime_seconds_label.TabIndex = 0;
            this.Total_playtime_seconds_label.Text = "Seconds";
            // 
            // Songs_played_label
            // 
            this.Songs_played_label.AutoSize = true;
            this.Songs_played_label.Location = new System.Drawing.Point(6, 70);
            this.Songs_played_label.Name = "Songs_played_label";
            this.Songs_played_label.Size = new System.Drawing.Size(75, 13);
            this.Songs_played_label.TabIndex = 0;
            this.Songs_played_label.Text = "Songs Played:";
            // 
            // Enemies_defeated_label
            // 
            this.Enemies_defeated_label.AutoSize = true;
            this.Enemies_defeated_label.Location = new System.Drawing.Point(6, 96);
            this.Enemies_defeated_label.Name = "Enemies_defeated_label";
            this.Enemies_defeated_label.Size = new System.Drawing.Size(97, 13);
            this.Enemies_defeated_label.TabIndex = 0;
            this.Enemies_defeated_label.Text = "Enemies Defeated:";
            // 
            // Distance_traveled_label
            // 
            this.Distance_traveled_label.AutoSize = true;
            this.Distance_traveled_label.Location = new System.Drawing.Point(6, 122);
            this.Distance_traveled_label.Name = "Distance_traveled_label";
            this.Distance_traveled_label.Size = new System.Drawing.Size(97, 13);
            this.Distance_traveled_label.TabIndex = 0;
            this.Distance_traveled_label.Text = "Distance Traveled:";
            // 
            // Chained_triggers_label
            // 
            this.Chained_triggers_label.AutoSize = true;
            this.Chained_triggers_label.Location = new System.Drawing.Point(6, 148);
            this.Chained_triggers_label.Name = "Chained_triggers_label";
            this.Chained_triggers_label.Size = new System.Drawing.Size(90, 13);
            this.Chained_triggers_label.TabIndex = 0;
            this.Chained_triggers_label.Text = "Chained Triggers:";
            // 
            // Critical_triggers_label
            // 
            this.Critical_triggers_label.AutoSize = true;
            this.Critical_triggers_label.Location = new System.Drawing.Point(6, 174);
            this.Critical_triggers_label.Name = "Critical_triggers_label";
            this.Critical_triggers_label.Size = new System.Drawing.Size(82, 13);
            this.Critical_triggers_label.TabIndex = 0;
            this.Critical_triggers_label.Text = "Critical Triggers:";
            // 
            // ProfiCards_received_label
            // 
            this.ProfiCards_received_label.AutoSize = true;
            this.ProfiCards_received_label.Location = new System.Drawing.Point(6, 200);
            this.ProfiCards_received_label.Name = "ProfiCards_received_label";
            this.ProfiCards_received_label.Size = new System.Drawing.Size(107, 13);
            this.ProfiCards_received_label.TabIndex = 0;
            this.ProfiCards_received_label.Text = "ProfiCards Received:";
            // 
            // StreetPasses_label
            // 
            this.StreetPasses_label.AutoSize = true;
            this.StreetPasses_label.Location = new System.Drawing.Point(6, 226);
            this.StreetPasses_label.Name = "StreetPasses_label";
            this.StreetPasses_label.Size = new System.Drawing.Size(72, 13);
            this.StreetPasses_label.TabIndex = 0;
            this.StreetPasses_label.Text = "StreetPasses:";
            // 
            // Songs_played_numericUpDown
            // 
            this.Songs_played_numericUpDown.Location = new System.Drawing.Point(136, 67);
            this.Songs_played_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Songs_played_numericUpDown.Name = "Songs_played_numericUpDown";
            this.Songs_played_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Songs_played_numericUpDown.TabIndex = 8;
            this.Songs_played_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Enemies_defeated_numericUpDown1
            // 
            this.Enemies_defeated_numericUpDown1.Location = new System.Drawing.Point(136, 93);
            this.Enemies_defeated_numericUpDown1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Enemies_defeated_numericUpDown1.Name = "Enemies_defeated_numericUpDown1";
            this.Enemies_defeated_numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.Enemies_defeated_numericUpDown1.TabIndex = 9;
            this.Enemies_defeated_numericUpDown1.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Distance_traveled_numericUpDown
            // 
            this.Distance_traveled_numericUpDown.Location = new System.Drawing.Point(136, 119);
            this.Distance_traveled_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Distance_traveled_numericUpDown.Name = "Distance_traveled_numericUpDown";
            this.Distance_traveled_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Distance_traveled_numericUpDown.TabIndex = 10;
            this.Distance_traveled_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Chained_triggers_numericUpDown
            // 
            this.Chained_triggers_numericUpDown.Location = new System.Drawing.Point(136, 145);
            this.Chained_triggers_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Chained_triggers_numericUpDown.Name = "Chained_triggers_numericUpDown";
            this.Chained_triggers_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Chained_triggers_numericUpDown.TabIndex = 11;
            this.Chained_triggers_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Critical_triggers_numericUpDown
            // 
            this.Critical_triggers_numericUpDown.Location = new System.Drawing.Point(136, 171);
            this.Critical_triggers_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Critical_triggers_numericUpDown.Name = "Critical_triggers_numericUpDown";
            this.Critical_triggers_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.Critical_triggers_numericUpDown.TabIndex = 12;
            this.Critical_triggers_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // ProfiCards_received_numericUpDown
            // 
            this.ProfiCards_received_numericUpDown.Location = new System.Drawing.Point(136, 197);
            this.ProfiCards_received_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ProfiCards_received_numericUpDown.Name = "ProfiCards_received_numericUpDown";
            this.ProfiCards_received_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.ProfiCards_received_numericUpDown.TabIndex = 13;
            this.ProfiCards_received_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // StreetPasses_numericUpDown
            // 
            this.StreetPasses_numericUpDown.Location = new System.Drawing.Point(136, 223);
            this.StreetPasses_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.StreetPasses_numericUpDown.Name = "StreetPasses_numericUpDown";
            this.StreetPasses_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.StreetPasses_numericUpDown.TabIndex = 14;
            this.StreetPasses_numericUpDown.ValueChanged += new System.EventHandler(this.Write_records);
            // 
            // Characters_tabPage
            // 
            this.Characters_tabPage.Controls.Add(this.groupBox1);
            this.Characters_tabPage.Controls.Add(this.Member3_groupBox);
            this.Characters_tabPage.Controls.Add(this.Member2_groupBox);
            this.Characters_tabPage.Controls.Add(this.Member1_groupBox);
            this.Characters_tabPage.Controls.Add(this.Leader_groupBox);
            this.Characters_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Characters_tabPage.Name = "Characters_tabPage";
            this.Characters_tabPage.Size = new System.Drawing.Size(824, 443);
            this.Characters_tabPage.TabIndex = 4;
            this.Characters_tabPage.Text = "Characters";
            this.Characters_tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Max_all_characters_stats_button);
            this.groupBox1.Controls.Add(this.Max_character_stats_button);
            this.groupBox1.Controls.Add(this.CharEditor_levelResets_picturebox);
            this.groupBox1.Controls.Add(this.CharEditor_totalCPlabel);
            this.groupBox1.Controls.Add(this.CharEditor_levelResets_label);
            this.groupBox1.Controls.Add(this.CharEditor_exp_textBox);
            this.groupBox1.Controls.Add(this.CharEditor_level_textBox);
            this.groupBox1.Controls.Add(this.CharEditor_spirit_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_totalCP_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_levelResets_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_stamina_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_luck_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_hp_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_agility_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_magic_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_strength_numericUpDown);
            this.groupBox1.Controls.Add(this.CharEditor_character_pictureBox);
            this.groupBox1.Controls.Add(this.CharEditor_character_comboBox);
            this.groupBox1.Controls.Add(this.CharEditor_spirit_label);
            this.groupBox1.Controls.Add(this.CharEditor_stamina_label);
            this.groupBox1.Controls.Add(this.CharEditor_luck_label);
            this.groupBox1.Controls.Add(this.CharEditor_hp_label);
            this.groupBox1.Controls.Add(this.CharEditor_agility_label);
            this.groupBox1.Controls.Add(this.CharEditor_magic_label);
            this.groupBox1.Controls.Add(this.CharEditor_strength_label);
            this.groupBox1.Controls.Add(this.CharEditor_exp_label);
            this.groupBox1.Controls.Add(this.CharEditor_character_label);
            this.groupBox1.Controls.Add(this.CharEditor_level_label);
            this.groupBox1.Location = new System.Drawing.Point(3, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 115);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Editor";
            // 
            // Max_all_characters_stats_button
            // 
            this.Max_all_characters_stats_button.Enabled = false;
            this.Max_all_characters_stats_button.Location = new System.Drawing.Point(628, 76);
            this.Max_all_characters_stats_button.Name = "Max_all_characters_stats_button";
            this.Max_all_characters_stats_button.Size = new System.Drawing.Size(177, 23);
            this.Max_all_characters_stats_button.TabIndex = 39;
            this.Max_all_characters_stats_button.Text = "Max All Characters Stats";
            this.Max_all_characters_stats_button.UseVisualStyleBackColor = true;
            this.Max_all_characters_stats_button.Click += new System.EventHandler(this.Max_all_characters_stats_button_Click);
            // 
            // Max_character_stats_button
            // 
            this.Max_character_stats_button.Enabled = false;
            this.Max_character_stats_button.Location = new System.Drawing.Point(445, 76);
            this.Max_character_stats_button.Name = "Max_character_stats_button";
            this.Max_character_stats_button.Size = new System.Drawing.Size(177, 23);
            this.Max_character_stats_button.TabIndex = 39;
            this.Max_character_stats_button.Text = "Max Warrior of Light Stats";
            this.Max_character_stats_button.UseVisualStyleBackColor = true;
            this.Max_character_stats_button.Click += new System.EventHandler(this.Max_character_stats_button_Click);
            // 
            // CharEditor_totalCPlabel
            // 
            this.CharEditor_totalCPlabel.AutoSize = true;
            this.CharEditor_totalCPlabel.Location = new System.Drawing.Point(270, 80);
            this.CharEditor_totalCPlabel.Name = "CharEditor_totalCPlabel";
            this.CharEditor_totalCPlabel.Size = new System.Drawing.Size(48, 13);
            this.CharEditor_totalCPlabel.TabIndex = 0;
            this.CharEditor_totalCPlabel.Text = "Total CP";
            // 
            // CharEditor_levelResets_label
            // 
            this.CharEditor_levelResets_label.AutoSize = true;
            this.CharEditor_levelResets_label.Location = new System.Drawing.Point(270, 50);
            this.CharEditor_levelResets_label.Name = "CharEditor_levelResets_label";
            this.CharEditor_levelResets_label.Size = new System.Drawing.Size(69, 13);
            this.CharEditor_levelResets_label.TabIndex = 0;
            this.CharEditor_levelResets_label.Text = "Level Resets";
            // 
            // CharEditor_exp_textBox
            // 
            this.CharEditor_exp_textBox.Location = new System.Drawing.Point(160, 77);
            this.CharEditor_exp_textBox.Name = "CharEditor_exp_textBox";
            this.CharEditor_exp_textBox.ReadOnly = true;
            this.CharEditor_exp_textBox.Size = new System.Drawing.Size(99, 20);
            this.CharEditor_exp_textBox.TabIndex = 29;
            // 
            // CharEditor_level_textBox
            // 
            this.CharEditor_level_textBox.Location = new System.Drawing.Point(160, 48);
            this.CharEditor_level_textBox.Name = "CharEditor_level_textBox";
            this.CharEditor_level_textBox.ReadOnly = true;
            this.CharEditor_level_textBox.Size = new System.Drawing.Size(99, 20);
            this.CharEditor_level_textBox.TabIndex = 28;
            // 
            // CharEditor_spirit_numericUpDown
            // 
            this.CharEditor_spirit_numericUpDown.Location = new System.Drawing.Point(736, 48);
            this.CharEditor_spirit_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_spirit_numericUpDown.Name = "CharEditor_spirit_numericUpDown";
            this.CharEditor_spirit_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_spirit_numericUpDown.TabIndex = 38;
            this.CharEditor_spirit_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_totalCP_numericUpDown
            // 
            this.CharEditor_totalCP_numericUpDown.Location = new System.Drawing.Point(345, 77);
            this.CharEditor_totalCP_numericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CharEditor_totalCP_numericUpDown.Name = "CharEditor_totalCP_numericUpDown";
            this.CharEditor_totalCP_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.CharEditor_totalCP_numericUpDown.TabIndex = 32;
            this.CharEditor_totalCP_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_levelResets_numericUpDown
            // 
            this.CharEditor_levelResets_numericUpDown.Location = new System.Drawing.Point(345, 48);
            this.CharEditor_levelResets_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CharEditor_levelResets_numericUpDown.Name = "CharEditor_levelResets_numericUpDown";
            this.CharEditor_levelResets_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.CharEditor_levelResets_numericUpDown.TabIndex = 31;
            this.CharEditor_levelResets_numericUpDown.ValueChanged += new System.EventHandler(this.Set_LvReset_totalCP);
            // 
            // CharEditor_stamina_numericUpDown
            // 
            this.CharEditor_stamina_numericUpDown.Location = new System.Drawing.Point(622, 48);
            this.CharEditor_stamina_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_stamina_numericUpDown.Name = "CharEditor_stamina_numericUpDown";
            this.CharEditor_stamina_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_stamina_numericUpDown.TabIndex = 37;
            this.CharEditor_stamina_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_luck_numericUpDown
            // 
            this.CharEditor_luck_numericUpDown.Location = new System.Drawing.Point(495, 48);
            this.CharEditor_luck_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_luck_numericUpDown.Name = "CharEditor_luck_numericUpDown";
            this.CharEditor_luck_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_luck_numericUpDown.TabIndex = 36;
            this.CharEditor_luck_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_hp_numericUpDown
            // 
            this.CharEditor_hp_numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CharEditor_hp_numericUpDown.Location = new System.Drawing.Point(345, 19);
            this.CharEditor_hp_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CharEditor_hp_numericUpDown.Name = "CharEditor_hp_numericUpDown";
            this.CharEditor_hp_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.CharEditor_hp_numericUpDown.TabIndex = 30;
            this.CharEditor_hp_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_agility_numericUpDown
            // 
            this.CharEditor_agility_numericUpDown.Location = new System.Drawing.Point(736, 19);
            this.CharEditor_agility_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_agility_numericUpDown.Name = "CharEditor_agility_numericUpDown";
            this.CharEditor_agility_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_agility_numericUpDown.TabIndex = 35;
            this.CharEditor_agility_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_magic_numericUpDown
            // 
            this.CharEditor_magic_numericUpDown.Location = new System.Drawing.Point(622, 19);
            this.CharEditor_magic_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_magic_numericUpDown.Name = "CharEditor_magic_numericUpDown";
            this.CharEditor_magic_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_magic_numericUpDown.TabIndex = 34;
            this.CharEditor_magic_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_strength_numericUpDown
            // 
            this.CharEditor_strength_numericUpDown.Location = new System.Drawing.Point(495, 19);
            this.CharEditor_strength_numericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CharEditor_strength_numericUpDown.Name = "CharEditor_strength_numericUpDown";
            this.CharEditor_strength_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.CharEditor_strength_numericUpDown.TabIndex = 33;
            this.CharEditor_strength_numericUpDown.ValueChanged += new System.EventHandler(this.Write_characters);
            // 
            // CharEditor_character_comboBox
            // 
            this.CharEditor_character_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharEditor_character_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CharEditor_character_comboBox.Enabled = false;
            this.CharEditor_character_comboBox.FormattingEnabled = true;
            this.CharEditor_character_comboBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Princess Sarah",
            "Firion",
            "Minwu",
            "Onion Knight",
            "Cid",
            "Cecil",
            "Kain",
            "Rydia",
            "Rosa",
            "Edge",
            "Bartz",
            "Faris",
            "Lenna",
            "Galuf",
            "Terra",
            "Locke",
            "Celes",
            "Edgar",
            "Cloud",
            "Sephiroth",
            "Aerith",
            "Tifa",
            "Yuffie",
            "Barret",
            "Vincent",
            "Squall",
            "Seifer",
            "Rinoa",
            "Laguna",
            "Zidane",
            "Vivi",
            "Garnet",
            "Eiko",
            "Tidus",
            "Yuna",
            "Auron",
            "Jecht",
            "Auron #2",
            "Shantotto",
            "Prishe",
            "Aphmau",
            "Lilisette",
            "Vaan",
            "Ashe",
            "Balthier",
            "Fran",
            "Lightning",
            "Snow",
            "Hope",
            "Vanille",
            "Y\'shtola",
            "Benjamin",
            "Ramza",
            "Agrias",
            "Orlandeau",
            "Yuna #2",
            "Rikku",
            "Paine",
            "Ciaran",
            "Cloud #2",
            "Tifa #2",
            "Zack",
            "Cosmos",
            "Chaos",
            "Ace",
            "Machina",
            "Rem",
            "Serah",
            "Noel",
            "Lightning #2"});
            this.CharEditor_character_comboBox.Location = new System.Drawing.Point(160, 19);
            this.CharEditor_character_comboBox.Name = "CharEditor_character_comboBox";
            this.CharEditor_character_comboBox.Size = new System.Drawing.Size(99, 21);
            this.CharEditor_character_comboBox.TabIndex = 27;
            this.CharEditor_character_comboBox.Text = "Warrior of Light";
            this.CharEditor_character_comboBox.SelectedIndexChanged += new System.EventHandler(this.Read_characters);
            // 
            // CharEditor_spirit_label
            // 
            this.CharEditor_spirit_label.AutoSize = true;
            this.CharEditor_spirit_label.Location = new System.Drawing.Point(696, 52);
            this.CharEditor_spirit_label.Name = "CharEditor_spirit_label";
            this.CharEditor_spirit_label.Size = new System.Drawing.Size(30, 13);
            this.CharEditor_spirit_label.TabIndex = 0;
            this.CharEditor_spirit_label.Text = "Spirit";
            // 
            // CharEditor_stamina_label
            // 
            this.CharEditor_stamina_label.AutoSize = true;
            this.CharEditor_stamina_label.Location = new System.Drawing.Point(571, 52);
            this.CharEditor_stamina_label.Name = "CharEditor_stamina_label";
            this.CharEditor_stamina_label.Size = new System.Drawing.Size(45, 13);
            this.CharEditor_stamina_label.TabIndex = 0;
            this.CharEditor_stamina_label.Text = "Stamina";
            // 
            // CharEditor_luck_label
            // 
            this.CharEditor_luck_label.AutoSize = true;
            this.CharEditor_luck_label.Location = new System.Drawing.Point(442, 50);
            this.CharEditor_luck_label.Name = "CharEditor_luck_label";
            this.CharEditor_luck_label.Size = new System.Drawing.Size(31, 13);
            this.CharEditor_luck_label.TabIndex = 0;
            this.CharEditor_luck_label.Text = "Luck";
            // 
            // CharEditor_hp_label
            // 
            this.CharEditor_hp_label.AutoSize = true;
            this.CharEditor_hp_label.Location = new System.Drawing.Point(270, 21);
            this.CharEditor_hp_label.Name = "CharEditor_hp_label";
            this.CharEditor_hp_label.Size = new System.Drawing.Size(22, 13);
            this.CharEditor_hp_label.TabIndex = 0;
            this.CharEditor_hp_label.Text = "HP";
            // 
            // CharEditor_agility_label
            // 
            this.CharEditor_agility_label.AutoSize = true;
            this.CharEditor_agility_label.Location = new System.Drawing.Point(696, 23);
            this.CharEditor_agility_label.Name = "CharEditor_agility_label";
            this.CharEditor_agility_label.Size = new System.Drawing.Size(34, 13);
            this.CharEditor_agility_label.TabIndex = 0;
            this.CharEditor_agility_label.Text = "Agility";
            // 
            // CharEditor_magic_label
            // 
            this.CharEditor_magic_label.AutoSize = true;
            this.CharEditor_magic_label.Location = new System.Drawing.Point(571, 23);
            this.CharEditor_magic_label.Name = "CharEditor_magic_label";
            this.CharEditor_magic_label.Size = new System.Drawing.Size(36, 13);
            this.CharEditor_magic_label.TabIndex = 0;
            this.CharEditor_magic_label.Text = "Magic";
            // 
            // CharEditor_strength_label
            // 
            this.CharEditor_strength_label.AutoSize = true;
            this.CharEditor_strength_label.Location = new System.Drawing.Point(442, 23);
            this.CharEditor_strength_label.Name = "CharEditor_strength_label";
            this.CharEditor_strength_label.Size = new System.Drawing.Size(47, 13);
            this.CharEditor_strength_label.TabIndex = 0;
            this.CharEditor_strength_label.Text = "Strength";
            // 
            // CharEditor_exp_label
            // 
            this.CharEditor_exp_label.AutoSize = true;
            this.CharEditor_exp_label.Location = new System.Drawing.Point(104, 80);
            this.CharEditor_exp_label.Name = "CharEditor_exp_label";
            this.CharEditor_exp_label.Size = new System.Drawing.Size(28, 13);
            this.CharEditor_exp_label.TabIndex = 0;
            this.CharEditor_exp_label.Text = "EXP";
            // 
            // CharEditor_character_label
            // 
            this.CharEditor_character_label.AutoSize = true;
            this.CharEditor_character_label.Location = new System.Drawing.Point(104, 23);
            this.CharEditor_character_label.Name = "CharEditor_character_label";
            this.CharEditor_character_label.Size = new System.Drawing.Size(53, 13);
            this.CharEditor_character_label.TabIndex = 0;
            this.CharEditor_character_label.Text = "Character";
            // 
            // CharEditor_level_label
            // 
            this.CharEditor_level_label.AutoSize = true;
            this.CharEditor_level_label.Location = new System.Drawing.Point(104, 50);
            this.CharEditor_level_label.Name = "CharEditor_level_label";
            this.CharEditor_level_label.Size = new System.Drawing.Size(33, 13);
            this.CharEditor_level_label.TabIndex = 0;
            this.CharEditor_level_label.Text = "Level";
            // 
            // Member3_groupBox
            // 
            this.Member3_groupBox.Controls.Add(this.Party4_ability4_textBox);
            this.Member3_groupBox.Controls.Add(this.Party4_character_pictureBox);
            this.Member3_groupBox.Controls.Add(this.Party4_ability1_label);
            this.Member3_groupBox.Controls.Add(this.Party4_ability2_label);
            this.Member3_groupBox.Controls.Add(this.Party4_ability1_textBox);
            this.Member3_groupBox.Controls.Add(this.Party4_ability2_textBox);
            this.Member3_groupBox.Controls.Add(this.Party4_ability3_textBox);
            this.Member3_groupBox.Controls.Add(this.Party4_ability4_label);
            this.Member3_groupBox.Controls.Add(this.Party4_ability3_label);
            this.Member3_groupBox.Controls.Add(this.Party4_character_comboBox);
            this.Member3_groupBox.Location = new System.Drawing.Point(621, 3);
            this.Member3_groupBox.Name = "Member3_groupBox";
            this.Member3_groupBox.Size = new System.Drawing.Size(200, 322);
            this.Member3_groupBox.TabIndex = 20;
            this.Member3_groupBox.TabStop = false;
            this.Member3_groupBox.Text = "Member";
            // 
            // Party4_ability4_textBox
            // 
            this.Party4_ability4_textBox.Location = new System.Drawing.Point(105, 296);
            this.Party4_ability4_textBox.Name = "Party4_ability4_textBox";
            this.Party4_ability4_textBox.ReadOnly = true;
            this.Party4_ability4_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party4_ability4_textBox.TabIndex = 25;
            this.Party4_ability4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party4_ability1_label
            // 
            this.Party4_ability1_label.AutoSize = true;
            this.Party4_ability1_label.Location = new System.Drawing.Point(30, 240);
            this.Party4_ability1_label.Name = "Party4_ability1_label";
            this.Party4_ability1_label.Size = new System.Drawing.Size(43, 13);
            this.Party4_ability1_label.TabIndex = 0;
            this.Party4_ability1_label.Text = "Ability 1";
            // 
            // Party4_ability2_label
            // 
            this.Party4_ability2_label.AutoSize = true;
            this.Party4_ability2_label.Location = new System.Drawing.Point(126, 240);
            this.Party4_ability2_label.Name = "Party4_ability2_label";
            this.Party4_ability2_label.Size = new System.Drawing.Size(43, 13);
            this.Party4_ability2_label.TabIndex = 0;
            this.Party4_ability2_label.Text = "Ability 2";
            // 
            // Party4_ability1_textBox
            // 
            this.Party4_ability1_textBox.Location = new System.Drawing.Point(7, 256);
            this.Party4_ability1_textBox.Name = "Party4_ability1_textBox";
            this.Party4_ability1_textBox.ReadOnly = true;
            this.Party4_ability1_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party4_ability1_textBox.TabIndex = 22;
            this.Party4_ability1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party4_ability2_textBox
            // 
            this.Party4_ability2_textBox.Location = new System.Drawing.Point(105, 256);
            this.Party4_ability2_textBox.Name = "Party4_ability2_textBox";
            this.Party4_ability2_textBox.ReadOnly = true;
            this.Party4_ability2_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party4_ability2_textBox.TabIndex = 23;
            this.Party4_ability2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party4_ability3_textBox
            // 
            this.Party4_ability3_textBox.Location = new System.Drawing.Point(7, 296);
            this.Party4_ability3_textBox.Name = "Party4_ability3_textBox";
            this.Party4_ability3_textBox.ReadOnly = true;
            this.Party4_ability3_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party4_ability3_textBox.TabIndex = 24;
            this.Party4_ability3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party4_ability4_label
            // 
            this.Party4_ability4_label.AutoSize = true;
            this.Party4_ability4_label.Location = new System.Drawing.Point(126, 280);
            this.Party4_ability4_label.Name = "Party4_ability4_label";
            this.Party4_ability4_label.Size = new System.Drawing.Size(43, 13);
            this.Party4_ability4_label.TabIndex = 0;
            this.Party4_ability4_label.Text = "Ability 4";
            // 
            // Party4_ability3_label
            // 
            this.Party4_ability3_label.AutoSize = true;
            this.Party4_ability3_label.Location = new System.Drawing.Point(30, 280);
            this.Party4_ability3_label.Name = "Party4_ability3_label";
            this.Party4_ability3_label.Size = new System.Drawing.Size(43, 13);
            this.Party4_ability3_label.TabIndex = 0;
            this.Party4_ability3_label.Text = "Ability 3";
            // 
            // Party4_character_comboBox
            // 
            this.Party4_character_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Party4_character_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Party4_character_comboBox.FormattingEnabled = true;
            this.Party4_character_comboBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Princess Sarah",
            "Firion",
            "Minwu",
            "Onion Knight",
            "Cid",
            "Cecil",
            "Kain",
            "Rydia",
            "Rosa",
            "Edge",
            "Bartz",
            "Faris",
            "Lenna",
            "Galuf",
            "Terra",
            "Locke",
            "Celes",
            "Edgar",
            "Cloud",
            "Sephiroth",
            "Aerith",
            "Tifa",
            "Yuffie",
            "Barret",
            "Vincent",
            "Squall",
            "Seifer",
            "Rinoa",
            "Laguna",
            "Zidane",
            "Vivi",
            "Garnet",
            "Eiko",
            "Tidus",
            "Yuna",
            "Auron",
            "Jecht",
            "Auron #2",
            "Shantotto",
            "Prishe",
            "Aphmau",
            "Lilisette",
            "Vaan",
            "Ashe",
            "Balthier",
            "Fran",
            "Lightning",
            "Snow",
            "Hope",
            "Vanille",
            "Y\'shtola",
            "Benjamin",
            "Ramza",
            "Agrias",
            "Orlandeau",
            "Yuna #2",
            "Rikku",
            "Paine",
            "Ciaran",
            "Cloud #2",
            "Tifa #2",
            "Zack",
            "Cosmos",
            "Chaos",
            "Ace",
            "Machina",
            "Rem",
            "Serah",
            "Noel",
            "Lightning #2"});
            this.Party4_character_comboBox.Location = new System.Drawing.Point(7, 210);
            this.Party4_character_comboBox.Name = "Party4_character_comboBox";
            this.Party4_character_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Party4_character_comboBox.TabIndex = 21;
            this.Party4_character_comboBox.Text = "Warrior of Light";
            this.Party4_character_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_characters);
            // 
            // Member2_groupBox
            // 
            this.Member2_groupBox.Controls.Add(this.Party3_ability4_textBox);
            this.Member2_groupBox.Controls.Add(this.Party3_character_pictureBox);
            this.Member2_groupBox.Controls.Add(this.Party3_ability2_label);
            this.Member2_groupBox.Controls.Add(this.Party3_ability2_textBox);
            this.Member2_groupBox.Controls.Add(this.Party3_ability4_label);
            this.Member2_groupBox.Controls.Add(this.Party3_character_comboBox);
            this.Member2_groupBox.Controls.Add(this.Party3_ability3_label);
            this.Member2_groupBox.Controls.Add(this.Party3_ability3_textBox);
            this.Member2_groupBox.Controls.Add(this.Party3_ability1_textBox);
            this.Member2_groupBox.Controls.Add(this.Party3_ability1_label);
            this.Member2_groupBox.Location = new System.Drawing.Point(415, 3);
            this.Member2_groupBox.Name = "Member2_groupBox";
            this.Member2_groupBox.Size = new System.Drawing.Size(200, 322);
            this.Member2_groupBox.TabIndex = 14;
            this.Member2_groupBox.TabStop = false;
            this.Member2_groupBox.Text = "Member";
            // 
            // Party3_ability4_textBox
            // 
            this.Party3_ability4_textBox.Location = new System.Drawing.Point(105, 296);
            this.Party3_ability4_textBox.Name = "Party3_ability4_textBox";
            this.Party3_ability4_textBox.ReadOnly = true;
            this.Party3_ability4_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party3_ability4_textBox.TabIndex = 19;
            this.Party3_ability4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party3_ability2_label
            // 
            this.Party3_ability2_label.AutoSize = true;
            this.Party3_ability2_label.Location = new System.Drawing.Point(126, 240);
            this.Party3_ability2_label.Name = "Party3_ability2_label";
            this.Party3_ability2_label.Size = new System.Drawing.Size(43, 13);
            this.Party3_ability2_label.TabIndex = 0;
            this.Party3_ability2_label.Text = "Ability 2";
            // 
            // Party3_ability2_textBox
            // 
            this.Party3_ability2_textBox.Location = new System.Drawing.Point(105, 256);
            this.Party3_ability2_textBox.Name = "Party3_ability2_textBox";
            this.Party3_ability2_textBox.ReadOnly = true;
            this.Party3_ability2_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party3_ability2_textBox.TabIndex = 17;
            this.Party3_ability2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party3_ability4_label
            // 
            this.Party3_ability4_label.AutoSize = true;
            this.Party3_ability4_label.Location = new System.Drawing.Point(126, 280);
            this.Party3_ability4_label.Name = "Party3_ability4_label";
            this.Party3_ability4_label.Size = new System.Drawing.Size(43, 13);
            this.Party3_ability4_label.TabIndex = 0;
            this.Party3_ability4_label.Text = "Ability 4";
            // 
            // Party3_character_comboBox
            // 
            this.Party3_character_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Party3_character_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Party3_character_comboBox.FormattingEnabled = true;
            this.Party3_character_comboBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Princess Sarah",
            "Firion",
            "Minwu",
            "Onion Knight",
            "Cid",
            "Cecil",
            "Kain",
            "Rydia",
            "Rosa",
            "Edge",
            "Bartz",
            "Faris",
            "Lenna",
            "Galuf",
            "Terra",
            "Locke",
            "Celes",
            "Edgar",
            "Cloud",
            "Sephiroth",
            "Aerith",
            "Tifa",
            "Yuffie",
            "Barret",
            "Vincent",
            "Squall",
            "Seifer",
            "Rinoa",
            "Laguna",
            "Zidane",
            "Vivi",
            "Garnet",
            "Eiko",
            "Tidus",
            "Yuna",
            "Auron",
            "Jecht",
            "Auron #2",
            "Shantotto",
            "Prishe",
            "Aphmau",
            "Lilisette",
            "Vaan",
            "Ashe",
            "Balthier",
            "Fran",
            "Lightning",
            "Snow",
            "Hope",
            "Vanille",
            "Y\'shtola",
            "Benjamin",
            "Ramza",
            "Agrias",
            "Orlandeau",
            "Yuna #2",
            "Rikku",
            "Paine",
            "Ciaran",
            "Cloud #2",
            "Tifa #2",
            "Zack",
            "Cosmos",
            "Chaos",
            "Ace",
            "Machina",
            "Rem",
            "Serah",
            "Noel",
            "Lightning #2"});
            this.Party3_character_comboBox.Location = new System.Drawing.Point(7, 210);
            this.Party3_character_comboBox.Name = "Party3_character_comboBox";
            this.Party3_character_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Party3_character_comboBox.TabIndex = 15;
            this.Party3_character_comboBox.Text = "Warrior of Light";
            this.Party3_character_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_characters);
            // 
            // Party3_ability3_label
            // 
            this.Party3_ability3_label.AutoSize = true;
            this.Party3_ability3_label.Location = new System.Drawing.Point(30, 280);
            this.Party3_ability3_label.Name = "Party3_ability3_label";
            this.Party3_ability3_label.Size = new System.Drawing.Size(43, 13);
            this.Party3_ability3_label.TabIndex = 0;
            this.Party3_ability3_label.Text = "Ability 3";
            // 
            // Party3_ability3_textBox
            // 
            this.Party3_ability3_textBox.Location = new System.Drawing.Point(7, 296);
            this.Party3_ability3_textBox.Name = "Party3_ability3_textBox";
            this.Party3_ability3_textBox.ReadOnly = true;
            this.Party3_ability3_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party3_ability3_textBox.TabIndex = 18;
            this.Party3_ability3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party3_ability1_textBox
            // 
            this.Party3_ability1_textBox.Location = new System.Drawing.Point(7, 256);
            this.Party3_ability1_textBox.Name = "Party3_ability1_textBox";
            this.Party3_ability1_textBox.ReadOnly = true;
            this.Party3_ability1_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party3_ability1_textBox.TabIndex = 16;
            this.Party3_ability1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party3_ability1_label
            // 
            this.Party3_ability1_label.AutoSize = true;
            this.Party3_ability1_label.Location = new System.Drawing.Point(30, 240);
            this.Party3_ability1_label.Name = "Party3_ability1_label";
            this.Party3_ability1_label.Size = new System.Drawing.Size(43, 13);
            this.Party3_ability1_label.TabIndex = 0;
            this.Party3_ability1_label.Text = "Ability 1";
            // 
            // Member1_groupBox
            // 
            this.Member1_groupBox.Controls.Add(this.Party2_ability4_textBox);
            this.Member1_groupBox.Controls.Add(this.Party2_character_pictureBox);
            this.Member1_groupBox.Controls.Add(this.Party2_ability2_textBox);
            this.Member1_groupBox.Controls.Add(this.Party2_character_comboBox);
            this.Member1_groupBox.Controls.Add(this.Party2_ability3_textBox);
            this.Member1_groupBox.Controls.Add(this.Party2_ability1_label);
            this.Member1_groupBox.Controls.Add(this.Party2_ability1_textBox);
            this.Member1_groupBox.Controls.Add(this.Party2_ability3_label);
            this.Member1_groupBox.Controls.Add(this.Party2_ability4_label);
            this.Member1_groupBox.Controls.Add(this.Party2_ability2_label);
            this.Member1_groupBox.Location = new System.Drawing.Point(209, 3);
            this.Member1_groupBox.Name = "Member1_groupBox";
            this.Member1_groupBox.Size = new System.Drawing.Size(200, 322);
            this.Member1_groupBox.TabIndex = 8;
            this.Member1_groupBox.TabStop = false;
            this.Member1_groupBox.Text = "Member";
            // 
            // Party2_ability4_textBox
            // 
            this.Party2_ability4_textBox.Location = new System.Drawing.Point(105, 296);
            this.Party2_ability4_textBox.Name = "Party2_ability4_textBox";
            this.Party2_ability4_textBox.ReadOnly = true;
            this.Party2_ability4_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party2_ability4_textBox.TabIndex = 13;
            this.Party2_ability4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party2_ability2_textBox
            // 
            this.Party2_ability2_textBox.Location = new System.Drawing.Point(105, 256);
            this.Party2_ability2_textBox.Name = "Party2_ability2_textBox";
            this.Party2_ability2_textBox.ReadOnly = true;
            this.Party2_ability2_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party2_ability2_textBox.TabIndex = 11;
            this.Party2_ability2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party2_character_comboBox
            // 
            this.Party2_character_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Party2_character_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Party2_character_comboBox.FormattingEnabled = true;
            this.Party2_character_comboBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Princess Sarah",
            "Firion",
            "Minwu",
            "Onion Knight",
            "Cid",
            "Cecil",
            "Kain",
            "Rydia",
            "Rosa",
            "Edge",
            "Bartz",
            "Faris",
            "Lenna",
            "Galuf",
            "Terra",
            "Locke",
            "Celes",
            "Edgar",
            "Cloud",
            "Sephiroth",
            "Aerith",
            "Tifa",
            "Yuffie",
            "Barret",
            "Vincent",
            "Squall",
            "Seifer",
            "Rinoa",
            "Laguna",
            "Zidane",
            "Vivi",
            "Garnet",
            "Eiko",
            "Tidus",
            "Yuna",
            "Auron",
            "Jecht",
            "Auron #2",
            "Shantotto",
            "Prishe",
            "Aphmau",
            "Lilisette",
            "Vaan",
            "Ashe",
            "Balthier",
            "Fran",
            "Lightning",
            "Snow",
            "Hope",
            "Vanille",
            "Y\'shtola",
            "Benjamin",
            "Ramza",
            "Agrias",
            "Orlandeau",
            "Yuna #2",
            "Rikku",
            "Paine",
            "Ciaran",
            "Cloud #2",
            "Tifa #2",
            "Zack",
            "Cosmos",
            "Chaos",
            "Ace",
            "Machina",
            "Rem",
            "Serah",
            "Noel",
            "Lightning #2"});
            this.Party2_character_comboBox.Location = new System.Drawing.Point(7, 210);
            this.Party2_character_comboBox.MaxDropDownItems = 9;
            this.Party2_character_comboBox.Name = "Party2_character_comboBox";
            this.Party2_character_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Party2_character_comboBox.TabIndex = 1;
            this.Party2_character_comboBox.Text = "Warrior of Light";
            this.Party2_character_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_characters);
            // 
            // Party2_ability3_textBox
            // 
            this.Party2_ability3_textBox.Location = new System.Drawing.Point(7, 296);
            this.Party2_ability3_textBox.Name = "Party2_ability3_textBox";
            this.Party2_ability3_textBox.ReadOnly = true;
            this.Party2_ability3_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party2_ability3_textBox.TabIndex = 12;
            this.Party2_ability3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party2_ability1_label
            // 
            this.Party2_ability1_label.AutoSize = true;
            this.Party2_ability1_label.Location = new System.Drawing.Point(30, 240);
            this.Party2_ability1_label.Name = "Party2_ability1_label";
            this.Party2_ability1_label.Size = new System.Drawing.Size(43, 13);
            this.Party2_ability1_label.TabIndex = 0;
            this.Party2_ability1_label.Text = "Ability 1";
            // 
            // Party2_ability1_textBox
            // 
            this.Party2_ability1_textBox.Location = new System.Drawing.Point(7, 256);
            this.Party2_ability1_textBox.Name = "Party2_ability1_textBox";
            this.Party2_ability1_textBox.ReadOnly = true;
            this.Party2_ability1_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party2_ability1_textBox.TabIndex = 10;
            this.Party2_ability1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party2_ability3_label
            // 
            this.Party2_ability3_label.AutoSize = true;
            this.Party2_ability3_label.Location = new System.Drawing.Point(30, 280);
            this.Party2_ability3_label.Name = "Party2_ability3_label";
            this.Party2_ability3_label.Size = new System.Drawing.Size(43, 13);
            this.Party2_ability3_label.TabIndex = 0;
            this.Party2_ability3_label.Text = "Ability 3";
            // 
            // Party2_ability4_label
            // 
            this.Party2_ability4_label.AutoSize = true;
            this.Party2_ability4_label.Location = new System.Drawing.Point(126, 280);
            this.Party2_ability4_label.Name = "Party2_ability4_label";
            this.Party2_ability4_label.Size = new System.Drawing.Size(43, 13);
            this.Party2_ability4_label.TabIndex = 0;
            this.Party2_ability4_label.Text = "Ability 4";
            // 
            // Party2_ability2_label
            // 
            this.Party2_ability2_label.AutoSize = true;
            this.Party2_ability2_label.Location = new System.Drawing.Point(126, 240);
            this.Party2_ability2_label.Name = "Party2_ability2_label";
            this.Party2_ability2_label.Size = new System.Drawing.Size(43, 13);
            this.Party2_ability2_label.TabIndex = 0;
            this.Party2_ability2_label.Text = "Ability 2";
            // 
            // Leader_groupBox
            // 
            this.Leader_groupBox.Controls.Add(this.Party1_ability4_textBox);
            this.Leader_groupBox.Controls.Add(this.Party1_ability2_textBox);
            this.Leader_groupBox.Controls.Add(this.Party1_ability3_textBox);
            this.Leader_groupBox.Controls.Add(this.Party1_ability1_textBox);
            this.Leader_groupBox.Controls.Add(this.Party1_ability4_label);
            this.Leader_groupBox.Controls.Add(this.Party1_ability2_label);
            this.Leader_groupBox.Controls.Add(this.Party1_ability3_label);
            this.Leader_groupBox.Controls.Add(this.Party1_ability1_label);
            this.Leader_groupBox.Controls.Add(this.Party1_character_comboBox);
            this.Leader_groupBox.Controls.Add(this.Party1_character_pictureBox);
            this.Leader_groupBox.Location = new System.Drawing.Point(3, 3);
            this.Leader_groupBox.Name = "Leader_groupBox";
            this.Leader_groupBox.Size = new System.Drawing.Size(200, 322);
            this.Leader_groupBox.TabIndex = 2;
            this.Leader_groupBox.TabStop = false;
            this.Leader_groupBox.Text = "Leader";
            // 
            // Party1_ability4_textBox
            // 
            this.Party1_ability4_textBox.Location = new System.Drawing.Point(105, 296);
            this.Party1_ability4_textBox.Name = "Party1_ability4_textBox";
            this.Party1_ability4_textBox.ReadOnly = true;
            this.Party1_ability4_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party1_ability4_textBox.TabIndex = 7;
            this.Party1_ability4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party1_ability2_textBox
            // 
            this.Party1_ability2_textBox.Location = new System.Drawing.Point(105, 256);
            this.Party1_ability2_textBox.Name = "Party1_ability2_textBox";
            this.Party1_ability2_textBox.ReadOnly = true;
            this.Party1_ability2_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party1_ability2_textBox.TabIndex = 5;
            this.Party1_ability2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party1_ability3_textBox
            // 
            this.Party1_ability3_textBox.Location = new System.Drawing.Point(7, 296);
            this.Party1_ability3_textBox.Name = "Party1_ability3_textBox";
            this.Party1_ability3_textBox.ReadOnly = true;
            this.Party1_ability3_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party1_ability3_textBox.TabIndex = 6;
            this.Party1_ability3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party1_ability1_textBox
            // 
            this.Party1_ability1_textBox.Location = new System.Drawing.Point(7, 256);
            this.Party1_ability1_textBox.Name = "Party1_ability1_textBox";
            this.Party1_ability1_textBox.ReadOnly = true;
            this.Party1_ability1_textBox.Size = new System.Drawing.Size(89, 20);
            this.Party1_ability1_textBox.TabIndex = 4;
            this.Party1_ability1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Party1_ability4_label
            // 
            this.Party1_ability4_label.AutoSize = true;
            this.Party1_ability4_label.Location = new System.Drawing.Point(126, 280);
            this.Party1_ability4_label.Name = "Party1_ability4_label";
            this.Party1_ability4_label.Size = new System.Drawing.Size(43, 13);
            this.Party1_ability4_label.TabIndex = 0;
            this.Party1_ability4_label.Text = "Ability 4";
            // 
            // Party1_ability2_label
            // 
            this.Party1_ability2_label.AutoSize = true;
            this.Party1_ability2_label.Location = new System.Drawing.Point(126, 240);
            this.Party1_ability2_label.Name = "Party1_ability2_label";
            this.Party1_ability2_label.Size = new System.Drawing.Size(43, 13);
            this.Party1_ability2_label.TabIndex = 0;
            this.Party1_ability2_label.Text = "Ability 2";
            // 
            // Party1_ability3_label
            // 
            this.Party1_ability3_label.AutoSize = true;
            this.Party1_ability3_label.Location = new System.Drawing.Point(30, 280);
            this.Party1_ability3_label.Name = "Party1_ability3_label";
            this.Party1_ability3_label.Size = new System.Drawing.Size(43, 13);
            this.Party1_ability3_label.TabIndex = 0;
            this.Party1_ability3_label.Text = "Ability 3";
            // 
            // Party1_ability1_label
            // 
            this.Party1_ability1_label.AutoSize = true;
            this.Party1_ability1_label.Location = new System.Drawing.Point(30, 240);
            this.Party1_ability1_label.Name = "Party1_ability1_label";
            this.Party1_ability1_label.Size = new System.Drawing.Size(43, 13);
            this.Party1_ability1_label.TabIndex = 0;
            this.Party1_ability1_label.Text = "Ability 1";
            // 
            // Party1_character_comboBox
            // 
            this.Party1_character_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Party1_character_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Party1_character_comboBox.FormattingEnabled = true;
            this.Party1_character_comboBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Princess Sarah",
            "Firion",
            "Minwu",
            "Onion Knight",
            "Cid",
            "Cecil",
            "Kain",
            "Rydia",
            "Rosa",
            "Edge",
            "Bartz",
            "Faris",
            "Lenna",
            "Galuf",
            "Terra",
            "Locke",
            "Celes",
            "Edgar",
            "Cloud",
            "Sephiroth",
            "Aerith",
            "Tifa",
            "Yuffie",
            "Barret",
            "Vincent",
            "Squall",
            "Seifer",
            "Rinoa",
            "Laguna",
            "Zidane",
            "Vivi",
            "Garnet",
            "Eiko",
            "Tidus",
            "Yuna",
            "Auron",
            "Jecht",
            "Auron #2",
            "Shantotto",
            "Prishe",
            "Aphmau",
            "Lilisette",
            "Vaan",
            "Ashe",
            "Balthier",
            "Fran",
            "Lightning",
            "Snow",
            "Hope",
            "Vanille",
            "Y\'shtola",
            "Benjamin",
            "Ramza",
            "Agrias",
            "Orlandeau",
            "Yuna #2",
            "Rikku",
            "Paine",
            "Ciaran",
            "Cloud #2",
            "Tifa #2",
            "Zack",
            "Cosmos",
            "Chaos",
            "Ace",
            "Machina",
            "Rem",
            "Serah",
            "Noel",
            "Lightning #2"});
            this.Party1_character_comboBox.Location = new System.Drawing.Point(7, 210);
            this.Party1_character_comboBox.Name = "Party1_character_comboBox";
            this.Party1_character_comboBox.Size = new System.Drawing.Size(187, 21);
            this.Party1_character_comboBox.TabIndex = 3;
            this.Party1_character_comboBox.Text = "Warrior of Light";
            this.Party1_character_comboBox.SelectedIndexChanged += new System.EventHandler(this.Write_characters);
            // 
            // Items_tabPage
            // 
            this.Items_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Items_tabPage.Controls.Add(this.Item_quest_med_groupBox);
            this.Items_tabPage.Controls.Add(this.Item_equip_groupBox);
            this.Items_tabPage.Controls.Add(this.max_items_button);
            this.Items_tabPage.Controls.Add(this.Items_dataGridView);
            this.Items_tabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Items_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Items_tabPage.Name = "Items_tabPage";
            this.Items_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Items_tabPage.Size = new System.Drawing.Size(824, 443);
            this.Items_tabPage.TabIndex = 3;
            this.Items_tabPage.Text = "Items";
            // 
            // Item_quest_med_groupBox
            // 
            this.Item_quest_med_groupBox.Controls.Add(this.Item_quest_med_richTextBox);
            this.Item_quest_med_groupBox.Location = new System.Drawing.Point(592, 235);
            this.Item_quest_med_groupBox.Name = "Item_quest_med_groupBox";
            this.Item_quest_med_groupBox.Size = new System.Drawing.Size(229, 205);
            this.Item_quest_med_groupBox.TabIndex = 4;
            this.Item_quest_med_groupBox.TabStop = false;
            this.Item_quest_med_groupBox.Text = "Quest Medley";
            // 
            // Item_quest_med_richTextBox
            // 
            this.Item_quest_med_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Item_quest_med_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_quest_med_richTextBox.Location = new System.Drawing.Point(7, 19);
            this.Item_quest_med_richTextBox.Name = "Item_quest_med_richTextBox";
            this.Item_quest_med_richTextBox.ReadOnly = true;
            this.Item_quest_med_richTextBox.Size = new System.Drawing.Size(216, 180);
            this.Item_quest_med_richTextBox.TabIndex = 1;
            this.Item_quest_med_richTextBox.Text = "Used from the map during a Quest Medley. Restores 30% of the HP gauge.";
            // 
            // Item_equip_groupBox
            // 
            this.Item_equip_groupBox.Controls.Add(this.Item_equip_richTextBox);
            this.Item_equip_groupBox.Location = new System.Drawing.Point(592, 29);
            this.Item_equip_groupBox.Name = "Item_equip_groupBox";
            this.Item_equip_groupBox.Size = new System.Drawing.Size(229, 205);
            this.Item_equip_groupBox.TabIndex = 4;
            this.Item_equip_groupBox.TabStop = false;
            this.Item_equip_groupBox.Text = "Equip";
            // 
            // Item_equip_richTextBox
            // 
            this.Item_equip_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Item_equip_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_equip_richTextBox.Location = new System.Drawing.Point(7, 19);
            this.Item_equip_richTextBox.Name = "Item_equip_richTextBox";
            this.Item_equip_richTextBox.ReadOnly = true;
            this.Item_equip_richTextBox.Size = new System.Drawing.Size(216, 180);
            this.Item_equip_richTextBox.TabIndex = 1;
            this.Item_equip_richTextBox.Text = "Used when HP gauge drops below 20%. Restores 30% of HP gauge.";
            // 
            // max_items_button
            // 
            this.max_items_button.Enabled = false;
            this.max_items_button.Location = new System.Drawing.Point(3, 3);
            this.max_items_button.Name = "max_items_button";
            this.max_items_button.Size = new System.Drawing.Size(818, 23);
            this.max_items_button.TabIndex = 2;
            this.max_items_button.Text = "Max All Items";
            this.max_items_button.UseVisualStyleBackColor = true;
            this.max_items_button.Click += new System.EventHandler(this.max_items_button_Click);
            // 
            // Items_dataGridView
            // 
            this.Items_dataGridView.AllowUserToAddRows = false;
            this.Items_dataGridView.AllowUserToDeleteRows = false;
            this.Items_dataGridView.AllowUserToResizeRows = false;
            this.Items_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Items_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Items_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.Items_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Items_dataGridView.Location = new System.Drawing.Point(3, 29);
            this.Items_dataGridView.Name = "Items_dataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Items_dataGridView.RowHeadersVisible = false;
            this.Items_dataGridView.Size = new System.Drawing.Size(582, 411);
            this.Items_dataGridView.TabIndex = 3;
            this.Items_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellCheck);
            this.Items_dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_integer_check);
            this.Items_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Set_item_desc);
            // 
            // CollectaCards_tabPage
            // 
            this.CollectaCards_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.CollectaCards_tabPage.Controls.Add(this.groupBox5);
            this.CollectaCards_tabPage.Controls.Add(this.groupBox3);
            this.CollectaCards_tabPage.Controls.Add(this.groupBox4);
            this.CollectaCards_tabPage.Controls.Add(this.groupBox2);
            this.CollectaCards_tabPage.Controls.Add(this.card_premium_description_groupBox);
            this.CollectaCards_tabPage.Controls.Add(this.card_rare_description_groupBox);
            this.CollectaCards_tabPage.Controls.Add(this.card_normal_description_groupBox);
            this.CollectaCards_tabPage.Controls.Add(this.max_all_cards_button);
            this.CollectaCards_tabPage.Controls.Add(this.max_premium_cards_button);
            this.CollectaCards_tabPage.Controls.Add(this.max_rare_cards_button);
            this.CollectaCards_tabPage.Controls.Add(this.max_normal_cards_button);
            this.CollectaCards_tabPage.Controls.Add(this.Cards_dataGridView);
            this.CollectaCards_tabPage.Location = new System.Drawing.Point(4, 22);
            this.CollectaCards_tabPage.Name = "CollectaCards_tabPage";
            this.CollectaCards_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CollectaCards_tabPage.Size = new System.Drawing.Size(824, 443);
            this.CollectaCards_tabPage.TabIndex = 2;
            this.CollectaCards_tabPage.Text = "CollectaCards";
            // 
            // max_all_cards_button
            // 
            this.max_all_cards_button.Enabled = false;
            this.max_all_cards_button.Location = new System.Drawing.Point(45, 3);
            this.max_all_cards_button.Name = "max_all_cards_button";
            this.max_all_cards_button.Size = new System.Drawing.Size(124, 23);
            this.max_all_cards_button.TabIndex = 2;
            this.max_all_cards_button.Text = "Max All Cards";
            this.max_all_cards_button.UseVisualStyleBackColor = true;
            this.max_all_cards_button.Click += new System.EventHandler(this.max_all_cards_button_Click);
            // 
            // max_premium_cards_button
            // 
            this.max_premium_cards_button.Enabled = false;
            this.max_premium_cards_button.Location = new System.Drawing.Point(649, 3);
            this.max_premium_cards_button.Name = "max_premium_cards_button";
            this.max_premium_cards_button.Size = new System.Drawing.Size(124, 23);
            this.max_premium_cards_button.TabIndex = 4;
            this.max_premium_cards_button.Text = "Max [P] Premium Cards";
            this.max_premium_cards_button.UseVisualStyleBackColor = true;
            this.max_premium_cards_button.Click += new System.EventHandler(this.max_premium_cards_button_Click);
            // 
            // max_rare_cards_button
            // 
            this.max_rare_cards_button.Enabled = false;
            this.max_rare_cards_button.Location = new System.Drawing.Point(447, 3);
            this.max_rare_cards_button.Name = "max_rare_cards_button";
            this.max_rare_cards_button.Size = new System.Drawing.Size(124, 23);
            this.max_rare_cards_button.TabIndex = 3;
            this.max_rare_cards_button.Text = "Max [R] Rare Cards";
            this.max_rare_cards_button.UseVisualStyleBackColor = true;
            this.max_rare_cards_button.Click += new System.EventHandler(this.max_rare_cards_button_Click);
            // 
            // max_normal_cards_button
            // 
            this.max_normal_cards_button.Enabled = false;
            this.max_normal_cards_button.Location = new System.Drawing.Point(250, 3);
            this.max_normal_cards_button.Name = "max_normal_cards_button";
            this.max_normal_cards_button.Size = new System.Drawing.Size(124, 23);
            this.max_normal_cards_button.TabIndex = 5;
            this.max_normal_cards_button.Text = "Max [N] Normal Cards";
            this.max_normal_cards_button.UseVisualStyleBackColor = true;
            this.max_normal_cards_button.Click += new System.EventHandler(this.max_normal_cards_button_Click);
            // 
            // Cards_dataGridView
            // 
            this.Cards_dataGridView.AllowUserToAddRows = false;
            this.Cards_dataGridView.AllowUserToDeleteRows = false;
            this.Cards_dataGridView.AllowUserToResizeRows = false;
            this.Cards_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cards_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Cards_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cards_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Card_name,
            this.Card_normal,
            this.Card_rare,
            this.Card_premium});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cards_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cards_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Cards_dataGridView.Location = new System.Drawing.Point(3, 29);
            this.Cards_dataGridView.Name = "Cards_dataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cards_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Cards_dataGridView.RowHeadersVisible = false;
            this.Cards_dataGridView.Size = new System.Drawing.Size(371, 411);
            this.Cards_dataGridView.TabIndex = 6;
            this.Cards_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellCheck);
            this.Cards_dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_integer_check);
            this.Cards_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Set_card_desc);
            // 
            // Songs_tabPage
            // 
            this.Songs_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.Songs_tabPage.Controls.Add(this.label11);
            this.Songs_tabPage.Controls.Add(this.label3);
            this.Songs_tabPage.Controls.Add(this.label2);
            this.Songs_tabPage.Controls.Add(this.label1);
            this.Songs_tabPage.Controls.Add(this.label10);
            this.Songs_tabPage.Controls.Add(this.Songs_dataGridView);
            this.Songs_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Songs_tabPage.Name = "Songs_tabPage";
            this.Songs_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Songs_tabPage.Size = new System.Drawing.Size(824, 443);
            this.Songs_tabPage.TabIndex = 1;
            this.Songs_tabPage.Text = "Songs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Times Played: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Ultimate All-Criticals: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Expert All-Criticals: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Basic All-Criticals: 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Times Cleared: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(45, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_files_ToolStripMenuItem,
            this.Save_files_ToolStripMenuItem,
            this.Save_files_as_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.File_ToolStripMenuItem.Text = "File";
            // 
            // Open_files_ToolStripMenuItem
            // 
            this.Open_files_ToolStripMenuItem.Name = "Open_files_ToolStripMenuItem";
            this.Open_files_ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.Open_files_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_files_ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.Open_files_ToolStripMenuItem.Text = "Open Files...";
            this.Open_files_ToolStripMenuItem.Click += new System.EventHandler(this.Open_files_ToolStripMenuItem_Click);
            // 
            // Save_files_ToolStripMenuItem
            // 
            this.Save_files_ToolStripMenuItem.Enabled = false;
            this.Save_files_ToolStripMenuItem.Name = "Save_files_ToolStripMenuItem";
            this.Save_files_ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.Save_files_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_files_ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.Save_files_ToolStripMenuItem.Text = "Save Files";
            this.Save_files_ToolStripMenuItem.Click += new System.EventHandler(this.Save_files_ToolStripMenuItem_Click);
            // 
            // Save_files_as_ToolStripMenuItem
            // 
            this.Save_files_as_ToolStripMenuItem.Enabled = false;
            this.Save_files_as_ToolStripMenuItem.Name = "Save_files_as_ToolStripMenuItem";
            this.Save_files_as_ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.Save_files_as_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Save_files_as_ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.Save_files_as_ToolStripMenuItem.Text = "Save Files As...";
            this.Save_files_as_ToolStripMenuItem.Click += new System.EventHandler(this.Save_files_as_ToolStripMenuItem_Click);
            // 
            // card_normal_description_groupBox
            // 
            this.card_normal_description_groupBox.Controls.Add(this.card_normal_description_richTextBox);
            this.card_normal_description_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.card_normal_description_groupBox.Location = new System.Drawing.Point(380, 352);
            this.card_normal_description_groupBox.Name = "card_normal_description_groupBox";
            this.card_normal_description_groupBox.Size = new System.Drawing.Size(145, 88);
            this.card_normal_description_groupBox.TabIndex = 8;
            this.card_normal_description_groupBox.TabStop = false;
            this.card_normal_description_groupBox.Text = "[N] Normal Card";
            // 
            // card_rare_description_groupBox
            // 
            this.card_rare_description_groupBox.Controls.Add(this.card_rare_description_richTextBox);
            this.card_rare_description_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(198)))), ((int)(((byte)(105)))));
            this.card_rare_description_groupBox.Location = new System.Drawing.Point(528, 352);
            this.card_rare_description_groupBox.Name = "card_rare_description_groupBox";
            this.card_rare_description_groupBox.Size = new System.Drawing.Size(145, 88);
            this.card_rare_description_groupBox.TabIndex = 8;
            this.card_rare_description_groupBox.TabStop = false;
            this.card_rare_description_groupBox.Text = "[R] Rare Card";
            // 
            // card_premium_description_groupBox
            // 
            this.card_premium_description_groupBox.Controls.Add(this.card_premium_description_richTextBox);
            this.card_premium_description_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(26)))));
            this.card_premium_description_groupBox.Location = new System.Drawing.Point(676, 352);
            this.card_premium_description_groupBox.Name = "card_premium_description_groupBox";
            this.card_premium_description_groupBox.Size = new System.Drawing.Size(145, 88);
            this.card_premium_description_groupBox.TabIndex = 8;
            this.card_premium_description_groupBox.TabStop = false;
            this.card_premium_description_groupBox.Text = "[P] Premium Card";
            // 
            // card_normal_description_richTextBox
            // 
            this.card_normal_description_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.card_normal_description_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.card_normal_description_richTextBox.Location = new System.Drawing.Point(6, 30);
            this.card_normal_description_richTextBox.Name = "card_normal_description_richTextBox";
            this.card_normal_description_richTextBox.ReadOnly = true;
            this.card_normal_description_richTextBox.Size = new System.Drawing.Size(137, 52);
            this.card_normal_description_richTextBox.TabIndex = 0;
            this.card_normal_description_richTextBox.Text = "HP+25\nSuccess Rate: 100%\nCritical Rate: 2%";
            // 
            // card_rare_description_richTextBox
            // 
            this.card_rare_description_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.card_rare_description_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.card_rare_description_richTextBox.Location = new System.Drawing.Point(6, 30);
            this.card_rare_description_richTextBox.Name = "card_rare_description_richTextBox";
            this.card_rare_description_richTextBox.ReadOnly = true;
            this.card_rare_description_richTextBox.Size = new System.Drawing.Size(137, 52);
            this.card_rare_description_richTextBox.TabIndex = 0;
            this.card_rare_description_richTextBox.Text = "HP+45/Strength+1\nSuccess Rate: 100%\nCritical Rate: 4%";
            // 
            // card_premium_description_richTextBox
            // 
            this.card_premium_description_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.card_premium_description_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.card_premium_description_richTextBox.Location = new System.Drawing.Point(6, 30);
            this.card_premium_description_richTextBox.Name = "card_premium_description_richTextBox";
            this.card_premium_description_richTextBox.ReadOnly = true;
            this.card_premium_description_richTextBox.Size = new System.Drawing.Size(137, 52);
            this.card_premium_description_richTextBox.TabIndex = 0;
            this.card_premium_description_richTextBox.Text = "HP+65/Strength+2\nSuccess Rate: 100%\nCritical Rate: 6%";
            // 
            // Highest_rank_pictureBox
            // 
            this.Highest_rank_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Bronze_Rank;
            this.Highest_rank_pictureBox.Location = new System.Drawing.Point(128, 136);
            this.Highest_rank_pictureBox.Name = "Highest_rank_pictureBox";
            this.Highest_rank_pictureBox.Size = new System.Drawing.Size(23, 21);
            this.Highest_rank_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Highest_rank_pictureBox.TabIndex = 59;
            this.Highest_rank_pictureBox.TabStop = false;
            // 
            // Song_icon_ultimatenex_pictureBox
            // 
            this.Song_icon_ultimatenex_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Song_icon_ultimatenex_pictureBox.Image")));
            this.Song_icon_ultimatenex_pictureBox.Location = new System.Drawing.Point(309, 166);
            this.Song_icon_ultimatenex_pictureBox.Name = "Song_icon_ultimatenex_pictureBox";
            this.Song_icon_ultimatenex_pictureBox.Size = new System.Drawing.Size(46, 31);
            this.Song_icon_ultimatenex_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Song_icon_ultimatenex_pictureBox.TabIndex = 3;
            this.Song_icon_ultimatenex_pictureBox.TabStop = false;
            // 
            // Song_icon_ultimate_pictureBox
            // 
            this.Song_icon_ultimate_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Song_icon_ultimate_pictureBox.Image")));
            this.Song_icon_ultimate_pictureBox.Location = new System.Drawing.Point(258, 166);
            this.Song_icon_ultimate_pictureBox.Name = "Song_icon_ultimate_pictureBox";
            this.Song_icon_ultimate_pictureBox.Size = new System.Drawing.Size(28, 31);
            this.Song_icon_ultimate_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Song_icon_ultimate_pictureBox.TabIndex = 3;
            this.Song_icon_ultimate_pictureBox.TabStop = false;
            // 
            // Song_icon_expert_pictureBox
            // 
            this.Song_icon_expert_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Song_icon_expert_pictureBox.Image")));
            this.Song_icon_expert_pictureBox.Location = new System.Drawing.Point(199, 166);
            this.Song_icon_expert_pictureBox.Name = "Song_icon_expert_pictureBox";
            this.Song_icon_expert_pictureBox.Size = new System.Drawing.Size(28, 31);
            this.Song_icon_expert_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Song_icon_expert_pictureBox.TabIndex = 3;
            this.Song_icon_expert_pictureBox.TabStop = false;
            // 
            // Song_icon_basic_pictureBox
            // 
            this.Song_icon_basic_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Song_icon_basic_pictureBox.Image")));
            this.Song_icon_basic_pictureBox.Location = new System.Drawing.Point(141, 166);
            this.Song_icon_basic_pictureBox.Name = "Song_icon_basic_pictureBox";
            this.Song_icon_basic_pictureBox.Size = new System.Drawing.Size(28, 31);
            this.Song_icon_basic_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Song_icon_basic_pictureBox.TabIndex = 3;
            this.Song_icon_basic_pictureBox.TabStop = false;
            // 
            // Progress_star5_pictureBox
            // 
            this.Progress_star5_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Star_Empty;
            this.Progress_star5_pictureBox.Location = new System.Drawing.Point(191, 93);
            this.Progress_star5_pictureBox.Name = "Progress_star5_pictureBox";
            this.Progress_star5_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.Progress_star5_pictureBox.TabIndex = 3;
            this.Progress_star5_pictureBox.TabStop = false;
            // 
            // Progress_star4_pictureBox
            // 
            this.Progress_star4_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Star_Empty;
            this.Progress_star4_pictureBox.Location = new System.Drawing.Point(161, 93);
            this.Progress_star4_pictureBox.Name = "Progress_star4_pictureBox";
            this.Progress_star4_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.Progress_star4_pictureBox.TabIndex = 3;
            this.Progress_star4_pictureBox.TabStop = false;
            // 
            // Progress_star3_pictureBox
            // 
            this.Progress_star3_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Star_Empty;
            this.Progress_star3_pictureBox.Location = new System.Drawing.Point(131, 93);
            this.Progress_star3_pictureBox.Name = "Progress_star3_pictureBox";
            this.Progress_star3_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.Progress_star3_pictureBox.TabIndex = 3;
            this.Progress_star3_pictureBox.TabStop = false;
            // 
            // Progress_star1_pictureBox
            // 
            this.Progress_star1_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Star_Empty;
            this.Progress_star1_pictureBox.Location = new System.Drawing.Point(71, 93);
            this.Progress_star1_pictureBox.Name = "Progress_star1_pictureBox";
            this.Progress_star1_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.Progress_star1_pictureBox.TabIndex = 3;
            this.Progress_star1_pictureBox.TabStop = false;
            // 
            // Progress_star2_pictureBox
            // 
            this.Progress_star2_pictureBox.Image = global::TFFCC_Save_Editor.Properties.Resources.Star_Empty;
            this.Progress_star2_pictureBox.Location = new System.Drawing.Point(101, 93);
            this.Progress_star2_pictureBox.Name = "Progress_star2_pictureBox";
            this.Progress_star2_pictureBox.Size = new System.Drawing.Size(30, 30);
            this.Progress_star2_pictureBox.TabIndex = 3;
            this.Progress_star2_pictureBox.TabStop = false;
            // 
            // Crowns_pictureBox
            // 
            this.Crowns_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Crowns_pictureBox.Image")));
            this.Crowns_pictureBox.Location = new System.Drawing.Point(9, 165);
            this.Crowns_pictureBox.Name = "Crowns_pictureBox";
            this.Crowns_pictureBox.Size = new System.Drawing.Size(26, 18);
            this.Crowns_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Crowns_pictureBox.TabIndex = 23;
            this.Crowns_pictureBox.TabStop = false;
            // 
            // CharEditor_levelResets_picturebox
            // 
            this.CharEditor_levelResets_picturebox.Location = new System.Drawing.Point(69, 19);
            this.CharEditor_levelResets_picturebox.Name = "CharEditor_levelResets_picturebox";
            this.CharEditor_levelResets_picturebox.Size = new System.Drawing.Size(28, 28);
            this.CharEditor_levelResets_picturebox.TabIndex = 2;
            this.CharEditor_levelResets_picturebox.TabStop = false;
            // 
            // CharEditor_character_pictureBox
            // 
            this.CharEditor_character_pictureBox.Location = new System.Drawing.Point(7, 19);
            this.CharEditor_character_pictureBox.Name = "CharEditor_character_pictureBox";
            this.CharEditor_character_pictureBox.Size = new System.Drawing.Size(90, 90);
            this.CharEditor_character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharEditor_character_pictureBox.TabIndex = 0;
            this.CharEditor_character_pictureBox.TabStop = false;
            // 
            // Party4_character_pictureBox
            // 
            this.Party4_character_pictureBox.Location = new System.Drawing.Point(7, 19);
            this.Party4_character_pictureBox.Name = "Party4_character_pictureBox";
            this.Party4_character_pictureBox.Size = new System.Drawing.Size(187, 185);
            this.Party4_character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Party4_character_pictureBox.TabIndex = 0;
            this.Party4_character_pictureBox.TabStop = false;
            // 
            // Party3_character_pictureBox
            // 
            this.Party3_character_pictureBox.Location = new System.Drawing.Point(7, 19);
            this.Party3_character_pictureBox.Name = "Party3_character_pictureBox";
            this.Party3_character_pictureBox.Size = new System.Drawing.Size(187, 185);
            this.Party3_character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Party3_character_pictureBox.TabIndex = 0;
            this.Party3_character_pictureBox.TabStop = false;
            // 
            // Party2_character_pictureBox
            // 
            this.Party2_character_pictureBox.Location = new System.Drawing.Point(7, 19);
            this.Party2_character_pictureBox.Name = "Party2_character_pictureBox";
            this.Party2_character_pictureBox.Size = new System.Drawing.Size(187, 185);
            this.Party2_character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Party2_character_pictureBox.TabIndex = 0;
            this.Party2_character_pictureBox.TabStop = false;
            // 
            // Party1_character_pictureBox
            // 
            this.Party1_character_pictureBox.Location = new System.Drawing.Point(7, 19);
            this.Party1_character_pictureBox.Name = "Party1_character_pictureBox";
            this.Party1_character_pictureBox.Size = new System.Drawing.Size(187, 185);
            this.Party1_character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Party1_character_pictureBox.TabIndex = 0;
            this.Party1_character_pictureBox.TabStop = false;
            // 
            // card_back_pictureBox
            // 
            this.card_back_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("card_back_pictureBox.Image")));
            this.card_back_pictureBox.Location = new System.Drawing.Point(2, 14);
            this.card_back_pictureBox.Name = "card_back_pictureBox";
            this.card_back_pictureBox.Size = new System.Drawing.Size(215, 145);
            this.card_back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_back_pictureBox.TabIndex = 7;
            this.card_back_pictureBox.TabStop = false;
            // 
            // card_rare_pictureBox
            // 
            this.card_rare_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("card_rare_pictureBox.Image")));
            this.card_rare_pictureBox.Location = new System.Drawing.Point(2, 14);
            this.card_rare_pictureBox.Name = "card_rare_pictureBox";
            this.card_rare_pictureBox.Size = new System.Drawing.Size(215, 145);
            this.card_rare_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_rare_pictureBox.TabIndex = 7;
            this.card_rare_pictureBox.TabStop = false;
            // 
            // card_premium_pictureBox
            // 
            this.card_premium_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("card_premium_pictureBox.Image")));
            this.card_premium_pictureBox.Location = new System.Drawing.Point(2, 14);
            this.card_premium_pictureBox.Name = "card_premium_pictureBox";
            this.card_premium_pictureBox.Size = new System.Drawing.Size(215, 145);
            this.card_premium_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_premium_pictureBox.TabIndex = 7;
            this.card_premium_pictureBox.TabStop = false;
            // 
            // card_normal_pictureBox
            // 
            this.card_normal_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("card_normal_pictureBox.Image")));
            this.card_normal_pictureBox.Location = new System.Drawing.Point(2, 14);
            this.card_normal_pictureBox.Name = "card_normal_pictureBox";
            this.card_normal_pictureBox.Size = new System.Drawing.Size(215, 145);
            this.card_normal_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_normal_pictureBox.TabIndex = 7;
            this.card_normal_pictureBox.TabStop = false;
            // 
            // Card_name
            // 
            this.Card_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.Card_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.Card_name.FillWeight = 240F;
            this.Card_name.HeaderText = "Card Name";
            this.Card_name.Name = "Card_name";
            this.Card_name.ReadOnly = true;
            // 
            // Card_normal
            // 
            this.Card_normal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Card_normal.HeaderText = "[N] Normal";
            this.Card_normal.MaxInputLength = 2;
            this.Card_normal.Name = "Card_normal";
            // 
            // Card_rare
            // 
            this.Card_rare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Card_rare.HeaderText = "[R] Rare";
            this.Card_rare.MaxInputLength = 2;
            this.Card_rare.Name = "Card_rare";
            // 
            // Card_premium
            // 
            this.Card_premium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Card_premium.HeaderText = "[P] Premium";
            this.Card_premium.MaxInputLength = 2;
            this.Card_premium.Name = "Card_premium";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.card_normal_pictureBox);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.groupBox2.Location = new System.Drawing.Point(380, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[N] Normal Card";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.card_rare_pictureBox);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(198)))), ((int)(((byte)(105)))));
            this.groupBox3.Location = new System.Drawing.Point(600, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 162);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[R] Rare Card";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.card_premium_pictureBox);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(26)))));
            this.groupBox4.Location = new System.Drawing.Point(380, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 162);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[P] Premium Card";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.card_back_pictureBox);
            this.groupBox5.Location = new System.Drawing.Point(600, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 162);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Card Back";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Item.DefaultCellStyle = dataGridViewCellStyle3;
            this.Item.HeaderText = "Item Name";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MaxInputLength = 2;
            this.Quantity.Name = "Quantity";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Theatrhythm Final Fantasy: Curtain Call - Save Editor v0.26";
            Profile_groupBox.ResumeLayout(false);
            Profile_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rhythmia_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Songs_dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Records_tabPage.ResumeLayout(false);
            this.Battle_party_groupBox.ResumeLayout(false);
            this.Battle_party_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Critical_boosts_achieved_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parameter_boosts_performed_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_used_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Treasure_chests_earned_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Collectacards_obtained_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fat_chocobo_encounters_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abilities_triggered_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Levels_reset_numericUpDown)).EndInit();
            this.Versus_mode_groupBox.ResumeLayout(false);
            this.Versus_mode_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_ties_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_ties_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_losses_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_losses_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_wins_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_wins_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Local_battle_rating_score_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Online_battle_rating_score_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_battle_victories_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_ultimatenex_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_ultimatenex_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_ultimate_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EX_bursts_used_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_expert_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_ultimate_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_local_basic_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_expert_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scores_played_online_basic_numericUpDown)).EndInit();
            this.Quest_medleys_groupBox.ResumeLayout(false);
            this.Quest_medleys_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Keys_used_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stages_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bosses_conquered_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Short_quests_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inherited_quests_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium_quests_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Long_quests_cleared_numericUpDown)).EndInit();
            this.Music_stages_groupBox.ResumeLayout(false);
            this.Music_stages_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_songs_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basic_scores_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expert_scores_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ultimate_scores_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfect_chains_achieved_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily_specials_cleared_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crowns_received_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSS_ranks_received_numericUpDown)).EndInit();
            this.Total_counts_groupBox.ResumeLayout(false);
            this.Total_counts_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_seconds_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_minutes_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_playtime_hours_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Songs_played_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemies_defeated_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance_traveled_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chained_triggers_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Critical_triggers_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfiCards_received_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetPasses_numericUpDown)).EndInit();
            this.Characters_tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_spirit_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_totalCP_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_levelResets_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_stamina_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_luck_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_hp_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_agility_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_magic_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_strength_numericUpDown)).EndInit();
            this.Member3_groupBox.ResumeLayout(false);
            this.Member3_groupBox.PerformLayout();
            this.Member2_groupBox.ResumeLayout(false);
            this.Member2_groupBox.PerformLayout();
            this.Member1_groupBox.ResumeLayout(false);
            this.Member1_groupBox.PerformLayout();
            this.Leader_groupBox.ResumeLayout(false);
            this.Leader_groupBox.PerformLayout();
            this.Items_tabPage.ResumeLayout(false);
            this.Item_quest_med_groupBox.ResumeLayout(false);
            this.Item_equip_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Items_dataGridView)).EndInit();
            this.CollectaCards_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cards_dataGridView)).EndInit();
            this.Songs_tabPage.ResumeLayout(false);
            this.Songs_tabPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.card_normal_description_groupBox.ResumeLayout(false);
            this.card_rare_description_groupBox.ResumeLayout(false);
            this.card_premium_description_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Highest_rank_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_ultimatenex_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_ultimate_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_expert_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Song_icon_basic_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star5_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star4_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star3_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_star2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crowns_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_levelResets_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEditor_character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party4_character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party3_character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party2_character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Party1_character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_back_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_rare_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_premium_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_normal_pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Songs_dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Records_tabPage;
        private System.Windows.Forms.TabPage Songs_tabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_files_ToolStripMenuItem;
        private System.Windows.Forms.TextBox Player_name_textBox;
        private System.Windows.Forms.Label Player_name_label;
        private System.Windows.Forms.Label Rhythmia_label;
        private System.Windows.Forms.NumericUpDown Rhythmia_numericUpDown;
        private System.Windows.Forms.NumericUpDown Expert_scores_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Basic_scores_cleared_numericUpDown;
        private System.Windows.Forms.Label Expert_scores_cleared_label;
        private System.Windows.Forms.Label Basic_scores_cleared_label;
        private System.Windows.Forms.Label Total_songs_cleared_label;
        private System.Windows.Forms.NumericUpDown SSS_ranks_received_numericUpDown;
        private System.Windows.Forms.NumericUpDown Crowns_received_numericUpDown;
        private System.Windows.Forms.NumericUpDown Daily_specials_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Perfect_chains_achieved_numericUpDown;
        private System.Windows.Forms.NumericUpDown Ultimate_scores_cleared_numericUpDown;
        private System.Windows.Forms.Label SSS_ranks_received_label;
        private System.Windows.Forms.Label Crowns_received_label;
        private System.Windows.Forms.Label Daily_specials_cleared_label;
        private System.Windows.Forms.Label Perfect_chains_achieved_label;
        private System.Windows.Forms.Label Ultimate_scores_cleared_label;
        private System.Windows.Forms.NumericUpDown Inherited_quests_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Long_quests_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Medium_quests_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Short_quests_cleared_numericUpDown;
        private System.Windows.Forms.Label Inherited_quests_cleared_label;
        private System.Windows.Forms.Label Long_quests_cleared_label;
        private System.Windows.Forms.Label Medium_quests_cleared_label;
        private System.Windows.Forms.Label Short_quests_cleared_label;
        private System.Windows.Forms.Label Total_quests_cleared_label;
        private System.Windows.Forms.NumericUpDown Scores_played_online_expert_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_online_basic_numericUpDown;
        private System.Windows.Forms.NumericUpDown AI_battle_victories_numericUpDown;
        private System.Windows.Forms.NumericUpDown Keys_used_numericUpDown;
        private System.Windows.Forms.NumericUpDown Stages_cleared_numericUpDown;
        private System.Windows.Forms.NumericUpDown Bosses_conquered_numericUpDown;
        private System.Windows.Forms.NumericUpDown EX_bursts_used_numericUpDown;
        private System.Windows.Forms.Label Scores_played_online_label;
        private System.Windows.Forms.Label AI_battle_victories_label;
        private System.Windows.Forms.Label Keys_used_label;
        private System.Windows.Forms.Label Stages_cleared_label;
        private System.Windows.Forms.Label Bosses_conquered_label;
        private System.Windows.Forms.Label EX_bursts_used_label;
        private System.Windows.Forms.TabPage CollectaCards_tabPage;
        private System.Windows.Forms.TabPage Items_tabPage;
        private System.Windows.Forms.DataGridView Items_dataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Quest_medleys_groupBox;
        private System.Windows.Forms.GroupBox Music_stages_groupBox;
        private System.Windows.Forms.GroupBox Battle_party_groupBox;
        private System.Windows.Forms.GroupBox Versus_mode_groupBox;
        private System.Windows.Forms.NumericUpDown Local_battle_rating_ties_numericUpDown;
        private System.Windows.Forms.NumericUpDown Online_battle_rating_ties_numericUpDown;
        private System.Windows.Forms.NumericUpDown Local_battle_rating_losses_numericUpDown;
        private System.Windows.Forms.NumericUpDown Online_battle_rating_losses_numericUpDown;
        private System.Windows.Forms.NumericUpDown Local_battle_rating_wins_numericUpDown;
        private System.Windows.Forms.NumericUpDown Online_battle_rating_wins_numericUpDown;
        private System.Windows.Forms.NumericUpDown Local_battle_rating_score_numericUpDown;
        private System.Windows.Forms.NumericUpDown Online_battle_rating_score_numericUpDown;
        private System.Windows.Forms.TextBox Total_rating_ties_textBox;
        private System.Windows.Forms.TextBox Total_rating_losses_textBox;
        private System.Windows.Forms.TextBox Total_rating_wins_textBox;
        private System.Windows.Forms.Label Local_battle_rating_label;
        private System.Windows.Forms.Label Online_battle_rating_label;
        private System.Windows.Forms.TextBox Total_rating_score_textBox;
        private System.Windows.Forms.Label Total_rating_label;
        private System.Windows.Forms.ComboBox Highest_rank_comboBox;
        private System.Windows.Forms.Label Highest_rank_label;
        private System.Windows.Forms.Label Levels_resets_label;
        private System.Windows.Forms.Label Collectacards_obtained_label;
        private System.Windows.Forms.NumericUpDown Critical_boosts_achieved_numericUpDown;
        private System.Windows.Forms.Label Parameter_boosts_performed_label;
        private System.Windows.Forms.NumericUpDown Parameter_boosts_performed_numericUpDown;
        private System.Windows.Forms.Label Critical_boosts_achieved_label;
        private System.Windows.Forms.NumericUpDown Items_used_numericUpDown;
        private System.Windows.Forms.Label Items_used_label;
        private System.Windows.Forms.Label Treasure_chests_earned_label;
        private System.Windows.Forms.NumericUpDown Treasure_chests_earned_numericUpDown;
        private System.Windows.Forms.NumericUpDown Collectacards_obtained_numericUpDown;
        private System.Windows.Forms.Label Abilities_triggered_label;
        private System.Windows.Forms.Label Fat_chocobo_encounters_label;
        private System.Windows.Forms.NumericUpDown Fat_chocobo_encounters_numericUpDown;
        private System.Windows.Forms.NumericUpDown Abilities_triggered_numericUpDown;
        private System.Windows.Forms.NumericUpDown Levels_reset_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_online_ultimatenex_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_online_ultimate_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_local_basic_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_local_expert_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_local_ultimate_numericUpDown;
        private System.Windows.Forms.NumericUpDown Scores_played_local_ultimatenex_numericUpDown;
        private System.Windows.Forms.Label Scores_played_local_label;
        private System.Windows.Forms.TextBox Total_quests_cleared_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Progress_label;
        private System.Windows.Forms.TextBox Trophies_textBox;
        private System.Windows.Forms.NumericUpDown Total_songs_cleared_numericUpDown;
        private System.Windows.Forms.ComboBox Highest_rank_class_comboBox;
        private System.Windows.Forms.Label Highest_rank_hash_label;
        private System.Windows.Forms.Label Highest_rank_class_label;
        private System.Windows.Forms.PictureBox Progress_star2_pictureBox;
        private System.Windows.Forms.PictureBox Progress_star5_pictureBox;
        private System.Windows.Forms.PictureBox Progress_star4_pictureBox;
        private System.Windows.Forms.PictureBox Progress_star3_pictureBox;
        private System.Windows.Forms.PictureBox Progress_star1_pictureBox;
        private System.Windows.Forms.PictureBox Song_icon_ultimatenex_pictureBox;
        private System.Windows.Forms.PictureBox Song_icon_ultimate_pictureBox;
        private System.Windows.Forms.PictureBox Song_icon_expert_pictureBox;
        private System.Windows.Forms.PictureBox Song_icon_basic_pictureBox;
        private System.Windows.Forms.GroupBox Total_counts_groupBox;
        private System.Windows.Forms.Label Total_playtime_label;
        private System.Windows.Forms.NumericUpDown Total_playtime_seconds_numericUpDown;
        private System.Windows.Forms.Label Total_playtime_hours_label;
        private System.Windows.Forms.NumericUpDown Total_playtime_minutes_numericUpDown;
        private System.Windows.Forms.Label Total_playtime_minutes_label;
        private System.Windows.Forms.NumericUpDown Total_playtime_hours_numericUpDown;
        private System.Windows.Forms.Label Total_playtime_seconds_label;
        private System.Windows.Forms.Label Songs_played_label;
        private System.Windows.Forms.Label Enemies_defeated_label;
        private System.Windows.Forms.Label Distance_traveled_label;
        private System.Windows.Forms.Label Chained_triggers_label;
        private System.Windows.Forms.Label Critical_triggers_label;
        private System.Windows.Forms.Label ProfiCards_received_label;
        private System.Windows.Forms.Label StreetPasses_label;
        private System.Windows.Forms.NumericUpDown Songs_played_numericUpDown;
        private System.Windows.Forms.NumericUpDown Enemies_defeated_numericUpDown1;
        private System.Windows.Forms.NumericUpDown Distance_traveled_numericUpDown;
        private System.Windows.Forms.NumericUpDown Chained_triggers_numericUpDown;
        private System.Windows.Forms.NumericUpDown Critical_triggers_numericUpDown;
        private System.Windows.Forms.NumericUpDown ProfiCards_received_numericUpDown;
        private System.Windows.Forms.NumericUpDown StreetPasses_numericUpDown;
        private System.Windows.Forms.Label Scores_played_total_label;
        private System.Windows.Forms.Label Total_rating_ties_label;
        private System.Windows.Forms.Label Total_rating_losses_label;
        private System.Windows.Forms.Label Total_rating_wins_label;
        private System.Windows.Forms.Label Total_rating_score_label;
        private System.Windows.Forms.TextBox Scores_played_total_ultimatenex_textBox;
        private System.Windows.Forms.TextBox Scores_played_total_ultimate_textBox;
        private System.Windows.Forms.TextBox Scores_played_total_expert_textBox;
        private System.Windows.Forms.TextBox Scores_played_total_basic_textBox;
        private System.Windows.Forms.ToolStripMenuItem Save_files_ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Chain;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Play_style;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Times_played;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_TImes_cleared;
        private System.Windows.Forms.DataGridViewTextBoxColumn songs_Date;
        private System.Windows.Forms.DataGridView Cards_dataGridView;
        private System.Windows.Forms.Button max_items_button;
        private System.Windows.Forms.Button max_all_cards_button;
        private System.Windows.Forms.Button max_premium_cards_button;
        private System.Windows.Forms.Button max_rare_cards_button;
        private System.Windows.Forms.Button max_normal_cards_button;
        private System.Windows.Forms.TabPage Characters_tabPage;
        private System.Windows.Forms.ToolStripMenuItem Save_files_as_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox Member3_groupBox;
        private System.Windows.Forms.GroupBox Member2_groupBox;
        private System.Windows.Forms.GroupBox Member1_groupBox;
        private System.Windows.Forms.GroupBox Leader_groupBox;
        private System.Windows.Forms.ComboBox Party1_character_comboBox;
        private System.Windows.Forms.PictureBox Party1_character_pictureBox;
        private System.Windows.Forms.Label Party1_ability4_label;
        private System.Windows.Forms.Label Party1_ability2_label;
        private System.Windows.Forms.Label Party1_ability3_label;
        private System.Windows.Forms.Label Party1_ability1_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox CharEditor_levelResets_picturebox;
        private System.Windows.Forms.Label CharEditor_totalCPlabel;
        private System.Windows.Forms.Label CharEditor_levelResets_label;
        private System.Windows.Forms.NumericUpDown CharEditor_spirit_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_totalCP_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_levelResets_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_stamina_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_luck_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_hp_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_agility_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_magic_numericUpDown;
        private System.Windows.Forms.NumericUpDown CharEditor_strength_numericUpDown;
        private System.Windows.Forms.PictureBox CharEditor_character_pictureBox;
        private System.Windows.Forms.ComboBox CharEditor_character_comboBox;
        private System.Windows.Forms.Label CharEditor_spirit_label;
        private System.Windows.Forms.Label CharEditor_stamina_label;
        private System.Windows.Forms.Label CharEditor_luck_label;
        private System.Windows.Forms.Label CharEditor_hp_label;
        private System.Windows.Forms.Label CharEditor_agility_label;
        private System.Windows.Forms.Label CharEditor_magic_label;
        private System.Windows.Forms.Label CharEditor_strength_label;
        private System.Windows.Forms.Label CharEditor_exp_label;
        private System.Windows.Forms.Label CharEditor_character_label;
        private System.Windows.Forms.Label CharEditor_level_label;
        private System.Windows.Forms.TextBox Party1_ability4_textBox;
        private System.Windows.Forms.TextBox Party1_ability2_textBox;
        private System.Windows.Forms.TextBox Party1_ability3_textBox;
        private System.Windows.Forms.TextBox Party1_ability1_textBox;
        private System.Windows.Forms.TextBox Party4_ability4_textBox;
        private System.Windows.Forms.PictureBox Party4_character_pictureBox;
        private System.Windows.Forms.Label Party4_ability1_label;
        private System.Windows.Forms.Label Party4_ability2_label;
        private System.Windows.Forms.TextBox Party4_ability1_textBox;
        private System.Windows.Forms.TextBox Party4_ability2_textBox;
        private System.Windows.Forms.TextBox Party4_ability3_textBox;
        private System.Windows.Forms.Label Party4_ability4_label;
        private System.Windows.Forms.Label Party4_ability3_label;
        private System.Windows.Forms.ComboBox Party4_character_comboBox;
        private System.Windows.Forms.TextBox Party3_ability4_textBox;
        private System.Windows.Forms.PictureBox Party3_character_pictureBox;
        private System.Windows.Forms.Label Party3_ability2_label;
        private System.Windows.Forms.TextBox Party3_ability2_textBox;
        private System.Windows.Forms.Label Party3_ability4_label;
        private System.Windows.Forms.ComboBox Party3_character_comboBox;
        private System.Windows.Forms.Label Party3_ability3_label;
        private System.Windows.Forms.TextBox Party3_ability3_textBox;
        private System.Windows.Forms.TextBox Party3_ability1_textBox;
        private System.Windows.Forms.Label Party3_ability1_label;
        private System.Windows.Forms.TextBox Party2_ability4_textBox;
        private System.Windows.Forms.PictureBox Party2_character_pictureBox;
        private System.Windows.Forms.TextBox Party2_ability2_textBox;
        private System.Windows.Forms.ComboBox Party2_character_comboBox;
        private System.Windows.Forms.TextBox Party2_ability3_textBox;
        private System.Windows.Forms.Label Party2_ability1_label;
        private System.Windows.Forms.TextBox Party2_ability1_textBox;
        private System.Windows.Forms.Label Party2_ability3_label;
        private System.Windows.Forms.Label Party2_ability4_label;
        private System.Windows.Forms.Label Party2_ability2_label;
        private System.Windows.Forms.TextBox CharEditor_exp_textBox;
        private System.Windows.Forms.TextBox CharEditor_level_textBox;
        private System.Windows.Forms.PictureBox Crowns_pictureBox;
        private System.Windows.Forms.PictureBox Highest_rank_pictureBox;
        private System.Windows.Forms.Button Max_all_characters_stats_button;
        private System.Windows.Forms.Button Max_character_stats_button;
        private System.Windows.Forms.GroupBox Item_quest_med_groupBox;
        private System.Windows.Forms.GroupBox Item_equip_groupBox;
        private System.Windows.Forms.RichTextBox Item_equip_richTextBox;
        private System.Windows.Forms.RichTextBox Item_quest_med_richTextBox;
        private System.Windows.Forms.GroupBox card_premium_description_groupBox;
        private System.Windows.Forms.GroupBox card_rare_description_groupBox;
        private System.Windows.Forms.GroupBox card_normal_description_groupBox;
        private System.Windows.Forms.PictureBox card_back_pictureBox;
        private System.Windows.Forms.PictureBox card_rare_pictureBox;
        private System.Windows.Forms.PictureBox card_premium_pictureBox;
        private System.Windows.Forms.PictureBox card_normal_pictureBox;
        private System.Windows.Forms.RichTextBox card_premium_description_richTextBox;
        private System.Windows.Forms.RichTextBox card_rare_description_richTextBox;
        private System.Windows.Forms.RichTextBox card_normal_description_richTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_rare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_premium;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewImageColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}

