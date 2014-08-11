using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageOrganizing
{
    public partial class Form1 : Form
    {
        private const string appTitle = "画像を整理するぉ!!";

        private const string MSG_COPY = "{0}へコピー済み。";

        /// <summary>
        ///     ドロップで受け取った画像ファイルパスのリスト
        /// </summary>
        private List<string> dropDirFilePath = null;

        /// <summary>
        ///     移動先のディレクトリ1を保持する。
        /// </summary>
        private string moveDirPath1 = null;

        /// <summary>
        ///     移動先のディレクトリ2を保持する。
        /// </summary>
        private string moveDirPath2 = null;

        /// <summary>
        ///     移動先のディレクトリ3を保持する。
        /// </summary>
        private string moveDirPath3 = null;

        /// <summary>
        ///     移動先のディレクトリ4を保持する。
        /// </summary>
        private string moveDirPath4 = null;

        /// <summary>
        ///     移動先のディレクトリ5を保持する。
        /// </summary>
        private string moveDirPath5 = null;

        /// <summary>
        ///     移動先のディレクトリ6を保持する。
        /// </summary>
        private string moveDirPath6 = null;

        /// <summary>
        ///     移動先のディレクトリ7を保持する。
        /// </summary>
        private string moveDirPath7 = null;

        /// <summary>
        ///     移動先のディレクトリ8を保持する。
        /// </summary>
        private string moveDirPath8 = null;

        /// <summary>
        ///     移動先のディレクトリ9を保持する。
        /// </summary>
        private string moveDirPath9 = null;

        /// <summary>
        ///     移動先のディレクトリ10を保持する。
        /// </summary>
        private string moveDirPath10 = null;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     画面ロード時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // AllowDrop がプロパティに表示されないので、ここで設定
            pictureBox1.AllowDrop = true;
        }

        /// <summary>
        ///     ドロップされた全ての画像が処理された際の初期化
        /// </summary>
        private void initialize()
        {
            // pictureBoxとタイトルを初期化。
            pictureBox1.ImageLocation = null;
            this.Text = appTitle;

            // 削除ボタンと次の画像ボタンを非活性化
            deleteButton.Enabled = false;
            nextImageButton.Enabled = false;

            // コピーと移動ボタンを非活性化
            selectionCopyButton.Enabled = false;
            moveButton1.Enabled = false;
            moveButton2.Enabled = false;
            moveButton3.Enabled = false;
            moveButton4.Enabled = false;
            moveButton5.Enabled = false;
            moveButton6.Enabled = false;
            moveButton7.Enabled = false;
            moveButton8.Enabled = false;
            moveButton9.Enabled = false;
            moveButton10.Enabled = false;
        }

        /// <summary>
        ///     画像をpictureBoxにセットする。
        /// </summary>
        private void setImage()
        {
            if (this.dropDirFilePath.Count == 0)
            {
                // フォームを初期化する。
                this.initialize();

                // リストにパスが入っていなかったらメッセージを表示する。
                MessageBox.Show("全ての画像を処理しました。");

                return;
            }

            // 画像をセット。
            pictureBox1.ImageLocation = this.dropDirFilePath[0];

            // ついでに、フォームのタイトルにパスを表示する。
            this.Text = this.dropDirFilePath[0];
        }

        /// <summary>
        ///     次の画像を表示する。
        /// </summary>
        private void setNextImage()
        {
            // 表示している画像のパスをリストから削除。
            this.dropDirFilePath.RemoveAt(0);

            // 次の画像を表示する。
            this.setImage();
        }

        /// <summary>
        ///     選抜へコピーボタン押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void selectionCopyButton_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、選抜ディレクトリへコピーする。
            this.copyOrMove(selectionPathTextBox.Text, 1);
        }

        /// <summary>
        ///     削除ボタン押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(this.dropDirFilePath[0]);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     画面更新ボタン押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            this.buttonAcrivation();
        }

        /// <summary>
        ///     ボタンの活性化
        /// </summary>
        private void buttonAcrivation()
        {
            // 1件以上あれば活性化
            if (this.dropDirFilePath != null && this.dropDirFilePath.Count > 0)
            {
                deleteButton.Enabled = true;
                    nextImageButton.Enabled = true;

                // 選抜へコピーディレクトリのパスが存在すれば活性化
                if (System.IO.Directory.Exists(selectionPathTextBox.Text))
                {
                    selectionCopyButton.Enabled = true;
                }

                // 各ボタンのディレクトリパスが存在すれば活性化
                this.updateButtonDisplay(moveButton1, movePathTextBox1.Text, ref this.moveDirPath1);
                this.updateButtonDisplay(moveButton2, movePathTextBox2.Text, ref this.moveDirPath2);
                this.updateButtonDisplay(moveButton3, movePathTextBox3.Text, ref this.moveDirPath3);
                this.updateButtonDisplay(moveButton4, movePathTextBox4.Text, ref this.moveDirPath4);
                this.updateButtonDisplay(moveButton5, movePathTextBox5.Text, ref this.moveDirPath5);
                this.updateButtonDisplay(moveButton6, movePathTextBox6.Text, ref this.moveDirPath6);
                this.updateButtonDisplay(moveButton7, movePathTextBox7.Text, ref this.moveDirPath7);
                this.updateButtonDisplay(moveButton8, movePathTextBox8.Text, ref this.moveDirPath8);
                this.updateButtonDisplay(moveButton9, movePathTextBox9.Text, ref this.moveDirPath9);
                this.updateButtonDisplay(moveButton10, movePathTextBox10.Text, ref this.moveDirPath10);
            }
        }

        /// <summary>
        ///     受け取ったボタンにpathから取得したディレクトリ名を表示する。
        /// </summary>
        /// <param name="btn">ボタン</param>
        /// <param name="path">ディレクトリのフルパス</param>
        /// <param name="savePath">ディレクトリのフルパスを保存しておく変数</param>
        private void updateButtonDisplay(Button btn, string path, ref string savePath)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    btn.Text = "未入力のため使用禁止";
                    btn.Enabled = false;
                }
                else
                {
                    if (System.IO.Directory.Exists(path))
                    {
                        string a;
                        string b;

                        a = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(path));
                        b = System.IO.Path.GetFileName(path);

                        btn.Text = string.Concat(a, @"\", b);
                        savePath = path;
                        btn.Enabled = true;
                    }
                    else
                    {
                        btn.Text = "存在しないディレクトリ";
                        btn.Enabled = false;
                    }
                }
            }
            catch
            {
                btn.Text = "pathが無効";
                btn.Enabled = false;
            }
        }

        /// <summary>
        ///     対象のディレクトリ
        /// </summary>
        /// <param name="targetDirPath">対象ディレクトリ</param>
        /// <param name="flg">コピーか移動かのフラグ</param>
        /// <remarks>
        ///     flg
        ///     1:コピー
        ///     2:移動
        /// </remarks>
        private void copyOrMove(string targetDirPath, int flg)
        {
            string targetFilePath = string.Concat(targetDirPath, @"\", System.IO.Path.GetFileName(this.dropDirFilePath[0]));

            if (System.IO.File.Exists(targetFilePath))
            {
                // 同名ファイルが存在するので、リネーム処理をする。
                string renameFileName;
                string renameFilaPath;
                int i = 1;

                while (true)
                {
                    renameFileName = string.Concat(System.IO.Path.GetFileNameWithoutExtension(targetFilePath), "_", i.ToString("D4"), System.IO.Path.GetExtension(targetFilePath));

                    renameFilaPath = string.Concat(System.IO.Path.GetDirectoryName(targetFilePath), @"\", renameFileName);

                    if (System.IO.File.Exists(renameFilaPath))
                    {
                        i++;
                    }
                    else
                    {
                        if (flg == 1)
                        {
                            System.IO.File.Copy(this.dropDirFilePath[0], renameFilaPath);
                        }
                        else
                        {
                            System.IO.File.Move(this.dropDirFilePath[0], renameFilaPath);
                        }
                        break;
                    }
                }
            }
            else
            {
                if (flg == 1)
                {
                    System.IO.File.Copy(this.dropDirFilePath[0], targetFilePath);
                }
                else
                {
                    System.IO.File.Move(this.dropDirFilePath[0], targetFilePath);
                }
            }
        }

        /// <summary>
        ///     DragEnterイベントハンドラ
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">DragEventArgs</param>
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            //if (e.Data.GetDataPresent(DataFormats.FileDrop)
            //    || e.Data.GetDataPresent(DataFormats.Bitmap))
            //{
            //    e.Effect = DragDropEffects.Copy;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        /// <summary>
        ///     pictureBoxへのドラッグアンドドロップ時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">DragEventArgs</param>
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // 初期化
            dropDirFilePath = new List<string>();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] dropFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string dropPath in dropFiles)
                {
                    if (System.IO.Directory.Exists(dropPath))
                    {
                        // ドロップされたものがディレクトリだった場合の処理
                        foreach (string dirP in System.IO.Directory.GetFiles(dropPath, "*"))
                        {
                            this.listAdd(dirP);
                        }
                    }
                    else
                    {
                        // ドロップされたものがファイルだった場合の処理
                        this.listAdd(dropPath);
                    }
                }
            }

            this.setImage();

            this.buttonAcrivation();
        }

        /// <summary>
        ///     リストにファイルを追加する。
        /// </summary>
        /// <param name="s">ファイルのフルパス</param>
        private void listAdd(string path)
        {
            string extension = System.IO.Path.GetExtension(path);

            if (this.isAny(extension, new string[] {".jpeg", ".jpg", ".png", ".gif", ".bmp"}))
            {
                this.dropDirFilePath.Add(path);
            }
        }

        /// <summary>
        ///     パラメータの拡張子が、パラメータの配列に一致するか否か
        /// </summary>
        /// <param name="extension">拡張子</param>
        /// <param name="values">対応拡張子の配列</param>
        /// <returns>一致したらtrue、しなければfalse</returns>
        private bool isAny(string extension, string[] values)
        {
            return values.Any(c => c == extension);
        }

        /// <summary>
        ///     次の画像ボタン押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void nextImageButton_Click(object sender, EventArgs e)
        {
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン1押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton1_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath1, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン2押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton2_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath2, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン3押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton3_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath3, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン4押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton4_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath4, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン5押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton5_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath5, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン6押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton6_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath6, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン7押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton7_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath7, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン8押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton8_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath8, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン9押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton9_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath9, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     移動ボタン10押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void moveButton10_Click(object sender, EventArgs e)
        {
            // 「2」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath10, 2);

            // 次のファイルを表示する。
            this.setNextImage();
        }

        /// <summary>
        ///     copyボタン1押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton1_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath1, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "1");
        }

        /// <summary>
        ///     copyボタン2押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton2_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath2, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "2");
        }

        /// <summary>
        ///     copyボタン3押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton3_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath3, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "3");
        }

        /// <summary>
        ///     copyボタン4押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton4_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath4, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "4");
        }

        /// <summary>
        ///     copyボタン5押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton5_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath5, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "5");
        }

        /// <summary>
        ///     copyボタン6押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton6_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath6, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "6");
        }

        /// <summary>
        ///     copyボタン7押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton7_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath7, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "7");
        }

        /// <summary>
        ///     copyボタン8押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton8_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath8, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "8");
        }

        /// <summary>
        ///     copyボタン9押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton9_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath9, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "9");
        }

        /// <summary>
        ///     copyボタン10押下時
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void copyButton10_Click(object sender, EventArgs e)
        {
            // 「1」を渡して、対象ディレクトリへ移動する。
            this.copyOrMove(this.moveDirPath10, 1);

            // タイトルにコピーしたことを通知
            this.Text = string.Format(MSG_COPY, "10");
        }
    }
}
