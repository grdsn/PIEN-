using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        //=========================================================================================================================================================//

        // ドキュメント読み込み完了時の処理
        private void ｗebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // ★★★読み込んだドキュメントのHTMLをテキストボックスに表示する★★★
            HTMLBOX.Text = webBrowser1.DocumentText;
        }

        //=========================================================================================================================================================//


        private void テキストボックス追加_Click(object sender, EventArgs e) // テキストボックス追加 //
        {
            //プレビュー

            webBrowser1.DocumentText =
            "<input type='text' name='name'>";



            //HTML

            HTMLBOX.Text =
            "<input type='text' name='name'>";
        }

        //=========================================================================================================================================================//

        private void テキスト追加ボタン_Click(object sender, EventArgs e) // テキスト追加 //
        { 
            //プレビュー

            webBrowser1.DocumentText =
            "<p>" + テキスト追加textBox.Text + "</p>";



            //HTML

            HTMLBOX.Text =
            "<p>" + テキスト追加textBox.Text + "</p>";

        }

        //=========================================================================================================================================================//

        private void URLリンク追加_Click(object sender, EventArgs e) // URLリンク追加ボタン //
        {
            //プレビュー

            webBrowser1.DocumentText =
            "<a href='" + URL入力textbox.Text + "'>" + URLタイトルtextbox.Text + "</a>";



            //HTML

            HTMLBOX.Text =
            "<a href='" + URL入力textbox.Text + "'>" + URLタイトルtextbox.Text + "</a>";
        }

        //=========================================================================================================================================================//

        /// <summary>
        /// 参照ボタンクリックイベント.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 画像追加_Click(object sender, EventArgs e) // 画像追加ボタン //
        {
            
               Form2 form2 = new Form2();
               form2.Show();
            
        }

        //=========================================================================================================================================================//



        private Bitmap ImageFileOpen(string fileName)
        {
            throw new NotImplementedException();
        }

        private void 動画追加_Click(object sender, EventArgs e)　// 動画追加ボタン //
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);



                //プレビュー
                webBrowser1.DocumentText = "<img src='pien.png'>";


                //HTML
                HTMLBOX.Text =
              "< img src = " + ofd.FileName + " >";


            }
        }

        //=========================================================================================================================================================//

        private void Webタイトル追加_Click(object sender, EventArgs e) // Webタイトル追加ボタン //
        {
            //プレビュー

            webBrowser1.DocumentText =
            "<title>" + Webタイトル追加textBox.Text + "</title>";



            //HTML

            HTMLBOX.Text =
            "<title>" + Webタイトル追加textBox.Text + "</title>";
        }

        //=========================================================================================================================================================//

        private void タイトル追加_Click(object sender, EventArgs e) // タイトル追加 //
        {
            //プレビュー

            webBrowser1.DocumentText =
            "<h1>" + タイトル追加textbox.Text + "<h1>";



            //HTML

            HTMLBOX.Text =
            "<h1>" + タイトル追加textbox.Text + "<h1>";
        }
        //=========================================================================================================================================================//


        private void ボタン追加_Click(object sender, EventArgs e) // ボタン追加 //
        { 
            //プレビュー

            webBrowser1.DocumentText =
            "<p><input type='button' value='" + ボタンタイトルtextBox.Text + "' id='button2'></p>";



            //HTML

            HTMLBOX.Text =
            "<p><input type=”button” value=”" + ボタンタイトルtextBox.Text + "” id=”button2”></p>";
        }

        //=========================================================================================================================================================//

        private void 表追加ボタン_Click(object sender, EventArgs e) // テスト中 //
        {
            /*//プレビュー

            webBrowser1.DocumentText =
            "<table border='1'>" +
             " < tr >" +
              "< th > 果物 </ th >< th > 味 </ th >" +
               " </ tr >" +
                " < tr >" +
                "< td > イチゴ </ td >< td > 甘い </ td >" +
                "</ tr >" +
                "< tr >" +
               "< td > レモン </ td >< td > 酸っぱい </ td >" +
               "</ tr >" +
               "</ table >";



            //HTML

            HTMLBOX.Text =
            "<table border='1'><br>" +
             " < tr ><br>" +
              "< th > 果物 </ th >< th > 味 </ th ><br>" +
               " </ tr ><br>" +
                " < tr ><br>" +
                "< td > イチゴ </ td >< td > 甘い </ td ><br>" +
                "</ tr ><br>" +
                "< tr ><br>" +
               "< td > レモン </ td >< td > 酸っぱい </ td ><br>" +
               "</ tr ><br>" +
               "</ table >";*/
        }
    }
}
     