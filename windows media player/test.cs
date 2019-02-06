using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_media_player
{
    public class test
    {
        private int count = 0;
        private int count2 = 1;
        private int count3;

        public int addCount()
        {
            return tempCount();
        }

        private int tempCount()
        {
            return (count + count2);

        }

        private void unusedStuff()
        {

        }
    }
}
