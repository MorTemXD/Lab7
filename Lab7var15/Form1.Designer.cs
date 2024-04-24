namespace CoinCollection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxYear = new TextBox();
            textBoxCountry = new TextBox();
            textBoxNominal = new TextBox();
            textBoxCondition = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(76, 204);
            textBoxYear.Margin = new Padding(4, 3, 4, 3);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(116, 23);
            textBoxYear.TabIndex = 1;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(76, 231);
            textBoxCountry.Margin = new Padding(4, 3, 4, 3);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(116, 23);
            textBoxCountry.TabIndex = 2;
            // 
            // textBoxNominal
            // 
            textBoxNominal.Location = new Point(76, 260);
            textBoxNominal.Margin = new Padding(4, 3, 4, 3);
            textBoxNominal.Name = "textBoxNominal";
            textBoxNominal.Size = new Size(116, 23);
            textBoxNominal.TabIndex = 3;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(76, 289);
            textBoxCondition.Margin = new Padding(4, 3, 4, 3);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(116, 23);
            textBoxCondition.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(226, 200);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 27);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(320, 200);
            buttonEdit.Margin = new Padding(4, 3, 4, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(88, 27);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Оновити";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(415, 200);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(88, 27);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(14, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 169);
            listBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 207);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 9;
            label1.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 239);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Країна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 268);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Номінал";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 297);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Стан";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 343);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxCondition);
            Controls.Add(textBoxNominal);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxYear);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Coin Collection";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}