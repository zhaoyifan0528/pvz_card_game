using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace game_2
{
    public class myplant
    {
        public int mark, lv, exp;
        public double quality;
        public int attadd, armadd, thradd, lifadd, growth,plant_pos;
        public void update_mess(int markin,int lvin,int expin,double qualityin,int attaddin,int armaddin,int thraddin,int lifaddin,int growthin,int plant_posin)
        {
            mark = markin;lv = lvin;exp = expin;quality = qualityin;attadd = attaddin;armadd = armaddin;
            thradd = thraddin;lifadd = lifaddin;growth = growthin;plant_pos = plant_posin;
        }
    }
}
