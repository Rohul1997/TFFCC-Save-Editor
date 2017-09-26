using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TFFCC_Save_Editor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        OpenFileDialog open = new OpenFileDialog();
        OpenFileDialog open_main = new OpenFileDialog();

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                open.Filter = " extsavedata.bk Files |extsavedata.bk|All Files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(open.FileName));
                    int count = 0;
                    for (int i = 0x5FD54; i < 0x66EEF; i += 0x2C)
                    {
                        var index = Songs_dataGridView.Rows.Add();
                        br.BaseStream.Position = i;
                        Songs_dataGridView.Rows[index].Cells["Level_name"].Value = "Unknown";
                        Songs_dataGridView.Rows[index].Cells["Points"].Value = br.ReadInt32();

                        br.BaseStream.Position = i;
                        var currentBytes = br.ReadBytes(0x2C);
                        Songs_dataGridView.Rows[index].Cells["Chain"].Value = currentBytes[0x04];

                        if (currentBytes[0x0A] == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Stylus";
                        }
                        else if (currentBytes[0x0A] == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Button";
                        }
                        else if (currentBytes[0x0A] == 0x03)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Hybrid";
                        }
                        else if (currentBytes[0x0A] == 0x04)
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "One-Handed";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Unplayed/Unknown";
                        }

                        Songs_dataGridView.Rows[index].Cells["Times_played"].Value = currentBytes[0x0C];
                        Songs_dataGridView.Rows[index].Cells["Times_cleared"].Value = currentBytes[0x10];
                        ++count;
                    }
                    label1.Text = $"Songs Found: {count}";
                    br.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid extsavedata.bk", "Failed to open the file");
            }
        }

        private void Open_main_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                open_main.Filter = " savedata.bk Files |savedata.bk|All Files (*.*)|*.*";
                if (open_main.ShowDialog() == DialogResult.OK)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(open_main.FileName));
                    br.BaseStream.Position = 0x12;
                    Name_textBox.Text = Encoding.Unicode.GetString(br.ReadBytes(0x0C));

                    br.BaseStream.Position = 0x2C;
                    Rhythmia_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x38;
                    TimeSpan time = TimeSpan.FromSeconds(BitConverter.ToInt32(br.ReadBytes(0x04), 0));
                    Total_playtime_hours_numericUpDown.Value = Convert.ToInt16(Math.Floor(time.TotalHours));
                    Total_playtime_minutes_numericUpDown.Value = time.Minutes;
                    Total_playtime_seconds_numericUpDown.Value = time.Seconds;

                    br.BaseStream.Position = 0x3738;
                    Songs_played_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x373C;
                    Enemies_defeated_numericUpDown1.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3740;
                    Distance_traveled_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3748;
                    Chained_triggers_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x374C;
                    Critical_triggers_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3750;
                    ProfiCards_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3754;
                    StreetPasses_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    br.BaseStream.Position = 0x3780;
                    Total_songs_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37AC;
                    Basic_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3788;
                    Expert_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x378C;
                    Ultimate_scores_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3790;
                    Perfect_chains_achieved_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3794;
                    Daily_specials_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3798;
                    Crowns_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x379C;
                    SSS_ranks_received_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37B4;
                    Total_quests_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37B8;
                    Short_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    br.BaseStream.Position = 0x37BA;
                    Medium_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    br.BaseStream.Position = 0x37BC;
                    Long_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    br.BaseStream.Position = 0x37BE ;
                    Inherited_quests_cleared_numericUpDown.Value = BitConverter.ToInt16(br.ReadBytes(0x02), 0);

                    br.BaseStream.Position = 0x37C0;
                    Bosses_conquered_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37C4;
                    Stages_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37C8;
                    Keys_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x37F6;
                    AI_battle_victories_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x272A;
                    Scores_played_basic_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3750;
                    Scores_played_expert_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    br.BaseStream.Position = 0x3810;
                    EX_bursts_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);
                }
            }
            catch
            {
                MessageBox.Show("Invalid savedata.bk", "Failed to open the file");
            }
        }
    }
}
