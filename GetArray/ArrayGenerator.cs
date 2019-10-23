using System;
using System.Drawing;
using System.Windows.Forms;

namespace GetArray
{
    public partial class ArrayGenerator : Form
    {
        bool[] ClickArray = new bool[64];
        public ArrayGenerator()
        {
            InitializeComponent();
            for (int i = 0; i < ClickArray.Length; i++) ClickArray[i] = false;
        }
        private void set_color(PictureBox box,bool clicked)
        {
            if (clicked == true)
                box.BackColor = Color.Red;
            else box.BackColor = Color.White;
        }
        private void Create_Click(object sender, EventArgs e)
        {
            array.Clear();
            array.Text = "int "+ arrayName.Text+ "\t[8][8]={";
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                array.Text += "{";
                for (int j = 0; j < 8; j++)
                {
                    if (j == 7) { if (ClickArray[count] == true) array.Text += "1"; if (ClickArray[count] == false) array.Text += "0"; }
                    else { if (ClickArray[count] == true) array.Text += "1,"; if (ClickArray[count] == false) array.Text += "0,"; }
                    count++;
                }
                if(i==7) array.Text += "}"; else array.Text += "},";
            }
            array.Text += "};";
            Select(true,false);
            array.SelectAll();
        }
        private void PictureBox1_Click(object sender, EventArgs e) { ClickArray[0] = !ClickArray[0]; set_color(pictureBox1, ClickArray[0]); }
        private void PictureBox2_Click(object sender, EventArgs e) { ClickArray[1] = !ClickArray[1]; set_color(pictureBox2, ClickArray[1]); }
        private void PictureBox3_Click(object sender, EventArgs e) { ClickArray[2] = !ClickArray[2]; set_color(pictureBox3, ClickArray[2]); }
        private void PictureBox4_Click(object sender, EventArgs e) { ClickArray[3] = !ClickArray[3]; set_color(pictureBox4, ClickArray[3]); }
        private void PictureBox5_Click(object sender, EventArgs e) { ClickArray[4] = !ClickArray[4]; set_color(pictureBox5, ClickArray[4]); }
        private void PictureBox6_Click(object sender, EventArgs e) { ClickArray[5] = !ClickArray[5]; set_color(pictureBox6, ClickArray[5]); }
        private void PictureBox7_Click(object sender, EventArgs e) { ClickArray[6] = !ClickArray[6]; set_color(pictureBox7, ClickArray[6]); }
        private void PictureBox8_Click(object sender, EventArgs e) { ClickArray[7] = !ClickArray[7]; set_color(pictureBox8, ClickArray[7]); }
        private void PictureBox9_Click(object sender, EventArgs e) { ClickArray[8] = !ClickArray[8]; set_color(pictureBox9, ClickArray[8]); }
        private void PictureBox10_Click(object sender, EventArgs e) { ClickArray[9] = !ClickArray[9]; set_color(pictureBox10, ClickArray[9]); }
        private void PictureBox11_Click(object sender, EventArgs e) { ClickArray[10] = !ClickArray[10]; set_color(pictureBox11, ClickArray[10]); }
        private void PictureBox12_Click(object sender, EventArgs e) { ClickArray[11] = !ClickArray[11]; set_color(pictureBox12, ClickArray[11]); }
        private void PictureBox13_Click(object sender, EventArgs e) { ClickArray[12] = !ClickArray[12]; set_color(pictureBox13, ClickArray[12]); }
        private void PictureBox14_Click(object sender, EventArgs e) { ClickArray[13] = !ClickArray[13]; set_color(pictureBox14, ClickArray[13]); }
        private void PictureBox15_Click(object sender, EventArgs e) { ClickArray[14] = !ClickArray[14]; set_color(pictureBox15, ClickArray[14]); }
        private void PictureBox16_Click(object sender, EventArgs e) { ClickArray[15] = !ClickArray[15]; set_color(pictureBox16, ClickArray[15]); }
        private void PictureBox17_Click(object sender, EventArgs e) { ClickArray[16] = !ClickArray[16]; set_color(pictureBox17, ClickArray[16]); }
        private void PictureBox18_Click(object sender, EventArgs e) { ClickArray[17] = !ClickArray[17]; set_color(pictureBox18, ClickArray[17]); }
        private void PictureBox19_Click(object sender, EventArgs e) { ClickArray[18] = !ClickArray[18]; set_color(pictureBox19, ClickArray[18]); }
        private void PictureBox20_Click(object sender, EventArgs e) { ClickArray[19] = !ClickArray[19]; set_color(pictureBox20, ClickArray[19]); }
        private void PictureBox21_Click(object sender, EventArgs e) { ClickArray[20] = !ClickArray[20]; set_color(pictureBox21, ClickArray[20]); }
        private void PictureBox22_Click(object sender, EventArgs e) { ClickArray[21] = !ClickArray[21]; set_color(pictureBox22, ClickArray[21]); }
        private void PictureBox23_Click(object sender, EventArgs e) { ClickArray[22] = !ClickArray[22]; set_color(pictureBox23, ClickArray[22]); }
        private void PictureBox24_Click(object sender, EventArgs e) { ClickArray[23] = !ClickArray[23]; set_color(pictureBox24, ClickArray[23]); }
        private void PictureBox25_Click(object sender, EventArgs e) { ClickArray[24] = !ClickArray[24]; set_color(pictureBox25, ClickArray[24]); }
        private void PictureBox26_Click(object sender, EventArgs e) { ClickArray[25] = !ClickArray[25]; set_color(pictureBox26, ClickArray[25]); }
        private void PictureBox27_Click(object sender, EventArgs e) { ClickArray[26] = !ClickArray[26]; set_color(pictureBox27, ClickArray[26]); }
        private void PictureBox28_Click(object sender, EventArgs e) { ClickArray[27] = !ClickArray[27]; set_color(pictureBox28, ClickArray[27]); }
        private void PictureBox29_Click(object sender, EventArgs e) { ClickArray[28] = !ClickArray[28]; set_color(pictureBox29, ClickArray[28]); }
        private void PictureBox30_Click(object sender, EventArgs e) { ClickArray[29] = !ClickArray[29]; set_color(pictureBox30, ClickArray[29]); }
        private void PictureBox31_Click(object sender, EventArgs e) { ClickArray[30] = !ClickArray[30]; set_color(pictureBox31, ClickArray[30]); }
        private void PictureBox32_Click(object sender, EventArgs e) { ClickArray[31] = !ClickArray[31]; set_color(pictureBox32, ClickArray[31]); }
        private void PictureBox33_Click(object sender, EventArgs e) { ClickArray[32] = !ClickArray[32]; set_color(pictureBox33, ClickArray[32]); }
        private void PictureBox34_Click(object sender, EventArgs e) { ClickArray[33] = !ClickArray[33]; set_color(pictureBox34, ClickArray[33]); }
        private void PictureBox35_Click(object sender, EventArgs e) { ClickArray[34] = !ClickArray[34]; set_color(pictureBox35, ClickArray[34]); }
        private void PictureBox36_Click(object sender, EventArgs e) { ClickArray[35] = !ClickArray[35]; set_color(pictureBox36, ClickArray[35]); }
        private void PictureBox37_Click(object sender, EventArgs e) { ClickArray[36] = !ClickArray[36]; set_color(pictureBox37, ClickArray[36]); }
        private void PictureBox38_Click(object sender, EventArgs e) { ClickArray[37] = !ClickArray[37]; set_color(pictureBox38, ClickArray[37]); }
        private void PictureBox39_Click(object sender, EventArgs e) { ClickArray[38] = !ClickArray[38]; set_color(pictureBox39, ClickArray[38]); }
        private void PictureBox40_Click(object sender, EventArgs e) { ClickArray[39] = !ClickArray[39]; set_color(pictureBox40, ClickArray[39]); }
        private void PictureBox41_Click(object sender, EventArgs e) { ClickArray[40] = !ClickArray[40]; set_color(pictureBox41, ClickArray[40]); }
        private void PictureBox42_Click(object sender, EventArgs e) { ClickArray[41] = !ClickArray[41]; set_color(pictureBox42, ClickArray[41]); }
        private void PictureBox43_Click(object sender, EventArgs e) { ClickArray[42] = !ClickArray[42]; set_color(pictureBox43, ClickArray[42]); }
        private void PictureBox44_Click(object sender, EventArgs e) { ClickArray[43] = !ClickArray[43]; set_color(pictureBox44, ClickArray[43]); }
        private void PictureBox45_Click(object sender, EventArgs e) { ClickArray[44] = !ClickArray[44]; set_color(pictureBox45, ClickArray[44]); }
        private void PictureBox46_Click(object sender, EventArgs e) { ClickArray[45] = !ClickArray[45]; set_color(pictureBox46, ClickArray[45]); }
        private void PictureBox47_Click(object sender, EventArgs e) { ClickArray[46] = !ClickArray[46]; set_color(pictureBox47, ClickArray[46]); }
        private void PictureBox48_Click(object sender, EventArgs e) { ClickArray[47] = !ClickArray[47]; set_color(pictureBox48, ClickArray[47]); }
        private void PictureBox49_Click(object sender, EventArgs e) { ClickArray[48] = !ClickArray[48]; set_color(pictureBox49, ClickArray[48]); }
        private void PictureBox50_Click(object sender, EventArgs e) { ClickArray[49] = !ClickArray[49]; set_color(pictureBox50, ClickArray[49]); }
        private void PictureBox51_Click(object sender, EventArgs e) { ClickArray[50] = !ClickArray[50]; set_color(pictureBox51, ClickArray[50]); }
        private void PictureBox52_Click(object sender, EventArgs e) { ClickArray[51] = !ClickArray[51]; set_color(pictureBox52, ClickArray[51]); }
        private void PictureBox53_Click(object sender, EventArgs e) { ClickArray[52] = !ClickArray[52]; set_color(pictureBox53, ClickArray[52]); }
        private void PictureBox54_Click(object sender, EventArgs e) { ClickArray[53] = !ClickArray[53]; set_color(pictureBox54, ClickArray[53]); }
        private void PictureBox55_Click(object sender, EventArgs e) { ClickArray[54] = !ClickArray[54]; set_color(pictureBox55, ClickArray[54]); }
        private void PictureBox56_Click(object sender, EventArgs e) { ClickArray[55] = !ClickArray[55]; set_color(pictureBox56, ClickArray[55]); }
        private void PictureBox57_Click(object sender, EventArgs e) { ClickArray[56] = !ClickArray[56]; set_color(pictureBox57, ClickArray[56]); }
        private void PictureBox58_Click(object sender, EventArgs e) { ClickArray[57] = !ClickArray[57]; set_color(pictureBox58, ClickArray[57]); }
        private void PictureBox59_Click(object sender, EventArgs e) { ClickArray[58] = !ClickArray[58]; set_color(pictureBox59, ClickArray[58]); }
        private void PictureBox60_Click(object sender, EventArgs e) { ClickArray[59] = !ClickArray[59]; set_color(pictureBox60, ClickArray[59]); }
        private void PictureBox61_Click(object sender, EventArgs e) { ClickArray[60] = !ClickArray[60]; set_color(pictureBox61, ClickArray[60]); }
        private void PictureBox62_Click(object sender, EventArgs e) { ClickArray[61] = !ClickArray[61]; set_color(pictureBox62, ClickArray[61]); }
        private void PictureBox63_Click(object sender, EventArgs e) { ClickArray[62] = !ClickArray[62]; set_color(pictureBox63, ClickArray[62]); }
        private void PictureBox64_Click(object sender, EventArgs e) { ClickArray[63] = !ClickArray[63]; set_color(pictureBox64, ClickArray[63]); }        
    }
}
