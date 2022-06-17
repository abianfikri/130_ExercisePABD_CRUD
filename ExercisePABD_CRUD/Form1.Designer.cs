
namespace ExercisePABD_CRUD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pemainID = new System.Windows.Forms.TextBox();
            this.namaPemain = new System.Windows.Forms.TextBox();
            this.umurPemain = new System.Windows.Forms.TextBox();
            this.posisiPemain = new System.Windows.Forms.TextBox();
            this.gajiPemain = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemainBolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUD_PABDDataSet = new ExercisePABD_CRUD.CRUD_PABDDataSet();
            this.pemainBolaTableAdapter = new ExercisePABD_CRUD.CRUD_PABDDataSetTableAdapters.PemainBolaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemainBolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pemain";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pemain";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Umur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Posisi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gaji";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pemainID
            // 
            this.pemainID.Location = new System.Drawing.Point(178, 63);
            this.pemainID.Name = "pemainID";
            this.pemainID.Size = new System.Drawing.Size(236, 22);
            this.pemainID.TabIndex = 5;
            this.pemainID.TextChanged += new System.EventHandler(this.pemainID_TextChanged);
            // 
            // namaPemain
            // 
            this.namaPemain.Location = new System.Drawing.Point(178, 112);
            this.namaPemain.Name = "namaPemain";
            this.namaPemain.Size = new System.Drawing.Size(236, 22);
            this.namaPemain.TabIndex = 6;
            this.namaPemain.TextChanged += new System.EventHandler(this.namaPemain_TextChanged);
            // 
            // umurPemain
            // 
            this.umurPemain.Location = new System.Drawing.Point(178, 157);
            this.umurPemain.Name = "umurPemain";
            this.umurPemain.Size = new System.Drawing.Size(236, 22);
            this.umurPemain.TabIndex = 7;
            this.umurPemain.TextChanged += new System.EventHandler(this.umurPemain_TextChanged);
            // 
            // posisiPemain
            // 
            this.posisiPemain.Location = new System.Drawing.Point(178, 203);
            this.posisiPemain.Name = "posisiPemain";
            this.posisiPemain.Size = new System.Drawing.Size(236, 22);
            this.posisiPemain.TabIndex = 8;
            this.posisiPemain.TextChanged += new System.EventHandler(this.posisiPemain_TextChanged);
            // 
            // gajiPemain
            // 
            this.gajiPemain.Location = new System.Drawing.Point(178, 246);
            this.gajiPemain.Name = "gajiPemain";
            this.gajiPemain.Size = new System.Drawing.Size(236, 22);
            this.gajiPemain.TabIndex = 9;
            this.gajiPemain.TextChanged += new System.EventHandler(this.gajiPemain_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(560, 112);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 44);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update.Location = new System.Drawing.Point(560, 162);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 38);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(560, 209);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 43);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpemainDataGridViewTextBoxColumn,
            this.namapemainDataGridViewTextBoxColumn,
            this.umurDataGridViewTextBoxColumn,
            this.posisiDataGridViewTextBoxColumn,
            this.gajiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemainBolaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idpemainDataGridViewTextBoxColumn
            // 
            this.idpemainDataGridViewTextBoxColumn.DataPropertyName = "id_pemain";
            this.idpemainDataGridViewTextBoxColumn.HeaderText = "id_pemain";
            this.idpemainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpemainDataGridViewTextBoxColumn.Name = "idpemainDataGridViewTextBoxColumn";
            // 
            // namapemainDataGridViewTextBoxColumn
            // 
            this.namapemainDataGridViewTextBoxColumn.DataPropertyName = "nama_pemain";
            this.namapemainDataGridViewTextBoxColumn.HeaderText = "nama_pemain";
            this.namapemainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapemainDataGridViewTextBoxColumn.Name = "namapemainDataGridViewTextBoxColumn";
            // 
            // umurDataGridViewTextBoxColumn
            // 
            this.umurDataGridViewTextBoxColumn.DataPropertyName = "umur";
            this.umurDataGridViewTextBoxColumn.HeaderText = "umur";
            this.umurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umurDataGridViewTextBoxColumn.Name = "umurDataGridViewTextBoxColumn";
            // 
            // posisiDataGridViewTextBoxColumn
            // 
            this.posisiDataGridViewTextBoxColumn.DataPropertyName = "posisi";
            this.posisiDataGridViewTextBoxColumn.HeaderText = "posisi";
            this.posisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.posisiDataGridViewTextBoxColumn.Name = "posisiDataGridViewTextBoxColumn";
            // 
            // gajiDataGridViewTextBoxColumn
            // 
            this.gajiDataGridViewTextBoxColumn.DataPropertyName = "gaji";
            this.gajiDataGridViewTextBoxColumn.HeaderText = "gaji";
            this.gajiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gajiDataGridViewTextBoxColumn.Name = "gajiDataGridViewTextBoxColumn";
            // 
            // pemainBolaBindingSource
            // 
            this.pemainBolaBindingSource.DataMember = "PemainBola";
            this.pemainBolaBindingSource.DataSource = this.cRUD_PABDDataSet;
            this.pemainBolaBindingSource.CurrentChanged += new System.EventHandler(this.pemainBolaBindingSource_CurrentChanged);
            // 
            // cRUD_PABDDataSet
            // 
            this.cRUD_PABDDataSet.DataSetName = "CRUD_PABDDataSet";
            this.cRUD_PABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemainBolaTableAdapter
            // 
            this.pemainBolaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STXihei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATA PEMAIN BOLA SSB PLUTO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(560, 68);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 38);
            this.tambah.TabIndex = 15;
            this.tambah.Text = "Add";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.gajiPemain);
            this.Controls.Add(this.posisiPemain);
            this.Controls.Add(this.umurPemain);
            this.Controls.Add(this.namaPemain);
            this.Controls.Add(this.pemainID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemainBolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pemainID;
        private System.Windows.Forms.TextBox namaPemain;
        private System.Windows.Forms.TextBox umurPemain;
        private System.Windows.Forms.TextBox posisiPemain;
        private System.Windows.Forms.TextBox gajiPemain;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CRUD_PABDDataSet cRUD_PABDDataSet;
        private System.Windows.Forms.BindingSource pemainBolaBindingSource;
        private CRUD_PABDDataSetTableAdapters.PemainBolaTableAdapter pemainBolaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

