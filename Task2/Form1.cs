namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<string, string> func = delegate (string s)
            {
                s = StrFunc.DeleteAllPunctuation(s);
                s = StrFunc.AllToUp(s);
                s = StrFunc.DeleteEmptySpace(s);
                s = StrFunc.AddSymbols(s);
                s = StrFunc.AddCount(s);
                return s;
            };
            richTextBox2.Text = func(richTextBox1.Text);
        }
    }
}
