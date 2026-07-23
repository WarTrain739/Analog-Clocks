namespace WinFormsTestingCMU2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        Bitmap bmp;
        Graphics cg;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }// I didn't need this =(
        private void Form1_Load(object sender, EventArgs e)
        {
                // create a new bitmap   
            bmp = new Bitmap(1500, 600);

                //timer   
            t.Interval = 1000; // 1000 miliseconds makes a second.   
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                // WOW GRAPHICS!!  
            cg = Graphics.FromImage(bmp);
                //time variables  
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            labelDateTime.Text = DateTime.Now.ToString(); // <<<<<<<<<<<<<<< I USED THE ToString()
            cg.Clear(Color.White); //This clears drawn clock hands before each redrawing.

            //draw a circle   
            cg.DrawEllipse(new Pen(Color.Black, 2f), 800, 100, 120, 120); //This outer circle of the clock represents the Twelth hour 12:00:00. Whereas the middle of the circle represents 00:00:00
            //seconds hand for circle clock
            cg.DrawEllipse(new Pen(Color.Red, 1f), 860 - (ss), 160 - (ss), ss*2, ss*2);
            //minutes hand for circle clock
            cg.DrawEllipse(new Pen(Color.Orange, 1f), 860 - (mm), 160 - (mm), mm*2, mm*2);
            //Hours Hand for circle clock
            if (hh <= 12)
                cg.DrawEllipse(new Pen(Color.Turquoise, 1f), 860 - ((hh)*5), 160 - ((hh)*5), (hh*10), (hh*10));
            else
            {//Hours Hand after it progresses into military time.
                hh = hh - 12;
                cg.DrawEllipse(new Pen(Color.Turquoise, 1f), 860 - ((hh) * 5), 160 - ((hh) * 5), hh*10, hh*10);
            }

            //Seconds Hand
            cg.DrawLine(new Pen(Color.Red, 2f), new Point((ss * 12), 350), new Point(ss * 12, 450));
            cg.DrawEllipse(new Pen(Color.Red, 2f), ((ss*12)-9), 393, 16, 16);
            //Minutes Hand
            cg.DrawLine(new Pen(Color.Blue, 3f), new Point((mm * 12), 350), new Point(mm * 12, 450));
            //Hours Hand
            if (hh <= 11)
            {
                cg.DrawLine(new Pen(Color.Blue, 4f), new Point((hh * 60) + mm, 360), new Point((hh * 60)+ mm, 440));
            }
            else
            {//Hours Hand after it progresses into military time changes color.
                hh = hh - 12;
                cg.DrawLine(new Pen(Color.Turquoise, 4f), new Point((hh * 60) + mm, 360), new Point((hh * 60) + mm, 440));
            }
            //clock numbers
            //Could I use a for loop to draw all these strings with more concise code?
            cg.DrawString("12", new Font("Ariel", 12), Brushes.Black, new PointF(0, 320));
            cg.DrawString("1", new Font("Ariel", 12), Brushes.Black, new PointF(52, 320));
            cg.DrawString("2", new Font("Ariel", 12), Brushes.Black, new PointF(112, 320));
            cg.DrawString("3", new Font("Ariel", 12), Brushes.Black, new PointF(172, 320));
            cg.DrawString("4", new Font("Ariel", 12), Brushes.Black, new PointF(232, 320));
            cg.DrawString("5", new Font("Ariel", 12), Brushes.Black, new PointF(292, 320));
            cg.DrawString("6", new Font("Ariel", 12), Brushes.Black, new PointF(352, 320));
            cg.DrawString("7", new Font("Ariel", 12), Brushes.Black, new PointF(412, 320));
            cg.DrawString("8", new Font("Ariel", 12), Brushes.Black, new PointF(472, 320));
            cg.DrawString("9", new Font("Ariel", 12), Brushes.Black, new PointF(532, 320));
            cg.DrawString("10", new Font("Ariel", 12), Brushes.Black, new PointF(585, 320));
            cg.DrawString("11", new Font("Ariel", 12), Brushes.Black, new PointF(645, 320));
            cg.DrawString("12", new Font("Ariel", 12), Brushes.Black, new PointF(705, 320));

            cg.DrawString("60", new Font("Ariel", 12), Brushes.Black, new PointF(0, 450));
            cg.DrawString("5", new Font("Ariel", 12), Brushes.Black, new PointF(52, 450));
            cg.DrawString("10", new Font("Ariel", 12), Brushes.Black, new PointF(105, 450));
            cg.DrawString("15", new Font("Ariel", 12), Brushes.Black, new PointF(165, 450));
            cg.DrawString("20", new Font("Ariel", 12), Brushes.Black, new PointF(225, 450));
            cg.DrawString("25", new Font("Ariel", 12), Brushes.Black, new PointF(285, 450));
            cg.DrawString("30", new Font("Ariel", 12), Brushes.Black, new PointF(345, 450));
            cg.DrawString("35", new Font("Ariel", 12), Brushes.Black, new PointF(405, 450));
            cg.DrawString("40", new Font("Ariel", 12), Brushes.Black, new PointF(465, 450));
            cg.DrawString("45", new Font("Ariel", 12), Brushes.Black, new PointF(525, 450));
            cg.DrawString("50", new Font("Ariel", 12), Brushes.Black, new PointF(585, 450));
            cg.DrawString("55", new Font("Ariel", 12), Brushes.Black, new PointF(645, 450));
            cg.DrawString("60", new Font("Ariel", 12), Brushes.Black, new PointF(705, 450));

            //clock markers
            //Could I use a for loop to draw all these strings with more concise code?
            cg.DrawArc(new Pen(Color.Black, 3f), 0, 250, 720, 100, 180, 180); //arc
            using (Pen penBlack = new Pen(Color.Black, 1))
            {
                cg.DrawLine(penBlack, 0, 390, 0, 410); //left boundry marker
                cg.DrawLine(penBlack, 60, 375, 60, 425); //1
                cg.DrawLine(penBlack, 120, 350, 120, 450);//2
                cg.DrawLine(penBlack, 180, 375, 180, 425);//3
                cg.DrawLine(penBlack, 240, 350, 240, 450);//4
                cg.DrawLine(penBlack, 300, 375, 300, 425);//5
                cg.DrawLine(penBlack, 360, 350, 360, 450);//6
                cg.DrawLine(penBlack, 420, 375, 420, 425);//7
                cg.DrawLine(penBlack, 480, 350, 480, 450);//8
                cg.DrawLine(penBlack, 540, 375, 540, 425);//9
                cg.DrawLine(penBlack, 600, 350, 600, 450);//10
                cg.DrawLine(penBlack, 660, 375, 660, 425);//11
                cg.DrawLine(penBlack, 720, 350, 720, 450);//12
            }
            //bitmap thing  
            pictureBox1.Image = bmp;   
            this.Text = "Analog Clock - " + hh + ":" + mm + ":" + ss; //I just think this is neat. Didn't even know I could do this.

            cg.Dispose();
        }
    }
}
