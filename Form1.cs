namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click); // 事件绑定

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 读取输入框中的数字并计算和
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double sum = num1 + num2;

                // 将结果显示在label上
                label1.Text = "Result: " + sum.ToString();
            }
            catch (FormatException)
            {
                // 输入格式错误时提示用户
                label1.Text = "Please enter valid numbers.";
            }
        }
    }
}
