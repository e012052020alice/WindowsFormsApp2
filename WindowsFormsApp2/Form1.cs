using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
//處理1.歷史紀錄是否要分開
//處理2.美化
//威力彩一樣的號碼可以重複買嗎?(看按加入選號紀錄這個按鈕有沒有要加這個條件)
//額外:自選號碼按超過數量是否要加MessageBox
//包含號碼數(5或6個)量和包牌數量(100個)問題
//二區包含和剔除有問題*二區包含就是選擇了)

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Label myPGLabelOne;
        List<Button> listPG選號按鈕 = new List<Button>();
        List<Button> listPG選號按鈕2 = new List<Button>();
        List<Button> listPG包牌選號按鈕1 = new List<Button>();
        List<Button> listPG包牌選號按鈕2 = new List<Button>();
        List<int> mylist = new List<int>();//每次快選都會清空(包括1和2選區)
        List<int> my包牌list = new List<int>();
        List<int> my包牌包含數量 = new List<int>();
        List<int> my包牌剔除數量 = new List<int>();
        List<int> my二區包牌包含數量 = new List<int>();
        List<int> my二區包牌剔除數量 = new List<int>();
        List<Label> list號碼標籤 = new List<Label>();
        List<Label> list得獎號碼標籤 = new List<Label>();
        bool is自選號碼 = false;
        bool is包含號碼 = false;
        bool is剔除號碼 = false;
        bool is開講換期 = false;
        bool is刪除選號 = false;
        bool is開獎後對獎 = true;
        int buttonCount = 0;//自選號碼時使用
        int buttonCount2 = 0;
        int count開獎 = 0;
        int count購買 = 1;
        int count包含號碼 = 0;
        int count剔除號碼 = 0;
        int count二區包含號碼 = 0;
        int count二區剔除號碼 = 0;
        int selectedIndex = 0;
        Random myRand = new Random();
        //TabPage tabPage = new TabPage("tab選號");
        private int currentPageIndex = 0;  // 当前显示的页面索引
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            程式化語法產生Label();
            程式化語法產生選號紐(6, 7);

            list得獎號碼標籤.Add(lblwinning1);
            list得獎號碼標籤.Add(lblwinning2);
            list得獎號碼標籤.Add(lblwinning3);
            list得獎號碼標籤.Add(lblwinning4);
            list得獎號碼標籤.Add(lblwinning5);
            list得獎號碼標籤.Add(lblwinning6);
            list得獎號碼標籤.Add(lblwinning7);//第二選區

        }

        void 程式化語法產生Label()
        {
            myPGLabelOne = new Label();
            myPGLabelOne.BackColor = Color.LightSalmon;
            myPGLabelOne.ForeColor = Color.Blue;
            myPGLabelOne.Font = new Font("微軟正黑體", 18);
            myPGLabelOne.Text = "包你中(才怪)彩券行投注單";
            myPGLabelOne.Location = new Point(175, 10);//X,Y
            myPGLabelOne.Size = new Size(550, 36);//W,H
            myPGLabelOne.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(myPGLabelOne);//Form的集合，加入到Form中
            //tab選號.Controls.Add(myPGLabelOne);
            //tabPage.Controls.Add(myPGLabelOne);
            //tabControl1.TabPages.Add(tab選號);

        }

        void 程式化語法產生選號紐(int col, int row)
        {
            int 號碼 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (號碼 > 37)
                    {
                        break;
                    }
                    號碼++;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    dButton.ForeColor = Color.Blue;
                    dButton.Font = new Font("微軟正黑體", 13);
                    dButton.Text = string.Format("{0}", 號碼);
                    dButton.Location = new Point(20 + 58 * j, 15 + 32 * i);
                    dButton.Size = new Size(46, 30);
                    dButton.Click += new EventHandler(dButton_Click);//+=事件指定運算值 , -= 事件解除運算子
                    dButton.Name = string.Format("btn{0}", 號碼);
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(dButton.ClientRectangle);
                    dButton.Region = new Region(path);
                    //Controls.Add(dButton);
                    tab選號.Controls.Add(dButton);
                    //tab包牌.Controls.Add(dButton);//只能有一个父控件(只會顯示在一個頁面)
                    listPG選號按鈕.Add(dButton);//同時加入的原因:加入都是記憶體的位置，都不是按鈕本身
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Button dButton = new Button();
                dButton.BackColor = Color.Beige;
                dButton.ForeColor = Color.Blue;
                dButton.Font = new Font("微軟正黑體", 13);
                dButton.Text = string.Format("{0}", i + 1);
                dButton.Location = new Point(20 + 48 * i, 250);
                dButton.Size = new Size(46, 30);
                dButton.Click += new EventHandler(dButton_Click);//+=事件指定運算值 , -= 事件解除運算子
                dButton.Name = string.Format("btn2{0}", i);

                //Controls.Add(dButton);
                tab選號.Controls.Add(dButton);
                listPG選號按鈕2.Add(dButton);//
            }
            //包牌按鈕
            號碼 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (號碼 > 37)
                    {
                        break;
                    }
                    號碼++;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    dButton.ForeColor = Color.Blue;
                    dButton.Font = new Font("微軟正黑體", 13);
                    dButton.Text = string.Format("{0}", 號碼);
                    dButton.Location = new Point(20 + 58 * j, 15 + 32 * i);
                    dButton.Size = new Size(46, 30);
                    dButton.Click += new EventHandler(dButton_Click);//+=事件指定運算值 , -= 事件解除運算子
                    dButton.Name = string.Format("btn包牌號碼{0}", 號碼);
                    tab包牌.Controls.Add(dButton);
                    listPG包牌選號按鈕1.Add(dButton);//同時加入的原因:加入都是記憶體的位置，都不是按鈕本身
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Button dButton = new Button();
                dButton.BackColor = Color.Beige;
                dButton.ForeColor = Color.Blue;
                dButton.Font = new Font("微軟正黑體", 13);
                dButton.Text = string.Format("{0}", i + 1);
                dButton.Location = new Point(20 + 48 * i, 240);
                dButton.Size = new Size(46, 30);
                dButton.Click += new EventHandler(dButton_Click);//+=事件指定運算值 , -= 事件解除運算子
                dButton.Name = string.Format("btn2包牌號碼{0}", i);

                //Controls.Add(dButton);
                tab包牌.Controls.Add(dButton);
                listPG包牌選號按鈕2.Add(dButton);//
            }

        }

        private void dButton_Click(object sender, EventArgs e)//object(Reference) sender:按鈕
        {

            //選號
            if (selectedIndex == 0)
            {
                Button myBtn = (Button)sender;//()將物件轉回原來的資料型態，ConvertTo是強制轉換
                                              //MessageBox.Show($"按下選號按鈕:{myBtn.Name}");
                                              //選號紐超過6個就不會變色，
                                              //string str = "";
                is自選號碼 = true;
                if (mylist.Count == 7)
                {
                    mylist.RemoveAt(6);
                }

                if (myBtn.BackColor == Color.Red)
                {
                    //移出所選號碼list
                    myBtn.BackColor = Color.Pink;
                    //str = myBtn.Text;
                    mylist.Remove(Convert.ToInt32(myBtn.Text));
                    buttonCount--;
                }
                else if (myBtn.BackColor == Color.Pink)
                {
                    //加入所選號碼list，檢查所選號碼有無超過6個
                    if (buttonCount < 6)
                    {
                        myBtn.BackColor = Color.Red;
                        mylist.Add(Convert.ToInt32(myBtn.Text));
                        buttonCount++;
                    }
                }
                //選區2
                else if (myBtn.BackColor == Color.Aqua)
                {
                    //移出所選號碼list
                    myBtn.BackColor = Color.Beige;
                    buttonCount2 = 0;
                }
                else
                {
                    //加入所選號碼list，檢查所選號碼有無超過6個
                    if (buttonCount2 == 0)
                    {
                        myBtn.BackColor = Color.Aqua;
                        //mylist.Add(Convert.ToInt32(myBtn.Text));
                        buttonCount2 = Convert.ToInt32(myBtn.Text);
                    }
                }
                //Console.WriteLine(buttonCount2);
            }
            //包牌
            else if (selectedIndex == 1)
            {

                Button myBtn包牌 = (Button)sender;
                if (is包含號碼)
                {

                    if (myBtn包牌.BackColor == Color.Red)
                    {
                        //移出所選號碼list
                        lbl包含號碼2.Text = "";
                        myBtn包牌.BackColor = Color.Pink;

                        my包牌包含數量.Remove(Convert.ToInt32(myBtn包牌.Text));
                        foreach (int number包含 in my包牌包含數量)
                        {
                            lbl包含號碼2.Text += $" {string.Join(" ", number包含)}";
                        }
                        count包含號碼--;

                    }
                    else if (myBtn包牌.BackColor == Color.Pink)
                    {
                        if (count包含號碼 < 6)//包含號碼數(5或6個)量和包牌數量(100個)問題
                        {

                            //int buttonNumber;
                            //int.TryParse(myBtn包牌.Text, out buttonNumber);
                            //Console.WriteLine(buttonNumber);
                            if (my包牌剔除數量.Contains(Convert.ToInt32(myBtn包牌.Text)))
                            {
                                MessageBox.Show("此號碼已被剔除選號選取");
                                //Console.WriteLine("此號碼已被剔除選號選取");
                            }
                            else
                            {
                                Console.WriteLine("號碼++");
                                lbl包含號碼2.Text = "";
                                //加入所選號碼list，檢查所選號碼有無超過6個

                                myBtn包牌.BackColor = Color.Red;
                                //lbl包含號碼2.Text += $"{myBtn包牌.Text}  ";
                                my包牌包含數量.Add(Convert.ToInt32(myBtn包牌.Text));
                                foreach (int number包含 in my包牌包含數量)
                                {
                                    lbl包含號碼2.Text += $" {string.Join(" ", number包含)}";
                                }

                                count包含號碼++;
                                //mylist.Add(Convert.ToInt32(myBtn包牌.Text));
                            }

                        }
                        else
                        {
                            MessageBox.Show("第一區不能選取超過6個號碼");
                        }

                    }
                    else if (myBtn包牌.BackColor == Color.Aqua)
                    {
                        //移出所選號碼list
                        lbl二區包含號碼.Text = "";
                        myBtn包牌.BackColor = Color.Beige;
                        my二區包牌包含數量.Remove(Convert.ToInt32(myBtn包牌.Text));
                        foreach (int number包含 in my二區包牌包含數量)
                        {
                            lbl二區包含號碼.Text += $" {string.Join(" ", number包含)}";
                        }
                        count二區包含號碼--;
                    }
                    else
                    {
                        if (count二區包含號碼 < 1)
                        {
                            if (my二區包牌剔除數量.Contains(Convert.ToInt32(myBtn包牌.Text)))
                            {
                                MessageBox.Show("此號碼已被剔除選號選取");
                                //Console.WriteLine("此號碼已被剔除選號選取");
                            }
                            else
                            {
                                lbl二區包含號碼.Text = "";
                                myBtn包牌.BackColor = Color.Aqua;
                                my二區包牌包含數量.Add(Convert.ToInt32(myBtn包牌.Text));
                                foreach (int number包含 in my二區包牌包含數量)
                                {
                                    lbl二區包含號碼.Text += $" {string.Join(" ", number包含)}";
                                }
                                count二區包含號碼++;
                            }

                        }
                        else
                        {
                            MessageBox.Show("第二區只能選取一個包含數字");
                        }
                    }
                }
                else if (is剔除號碼)
                {
                    if (myBtn包牌.BackColor == Color.Red)
                    {
                        //移出所選號碼list
                        lbl剔除號碼.Text = "";
                        myBtn包牌.BackColor = Color.Pink;

                        my包牌剔除數量.Remove(Convert.ToInt32(myBtn包牌.Text));
                        foreach (int number剔除 in my包牌剔除數量)
                        {
                            lbl剔除號碼.Text += $" {string.Join(" ", number剔除)}";
                        }
                        count剔除號碼--;

                    }
                    else if (myBtn包牌.BackColor == Color.Pink)
                    {
                        if (count剔除號碼 < 10)
                        {
                            if (my包牌包含數量.Contains(Convert.ToInt32(myBtn包牌.Text)))
                            {
                                MessageBox.Show("此號碼已被包含選號選取");
                            }
                            else
                            {
                                lbl剔除號碼.Text = "";
                                myBtn包牌.BackColor = Color.Red;
                                my包牌剔除數量.Add(Convert.ToInt32(myBtn包牌.Text));
                                foreach (int number剔除 in my包牌剔除數量)
                                {
                                    lbl剔除號碼.Text += $" {string.Join(" ", number剔除)}";
                                }
                                count剔除號碼++;
                            }

                        }

                    }
                    else if (myBtn包牌.BackColor == Color.Aqua)
                    {
                        //移出所選號碼list
                        lbl二區剔除號碼.Text = "";
                        myBtn包牌.BackColor = Color.Beige;
                        my二區包牌剔除數量.Remove(Convert.ToInt32(myBtn包牌.Text));
                        foreach (int number剔除 in my二區包牌剔除數量)
                        {
                            lbl二區剔除號碼.Text += $" {string.Join(" ", number剔除)}";
                        }
                        count二區剔除號碼--;
                    }
                    else
                    {
                        if (count二區剔除號碼 < 7)
                        {
                            if (my二區包牌包含數量.Contains(Convert.ToInt32(myBtn包牌.Text)))
                            {
                                MessageBox.Show("此數字已被選擇為包含數字");
                            }
                            else
                            {
                                lbl二區剔除號碼.Text = "";
                                myBtn包牌.BackColor = Color.Aqua;
                                my二區包牌剔除數量.Add(Convert.ToInt32(myBtn包牌.Text));
                                foreach (int number剔除 in my二區包牌剔除數量)
                                {
                                    lbl二區剔除號碼.Text += $" {string.Join(" ", number剔除)}";
                                }
                                count二區剔除號碼++;
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("請先按下包含選號或是剔除選號按鈕");
                }
            }
            if (my包牌包含數量.Count == 0)
            {
                lbl包含號碼2.Text = "0";
            }
            if (my包牌剔除數量.Count == 0)
            {
                lbl剔除號碼.Text = "0";
            }
            if (my二區包牌包含數量.Count == 0)
            {
                lbl二區包含號碼.Text = "0";
            }
            if (my二區包牌剔除數量.Count == 0)
            {
                lbl二區剔除號碼.Text = "0";
            }
        }

        private void btn快選_Click(object sender, EventArgs e)
        {
            is自選號碼 = false;
            清除所有號碼();
            //Random myRand=new Random();
            //List<int> mylist = new List<int>();
            mylist.Clear();
            for (int i = 0; i < 6; i += 1)
            {
                int indexNum = 0;
                do
                {
                    indexNum = myRand.Next(1, 38);
                } while (mylist.Contains(indexNum));
                //Console.WriteLine(indexNum);
                mylist.Add(indexNum);
                listPG選號按鈕[indexNum - 1].BackColor = Color.Red;
                //1.利用while迴圈剔除重複
                //2.用加入選號紐加入選號

            }
            mylist.Sort();
            int indexNum2 = 0;
            indexNum2 = myRand.Next(1, 8);
            listPG選號按鈕2[indexNum2 - 1].BackColor = Color.Aqua;
            mylist.Add(indexNum2);
            buttonCount = 6;
            buttonCount2 = indexNum2;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(mylist[i]);
            //}
            //Console.WriteLine(indexNum2);
        }
        void 清除所有號碼()
        {
            foreach (Button button in listPG選號按鈕)
            {
                button.BackColor = Color.Pink;
            }
            foreach (Button button in listPG選號按鈕2)
            {
                button.BackColor = Color.Beige;
            }
            foreach (Button button in listPG包牌選號按鈕1)
            {
                button.BackColor = Color.Pink;
            }
            foreach (Button button in listPG包牌選號按鈕2)
            {
                button.BackColor = Color.Beige;
            }
        }

        private void btn加入選號紀錄_Click(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
            //else
            //{
            //    MessageBox.Show("本期已對獎完畢，請等新一期開獎");
            //}
            //if (lbl開獎期數.Text == lbl購買期數.Text)
            //{

            //}
            if (!is開講換期)
            {
                string str選號 = "";
                if (is自選號碼 == true && buttonCount == 6 && buttonCount2 != 0)
                //if (is自選號碼 == true )
                {
                    mylist.Sort();
                    mylist.Add(buttonCount2);

                }
                if (mylist.Count == 7)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        str選號 += $"{mylist[i]}  ";
                    }
                    lbox選號紀錄.Items.Add(str選號);
                    lbox購買紀錄.Items.Add(str選號);
                    lbl購買期數.Text = $"購買期數:第{count購買}期";
                }
                else
                {
                    MessageBox.Show("不足選號數量，請在第一區選滿6個數，第二區選擇1個");
                }




                //buttonCount = 0;
                //buttonCount2 = 0;
            }
            else
            {
                MessageBox.Show("已開獎，請先對獎");
            }

        }

        private void btn對獎_Click(object sender, EventArgs e)
        {
            if (is開講換期 && lbox購買紀錄.Items.Count != 0)
            {
                List<List<int>> allSelectedNumbers = new List<List<int>>();
                lbox對獎紀錄.Items.Clear();

                //把購買紀錄拆成一個個list
                foreach (string selectNumbers in lbox購買紀錄.Items)
                {
                    string[] numberStrings = selectNumbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (numberStrings.Length >= 7)
                    {
                        List<int> groupNumbers = new List<int>();
                        for (int i = 0; i < numberStrings.Length; i++)
                        {
                            int.TryParse(numberStrings[i], out int number);
                            groupNumbers.Add(number);
                        }
                        //Console.WriteLine(string.Join(", ", groupNumbers));
                        allSelectedNumbers.Add(groupNumbers);

                    }
                }
                //對獎
                int count = 1;
                foreach (List<int> generatelist in allSelectedNumbers)
                {

                    List<int> winninglist = new List<int>();
                    for (int j = 0; j < list得獎號碼標籤.Count; j++)
                    {
                        if (int.TryParse(list得獎號碼標籤[j].Text, out int number))
                        {
                            winninglist.Add(number);
                        }
                    }
                    List<int> generatelistWithoutLast = generatelist.Take(generatelist.Count - 1).ToList();
                    List<int> winninglistWithoutLast = winninglist.Take(winninglist.Count - 1).ToList().ToList();
                    int commonNumbersCount = generatelistWithoutLast.Intersect(winninglistWithoutLast).Count();
                    bool isSecondSectionSame = generatelist.Last() == winninglist.Last();
                    Console.WriteLine(commonNumbersCount);
                    Console.WriteLine(isSecondSectionSame);
                    string str中獎結果 = "";
                    str中獎結果 = how中獎結果(commonNumbersCount, isSecondSectionSame);

                    string str選號 = "";
                    //for (int i = 0; i < list號碼標籤.Count; i++)
                    //{
                    //    str選號 += $"{generatelist[i]}  ";//空
                    //    Console.WriteLine(generatelist[i].ToString());
                    //}
                    //Console.WriteLine(generatelist);
                    str選號 += $"第{count}組\n";
                    str選號 += $" {string.Join(" ", generatelist)}\n";
                    //Console.WriteLine($"選號:{str選號}");
                    //Console.WriteLine($"Generating List: {string.Join(", ", generatelist)}");
                    str選號 += str中獎結果;
                    lbox對獎紀錄.Items.Add(str選號);
                    count++;
                    if (count開獎 != 0)
                    {
                        lbox選號紀錄.Items.Clear();
                        lbox包牌紀錄.Items.Clear();
                        lbox購買紀錄.Items.Clear();
                    }
                    
                }
                is開講換期 = false;
                is開獎後對獎 = true;
                lbl期數.Text = $"第{count購買 - 1}期";
                lbl購買期數.Text = $"第{count購買}期";
                lbox歷史得獎紀錄.Items.Add($"{lbl期數.Text}");
                foreach (var item in lbox對獎紀錄.Items)
                {
                    lbox歷史得獎紀錄.Items.Add(item);
                }

            }
            else if (lbox購買紀錄.Items.Count == 0)
            {
                MessageBox.Show("沒有買票，對什麼獎");
            }
            else if (!is開講換期)
            {
                MessageBox.Show("尚未開新一期獎");
            }

        }
        string how中獎結果(int numbers, bool is第二區)//可能要改lbox多筆獎號對獎
        {
            //lbox對獎紀錄.Items.Clear();
            if (numbers == 6 && is第二區)
            {
                return "恭喜頭獎\n";
            }
            else if (numbers == 6)
            {
                return "恭喜貳獎\n";
            }
            else if (numbers == 5 && is第二區)
            {
                return "恭喜參獎\n獎金:150,000\n";
            }
            else if (numbers == 5)
            {
                return "恭喜肆獎\n獎金:20,000\n";
            }
            else if (numbers == 4 && is第二區)
            {
                return "恭喜伍獎\n獎金:4,000\n";
            }
            else if (numbers == 4)
            {
                return "恭喜陸獎\n獎金:800\n";
            }
            else if (numbers == 3 && is第二區)
            {
                return "恭喜柒獎\n獎金:400\n";
            }
            else if (numbers == 2 && is第二區)
            {
                return "恭喜捌獎\n獎金:200\n";
            }
            else if (numbers == 3)
            {
                return "恭喜玖獎\n獎金:100\n";
            }
            else if (numbers == 1 && is第二區)
            {
                return "普獎一個\n獎金:100\n";
            }
            else
            {
                return "錢錢飛走了~";
            }
        }

        private void btn包牌_Click(object sender, EventArgs e)
        {
            is剔除號碼 = false;
            is包含號碼 = false;
            if (!is開講換期)
            {
                for (int i = 0; i < Convert.ToInt32(textBox包牌數量.Text); i++)
                {
                    my包牌list.Clear();
                    for (int k = 0; k < my包牌包含數量.Count; k++)
                    {
                        my包牌list.Add(my包牌包含數量[k]);
                    }
                    for (int j = 0; j < 6 - my包牌包含數量.Count; j += 1)
                    {
                        int indexNum = 0;
                        do
                        {
                            indexNum = myRand.Next(1, 38);
                        } while (my包牌list.Contains(indexNum) || my包牌剔除數量.Contains(indexNum));
                        my包牌list.Add(indexNum);

                    }
                    my包牌list.Sort();
                    int indexNum2 = 0;
                    if (my二區包牌包含數量.Count == 0)
                    {
                        do
                        {
                            indexNum2 = myRand.Next(1, 8);
                        } while (my包牌list.Contains(indexNum2) || my二區包牌剔除數量.Contains(indexNum2));
                        my包牌list.Add(indexNum2);
                    }
                    else
                    {
                        my包牌list.Add(my二區包牌包含數量[0]);
                    }

                    string str選號 = "";
                    for (int index = 0; index < 7; index++)
                    {
                        str選號 += $"{my包牌list[index]}  ";
                    }

                    lbox包牌紀錄.Items.Add(str選號);
                    lbox購買紀錄.Items.Add(str選號);
                    lbl購買期數.Text = $"購買期數:第{count購買}期";
                }
            }
            else
            {
                MessageBox.Show("已開獎，請先對獎");
            }



        }

        private void btn包含號碼_Click(object sender, EventArgs e)
        {
            is包含號碼 = true;
            is剔除號碼 = false;
            清除所有號碼();

            foreach (Button myButton in listPG包牌選號按鈕1)
            {
                if (my包牌包含數量.Contains(Convert.ToInt32(myButton.Text)))
                {
                    myButton.BackColor = Color.Red;
                }
            }

            foreach (Button myButton in listPG包牌選號按鈕2)
            {
                if (my二區包牌包含數量.Contains(Convert.ToInt32(myButton.Text)))
                {
                    myButton.BackColor = Color.Aqua;
                }
            }

        }

        private void btn剔除號碼_Click(object sender, EventArgs e)
        {
            is剔除號碼 = true;
            is包含號碼 = false;
            清除所有號碼();
            foreach (Button myButton in listPG包牌選號按鈕1)
            {
                if (my包牌剔除數量.Contains(Convert.ToInt32(myButton.Text)))
                {
                    myButton.BackColor = Color.Red;
                }
            }
            foreach (Button myButton in listPG包牌選號按鈕2)
            {
                if (my二區包牌剔除數量.Contains(Convert.ToInt32(myButton.Text)))
                {
                    myButton.BackColor = Color.Aqua;
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = tabControl1.SelectedIndex;
            清除所有號碼();
            buttonCount = 0;
            buttonCount2 = 0;
        }

        private void btn開獎_Click(object sender, EventArgs e)
        {
            //生成得獎號碼
            List<int> my得獎list = new List<int>();

            //if (count開獎 != 0)
            //{
            //    lbox對獎紀錄.Items.Clear();
            //}
            
            

            
            if (!is開獎後對獎 && lbox購買紀錄.Items.Count != 0)
            {
                MessageBox.Show("請先對完當期獎");
            }

            else
            {
                is開講換期 = true;
                count開獎++;
                count購買++;
                lbl開獎期數.Text = $"開獎期數:第{count開獎}期";
                for (int i = 0; i < 6; i += 1)
                {
                    int indexNum = 0;
                    do
                    {

                        indexNum = myRand.Next(1, 38);
                        list得獎號碼標籤[i].Text = Convert.ToString(indexNum);
                    } while (my得獎list.Contains(indexNum));
                    //Console.WriteLine(indexNum);
                    my得獎list.Add(indexNum);

                }
                my得獎list.Sort();
                my得獎list.Add(myRand.Next(1, 8));
                for (int i = 0; i < list得獎號碼標籤.Count; i++)
                {
                    list得獎號碼標籤[i].Text = my得獎list[i].ToString();

                }
                is開獎後對獎 = false;
                
            }

            if (lbox購買紀錄.Items.Count == 0)
            {
                is開講換期 = false;
                is開獎後對獎 = true;
            }
        }

        private void btn刪除所選號碼_Click(object sender, EventArgs e)
        {
            if (lbox選號紀錄.SelectedIndex >= 0)
            {
                string selectedNumber = lbox選號紀錄.SelectedItem.ToString();
                lbox選號紀錄.Items.RemoveAt(lbox選號紀錄.SelectedIndex);
                if (lbox購買紀錄.Items.Contains(selectedNumber))
                {
                    lbox購買紀錄.Items.Remove(selectedNumber);
                    is刪除選號 = true;
                }
            }
            else
            {
                MessageBox.Show("請選擇一組號碼");
            }
        }

        private void btn刪除所有號碼_Click(object sender, EventArgs e)
        {
            string selectedNumber = lbox包牌紀錄.SelectedItem.ToString();
            lbox包牌紀錄.Items.RemoveAt(lbox包牌紀錄.SelectedIndex);
            if (lbox購買紀錄.Items.Contains(selectedNumber))
            {
                lbox購買紀錄.Items.Remove(selectedNumber);
                is刪除選號 = true;
            }
        }
    }

}
