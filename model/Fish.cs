using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fissing.model
{
    class Fish
    {
        private PictureBox _picture;
        public Fish(int positionX, int positionY, int speed,PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            this._picture = picture;
        }

        // プロパティ
        public int PositionX { get; set; }              // 位置x
        public int PositionY { get; set; }              // 位置y
        public int Speed { get; set; }                  // 泳ぐスピード
        public int MoveWidth { get; private set; }      // 移動範囲幅


    }
}
