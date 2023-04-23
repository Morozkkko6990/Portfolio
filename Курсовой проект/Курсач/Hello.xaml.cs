using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Hello.xaml
    /// </summary>
    public partial class Hello : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Hello()
        {
            InitializeComponent();             
            timer.Interval=TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }       

        void Timer_Tick(object sender, EventArgs e)
        {
            MainWindow win=new MainWindow();
            win.Show();
            this.Close();
            timer.Stop();
        }
    }
}
