using System;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       int q_num=0;
        bool started = false;
        double points = 0;
        int[] mas_4_task = new int[5];
        int[] mas = new int[10];
        int [] mas_t_for= {5,3,4,0,1,2,0,0};
        ComboBox[] cmb = new ComboBox [8]; 
        string connStr = "server=englisholimp.sytes.net;user=root;database=olimpiada;";
        RadioButton[] ch_t = new RadioButton[6];
        RadioButton[] ch_f = new RadioButton[6];
        int[] t_u = new int[6];
        int[] f_u = new int[6];
        int[] t = new int[6];
        int[] f = new int[6];


        RadioButton[] ch_t8 = new RadioButton[5];
        RadioButton[] ch_f8 = new RadioButton[5];
        int[] t_u8 = new int[5];
        int[] f_u8 = new int[5];
        int[] t8 = new int[5];
        int[] f8 = new int[5];
        public MainWindow()
        {
          
            InitializeComponent();
            media.Source = new Uri(@"picture\13.mp3", UriKind.RelativeOrAbsolute);
            media.Play();
            Next.Visibility = Visibility.Collapsed;

            for (int i = 0; i < 8; i++)
            { cmb[i] = new ComboBox(); }
            cmb[0].Items.Add("--");
            cmb[0].Items.Add("1");
            cmb[0].Items.Add("2");
            cmb[0].Items.Add("3");
            cmb[0].Items.Add("4");
            cmb[0].Items.Add("5");
            cmb[0].SelectedIndex = 0;


            cmb[1].Items.Add("--");
            cmb[1].Items.Add("1");
            cmb[1].Items.Add("2");
            cmb[1].Items.Add("3");
            cmb[1].Items.Add("4");
            cmb[1].Items.Add("5");
            cmb[1].SelectedIndex = 0;

            cmb[2].Items.Add("--");
            cmb[2].Items.Add("1");
            cmb[2].Items.Add("2");
            cmb[2].Items.Add("3");
            cmb[2].Items.Add("4");
            cmb[2].Items.Add("5");
            cmb[2].SelectedIndex = 0;

            cmb[3].Items.Add("--");
            cmb[3].Items.Add("1");
            cmb[3].Items.Add("2");
            cmb[3].Items.Add("3");
            cmb[3].Items.Add("4");
            cmb[3].Items.Add("5");
            cmb[3].SelectedIndex = 0;


            cmb[4].Items.Add("--");
            cmb[4].Items.Add("1");
            cmb[4].Items.Add("2");
            cmb[4].Items.Add("3");
            cmb[4].Items.Add("4");
            cmb[4].Items.Add("5");
            cmb[4].SelectedIndex = 0;

            cmb[5].Items.Add("--");
            cmb[5].Items.Add("1");
            cmb[5].Items.Add("2");
            cmb[5].Items.Add("3");
            cmb[5].Items.Add("4");
            cmb[5].Items.Add("5");
            cmb[5].SelectedIndex = 0;

            cmb[6].Items.Add("--");
            cmb[6].Items.Add("1");
            cmb[6].Items.Add("2");
            cmb[6].Items.Add("3");
            cmb[6].Items.Add("4");
            cmb[6].Items.Add("5");
            cmb[6].SelectedIndex = 0;

            cmb[7].Items.Add("--");
            cmb[7].Items.Add("1");
            cmb[7].Items.Add("2");
            cmb[7].Items.Add("3");
            cmb[7].Items.Add("4");
            cmb[7].Items.Add("5");
            cmb[7].SelectedIndex = 0;
        }
        void end()
        {
            media.Source = new Uri(@"picture\13.mp3", UriKind.RelativeOrAbsolute);
            media.Play();
            lbl1.Visibility = Visibility.Collapsed;
            lbl2.Visibility = Visibility.Collapsed;
            listen.Visibility = Visibility.Collapsed;
            Next2.Visibility = Visibility.Collapsed;
            Next.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Collapsed;
            login.Visibility = Visibility.Collapsed;
            pass.Visibility = Visibility.Collapsed;
            enter.Visibility = Visibility.Collapsed;
            tbbbbb.Text = "Thanks For Participating, Goodbye! Your Rezults : "+ points+" /100";
            grid.Visibility = Visibility.Visible;

        }

        void show()
        {
            if (q_num == 0)
            {
                if (!p1.IsVisible)
                {
                    media.Stop();
                    started = true;
                    SV.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n\n Listening Skills Focus";
                    return;
         
                } else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p1.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }

            if (q_num == 1)
            {
                if (!p2.IsVisible)
                {
                    SV.Visibility = Visibility.Collapsed;
                    listen.Visibility = Visibility.Collapsed; Stop.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n\n Reading Skills Focus";
                    return;
                }
                else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p2.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }
            if (q_num == 2)
            {
                if (!p3.IsVisible)
                {
                    SV.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n\n Reading Skills Focus";
                    return;

                }
                else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p3.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }
            if (q_num == 3)
            {
                if (!p3.IsVisible)
                {
                    SV.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n\n Use of English skills focus";
                    return;

                }
                else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p3.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }
            if (q_num == 4)
            {
                if (!p3.IsVisible)
                {
                    SV.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n\n Use of English skills focus";
                    return;

                }
                else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p3.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }
            if (q_num == 5)
            {
                if (!p4.IsVisible)
                {
                    SV.Visibility = Visibility.Collapsed;
                    Next2.Visibility = Visibility.Visible;
                    p4.Visibility = Visibility.Visible;
                    zad.Visibility = Visibility.Visible;
                    zad.Text = "\n Ladies and gentlemen!  If you want to increase your listening skills and to conquer your laziness you should make acquaintance with our best friend inspector Hudson and his friends. They are the devoted friends of our Olympiad too. Meet the new detective story 'The Murder in the Office.'";
                    return;
                }
                else
                {
                    Next2.Visibility = Visibility.Collapsed;
                    p4.Visibility = Visibility.Collapsed;
                    zad.Visibility = Visibility.Collapsed;
                    return;
                }
            }
        }


        //авторизация
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();

                string sql = "select log,pas from users";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        if (login.Text == "" || pass.Password == "") { MessageBox.Show("Не все поля заполнены"); return; }
                        if (reader.GetString(0) == login.Text && reader.GetString(1) == pass.Password)
                        {
                            grid.Visibility = Visibility.Collapsed;
                            conn.Close();
                            Next.Visibility = Visibility.Visible;
                            show();
                            
                            return;
                        }


                    }


                conn.Close();

                MessageBox.Show("Введите Ваш логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
               MessageBox.Show("Не удалось подключится к БД. Отсутсвует соедниение с сетью либо сервер отключён!","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //1 задание
        public void q1()
        {
            SV.Visibility = Visibility.Visible;
            SV.ScrollToVerticalOffset(0);
            show();
            listen.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Visible;
            TextBlock l = new TextBlock();
            l.FontSize = 14;
            l.TextWrapping = TextWrapping.Wrap;
         

            l.Width =700;
            l.Height = 200;
            CVS.Children.Add(l);

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string sql = "select q_text from quests where q_num=1 ORDER BY id ASC ";


            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();
            

            if (reader.HasRows)
                while (reader.Read())
                {


                   l.Text= reader.GetString(0)+"\n  T    F";


                }

          
            conn.Close();
            conn.Open();
            string sql1 = "select truee from answers where q_num=1 and a_num_q=1 ORDER BY id ASC ";

            MySqlCommand command1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = command1.ExecuteReader();
            int i = 0;

            if (reader1.HasRows)
                while (reader1.Read())
                {
                    ch_t[i] = new RadioButton();
                    ch_t[i].GroupName = "g" + i;
                    ch_t[i].FontSize = 14;
                    ch_t[i].Checked += RadioButton_Checked3;
                    t[i]= reader1.GetInt32(0);
                    i++;

                }
            i = 0;
            conn.Close();
            conn.Open();
            string sql2 = "select a_text, truee from answers where q_num=1 and a_num_q=2 ORDER BY id ASC ";

            MySqlCommand command2 = new MySqlCommand(sql2, conn);

            MySqlDataReader reader2 = command2.ExecuteReader();
         

            if (reader2.HasRows)
                while (reader2.Read())
                {
                    ch_f[i] = new RadioButton();
                    ch_f[i].GroupName = "g" + i;
                    ch_f[i].FontSize = 14;
                    ch_f[i].Content = reader2.GetString(0);
                    f[i] = reader2.GetInt32(1);
                    ch_f[i].Checked += RadioButton_Checked3;
                    i++;

                }
            conn.Close();
            for (i = 0; i < 6; i++)
            {
                
                Canvas.SetLeft(ch_t[i], 5);
                Canvas.SetTop(ch_t[i], (i*20)+60);
                CVS.Children.Add(ch_t[i]);
                Canvas.SetLeft(ch_f[i], 25);
                Canvas.SetTop(ch_f[i], (i * 20) + 60);
                CVS.Children.Add(ch_f[i]);
            }

           
        }

        //2 задание
        public void q4()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 1200;
            show();
            string[] mas_s = new string[8];
            SV.Visibility = Visibility.Visible;
            TextBlock l = new TextBlock();
            l.FontSize = 14;
            l.TextWrapping = TextWrapping.Wrap;


            l.Width = 700;
            l.Height = 400;
            CVS.Children.Add(l);

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string sql = "select quests.q_text,texts.text from quests,texts where quests.q_num=4 and texts.q_num=4  ";


            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
                while (reader.Read())
                {


                    l.Text = reader.GetString(0)+"\n";
                   l.Text += reader.GetString(1);
                   

                }
            conn.Close();

            MySqlConnection conn2 = new MySqlConnection(connStr);

            conn2.Open();

            string sql2 = "select distinct a_text from answers where q_num=4";


            MySqlCommand command2 = new MySqlCommand(sql2, conn2);

            MySqlDataReader reader2 = command2.ExecuteReader();
            TextBlock tb = new TextBlock();
            tb.Width = 250;
            int i = 0;
            char c = 'A';
            if (reader2.HasRows)
               
                while (reader2.Read())
                {


                    tb.Text+= c+")"+reader2.GetString(0) + "\n\n";
                    c++;
                    i++;

                }
            conn2.Close();
            tb.FontSize = 14;
            Canvas.SetTop(tb, 350);
           for (i = 0; i < 8; i++)
            { Canvas.SetLeft(cmb[i], 350);
                Canvas.SetTop(cmb[i],350+(i*32));
                CVS.Children.Add(cmb[i]);
            }
            CVS.Children.Add(tb);
            CVS.Height = Canvas.GetTop(cmb[cmb.Length - 1]) + 20;
        }


        TextBlock[] tbtwotext;

        TextBlock[] tbtwoquetion;

        RadioButton[] rbtwoanswer;

       //задание 2
        public void q2()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
            SV.Visibility = Visibility.Visible;
            show();
            int k=3;
            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Width = 700;
            Canvas.SetLeft(tb,0);
            Canvas.SetTop(tb,-55);
            CVS.Children.Add(tb);
            tbtwoquetion = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbtwoquetion[i] = new TextBlock();
                tbtwoquetion[i].TextWrapping = TextWrapping.Wrap;
                tbtwoquetion[i].Width = 700;
                CVS.Children.Add(tbtwoquetion[i]);
                Canvas.SetLeft(tbtwoquetion[i], 0);
                Canvas.SetTop(tbtwoquetion[i], i*150-10 );
            }


            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_text from quests where q_num=2 and part_num=0 ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();
            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tb.Text = reader.GetString(0)+"\n";
                    i1++;
                }
            conn.Close();
            conn.Open();

            conn = new MySqlConnection(connStr);
            conn.Open();
             sql = "select q_text from quests where q_num=2 and part_num!=0 ORDER BY id ASC ";

             command = new MySqlCommand(sql, conn);

             reader = command.ExecuteReader();


             i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbtwoquetion[i1].Text += reader.GetString(0);
                    i1++;
                }
            conn.Close();
            conn.Open();
            sql = "select q_num,text from texts where q_num=2 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 3;

            tbtwotext = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbtwotext[i] = new TextBlock();
                tbtwotext[i].TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbtwotext[i]);
                tbtwotext[i].Width = 700;
                Canvas.SetLeft(tbtwotext[i], 0);
                Canvas.SetTop(tbtwotext[i], Canvas.GetTop(tbtwoquetion[i])+20);

            }


            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbtwotext[i1].Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();
            sql = "select q_num,a_text from answers where q_num=2 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 9;


            rbtwoanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 3 == 0) ii++;
                rbtwoanswer[i] = new RadioButton();
                CVS.Children.Add(rbtwoanswer[i]);
                Canvas.SetLeft(rbtwoanswer[i], 0);
                Canvas.SetTop(rbtwoanswer[i], Canvas.GetTop(tbtwotext[ii - 1]) + 60 + (iii) * 20);
                rbtwoanswer[i].GroupName = ii + "";
                if (iii == 2) iii = 0;
                else iii++;

            }


            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {
                    rbtwoanswer[i1].Content = reader.GetString(1);
                    rbtwoanswer[i1].Checked += RadioButton_Checked;
                    i1++;
                }


            CVS.Height = Canvas.GetTop(rbtwoanswer[rbtwoanswer.Length - 1]) + 20;
            conn.Close();
        }


        TextBlock tbthreetext;

        TextBlock tbthreequetion;

        RadioButton[] rbthreeanswer;
        //задание 3
        public void q3()
        {
            SV.ScrollToVerticalOffset(0);
            show();
            CVS.Height = 860;
            SV.Visibility = Visibility.Visible;
            int k;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_num,q_text from quests where q_num=3 ORDER BY id ASC ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            k = 1;
            for (int i = 0; i < k; i++)
            {
                tbthreequetion = new TextBlock();
                tbthreequetion.TextWrapping = TextWrapping.Wrap;
                tbthreequetion.Width = 700;
                CVS.Children.Add(tbthreequetion);
                Canvas.SetLeft(tbthreequetion, 0);
                Canvas.SetTop(tbthreequetion, 150 * i);
            }

            if (reader.HasRows)
                while (reader.Read())
                {

                    tbthreequetion.Text = reader.GetString(1);

                }
            conn.Close();
            conn.Open();

            sql = "select q_num,text from texts where q_num=3 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 1;

            tbthreetext = new TextBlock();
            for (int i = 0; i < k; i++)
            {
                tbthreetext = new TextBlock();
                tbthreetext.TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbthreetext);
                tbthreetext.Width = 700;
                Canvas.SetLeft(tbthreetext, 0);
                Canvas.SetTop(tbthreetext, Canvas.GetTop(tbthreequetion) + 20);

            }


            if (reader.HasRows)
                while (reader.Read())
                {

                    tbthreetext.Text = reader.GetString(1);

                }
            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=3 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 40;


            rbthreeanswer = new RadioButton[k];
            int ii = 0;

            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbthreeanswer[i] = new RadioButton();
                CVS.Children.Add(rbthreeanswer[i]);
                Canvas.SetLeft(rbthreeanswer[i], 0);
                if (i == 0)
                {

                    TextBlock tmp = new TextBlock(); tmp.Text = "" + ii;
                    CVS.Children.Add(tmp);
                    Canvas.SetLeft(tmp, 100);
                    Canvas.SetTop(tmp, Canvas.GetTop(tbthreetext) + 280);

                    Canvas.SetTop(rbthreeanswer[i], Canvas.GetTop(tbthreetext) + 300); rbthreeanswer[i].GroupName = ii + ""; continue;
                }
                if (i % 4 == 0)
                {
                    TextBlock tmp = new TextBlock(); tmp.Text = "" + ii;
                    CVS.Children.Add(tmp);
                    Canvas.SetLeft(tmp, 100);
                    Canvas.SetTop(tmp, Canvas.GetTop(rbthreeanswer[i - 1]) + 20);
                    Canvas.SetTop(rbthreeanswer[i], Canvas.GetTop(rbthreeanswer[i - 1]) + 40); rbthreeanswer[i].GroupName = ii + ""; continue;

                }
                else { Canvas.SetTop(rbthreeanswer[i], Canvas.GetTop(rbthreeanswer[i - 1]) + 20); rbthreeanswer[i].GroupName = ii + ""; continue; }

            }

            CVS.Height = Canvas.GetTop(rbthreeanswer[rbthreeanswer.Length - 1]) + 20;


            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {
                    rbthreeanswer[i1].Content = reader.GetString(1);
                    rbthreeanswer[i1].Checked += RadioButton_Checked1;
                    i1++;
                }


            conn.Close();
        }




        TextBlock[] tbfivequetion;

        RadioButton[] rbfiveanswer;

        //задание 5
        public void q5()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
            show();
            SV.Visibility = Visibility.Visible;
            int k;
         
            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Width = 700;
            Canvas.SetLeft(tb, 0);
            Canvas.SetTop(tb, 0);
            CVS.Children.Add(tb);

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_text from quests where q_num=5 and part_num=0 ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();
            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tb.Text = reader.GetString(0) + "\n";
                    i1++;
                }
            conn.Close();
            conn.Open();



             conn = new MySqlConnection(connStr);
            conn.Open();
             sql = "select q_num,q_text from quests where q_num=5 and part_num!=0 ORDER BY id ASC ";

             command = new MySqlCommand(sql, conn);

             reader = command.ExecuteReader();


            k = 12;
            tbfivequetion = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbfivequetion[i] = new TextBlock();
                tbfivequetion[i].TextWrapping = TextWrapping.Wrap;
                tbfivequetion[i].Width = 700;
                CVS.Children.Add(tbfivequetion[i]);
                Canvas.SetLeft(tbfivequetion[i], 0);
                Canvas.SetTop(tbfivequetion[i], 20 * i + (150 * i) + 20);
            }

             i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbfivequetion[i1].Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=5 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 12*4;


            rbfiveanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbfiveanswer[i] = new RadioButton();
                CVS.Children.Add(rbfiveanswer[i]);
                Canvas.SetLeft(rbfiveanswer[i], 0);
                Canvas.SetTop(rbfiveanswer[i], Canvas.GetTop(tbfivequetion[ii - 1]) + 20 + (iii) * 20);
                rbfiveanswer[i].GroupName = ii + "";
                if (iii == 3) iii = 0;
                else iii++;

            }



            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    rbfiveanswer[i1].Content = reader.GetString(1);
                    rbfiveanswer[i1].Checked += RadioButton_Checked2;
                    i1++;
                }

            CVS.Height = Canvas.GetTop(rbfiveanswer[rbfiveanswer.Length - 1]) + 20;
            conn.Close();
        }



        TextBlock tbsixquetion;
        TextBlock[] tbsixtext;

        RadioButton[] rbsixanswer;

        //задание 6
        public void q6()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
            show();
            SV.Visibility = Visibility.Visible;
            listen.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Visible;
            int k;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_num,q_text from quests where q_num=6 ORDER BY id ASC ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            k = 1;
            tbsixquetion = new TextBlock();
            for (int i = 0; i < k; i++)
            {
                
                tbsixquetion.TextWrapping = TextWrapping.Wrap;
                tbsixquetion.Width = 700;
                CVS.Children.Add(tbsixquetion);
                Canvas.SetLeft(tbsixquetion, 0);
                Canvas.SetTop(tbsixquetion, 150 * i );
            }

            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbsixquetion.Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();

            sql = "select q_num,text from texts where q_num=6 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5;

            tbsixtext = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbsixtext[i] = new TextBlock();
                tbsixtext[i].TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbsixtext[i]);
                tbsixtext[i].Width = 700;
                Canvas.SetLeft(tbsixtext[i], 0);
                Canvas.SetTop(tbsixtext[i], 150 * i + 20);

            }

            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbsixtext[i1].Text = reader.GetString(1);
                    i1++;
                }
            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=6 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5 * 4;


            rbsixanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbsixanswer[i] = new RadioButton();
                CVS.Children.Add(rbsixanswer[i]);
                Canvas.SetLeft(rbsixanswer[i], 0);
                Canvas.SetTop(rbsixanswer[i], Canvas.GetTop(tbsixtext[ii - 1]) + 20 + (iii) * 20);
                rbsixanswer[i].GroupName = ii + "";
                if (iii == 3) iii = 0;
                else iii++;

            }



            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    rbsixanswer[i1].Content = reader.GetString(1);
                    rbsixanswer[i1].Checked += RadioButton_Checked4;
                    i1++;
                }

            CVS.Height = Canvas.GetTop(rbsixanswer[rbsixanswer.Length - 1]) + 20;
            conn.Close();
        }


        TextBlock tbsevenquetion;
        TextBlock[] tbseventext;

        RadioButton[] rbsevenanswer;

        //задание 7
        public void q7()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
       
            SV.Visibility = Visibility.Visible;
            int k;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_num,q_text from quests where q_num=7 ORDER BY id ASC ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            k = 1;
            tbsevenquetion = new TextBlock();
            for (int i = 0; i < k; i++)
            {

                tbsevenquetion.TextWrapping = TextWrapping.Wrap;
                tbsevenquetion.Width = 700;
                CVS.Children.Add(tbsevenquetion);
                Canvas.SetLeft(tbsevenquetion, 0);
                Canvas.SetTop(tbsevenquetion, 150 * i);
            }

            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbsevenquetion.Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();

            sql = "select q_num,text from texts where q_num=7 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5;

            tbseventext = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbseventext[i] = new TextBlock();
                tbseventext[i].TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbseventext[i]);
                tbseventext[i].Width = 700;
                Canvas.SetLeft(tbseventext[i], 0);
                Canvas.SetTop(tbseventext[i], 150 * i+20);

            }

            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbseventext[i1].Text = reader.GetString(1);
                    i1++;
                }
            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=7 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5 * 4;


            rbsevenanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbsevenanswer[i] = new RadioButton();
                CVS.Children.Add(rbsevenanswer[i]);
                Canvas.SetLeft(rbsevenanswer[i], 0);
                Canvas.SetTop(rbsevenanswer[i], Canvas.GetTop(tbseventext[ii - 1]) + 20 + (iii) * 20);
                rbsevenanswer[i].GroupName = ii + "";
                if (iii == 3) iii = 0;
                else iii++;

            }



            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    rbsevenanswer[i1].Content = reader.GetString(1);
                    rbsevenanswer[i1].Checked += RadioButton_Checked5;
                    i1++;
                }

            CVS.Height = Canvas.GetTop(rbsevenanswer[rbsevenanswer.Length - 1]) + 20;
            conn.Close();
        }


        TextBlock tbninequetion;
        TextBlock[] tbninetext;

        RadioButton[] rbnineanswer;

        //задание 9
        public void q9()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
            SV.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Visible;
            int k;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_num,q_text from quests where q_num=9 ORDER BY id ASC ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            k = 1;
            tbninequetion = new TextBlock();
            for (int i = 0; i < k; i++)
            {

                tbninequetion.TextWrapping = TextWrapping.Wrap;
                tbninequetion.Width = 700;
                CVS.Children.Add(tbninequetion);
                Canvas.SetLeft(tbninequetion, 0);
                Canvas.SetTop(tbninequetion, 150 * i);
            }

            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbninequetion.Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();

            sql = "select q_num,text from texts where q_num=9 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5;

            tbninetext = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbninetext[i] = new TextBlock();
                tbninetext[i].TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbninetext[i]);
                tbninetext[i].Width = 700;
                Canvas.SetLeft(tbninetext[i], 0);
                Canvas.SetTop(tbninetext[i], 150 * i+20);

            }

            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbninetext[i1].Text = reader.GetString(1);
                    i1++;
                }
            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=9 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5 * 4;


            rbnineanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbnineanswer[i] = new RadioButton();
                CVS.Children.Add(rbnineanswer[i]);
                Canvas.SetLeft(rbnineanswer[i], 0);
                Canvas.SetTop(rbnineanswer[i], Canvas.GetTop(tbninetext[ii - 1]) + 20 + (iii) * 20);
                rbnineanswer[i].GroupName = ii + "";
                if (iii == 3) iii = 0;
                else iii++;

            }



            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    rbnineanswer[i1].Content = reader.GetString(1);
                    rbnineanswer[i1].Checked += RadioButton_Checked6;
                    i1++;
                }

            CVS.Height = Canvas.GetTop(rbnineanswer[rbnineanswer.Length - 1]) + 20;
            conn.Close();
        }


        TextBlock tbtenquetion;
        TextBlock[] tbtentext;

        RadioButton[] rbtenanswer;

        //задание 10
        public void q10()
        {
            SV.ScrollToVerticalOffset(0);
            CVS.Height = 860;
            SV.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Visible;
            int k;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_num,q_text from quests where q_num=10 ORDER BY id ASC ";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            k = 1;
            tbtenquetion = new TextBlock();
            for (int i = 0; i < k; i++)
            {

                tbtenquetion.TextWrapping = TextWrapping.Wrap;
                tbtenquetion.Width = 700;
                CVS.Children.Add(tbtenquetion);
                Canvas.SetLeft(tbtenquetion, 0);
                Canvas.SetTop(tbtenquetion, 150 * i);
            }

            int i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbtenquetion.Text = reader.GetString(1);
                    i1++;
                }

            conn.Close();
            conn.Open();

            sql = "select q_num,text from texts where q_num=10 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5;

            tbtentext = new TextBlock[k];
            for (int i = 0; i < k; i++)
            {
                tbtentext[i] = new TextBlock();
                tbtentext[i].TextWrapping = TextWrapping.Wrap;
                CVS.Children.Add(tbtentext[i]);
                tbtentext[i].Width = 700;
                Canvas.SetLeft(tbtentext[i], 0);
                Canvas.SetTop(tbtentext[i], 150 * i+20);

            }

            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    tbtentext[i1].Text = reader.GetString(1);
                    i1++;
                }
            conn.Close();
            conn.Open();

            sql = "select q_num,a_text from answers where q_num=10 ORDER BY id ASC ";
            command = new MySqlCommand(sql, conn);
            reader = command.ExecuteReader();

            k = 5 * 4;


            rbtenanswer = new RadioButton[k];
            int ii = 0;
            int iii = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 4 == 0) ii++;
                rbtenanswer[i] = new RadioButton();
                CVS.Children.Add(rbtenanswer[i]);
                Canvas.SetLeft(rbtenanswer[i], 0);
                Canvas.SetTop(rbtenanswer[i], Canvas.GetTop(tbtentext[ii - 1]) + 20 + (iii) * 20);
                rbtenanswer[i].GroupName = ii + "";
                if (iii == 3) iii = 0;
                else iii++;

            }



            i1 = 0;
            if (reader.HasRows)
                while (reader.Read())
                {

                    rbtenanswer[i1].Content = reader.GetString(1);
                    rbtenanswer[i1].Checked += RadioButton_Checked7;
                    i1++;
                }

            CVS.Height = Canvas.GetTop(rbtenanswer[rbtenanswer.Length - 1]) + 20;
            conn.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbtwoanswer.Length; i++)
            {
                if (rbtwoanswer[i].GroupName == t) rbtwoanswer[i].IsEnabled = false;
            }
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbthreeanswer.Length; i++)
            {
                if (rbthreeanswer[i].GroupName == t) rbthreeanswer[i].IsEnabled = false;
            }
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbfiveanswer.Length; i++)
            {
                if (rbfiveanswer[i].GroupName == t) rbfiveanswer[i].IsEnabled = false;
            }
        }
        private void RadioButton_Checked4(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbsixanswer.Length; i++)
            {
                if (rbsixanswer[i].GroupName == t) rbsixanswer[i].IsEnabled = false;
            }
        }
        private void RadioButton_Checked5(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbsevenanswer.Length; i++)
            {
                if (rbsevenanswer[i].GroupName == t) rbsevenanswer[i].IsEnabled = false;
            }
        }

        private void RadioButton_Checked6(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbnineanswer.Length; i++)
            {
                if (rbnineanswer[i].GroupName == t) rbnineanswer[i].IsEnabled = false;
            }
        }
        private void RadioButton_Checked7(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < rbtenanswer.Length; i++)
            {
                if (rbtenanswer[i].GroupName == t) rbtenanswer[i].IsEnabled = false;
            }
        }
        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < ch_t.Length; i++)
            {
                if (ch_t[i].GroupName == t) ch_t[i].IsEnabled = false;
            }
            for (int i = 0; i < ch_f.Length; i++)
            {
                if (ch_f[i].GroupName == t) ch_f[i].IsEnabled = false;
            }
        }


        //задание 8
        public void q8()
        {
            SV.Visibility = Visibility.Visible;
      
            TextBlock l = new TextBlock();

            l.TextWrapping = TextWrapping.Wrap;


            l.Width = 700;
            l.Height = 200;
            l.FontSize = 14;
            CVS.Children.Add(l);

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select q_text from quests where q_num=8";


            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
                while (reader.Read())
                {


                    l.Text = reader.GetString(0)+"\n   T   F";


                }


            conn.Close();

            conn.Open();
            string sql1 = "select truee from answers where q_num=8 and a_num_q=1 ";

            MySqlCommand command1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = command1.ExecuteReader();
            int i = 0;

            if (reader1.HasRows)
                while (reader1.Read())
                {
                    ch_t8[i] = new RadioButton();
                    ch_t8[i].FontSize = 14;
                    ch_t8[i].GroupName = "gr2" + i;
                    ch_t8[i].Checked += RadioButton_Checked8;
                    t8[i] = reader1.GetInt32(0);
                    i++;

                }
            i = 0;
            conn.Close();
            conn.Open();
            string sql2 = "select a_text, truee from answers where q_num=8 and a_num_q=2 ";

            MySqlCommand command2 = new MySqlCommand(sql2, conn);

            MySqlDataReader reader2 = command2.ExecuteReader();


            if (reader2.HasRows)
                while (reader2.Read())
                {
                    ch_f8[i] = new RadioButton();
                    ch_f8[i].GroupName = "gr2" + i;
                    ch_f8[i].FontSize = 14;
                    ch_f8[i].Content = reader2.GetString(0);
                    f8[i] = reader2.GetInt32(1);
                    ch_f8[i].Checked += RadioButton_Checked8;
                    i++;

                }
            conn.Close();
            for (i = 0; i < 5; i++)
            {

                Canvas.SetLeft(ch_t8[i], 5);
                Canvas.SetTop(ch_t8[i], (i * 20) + 60);
                CVS.Children.Add(ch_t8[i]);
                Canvas.SetLeft(ch_f8[i], 25);
                Canvas.SetTop(ch_f8[i], (i * 20) + 60);
                CVS.Children.Add(ch_f8[i]);
            }


        }


        private void RadioButton_Checked8(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string t = pressed.GroupName;
            for (int i = 0; i < ch_t8.Length; i++)
            {
                if (ch_t8[i].GroupName == t) ch_t8[i].IsEnabled = false;
            }
            for (int i = 0; i < ch_f8.Length; i++)
            {
                if (ch_f8[i].GroupName == t) ch_f8[i].IsEnabled = false;
            }
        }


        //проверка и переключение
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          

            if (q_num == 0)
            {
                media.Stop();
                for (int i = 0; i < ch_t.Length; i++)
                {
                    if (ch_t[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                for (int i = 0; i < ch_t.Length; i++)
                {
                    if (ch_f[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }

                int kol_p = 0; 
               
                for (int i = 0; i < 6; i++)
                {
                    if ((bool)ch_t[i].IsChecked) { t_u[i] = 1;f_u[i] = 0; }
                    if ((bool)ch_f[i].IsChecked) { t_u[i] = 0; f_u[i] = 1; }
                    if (t_u[i] == t[i] && f_u[i] == f[i]) kol_p++;
                }
               
                mas[0] = kol_p;
              
                q_num++;
                CVS.Children.Clear();

                show();
                return;
            }

            if (q_num == 1)
            {
                media.Stop();
                int kol_p = 0;
                int kk = 0;
                for (int i = 0; i < 8; i++)
                {
                   
                    int temp = -1;
                    if (cmb[i].SelectedItem.ToString() == "--") { temp = -1; kk++; } else { temp = Convert.ToInt32(cmb[i].SelectedItem); }
                    if(kk>3) { MessageBox.Show("Выберите соответствия "); return; }
                    
                    //  MessageBox.Show("" + temp + " " + mas_t_for[i]);
                    if (temp == mas_t_for[i]) kol_p++;
                }
                if (kk < 3) { MessageBox.Show("Соответствия повторяются "); return; }
                mas[3] = kol_p;

                q_num++;

                CVS.Children.Clear();
                show();
                return;

           
            }

            if (q_num == 2)
            {
                for (int i = 0; i < rbtwoanswer.Length; i++)
                {
                    if (rbtwoanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                

                q_num++;
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=2  ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[3];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;
                for (int i = 0; i < rbtwoanswer.Length; i++)
                {
                    if (rbtwoanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbtwoanswer[i].GroupName);
                        if (rbtwoanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[1] = kolv;

                show();
                return;
            }
            if (q_num == 3)
            {
                media.Stop();
                for (int i = 0; i < rbthreeanswer.Length; i++)
                {
                    if (rbthreeanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                q_num++;
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=3  ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[10];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbthreeanswer.Length; i++)
                {
                    if (rbthreeanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbthreeanswer[i].GroupName);
                        if (rbthreeanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[2] = kolv;

                show();
                return;

            }

            if (q_num == 4)
            {
                media.Stop();
                for (int i = 0; i < rbfiveanswer.Length; i++)
                {
                    if (rbfiveanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                q_num++;
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=5  ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[12];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbfiveanswer.Length; i++)
                {
                    if (rbfiveanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbfiveanswer[i].GroupName);
                        if (rbfiveanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[4] = kolv;


                show();
                return;
            }
            if (q_num == 5)
            {
                media.Stop();
                for (int i = 0; i < rbsixanswer.Length; i++)
                {
                    if (rbsixanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                media.Stop();
                q_num++;
                CVS.Children.Clear();
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=6 ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[5];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbsixanswer.Length; i++)
                {
                    if (rbsixanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbsixanswer[i].GroupName);
                        if (rbsixanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[5] = kolv;
            
                q7();
                return;
            }
            if (q_num == 6)
            {
                media.Stop();
                for (int i = 0; i < rbtwoanswer.Length; i++)
                {
                    if (rbsevenanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                media.Stop();
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=7 ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[5];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbsevenanswer.Length; i++)
                {
                    if (rbsevenanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbsevenanswer[i].GroupName);
                        if (rbsevenanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[6] = kolv;
                
                q_num ++;
                q8();
                return;
            }
            if (q_num == 7)
            {

                media.Stop();
                int kol_p = 0;
                for (int i = 0; i < ch_t8.Length; i++)
                {
                    if (ch_t8[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                for (int i = 0; i < ch_t8.Length; i++)
                {
                    if (ch_f8[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                for (int i = 0; i < 5; i++)
                {
                    if ((bool)ch_t8[i].IsChecked) { t_u8[i] = 1; f_u8[i] = 0; }
                    if ((bool)ch_f8[i].IsChecked) { t_u8[i] = 0; f_u8[i] = 1; }
                    if (t_u8[i] == t8[i] && f_u8[i] == f8[i]) kol_p++;
                }
              
                mas[7] = kol_p;
              media.Stop();
                q_num++;
                CVS.Children.Clear();
             
                 q9();
                return;
            }
            if (q_num == 8)
            {
                for (int i = 0; i < rbnineanswer.Length; i++)
                {
                    if (rbnineanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                media.Stop();
                q_num++;
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=9 ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[5];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbnineanswer.Length; i++)
                {
                    if (rbnineanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbnineanswer[i].GroupName);
                        if (rbnineanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                mas[8] = kolv;
               

                q10();
                return;
            }
            if (q_num == 9)
            {
                for (int i = 0; i < rbtenanswer.Length; i++)
                {
                    if (rbtenanswer[i].IsEnabled == true) { MessageBox.Show("Ответьте на вопросы"); return; }
                }
                media.Stop();
                q_num++;
                CVS.Children.Clear();

                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT a_text FROM answers WHERE truee=1 and q_num=9 ORDER BY id ASC ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                string[] otv = new string[5];
                int i1 = 0;
                if (reader.HasRows)
                    while (reader.Read())
                    {

                        otv[i1] = reader.GetString(0);
                        i1++;
                    }
                conn.Close();
                int kolv = 0;

                for (int i = 0; i < rbnineanswer.Length; i++)
                {
                    if (rbnineanswer[i].IsChecked == true)
                    {
                        int temp = Convert.ToInt32(rbnineanswer[i].GroupName);
                        if (rbnineanswer[i].Content.ToString() == otv[temp - 1])
                        {
                            kolv++;
                        }
                    }

                }
                started = false;
                mas[9] = kolv;
                listen.Visibility = Visibility.Collapsed;
                Stop.Visibility = Visibility.Collapsed;
                for (int i = 0; i < mas.Length; i++)
                {
                    points+=mas[i]* 1.5625;
                }
                end();
              


                conn.Open();

                string str = "Select canceled from rezults where log = '" + login.Text + "'";
                MySqlCommand command2 = new MySqlCommand(str, conn);

                MySqlDataReader reader2 = command2.ExecuteReader();
                int cancel = 0;
                if (reader2.HasRows)
                    while (reader2.Read())
                    {
                        cancel = reader2.GetInt32(0);
                    }
                conn.Close();
                if (cancel != 1)
                {
                    str = " INSERT INTO rezults(log,points,canceled) VALUES('" + login.Text + "'," + Math.Round(points) + ",1)";
                    conn.Open();
                    command2 = new MySqlCommand(str, conn);
                    command2.ExecuteScalar();                 
                   conn.Close();
                }
                    return;    
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (q_num == 0)
            {
                if(media.Position== new TimeSpan(0, 0, 0, 0, 0))
                media.Source = new Uri(@"picture\21.mp3", UriKind.RelativeOrAbsolute);
                media.Play();

            }
            else
            {
                if (media.Position == new TimeSpan(0, 0, 0, 0, 0))
                    media.Source = new Uri(@"picture\config.mp3", UriKind.RelativeOrAbsolute);
                media.Play();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        
            media.Pause();
        }

        private void Next2_Click(object sender, RoutedEventArgs e)
        {
            if (q_num == 0) { Next2.Visibility = Visibility.Collapsed; q1();  }
            if (q_num == 1) { Next2.Visibility = Visibility.Collapsed; q4(); listen.Visibility = Visibility.Collapsed; Stop.Visibility = Visibility.Collapsed; }
            if (q_num == 2) { Next2.Visibility = Visibility.Collapsed; q2(); }
            if (q_num == 3) { Next2.Visibility = Visibility.Collapsed; q3(); }
            if (q_num == 4) { Next2.Visibility = Visibility.Collapsed; q5(); }
            if (q_num == 5) { Next2.Visibility = Visibility.Collapsed; q6(); }
        }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (started==true)
            {
               
                media.Stop();
                media.Position = new TimeSpan(0, 0, 0, 0, 0);
                

            }
            else
            {
                media.Source = new Uri(@"picture\13.mp3", UriKind.RelativeOrAbsolute);
                media.Play();
            }
        }
    }
}