using System;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(redBox.Visible)
            {
                AnimateWindowHelper.AnimateWindow(redBox.Handle, 200,
                    AnimateWindowHelper.AnimateWindowFlags.AW_HOR_NEGATIVE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_HIDE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_CENTER);
            }
            else
            {
                AnimateWindowHelper.AnimateWindow(redBox.Handle, 200,
                    AnimateWindowHelper.AnimateWindowFlags.AW_HOR_NEGATIVE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_CENTER);
            }
            redBox.Visible = !redBox.Visible;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (blueBox.Visible)
            {
                AnimateWindowHelper.AnimateWindow(blueBox.Handle, 200,
                    AnimateWindowHelper.AnimateWindowFlags.AW_HOR_NEGATIVE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_HIDE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_SLIDE);
            }
            else
            {
                AnimateWindowHelper.AnimateWindow(blueBox.Handle, 200,
                    AnimateWindowHelper.AnimateWindowFlags.AW_HOR_POSITIVE
                    | AnimateWindowHelper.AnimateWindowFlags.AW_SLIDE);
            }
            blueBox.Visible = !blueBox.Visible;
        }

        readonly AnimationHelper animationHelper = new AnimationHelper();
        readonly AnimationHelper animationHelper1 = new AnimationHelper();
        private int bluePos = 0;
        private int redPos = 0;
        private readonly int stepSize = 200;
        private readonly int windowWidthMargin = 14;

        private void Button3_Click(object sender, EventArgs e)
        {
            bluePos += stepSize;
            redPos += stepSize;
            
            int maxpos = this.Width - windowWidthMargin - blueBox.Width;
            int maxpos1 = this.Width - windowWidthMargin - redBox.Width;
            if (maxpos < bluePos)
            {
                bluePos = maxpos;
            }
            if (maxpos1 < redPos)
            {
                redPos = maxpos1;
            }
            animationHelper.MoveXEx(blueBox, bluePos);
            animationHelper1.MoveXEx(redBox, redPos);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            bluePos -= stepSize;
            redPos -= stepSize;
            if (0 > bluePos)
            {
                bluePos = 0;
            }
            if (0 > redPos)
            {
                redPos = 0;
            }
            animationHelper.MoveXEx(blueBox, bluePos);
            animationHelper1.MoveXEx(redBox, redPos);
        }

        private void ButtonOnPopup_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            AnimateWindowHelper.AnimateWindow(form2.Handle, 200,
                AnimateWindowHelper.AnimateWindowFlags.AW_HOR_NEGATIVE 
                | AnimateWindowHelper.AnimateWindowFlags.AW_CENTER);
            form2.ShowDialog();
        }
    }
}
