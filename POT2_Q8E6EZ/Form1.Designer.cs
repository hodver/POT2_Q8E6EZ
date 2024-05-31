namespace POT2_Q8E6EZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            kavezoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            varosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            napiLatogatokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profitEZREuroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kavezoAdatBindingSource = new BindingSource(components);
            buttonNew = new Button();
            buttonDel = new Button();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonFact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kavezoAdatBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kavezoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, varosDataGridViewTextBoxColumn, napiLatogatokDataGridViewTextBoxColumn, profitEZREuroDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kavezoAdatBindingSource;
            dataGridView1.Location = new Point(13, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 354);
            dataGridView1.TabIndex = 0;
            // 
            // kavezoIDDataGridViewTextBoxColumn
            // 
            kavezoIDDataGridViewTextBoxColumn.DataPropertyName = "KavezoID";
            kavezoIDDataGridViewTextBoxColumn.HeaderText = "KavezoID";
            kavezoIDDataGridViewTextBoxColumn.Name = "kavezoIDDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // varosDataGridViewTextBoxColumn
            // 
            varosDataGridViewTextBoxColumn.DataPropertyName = "Varos";
            varosDataGridViewTextBoxColumn.HeaderText = "Varos";
            varosDataGridViewTextBoxColumn.Name = "varosDataGridViewTextBoxColumn";
            // 
            // napiLatogatokDataGridViewTextBoxColumn
            // 
            napiLatogatokDataGridViewTextBoxColumn.DataPropertyName = "NapiLatogatok";
            napiLatogatokDataGridViewTextBoxColumn.HeaderText = "NapiLatogatok";
            napiLatogatokDataGridViewTextBoxColumn.Name = "napiLatogatokDataGridViewTextBoxColumn";
            // 
            // profitEZREuroDataGridViewTextBoxColumn
            // 
            profitEZREuroDataGridViewTextBoxColumn.DataPropertyName = "ProfitEZREuro";
            profitEZREuroDataGridViewTextBoxColumn.HeaderText = "ProfitEZREuro";
            profitEZREuroDataGridViewTextBoxColumn.Name = "profitEZREuroDataGridViewTextBoxColumn";
            // 
            // kavezoAdatBindingSource
            // 
            kavezoAdatBindingSource.DataSource = typeof(KavezoAdat);
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(713, 419);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "Új sor";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(632, 419);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Törlés";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(702, 21);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Betöltés";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(621, 21);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonFact
            // 
            buttonFact.Location = new Point(13, 12);
            buttonFact.Name = "buttonFact";
            buttonFact.Size = new Size(75, 23);
            buttonFact.TabIndex = 5;
            buttonFact.Text = "Érdekességek";
            buttonFact.UseVisualStyleBackColor = true;
            buttonFact.Click += buttonFact_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFact);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(buttonDel);
            Controls.Add(buttonNew);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kavezoAdatBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonNew;
        private Button buttonDel;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonFact;
        private DataGridViewTextBoxColumn kavezoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napiLatogatokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitEZREuroDataGridViewTextBoxColumn;
        private BindingSource kavezoAdatBindingSource;
    }
}