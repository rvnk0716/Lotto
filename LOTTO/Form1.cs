using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[] tt = new TextBox[3];
        PictureBox[] yy = new PictureBox[3];
        int x = 0, y = 0, a = 0, b = 0, c = 0, d = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, o = 0, p = 0, aa = 0, bb = 0, cc = 0, dd = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            {

                switch (x % 2)
                {
                    case 0:
                        if (pictureBox1.Left < panel1.Width - pictureBox1.Width)
                        {
                            pictureBox1.Left = pictureBox1.Left + 15;

                        }
                        else
                        {
                            x = x + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox1.Left > 0)
                        {
                            pictureBox1.Left = pictureBox1.Left - 15;
                        }
                        else
                        {
                            x = x - 1;
                        }
                        break;
                }
                switch (y % 2)
                {
                    case 0:
                        if (pictureBox1.Top < panel1.Height - pictureBox1.Height)
                        {
                            pictureBox1.Top = pictureBox1.Top + 15;

                        }
                        else
                        {
                            y = y + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox1.Top > 0)
                        {
                            pictureBox1.Top = pictureBox1.Top - 15;

                        }
                        else
                        {
                            y = y - 1;
                        }
                        break;
                }

                switch (a % 2)
                {
                    case 0:
                        if (pictureBox2.Left < panel1.Width - pictureBox2.Width)
                        {
                            pictureBox2.Left = pictureBox2.Left + 15;

                        }
                        else
                        {
                            a = a + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox2.Left > 0)
                        {
                            pictureBox2.Left = pictureBox2.Left - 15;
                        }
                        else
                        {
                            a = a - 1;
                        }
                        break;
                }
                switch (b % 2)
                {
                    case 0:
                        if (pictureBox2.Top < panel1.Height - pictureBox2.Height)
                        {
                            pictureBox2.Top = pictureBox2.Top + 15;

                        }
                        else
                        {
                            b = b + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox2.Top > 0)
                        {
                            pictureBox2.Top = pictureBox2.Top - 15;

                        }
                        else
                        {
                            b = b - 1;
                        }
                        break;
                }

                switch (c % 2)
                {
                    case 0:
                        if (pictureBox3.Left < panel1.Width - pictureBox3.Width)
                        {
                            pictureBox3.Left = pictureBox3.Left + 15;

                        }
                        else
                        {
                            c = c + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox3.Left > 0)
                        {
                            pictureBox3.Left = pictureBox3.Left - 15;
                        }
                        else
                        {
                            c = c - 1;
                        }
                        break;
                }
                switch (d % 2)
                {
                    case 0:
                        if (pictureBox3.Top < panel1.Height - pictureBox3.Height)
                        {
                            pictureBox3.Top = pictureBox3.Top + 15;

                        }
                        else
                        {
                            d = d + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox3.Top > 0)
                        {
                            pictureBox3.Top = pictureBox3.Top - 15;

                        }
                        else
                        {
                            d = d - 1;
                        }
                        break;
                }

                switch (f % 2)
                {
                    case 0:
                        if (pictureBox4.Left < panel1.Width - pictureBox4.Width)
                        {
                            pictureBox4.Left = pictureBox4.Left + 15;

                        }
                        else
                        {
                            f = f + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox4.Left > 0)
                        {
                            pictureBox4.Left = pictureBox4.Left - 15;
                        }
                        else
                        {
                            f = f - 1;
                        }
                        break;
                }
                switch (g % 2)
                {
                    case 0:
                        if (pictureBox4.Top < panel1.Height - pictureBox4.Height)
                        {
                            pictureBox4.Top = pictureBox4.Top + 15;

                        }
                        else
                        {
                            g = g + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox4.Top > 0)
                        {
                            pictureBox4.Top = pictureBox4.Top - 15;

                        }
                        else
                        {
                            g = g - 1;
                        }
                        break;
                }

                switch (h % 2)
                {
                    case 0:
                        if (pictureBox5.Left < panel1.Width - pictureBox5.Width)
                        {
                            pictureBox5.Left = pictureBox5.Left + 15;

                        }
                        else
                        {
                            h = h + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox5.Left > 0)
                        {
                            pictureBox5.Left = pictureBox5.Left - 15;
                        }
                        else
                        {
                            h = h - 1;
                        }
                        break;
                }
                switch (i % 2)
                {
                    case 0:
                        if (pictureBox5.Top < panel1.Height - pictureBox5.Height)
                        {
                            pictureBox5.Top = pictureBox5.Top + 15;
                        }
                        else
                        {
                            i = i + 1;
                        }
                        break;
                    case 1:
                        if (pictureBox5.Top > 0)
                        {
                            pictureBox5.Top = pictureBox5.Top - 15;

                        }
                        else
                        {
                            i = i - 1;
                        }
                        break;

                }
                        switch (j % 2)
                        {
                            case 0:
                                if (pictureBox6.Left < panel1.Width - pictureBox6.Width)
                                {
                                    pictureBox6.Left = pictureBox5.Left + 15;

                                }
                                else
                                {
                                    j = j + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox6.Left > 0)
                                {
                                    pictureBox6.Left = pictureBox6.Left - 15;
                                }
                                else
                                {
                                    j = j - 1;
                                }
                                break;
                        }
                        switch (k % 2)
                        {
                            case 0:
                                if (pictureBox6.Top < panel1.Height - pictureBox6.Height)
                                {
                                    pictureBox6.Top = pictureBox6.Top + 15;
                                }
                                else
                                {
                                    k = k + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox6.Top > 0)
                                {
                                    pictureBox6.Top = pictureBox6.Top - 15;

                                }
                                else
                                {
                                    k = k - 1;
                                }
                                break;
                        }

                        switch (m % 2)
                        {
                            case 0:
                                if (pictureBox7.Left < panel1.Width - pictureBox7.Width)
                                {
                                    pictureBox7.Left = pictureBox7.Left + 15;

                                }
                                else
                                {
                                    m = m + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox7.Left > 0)
                                {
                                    pictureBox7.Left = pictureBox7.Left - 15;
                                }
                                else
                                {
                                    m = m - 1;
                                }
                                break;
                        }
                        switch (n % 2)
                        {
                            case 0:
                                if (pictureBox7.Top < panel1.Height - pictureBox7.Height)
                                {
                                    pictureBox7.Top = pictureBox7.Top + 15;
                                }
                                else
                                {
                                    n = n + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox7.Top > 0)
                                {
                                    pictureBox7.Top = pictureBox7.Top - 15;

                                }
                                else
                                {
                                    n = n - 1;
                                }
                                break;
                        }

                //------------------------------------------------------------------------------------------------------------
                        switch (o % 2)
                        {
                            case 0:
                                if (pictureBox8.Left < panel1.Width - pictureBox8.Width)
                                {
                                    pictureBox8.Left = pictureBox8.Left + 15;

                                }
                                else
                                {
                                    o = o + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox8.Left > 0)
                                {
                                    pictureBox8.Left = pictureBox8.Left - 15;
                                }
                                else
                                {
                                    o = o - 1;
                                }
                                break;
                        }
                        switch (p % 2)
                        {
                            case 0:
                                if (pictureBox8.Top < panel1.Height - pictureBox8.Height)
                                {
                                    pictureBox8.Top = pictureBox8.Top + 15;
                                }
                                else
                                {
                                    p = p + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox8.Top > 0)
                                {
                                    pictureBox8.Top = pictureBox8.Top - 15;

                                }
                                else
                                {
                                    p = p - 1;
                                }
                                break;
                        }

                        switch (aa % 2)
                        {
                            case 0:
                                if (pictureBox9.Left < panel1.Width - pictureBox9.Width)
                                {
                                    pictureBox9.Left = pictureBox9.Left + 15;

                                }
                                else
                                {
                                    aa = aa + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox9.Left > 0)
                                {
                                    pictureBox9.Left = pictureBox9.Left - 15;
                                }
                                else
                                {
                                    aa = aa - 1;
                                }
                                break;
                        }
                        switch (bb % 2)
                        {
                            case 0:
                                if (pictureBox9.Top < panel1.Height - pictureBox9.Height)
                                {
                                    pictureBox9.Top = pictureBox9.Top + 15;
                                }
                                else
                                {
                                    bb = bb + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox9.Top > 0)
                                {
                                    pictureBox9.Top = pictureBox9.Top - 15;

                                }
                                else
                                {
                                    bb = bb - 1;
                                }
                                break;
                        }

                        switch (cc % 2)
                        {
                            case 0:
                                if (pictureBox10.Left < panel1.Width - pictureBox10.Width)
                                {
                                    pictureBox10.Left = pictureBox10.Left + 15;

                                }
                                else
                                {
                                    cc = cc + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox10.Left > 0)
                                {
                                    pictureBox10.Left = pictureBox10.Left - 15;
                                }
                                else
                                {
                                    cc = cc - 1;
                                }
                                break;
                        }
                        switch (dd % 2)
                        {
                            case 0:
                                if (pictureBox10.Top < panel1.Height - pictureBox10.Height)
                                {
                                    pictureBox10.Top = pictureBox10.Top + 15;
                                }
                                else
                                {
                                    dd = dd + 1;
                                }
                                break;
                            case 1:
                                if (pictureBox10.Top > 0)
                                {
                                    pictureBox10.Top = pictureBox10.Top - 15;

                                }
                                else
                                {
                                    dd = dd - 1;
                                }
                                break;
                        }




                 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            PictureBox[] boxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10};
            for (int i = 0; i < boxes.Length; i++)
            {
                GraphicsPath gp2 = new GraphicsPath();

                gp2.AddEllipse(boxes[i].ClientRectangle);

                Region region2 = new Region(gp2);

                boxes[i].Region = region2;

                gp2.Dispose();

                region2.Dispose();
            }
           
            GraphicsPath gp3 = new GraphicsPath();

            gp3.AddEllipse(panel1.ClientRectangle);

            Region region3 = new Region(gp3);

            panel1.Region = region3;

            gp3.Dispose();

            region3.Dispose();
          
            Font font = new Font("Times New Roman", 30 );
            for (int i = 0; i < 3; i++)
            {
                
              
                tt[i] = new TextBox();
                tt[i].Size = new Size(55, 33);
                tt[i].Font = font;
                tt[i].Location = new Point(490 + 90 * i, 150);
                this.Controls.Add(tt[i]);
                yy[i] = new PictureBox();
                yy[i].Size = new Size(35, 35);
                yy[i].Location = new Point(100 + 85 * i, 92);
                yy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(yy[i]);
            }                   
        }


        bool isStart = false;
        private void button1_Click(object sender, EventArgs e)
        {
            isStart = !isStart;
           
                PictureBox[] boxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
                boxes[0] = pictureBox1; boxes[1] = pictureBox2; boxes[2] = pictureBox3; boxes[3] = pictureBox4; boxes[4] = pictureBox5; boxes[5] = pictureBox6; boxes[6] = pictureBox7; boxes[0] = pictureBox8; boxes[8] = pictureBox9; boxes[9] = pictureBox10;
                bool c = false;


                for (int i = 0; i < 3; i++)
                {
                    tt[i].ForeColor = Color.Black;
                }
                for (int i = 0; i < 10; i++)
                {
                    boxes[i].Visible = true;
                }
                foreach (var text in tt)//檢查有沒有輸入數字
                {
                    if (text.Text == "") c = true;

                }
                if (c == true) MessageBox.Show("請先輸入完三個數字!!", "警告");
                else if (tt[0].Text == tt[1].Text || tt[0].Text == tt[2].Text || tt[1].Text == tt[2].Text) { MessageBox.Show("請檢查有沒有輸入重複的數字"); }
                else if (isStart)
                {
                    button1.Enabled = false;
                    button1.Text = "重新開獎!!";
                    label1.Visible = false;
                    Random r = new Random();
                    int[] randomize = new int[3];
                    PictureBox[] array = new PictureBox[3];
                    array[0] = pictureBox11;
                    array[1] = pictureBox12;
                    array[2] = pictureBox13;
                    int g = 0;
                    string con = ""; string con2 = ""; string con3 = "";               
                    for (int i = 0; i < 3; i++)
                    {
                        randomize[i] = r.Next(0, 10);
                        bool f = true;
                        for (int j = 0; j < i; j++)
                        {

                            if (randomize[j] == randomize[i]) f = false;
                        }
                        if (f == true)
                            randomize[i] = randomize[i];
                        else i--;
                        boxes[randomize[i]].Visible = false;
                        array[i].Image = imageList1.Images[randomize[i]];
                        yy[i].Image = imageList1.Images[randomize[i]];
                        con = (randomize[0] + 1).ToString() + "  ";
                        con2 = (randomize[1] + 1).ToString() + "  ";
                        con3 = (randomize[2] + 1).ToString() + "  ";
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (int.Parse((randomize[i] + 1).ToString()) == int.Parse(tt[j].Text)) { g++; tt[j].ForeColor = Color.Red; }
                        }

                    }

                    label4.Text = "中了" + g.ToString() + "個數字!!";

                    if (g == 0)
                    {
                        label4.Text = "都沒中........";
                      
                        pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\銘謝惠顧.png");
                    }


                    if (g == 1)
                    {                      
                        pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\小錢.png");
                    }

                    if (g == 2)
                    {                 
                        pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\中錢.png");
                    }

                    if (g == 3)
                    {
                        MessageBox.Show("中大獎了!");
                        label4.Text = "全中了!!";                    
                        pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\大錢.png");
                    }


                    label2.Text = "開獎號碼為:" + con;
                    label5.Text = con2; label6.Text = con3;
                    label3.Visible = false;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                    zz = 0;
                }else{
                    zz = 0;
                    button1.Text = "開獎!!";
                    label3.Text = "祝您再次中獎!!";                
                    label3.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    label6.Visible = false;
                    label5.Visible = false;
                    label2.Visible = false;
                    label4.Visible = false;
                    timer2.Stop();
                    timer3.Stop();
                                                  
            }
     
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
          
        int zz = 0;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
           
            zz++;
            if (zz > 60)
                for (int i = 0; i < 3; i++)
                {
                    yy[i].Left+=2;
                 
                }
            
            if (zz == 263)
            {
                timer2.Enabled = false;
                label6.Visible = true;
                label5.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
            }
           
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            for (int i = 0; i < 3; i++)
            {
                yy[i].Location = new Point(100 + 85 * i, 92);
            }     
        }
    }
}
