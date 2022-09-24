using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gomoku
{
    enum COLOR { WHITE,BLUE,RED};
    class cell:Button
    {
        public COLOR occupier;


        public cell(int h,int w)
        {
            this.Height = h;
            this.Width = w;
            occupier = COLOR.WHITE;
        }
    }
}
