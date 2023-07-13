using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFLEXION
{
    public partial class Form1 : Form
    {
        private Pen mypen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void class11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void class11_Click_1(object sender, EventArgs e)
        {
            button1.Location = new Point(class11.Location.X + 25, class11.Location.Y + 25);
            class11.Invalidate();
            button1.Invalidate();
            button1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            g.DrawLine(p, panel3.Width - 10, 140, panel3.Width - 10, 152);
            g.DrawLine(p, panel3.Width - 10, 160, panel3.Width - 10, 172);

            g.DrawLine(p, panel3.Width - 10, 100, panel3.Width - 10, 112);
            g.DrawLine(p, panel3.Width - 10, 120, panel3.Width - 10, 132);
            g.DrawLine(p, panel3.Width - 10, 180, panel3.Width - 10, 192);
            g.DrawLine(p, panel3.Width - 10, 200, panel3.Width - 10, 212);
            g.DrawLine(p, panel3.Width - 10, 220, panel3.Width - 10, 232);
            g.DrawLine(p, panel3.Width - 10, 240, panel3.Width - 10, 252);
            g.DrawLine(p, panel3.Width - 10, 260, panel3.Width - 10, 272);
            g.DrawLine(p, panel3.Width - 10, 280, panel3.Width - 10, 292);
            g.DrawLine(p, panel3.Width - 10, 300, panel3.Width - 10, 312);
            g.DrawLine(p, panel3.Width - 10, 320, panel3.Width - 10, 332);
            g.DrawLine(p, panel3.Width - 10, 340, panel3.Width - 10, 352);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            g.DrawLine(p, panel3.Width - 10, 0, panel3.Width - 10, 12);
            g.DrawLine(p, panel3.Width - 10, 20, panel3.Width - 10, 32);

            g.DrawLine(p, panel3.Width - 10, 40, panel3.Width - 10, 52);
            g.DrawLine(p, panel3.Width - 10, 60, panel3.Width - 10, 72);
            g.DrawLine(p, panel3.Width - 10, 80, panel3.Width - 10, 92);
            g.DrawLine(p, panel3.Width - 10, 100, panel3.Width - 10, 112);
            g.DrawLine(p, panel3.Width - 10, 120, panel3.Width - 10, 132);
            g.DrawLine(p, panel3.Width - 10, 140, panel3.Width - 10, 152);
            g.DrawLine(p, panel3.Width - 10, 160, panel3.Width - 10, 172);
            g.DrawLine(p, panel3.Width - 10, 180, panel3.Width - 10, 192);
            g.DrawLine(p, panel3.Width - 10, 200, panel3.Width - 10, 222);
            g.DrawLine(p, panel3.Width - 10, 220, panel3.Width - 10, 242);
            g.DrawLine(p, panel3.Width - 10, 240, panel3.Width - 10, 262);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                {
                    double v;
                    v = Convert.ToDouble(textBox1.Text);
                    if (v == 1)
                    {
                        panel1.BackColor = Color.White;
                        panel3.BackColor = Color.White;
                        label3.Text = "Air";
                        label3.Visible = true;
                    }
                    else
                    {
                        if ((v > 1) && (v < 1.33))
                        {
                            panel1.BackColor = Color.LightBlue;
                            panel3.BackColor = Color.LightBlue;
                            label3.Text = "Air";
                            label3.Visible = true;

                        }
                        else

                        {
                            if (v == 1.33)
                            {
                                panel1.BackColor = Color.AliceBlue;
                                panel3.BackColor = Color.AliceBlue;
                                label3.Text = "Eau";
                                label3.Visible = true;

                            }
                            else
                            {
                                if ((v > 1.33) && (v < 1.5))
                                {
                                    panel1.BackColor = Color.SkyBlue;
                                    panel3.BackColor = Color.SkyBlue;
                                    label3.Text = "Eau";
                                    label3.Visible = true;

                                }
                                else
                                {
                                    if (v > 1.5)
                                    {
                                       
                                        panel1.BackColor = Color.Thistle;
                                        panel3.BackColor = Color.Thistle;
                                        label3.Text = "Verre";
                                        label3.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                panel1.BackColor = Color.White;
                panel3.BackColor = Color.White;
                label3.Text = "";
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {

                {
                    
                    double v;
                    v = Convert.ToDouble(textBox2.Text);
                    if (v == 1)
                    {
                        panel2.BackColor = Color.White;
                        label4.Text = "Air";
                        label4.Visible = true;
                       
                    }
                    else
                    {
                        if ((v > 1) && (v < 1.33))
                        {
                            panel2.BackColor = Color.LightBlue;

                            label4.Text = "Air";
                            label4.Visible = true;

                        }
                        else

                        {
                            if (v == 1.33)
                            {
                                panel2.BackColor = Color.AliceBlue;

                                label4.Text = "Eau";
                                label4.Visible = true;

                            }
                            else
                            {
                                if ((v > 1.33) && (v < 1.5))
                                {
                                    panel2.BackColor = Color.SkyBlue;

                                    label4.Text = "Eau";
                                    label4.Visible = true;

                                }
                                else
                                {
                                    if (v > 1.5)
                                    {
                                        panel2.BackColor = Color.Thistle;

                                        label4.Text = "Verre";
                                        label4.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }label7.BackColor = panel2.BackColor;
            }
            catch (Exception)
            {
                panel2.BackColor = Color.LightBlue;
                label4.Text = "";
                label7.BackColor = panel2.BackColor; 

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        bool drawline = false; 
        private async void button1_Click(object sender, EventArgs e)
        {
           
            int start = button1.Location.X; int end = button1.Location.Y; 
            try
            {
               Pen pen1= null ;// = new Pen(Color.Red, 3);
                //pen1?.Dispose();
                //int locationx = button1.Location.X;
                //int locationy = button1.Location.Y;
              //  if (pen1 != null)
                {
                    drawline = true; 
                    System.Drawing.Pen mypen;
                    mypen = new System.Drawing.Pen(System.Drawing.Color.Red, 0);
                    mypen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    System.Drawing.Graphics g = panel3.CreateGraphics();
                    System.Drawing.Graphics g2 = panel1.CreateGraphics();
                    g2.DrawLine(mypen, button1.Location.X, button1.Location.Y, label5.Location.X, label5.Location.Y);
                    double v = Math.Atan2(Math.Abs(label5.Location.Y - button1.Location.Y),
                                                   (float)Math.Abs(label5.Location.X - button1.Location.X));
                    label6.Text = ((int)(90 - (v * 180 / Math.PI))).ToString();
                    label6.Visible = true;
                    //int v1 = (int)(label5.Location.Y - button1.Location.Y) / (label5.Location.X - button1.Location.X);
                    //g.DrawLine(mypen, label5.Location.X, (float)((double)(Math.Tan(v) + 1) * (label5.Location.Y)), 700, (float)((double)(Math.Tan(v) + 1) * 700));
                    float x = (float)(250 * Math.Cos(v));
                    float y = (float)(panel3.Height - 250 * Math.Sin(v));
                    g.DrawLine(mypen, x, y, 0, panel3.Height);
                    System.Drawing.Graphics g1 = panel4.CreateGraphics();
                    // calculer angle de refraction 
                    float n1 = (float)Convert.ToDouble(textBox1.Text);
                    float n2 = (float)Convert.ToDouble(textBox2.Text);

                    float sini = (float)((n1 / n2) * Math.Sin(v));
                    float angle = (float)Math.Asin(sini);
                    float lenght = 100;
                    float x2 = (float)(lenght * Math.Cos(angle));
                    float y2 = (float)(+lenght * (float)Math.Sin(angle));
                    g1.DrawLine(mypen, x2, y2, 0, 0);
                    label7.Text = ((int)(90 - angle * 180 / Math.PI)).ToString();
                    label7.Visible = true;
                    mypen.Dispose();
                }
                if (drawline)
                {
                    await Task.Delay(10000);
                    panel1.Invalidate();
                    panel2.Invalidate()
    ;
                    panel4.Invalidate();
                    panel3.Invalidate();
                    drawline = false;
                    label7.Text = "";
                    label6.Text = "";

                }

                if (start != class11.Location.X && end != button1.Location.Y)
                {
                    //panel1.BackColor = panel1.BackColor;
                    //panel2.BackColor = panel2.BackColor;

                    drawline = true;

                    //                panel1.Invalidate();
                    //                panel2.Invalidate()
                    //;
                    //                panel4.Invalidate();
                    //                panel3.Invalidate();
                }
                else drawline = false; 
                start  = button1.Location.X; end  = button1.Location.Y; 
                
                // pen1 = mypen; 
                //  pen1 = mypen; 
                //g.Dispose();
                //g1.Dispose();
                //g2.Dispose();
                // mypen.Dispose();
                // class11.Invalidate();
                //class11.Refresh();
                //   button1.Invalidate();
                //  while (locationx != button1.Location.X && locationy != button1.Location.Y)
                {
               //     g1.Clear(panel4.BackColor);
                   // panel1.Refresh();
                    //panel2.Refresh(); panel3.Refresh(); panel4.Refresh();
                }
            }catch (Exception )
            { 
                mypen = new System.Drawing.Pen(System.Drawing.Color.Red, 0);
                mypen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                System.Drawing.Graphics g = panel3.CreateGraphics();
                System.Drawing.Graphics g2 = panel1.CreateGraphics();
                //g2.DrawLine(mypen, button1.Location.X, button1.Location.Y, label5.Location.X, label5.Location.Y);
               //1 g2.Clear(panel1.BackColor);



            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
         private Cursor createcursor(Bitmap bm)
        {
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());

        }
        Image origine;
        private void button2_Click_1(object sender, EventArgs e)
        {
            
           
            
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = origine;
            this.Cursor = Cursors.Default;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        { 
            origine = button2.Image;
            this.Cursor = createcursor((Bitmap)(sender as Button).Image);
            
        }
    }
        
    
}
