namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int nilai1 = int.Parse(textBox1.Text);
        int nilai2 = int.Parse(textBox2.Text);
        int hasil;
        hasil = nilai1 + nilai2;
        textBox3.Text = hasil.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        int nilai1 = int.Parse(textBox1.Text);
        int nilai2 = int.Parse(textBox2.Text);
        int hasil;
        hasil = nilai1 - nilai2;
        textBox3.Text = hasil.ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        int nilai1 = int.Parse(textBox1.Text);
        int nilai2 = int.Parse(textBox2.Text);
        int hasil;
        hasil = nilai1 * nilai2;
        textBox3.Text = hasil.ToString();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        int nilai1 = int.Parse(textBox1.Text);
        int nilai2 = int.Parse(textBox2.Text);
        int hasil;
        hasil = nilai1 / nilai2;
        textBox3.Text = hasil.ToString();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
    }
}
