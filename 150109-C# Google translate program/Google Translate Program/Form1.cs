
/* 
일단 char 배열의 안에, .가 있으면 그 다음에 개행을 넣어야 되는데 그렇게 되면 
배열의 크기가 달라진다. 
-> 스트링 = 스티링 + 뉴라인. 이런식이어야 된다는 말이지. 그러고 뉴라인이 붙었으니 스트링 길이도 1또는 2가 늘어났으니 거기에 맞게 for문의 범위도 늘려야 되고
-> 이걸 언제하나? 공백을 지울때? 글을 쓸 때에?
 */

 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Google_Translate_Program
{
    public partial class Form1 : Form
    {


        string[] ShowLanguageList = {
                                        "English",
                                        "Japanese",
                                        "Chinese",
                                        "Vietnamese",
                                        "Mongolian",
                                        "Korean"
                                    };

        string[] forGoogleSiteLanguageList = {
                                              "en",
                                              "ja",
                                              "zh-CN",
                                              "vi",
                                              "mn",
                                              "ko"
                                             };

        public Form1()
        {
            InitializeComponent();
            for(int i = 0 ; i < ShowLanguageList.Count<string>();i++)
            {
                comboBoxLanguageFrom.Items.Insert(i, (object)ShowLanguageList[i]);
                comboBoxLanguageTo.Items.Insert(i, (object)ShowLanguageList[i]);
            }
            comboBoxLanguageFrom.Text = (string)comboBoxLanguageFrom.Items[0]; //en
            comboBoxLanguageTo.Text = (string)comboBoxLanguageFrom.Items[5]; //ko
            
        }

        string googleAddress = "https://translate.google.com/#";
        string language = "";
        string enKo = "en/ko/";
        string jaKo = "ja/ko/";
        string chKo = "zh-CN/ko/";
        string viKo = "vi/ko/";

        string getLanuageAbbreviation(string input)
        {
            for(int i = 0 ; i < ShowLanguageList.Count<string>();i++)
            {
                if (input == ShowLanguageList[i])
                {
                    return forGoogleSiteLanguageList[i];
                }
            }
            return "";
        }

        void languageSelect()
        {
            
            string from = (string)comboBoxLanguageFrom.SelectedItem;
            string to = (string)comboBoxLanguageTo.SelectedItem;

            language = getLanuageAbbreviation(from) + "/" +
                getLanuageAbbreviation(to) + "/";
        }


        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            //string language = jaKo;

            //if (radioButtonEnglish.Checked)
            //{
            //    language = enKo;
            //}
            languageSelect();
            trimBlink();
            webBrowser1.Navigate(googleAddress + language + Clipboard.GetText());            
        }



        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.A | Keys.Control:
                    if (this.ActiveControl is TextBox)
                    {
                        TextBox txt = (TextBox)this.ActiveControl;
                        txt.SelectionStart = 0;
                        txt.SelectionLength = txt.Text.Length;
                        return true;
                    }
                    break;
            }
            return base.ProcessDialogKey(keyData);
        } 


        void trimBlink(int type = 0)
        {
            //만약 '.' 다음이나 ". " 다음이 아니면 newLine 문자를 삭제하는 함수
            int count = textBox1.Lines.Count<string>();
            string[] textBoxFileName = new string[count];

            for (int i = 0; i < count; i++)
            {
                textBoxFileName[i] = textBox1.Lines[i];  //한줄 가져옴

                

                if (type == 0)  //0일 때에만 공백 지우고, 그렇지 않으면 공백은 안지운다
                {
                    int length = textBoxFileName[i].Length;

                    //length -2, -3이 .일 경우 newline 삭제
                    if (length > 2)
                    {
                        if (textBoxFileName[i][length - 3] == '.' ||
                            textBoxFileName[i][length - 2] == '.')
                        {

                        }
                        else
                        {
                            textBoxFileName[i] = textBoxFileName[i].Replace(Environment.NewLine, "");
                        }
                    }
                    else
                    {
                        textBoxFileName[i] = textBoxFileName[i].Replace(Environment.NewLine, "");
                    }
                }
            }

            textBox1.Text = "";
            for (int i = 0; i < count; i++)
            {
                textBox1.AppendText(textBoxFileName[i]);

                if (type == 0)  //타입이 0일 때에만 공백 지우고, 그렇지 않으면 공백은 안지운다
                {
                    if (i + 1 < count)  //0부터 count -1까지란 얘기인듯
                    {
                        if (textBoxFileName[i + 1].Length > 0)
                        {
                            if (textBoxFileName[i + 1][0] != ' ')
                            {
                                textBox1.AppendText(" ");
                            }
                        }
                    }
                }
                else
                {
                    //이 경우 newline을 넣는 이유는 line읽어올 때에 newline까지는 안읽어 왔기 때문?
                    //암튼 원본은 이걸 넣어야 맞음
                    textBox1.AppendText(Environment.NewLine);
                }
            }

            if (textBox1.Text != "")
            {
                Clipboard.SetText(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            languageSelect();


            trimBlink(1);
            webBrowser1.Navigate(googleAddress + language + Clipboard.GetText());       
            
            //Bitmap bt = new Bitmap(this.Width, this.Height);
            //DrawToBitmap(bt, webBrowser1.Bounds);
            //bt.Save("test.bmp");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 900;
        }

        bool[] isFirstTime = { false, true, true, true, true };
        string[] webAddress = {"https://translate.google.com/",
        "http://www.reverso.net/spell-checker/english-spelling-grammar/",
"http://dic.naver.com",
"http://www.learnersdictionary.com",
"http://www.excite.co.jp/world/english/"};

        const int webbrowserSize = 5;
        System.Windows.Forms.WebBrowser[] webbrowsers = new System.Windows.Forms.WebBrowser[webbrowserSize];
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webbrowsers[0] = this.webBrowser1;
            webbrowsers[1] = this.webBrowser2;
            webbrowsers[2] = this.webBrowser5;
            webbrowsers[3] = this.webBrowser10;
            webbrowsers[4] = this.webBrowser7;            

            int index = ((System.Windows.Forms.TabControl)sender).SelectedIndex;
            if (isFirstTime[index] == true)
            {
                isFirstTime[index] = false;
                webbrowsers[index].Url = new Uri(webAddress[index]);
            }
        }
    }
}
