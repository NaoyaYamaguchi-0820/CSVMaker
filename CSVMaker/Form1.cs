using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Reference_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "HTMLファイル(*.html)|*.html";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.TextBox_Path.Text = ofd.FileName;
            }

        }

        private void Button_Execute_Click(object sender, EventArgs e)
        {

            // テキストボックスが空の場合、処理を終了させる
            if (String.IsNullOrEmpty(this.TextBox_Path.Text))
            {
                MessageBox.Show("ファイルが選択されていません");
                return;
            }

            // テキストボックスに入力されたファイルが存在しない場合、処理を終了させる
            if (File.Exists(this.TextBox_Path.Text) == false)
            {
                MessageBox.Show("指定されたファイルが存在しません");
                return;
            }

            // HTMLファイルをListに変換する
            List<List<string>> list = HtmlToList.GetList(this.TextBox_Path.Text);

            // Listに変換できなかった場合は処理を終了させる
            if (list == null)
            {
                MessageBox.Show("HTMLファイルの解析に失敗しました");
                return;
            }

            // Listをもとに、CSVファイルを生成する
            CsvWriter.CreateCsv(list);

        }
    }
}
