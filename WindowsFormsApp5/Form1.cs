using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyGenericClass<T>
        {
            private T genericMember;

            public MyGenericClass(T value)
            {
                genericMember = value;
            }

            public string DisplayInformation()
            {
                return $"Тип: {typeof(T)}, Значение: {genericMember}";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var stringInstance = new MyGenericClass<string>("Привет, мир!");
            var intInstance = new MyGenericClass<int>(12345);

            MessageBox.Show(stringInstance.DisplayInformation());
            MessageBox.Show(intInstance.DisplayInformation());
        }
    }
}

