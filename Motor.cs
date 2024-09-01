using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneCompositions
{
    internal class Motor
    {
        private int beygirGucu;
        private int tork;
        private RichTextBox richtextbox;
        private PictureBox pictureBox;

        public Motor(int beygirGucu, int tork, RichTextBox richtextbox, PictureBox pictureBox)
        {
            this.beygirGucu = beygirGucu;
            this.tork = tork;
            this.richtextbox = richtextbox;
            this.pictureBox = pictureBox;
        }


        public int BeygirGucu { get => beygirGucu; set => beygirGucu = value; }
        public int Tork { get => tork; set => tork = value; }

        public void motoruCalistir()
        {
            this.richtextbox.Text = "Motor Çalıştırıldı...";
            this.pictureBox.Load("C:/Users/senad/Downloads/8175.png_3010.png");
        }
        public void motoruDurdur()
        {
            this.richtextbox.Text = "Motor durduruluyor..";
            this.pictureBox.Load("C:\\Users\\senad\\Downloads\\8175.png_300.png");
        }
    }
  
}
