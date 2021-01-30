
namespace CSVMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_Path = new System.Windows.Forms.TextBox();
            this.Reference = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Path
            // 
            this.TextBox_Path.Location = new System.Drawing.Point(12, 49);
            this.TextBox_Path.Name = "TextBox_Path";
            this.TextBox_Path.Size = new System.Drawing.Size(620, 31);
            this.TextBox_Path.TabIndex = 0;
            // 
            // Reference
            // 
            this.Reference.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reference.Location = new System.Drawing.Point(638, 49);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(121, 45);
            this.Reference.TabIndex = 1;
            this.Reference.Text = "参照";
            this.Reference.UseVisualStyleBackColor = true;
            this.Reference.Click += new System.EventHandler(this.Button_Reference_Click);
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Execute.Location = new System.Drawing.Point(535, 135);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(224, 85);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "CSV作成";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Button_Execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.TextBox_Path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Path;
        private System.Windows.Forms.Button Reference;
        private System.Windows.Forms.Button Execute;
    }
}

