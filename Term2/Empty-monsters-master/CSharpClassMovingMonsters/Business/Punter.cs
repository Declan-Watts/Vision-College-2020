using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CSharpClassMovingMonsters.Business
{
    abstract class Punter
    {
        public string name { get; set; }
        public int monster { get; set; }
        public Single cash { get; set; }
        public Single bet { get; set; }
        public Label labelWinner { get; set; }
        public Color myColor { get; set; }
    }
}
