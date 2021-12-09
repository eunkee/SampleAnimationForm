using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    //https://programmerall.com/article/8702671930/
    public class AnimationHelper
    {
        private readonly System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private readonly double force = 0.01d;
        private readonly double drag = 0.8d;
        private double velocity = 0.0;
        private Control control;
        private int targetPos = 0;

        public AnimationHelper(int interval = 5)
        {
            animationTimer.Interval = interval;
            animationTimer.Tick += delegate
            {
                if (control == null) return;
                int currentPos = control.Location.X;
                if (Math.Abs(currentPos - targetPos) <= 5)
                {
                    control.Location = new Point(targetPos, control.Location.Y);
                    animationTimer.Stop();
                }
                int dx = targetPos - currentPos;
                velocity += force * dx;
                velocity *= drag;
                if (Math.Abs(velocity) < 5)
                {
                    if (velocity > 0)
                        velocity = 5;
                    else
                        velocity = -5;
                }
                control.Location = new Point(currentPos + (int)velocity, control.Location.Y);
            };
            animationTimer.Start();
        }

        public void MoveXEx(Control control, int targetPos)
        {
            this.control = control;
            if (this.targetPos != targetPos)
            {
                this.targetPos = targetPos;
                velocity = 0;
                animationTimer.Start();
            }
        }
    }
}