using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomoku
{
    public partial class GForm : Form
    {
        int dem;
        cell[,] cs;
        cell cc;
        COLOR turn=COLOR.RED;
        int Win = 5;
        public GForm()
        {
            InitializeComponent();
        }
        void turnchange()
        {
            if(turn==COLOR.RED)
            {
                turn = COLOR.BLUE;
            }
            else
            {
                turn = COLOR.RED;
            }
        }
        private void init()
        {
            grid.Controls.Clear();
            cs = new cell[dem, dem];
            if(vshuman.Checked==true)
            {
                for (int i = 0; i < dem; i++)
                {
                    for (int j = 0; j < dem; j++)
                    {
                        int h = grid.Height / dem - 10;
                        int w = grid.Width / dem - 10;
                        cell c = new cell(h, w);
                        grid.Controls.Add(c);
                        c.Click += new System.EventHandler(whencell);

                        cs[i, j] = c;
                    }
                }

            }
            else if(vsmachine.Checked==true)
            {
             
                for (int i = 0; i < dem; i++)
                {
                    for (int j = 0; j < dem; j++)
                    {
                      
                        int h = grid.Height / dem - 10;
                        int w = grid.Width / dem - 10;
                        cell c = new cell(h, w);
                        grid.Controls.Add(c);
                        c.Click += new System.EventHandler(computervv);

                        cs[i, j] = c;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the type of the game ");
            }
           
        }
        int randomvalue(int dem)
        {
            Random r = new Random();
           return r.Next(0, dem - 1);
          
           ;
        }
        void computermove()
        {
            int w, f;
            do
            {
                w = randomvalue(dem);
                f = randomvalue(dem);

            }
            while (cs[w, f].occupier != COLOR.WHITE);

    
                for (int i = 0; i < dem; i++)
                {
                    for (int j = 0; j < dem; j++)
                    {
                        if (cs[i, j].occupier == COLOR.WHITE)
                        {
                            cs[i, j].occupier = turn;
                            if (iswin(turn,5))
                            {
                                cs[i, j].occupier = COLOR.WHITE;
                                cc = cs[i, j];
                                return;
                            }
                            else
                            {
                                cs[i, j].occupier = COLOR.WHITE;
                            }
                        }
                    }
                }
                turnchange();
                for (int t = 5; t >= 0; t--)
                {
                    for (int i = 0; i < dem; i++)
                    {
                        for (int j = 0; j < dem; j++)
                        {
                            if (cs[i, j].occupier == COLOR.WHITE)
                            {
                                cs[i, j].occupier = turn;
                                if (iswin(turn, t))
                                {
                                    cs[i, j].occupier = COLOR.WHITE;
                                    turnchange();
                                    cc = cs[i, j];
                                    return;
                                }
                                else
                                {
                                    cs[i, j].occupier = COLOR.WHITE;
                                }
                            }
                        }
                    }
                }

                w++;
                f++;
            
        cc = cs[w, f];
        turnchange();
        }

        void whencell(object sender, EventArgs e)
        {
            cc = (cell)sender;
            if(cc.occupier!=COLOR.WHITE)
            {
                MessageBox.Show("Worng turn.....! ");
                return;
            }
      
            updatebox();
            if (iswin(turn,5))
            {
                MessageBox.Show(turn.ToString() + " is win ");
                

          
            }
            turnchange();
        }
        void computervv(object sender, EventArgs e)
        {
            cc = (cell)sender;
            for (int i = 0; i < 2;i++ )
            {
                if(i==0)
                {
                    if (cc.occupier != COLOR.WHITE)
                    {
                        MessageBox.Show("Worng turn.....! ");

                        return;
                    }
                    
                }
                else
                {
                    computermove(); 
                }
                updatebox();
                if (iswin(turn,5))
                {
                    MessageBox.Show(turn.ToString() + " is win ");
                }
                turnchange();
            }
        }
        bool l_to_r_horizontal(int ri, int ci, COLOR turn,int Win1)
        {
            if(ci+Win1>dem)
            {
                return false;
            }
            for(int i=0;i<Win1;i++)
            {
                if(cs[ri,ci+i].occupier!=turn)
                {
                    return false;
                }
            }
            return true;
        }
        bool r_to_l_horizontal(int ri,int ci,COLOR turn,int Win1)
        {
            if(ci-Win1<0)
            {
                return false;
            }
            for(int i=Win1;i>0;i--,ci--)
            {
                if(cs[ri,ci].occupier!=turn)
                {
                    return false;
                }
            }
            return true;
        }
        bool t_to_b_vertical(int ri,int ci,COLOR turn,int Win1)
        {
            if(ri+Win1>dem)
            {
                return false;
            }
            for(int i=0;i<Win1;i++)
            {
                if(cs[ri+i,ci].occupier!=turn)
                {
                    return false;
                }
            }


            return true;
                 
        }
        bool b_to_t_vertical(int ri,int ci,COLOR turn,int Win1)
        {
            if(ri-Win1<0)
            {
                return false;
            }
            for(int i=Win1;i>0;i--,ri--)
            {
                if(cs[ri,ci].occupier!=turn)
                {
                    return false;
                }
            }
            return true;

        }
        bool t_to_b_r_diagonal(int ri,int ci,COLOR turn,int Win1)
        {
            if(ci+Win1>dem||ri+Win1>dem)
            {
                return false;
            }
            for(int i=0;i<Win1;i++)
            {
                if(cs[ri+i,ci+i].occupier!=turn)
                {
                    return false;
                }
            }
            return true;
        }
        
        bool t_to_b_l_diagonal(int ri,int ci,COLOR turn,int Win1)
        {
           if(ri-Win1<0||ci+Win1>dem)
           {
               return false;
           }
           for (int i = 0;i<Win1; i++, ri--, ci++)
           {
               if (cs[ri, ci].occupier != turn)
               {
                   return false;
               }
           }
            return true;
        }
        bool diagonal(int ri,int ci,COLOR turn,int win1)
        {
            if(ri+win1>dem||ci-win1<0)
            {
                return false;

            }
            for(int i=0;i<win1;i++,ri++,ci--)
            {
                if(cs[ri,ci].occupier!=turn)
                {
                    return false;
                }
            }
            return true;
        }
   
        bool doiwinhere(int ri,int ci,COLOR turn,int Win1)
        {
            return l_to_r_horizontal(ri, ci, turn,Win1) || r_to_l_horizontal(ri, ci, turn,Win1) || t_to_b_vertical(ri, ci, turn,Win1) ||
                b_to_t_vertical(ri, ci, turn,Win1) || t_to_b_r_diagonal(ri, ci, turn,Win1) || t_to_b_l_diagonal(ri, ci, turn,Win1) || diagonal(ri,ci,turn,Win1);
        }
        bool iswin(COLOR turn,int Win1)
        {
            for(int i=0;i<dem;i++)
            {
                for(int j=0;j<dem;j++)
                {
                    if (doiwinhere(i, j, turn,Win1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        void updatebox()
        {
            cc.occupier = turn;
            if(turn==COLOR.BLUE)
            {
                cc.BackColor = Color.Blue;

            }
            else
            {
                cc.BackColor = Color.Red;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            if(fiveX5.Checked==true)
            {
                dem = 5;
            }
            else if(tenX10.Checked)
            {
                dem = 10;
            }
            else if(fifteenX15.Checked)
            {
                dem = 15;
            }
            else
            {
                MessageBox.Show("SELSECT A DEMENSION.....!");
            }
            init();

        }
        private void GForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
