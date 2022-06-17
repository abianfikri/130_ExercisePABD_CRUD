
namespace ExercisePABD_CRUD
{
    partial class Pelatih
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelatih));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pemainBolaTableAdapter = new ExercisePABD_CRUD.CRUD_PABDDataSetTableAdapters.PemainBolaTableAdapter();
            this.cRUD_PABDDataSet = new ExercisePABD_CRUD.CRUD_PABDDataSet();
            this.pemainBolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tambah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.noTlp = new System.Windows.Forms.TextBox();
            this.namaPemain = new System.Windows.Forms.TextBox();
            this.pemainID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cRUD_PABDDataSet1 = new ExercisePABD_CRUD.CRUD_PABDDataSet1();
            this.cRUDPABDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelatihBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelatihTableAdapter = new ExercisePABD_CRUD.CRUD_PABDDataSet1TableAdapters.PelatihTableAdapter();
            this.idpelatihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelatihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemainBolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDPABDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelatihBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pemainBolaTableAdapter
            // 
            this.pemainBolaTableAdapter.ClearBeforeFill = true;
            // 
            // cRUD_PABDDataSet
            // 
            this.cRUD_PABDDataSet.DataSetName = "CRUD_PABDDataSet";
            this.cRUD_PABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemainBolaBindingSource
            // 
            this.pemainBolaBindingSource.DataMember = "PemainBola";
            this.pemainBolaBindingSource.DataSource = this.cRUD_PABDDataSet;
            this.pemainBolaBindingSource.CurrentChanged += new System.EventHandler(this.pemainBolaBindingSource_CurrentChanged);
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(593, 70);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 38);
            this.tambah.TabIndex = 32;
            this.tambah.Text = "Add";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STXihei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "DATA PEMAIN BOLA SSB PLUTO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpelatihDataGridViewTextBoxColumn,
            this.namapelatihDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pelatihBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(593, 211);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 43);
            this.delete.TabIndex = 29;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update.Location = new System.Drawing.Point(593, 164);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 38);
            this.update.TabIndex = 28;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(593, 114);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 44);
            this.save.TabIndex = 27;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // noTlp
            // 
            this.noTlp.Location = new System.Drawing.Point(211, 159);
            this.noTlp.Name = "noTlp";
            this.noTlp.Size = new System.Drawing.Size(236, 22);
            this.noTlp.TabIndex = 24;
            this.noTlp.TextChanged += new System.EventHandler(this.noTlp_TextChanged);
            // 
            // namaPemain
            // 
            this.namaPemain.Location = new System.Drawing.Point(211, 114);
            this.namaPemain.Name = "namaPemain";
            this.namaPemain.Size = new System.Drawing.Size(236, 22);
            this.namaPemain.TabIndex = 23;
            this.namaPemain.TextChanged += new System.EventHandler(this.namaPemain_TextChanged);
            // 
            // pemainID
            // 
            this.pemainID.Location = new System.Drawing.Point(211, 65);
            this.pemainID.Name = "pemainID";
            this.pemainID.Size = new System.Drawing.Size(236, 22);
            this.pemainID.TabIndex = 22;
            this.pemainID.TextChanged += new System.EventHandler(this.pemainID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "No Telp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nama Pemain";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID Pemain";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cRUD_PABDDataSet1
            // 
            this.cRUD_PABDDataSet1.DataSetName = "CRUD_PABDDataSet1";
            this.cRUD_PABDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRUDPABDDataSet1BindingSource
            // 
            this.cRUDPABDDataSet1BindingSource.DataSource = this.cRUD_PABDDataSet1;
            this.cRUDPABDDataSet1BindingSource.Position = 0;
            this.cRUDPABDDataSet1BindingSource.CurrentChanged += new System.EventHandler(this.cRUDPABDDataSet1BindingSource_CurrentChanged);
            // 
            // pelatihBindingSource
            // 
            this.pelatihBindingSource.DataMember = "Pelatih";
            this.pelatihBindingSource.DataSource = this.cRUDPABDDataSet1BindingSource;
            this.pelatihBindingSource.CurrentChanged += new System.EventHandler(this.pelatihBindingSource_CurrentChanged);
            // 
            // pelatihTableAdapter
            // 
            this.pelatihTableAdapter.ClearBeforeFill = true;
            // 
            // idpelatihDataGridViewTextBoxColumn
            // 
            this.idpelatihDataGridViewTextBoxColumn.DataPropertyName = "id_pelatih";
            this.idpelatihDataGridViewTextBoxColumn.HeaderText = "id_pelatih";
            this.idpelatihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpelatihDataGridViewTextBoxColumn.Name = "idpelatihDataGridViewTextBoxColumn";
            // 
            // namapelatihDataGridViewTextBoxColumn
            // 
            this.namapelatihDataGridViewTextBoxColumn.DataPropertyName = "nama_pelatih";
            this.namapelatihDataGridViewTextBoxColumn.HeaderText = "nama_pelatih";
            this.namapelatihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapelatihDataGridViewTextBoxColumn.Name = "namapelatihDataGridViewTextBoxColumn";
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            // 
            // Pelatih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.noTlp);
            this.Controls.Add(this.namaPemain);
            this.Controls.Add(this.pemainID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pelatih";
            this.Text = "Pelatih";
            this.Load += new System.EventHandler(this.Pelatih_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemainBolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUD_PABDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDPABDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelatihBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CRUD_PABDDataSetTableAdapters.PemainBolaTableAdapter pemainBolaTableAdapter;
        private CRUD_PABDDataSet cRUD_PABDDataSet;
        private System.Windows.Forms.BindingSource pemainBolaBindingSource;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox noTlp;
        private System.Windows.Forms.TextBox namaPemain;
        private System.Windows.Forms.TextBox pemainID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cRUDPABDDataSet1BindingSource;
        private CRUD_PABDDataSet1 cRUD_PABDDataSet1;
        private System.Windows.Forms.BindingSource pelatihBindingSource;
        private CRUD_PABDDataSet1TableAdapters.PelatihTableAdapter pelatihTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelatihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelatihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
    }
}