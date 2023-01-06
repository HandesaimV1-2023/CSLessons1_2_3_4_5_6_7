namespace Lesson4_group1
{
    public partial class Form1 : Form
    {
        Egul eg = new Egul() { Radius = 5, nekuda = new Nekuda() { X = 50, Y = 6 } };

        public Form1()
        {
            InitializeComponent();
            eg.Change += draw;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Func(object sender, EventArgs e)
        {
            button1.Text = "push";
        }
        private void Func2(object sender, EventArgs e)
        {
           // button1.Text += "push";
            label2.Text+=(sender as Button).Text ;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Malben m = new Malben();
            m.Orech = int.Parse( textBox2.Text);
            m.Rochav = int.Parse(textBox3.Text);
            label1.Text = m.ToString();
        }

        private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                label2.Text = "מספר";
            else
                label2.Text = "אות";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {// הפונקציות של הארועים מקבלות
         // סנדר שהוא האוביקט עליו מופעל הארוע
         // ואי שהוא פרמטרים על הארוע
            label2.Text = e.Location.ToString();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = eg.ToString();
            eg.nekuda.X = 30;
        }

        void draw()
        {
            label2.Text = eg.ToString();
        }
    }
}