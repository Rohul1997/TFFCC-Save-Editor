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

                    //Main songs
                    int Main_count = 0;
                    for (int i = 0x5FD54; i < 0x66F48; i += 0x2C)
                    {
                        var index = Songs_dataGridView.Rows.Add();
                        Songs_dataGridView.Rows[index].Cells["Level_name"].Value = "Unknown";

                        //Read Score value for song
                        br.BaseStream.Position = i;
                        Songs_dataGridView.Rows[index].Cells["Score"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read chain value for song
                        br.BaseStream.Position = i + 0x04;
                        Songs_dataGridView.Rows[index].Cells["Chain"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read status value for song
                        br.BaseStream.Position = i + 0x09;
                        var status = br.ReadByte();
                        if (status == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "All-Critical";
                        }
                        else if (status == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Perfect Chain";
                        }
                        else if (status == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Clear";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unplayed/Unknown";
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
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Unplayed/Unknown";
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

                        ++Main_count;
                    }
                    label1.Text = $"Songs Found: {Main_count}";

                    //DLC songs
                    int DLC_count = 0;
                    for (int i = 0x670D4; i < 0x6A438; i += 0x2C)
                    {
                        var index = Songs_dataGridView.Rows.Add();
                        Songs_dataGridView.Rows[index].Cells["Level_name"].Value = "Unknown";

                        //Read Score value for song
                        br.BaseStream.Position = i;
                        Songs_dataGridView.Rows[index].Cells["Score"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read chain value for song
                        br.BaseStream.Position = i + 0x04;
                        Songs_dataGridView.Rows[index].Cells["Chain"].Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                        //Read status value for song
                        br.BaseStream.Position = i + 0x09;
                        var status = br.ReadByte();
                        if (status == 0x00)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "All-Critical";
                        }
                        else if (status == 0x01)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Perfect Chain";
                        }
                        else if (status == 0x02)
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Clear";
                        }
                        else
                        {
                            Songs_dataGridView.Rows[index].Cells["Status"].Value = "Unplayed/Unknown";
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
                            Songs_dataGridView.Rows[index].Cells["Play_style"].Value = "Unplayed/Unknown";
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

                        ++DLC_count;
                    }
                    label2.Text = $"DLC Songs Found: {DLC_count}";
                    label3.Text = $"Total Songs Found: {Main_count + DLC_count}";
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

                    //Read player name
                    br.BaseStream.Position = 0x12;
                    Player_name_textBox.Text = Encoding.Unicode.GetString(br.ReadBytes(0x0C));

                    //Read Rhythmia
                    br.BaseStream.Position = 0x2C;
                    Rhythmia_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

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

                    //Read total songs
                    br.BaseStream.Position = 0x3780;
                    Total_songs_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read basic scores cleared
                    br.BaseStream.Position = 0x37AC;
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

                    //Read total quests cleared
                    br.BaseStream.Position = 0x37B4;
                    Total_quests_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

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

                    //Read bosses conquered
                    br.BaseStream.Position = 0x37C0;
                    Bosses_conquered_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read stages cleared
                    br.BaseStream.Position = 0x37C4;
                    Stages_cleared_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read keys used
                    br.BaseStream.Position = 0x37C8;
                    Keys_used_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read ai battle victories
                    br.BaseStream.Position = 0x37F6;
                    AI_battle_victories_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read scores played basic
                    br.BaseStream.Position = 0x272A;
                    Scores_played_basic_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read scores played expert
                    br.BaseStream.Position = 0x3750;
                    Scores_played_expert_numericUpDown.Value = BitConverter.ToInt32(br.ReadBytes(0x04), 0);

                    //Read ex bursts used
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
