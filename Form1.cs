namespace NesneCompositions
{
    public partial class FormHelikopter : Form
    {
        private Helikopter heli1;
        public FormHelikopter()
        {
            InitializeComponent();

            InitMyHeli(); //solda ayar çýkýnca yontemý oluþtur yap
        }

        private void InitMyHeli()
        {
            Depo myDepo = new Depo(200);
            Pervane myPervane = new Pervane(10, 570);
            Motor myMotor = new Motor(700, 450, richTextBox1, pictureBox1);

            heli1 = new Helikopter("H-234", myMotor, myDepo, myPervane);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heli1.helikopteriCalistir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            heli1.helikopteriDurdur();
        }
    }
}
