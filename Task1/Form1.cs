namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            programmers = new Programmers();

            programmers.OnChanging += Update; programmers.OnDelete += Update;

            programmers.OnChanging += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Список был изменен");
            };

            programmers.OnDelete += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Объект успешно удален");
            };
        }


        Programmers programmers;


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox_FIO.Text != "" & textBox_Speculity.Text != "" & byte.TryParse(textBox_Age.Text, out byte age))
            {
                string fio = textBox_FIO.Text; string speculity = textBox_Speculity.Text;
                textBox_Age.Text = textBox_FIO.Text = textBox_Speculity.Text = "";

                programmers.Add(new Programmer()
                {
                    FIO = fio,
                    Age = age,
                    Speculity = speculity
                });

            }
        }
        private void Update(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Programmer programmer in programmers.list)
            {
                dataGridView1.Rows.Add(programmer.FIO, programmer.Age.ToString(), programmer.Speculity);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                programmers.Delete(dataGridView1.CurrentRow.Index);
        }
    }
}
