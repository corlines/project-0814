using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace gzme
{
    class MainApp : Form
    {
        #region ���콺 Ŭ�� ����
        //public void MyMouseHandler(object sender, MouseEventArgs e)
        //{
        //    WriteLine($"Sender : {((Form)sender).Text}");
        //    WriteLine($"X:{e.X}, Y:{e.Y}");
        //    WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}");

        //}

        //public MainApp(string title)
        //{
        //    this.Text = title;
        //    this.MouseDown +=
        //        new MouseEventHandler(MyMouseHandler);
        //}
        //static void Main(string[] args)
        //{
        //    Application.Run(new MainApp("Mouse Event Test"));
        //}
        #endregion
        #region ���콺 ���� 2
        //static void Main(string[] args)
        //{
        //    Random rand = new Random();
        //    MainApp form = new MainApp();
        //    form.Width = rand.Next(100,600);
        //    form.Height = rand.Next(100, 600);

        //    form.MouseDown += new MouseEventHandler(form_MouseDown);
        //    Application.Run(form);
        //}
        // static   Random rand = new Random();
        //static void form_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Form form = (Form)sender;
        //    int oldWidth = rand.Next(100, 1000);
        //    int oldHeight = rand.Next(100,1000);

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if(oldWidth < oldHeight)
        //        {
        //            form.Width = oldHeight;
        //            form.Height = oldWidth;
        //        }
        //    }
        //    else if (e.Button == MouseButtons.Right)
        //    {
        //        if (oldHeight < oldWidth)
        //        {
        //            form.Width = oldHeight;
        //            form.Height = oldWidth;
        //        }
        //    }
        //    Console.WriteLine("�������� ũ�Ⱑ ����Ǿ����ϴ�");
        //    Console.WriteLine($"Width: {form.Width}, Height: {form.Height}");
            #endregion

        #region �ϱ� �ȴٶ�� ���ϸ� ȥ���� �ϰ� �ʹٶ�� ���ϸ� �ϱ� �Ȱ� pc���� ���� ������ pc���� ������ �� ������ ���� Ǯ����Ͽ�...

        Random rand;
        public MainApp()
        {
            rand = new Random();

            this.MouseWheel += new MouseEventHandler(MainApp_MouseWheel);
            this.MouseDown += new MouseEventHandler(MainApp_MouseDown);
        }
            
        void MainApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

            }
            else if (e.Button == MouseButtons.Right)
            {
                if (this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                    return;
                }
                string file = "ĸó1.PNG";
                if (System.IO.File.Exists(file) == false)
                    MessageBox.Show("�̹��� ������ ����");
                else
                    this.BackgroundImage = Image.FromFile(file);

            }
        }
        

        void MainApp_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
            Console.WriteLine($"Opacity: {this.Opacity}");


        }
        static void Main(string[] args)
        {
            Application.Run(new MainApp());
        }
        #endregion
    }
}