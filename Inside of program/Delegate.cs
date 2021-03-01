public partial class Form1 : Form
    {
        public delegate int PerformCalculation(int x, int y);

        public delegate void Del(string message);

        public Form1()
        {
            InitializeComponent();
            Del handler = DelegateMethod;
            handler("hello");


            MethodWithCallback(1, 2, handler);
        }

        public static void DelegateMethod(string message)
        {
            MessageBox.Show(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is " + (param1 + param2).ToString());
        }
    }