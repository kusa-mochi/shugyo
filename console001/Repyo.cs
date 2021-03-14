using System;

namespace console001
{
    public class Repyo
    {
        public Repyo()
        {
        }

        public string EatPotechi(int nannmai = 3)
        {
            return this.EatPotechi((float)nannmai);
            // return $"ポテチうまい！{nannmai}枚食べたお！";
        }

        public string EatPotechi(float nannmai)
        {
            return $"ポテチうめぇ！てちゅにおすそ分けしながら{nannmai:F1}枚食べたお！";
            // return 3;
        }

        public string EatPotechi(int nannmai, bool kannshoku)
        {
            string tmp = kannshoku ? "完食！" : "無理ぽよ";
            return $"ポテチうまい！{nannmai}枚食べたお！{tmp}";
        }
    }
}
