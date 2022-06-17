using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisePABD_CRUD
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=CRUD_PABD;User ID=sa;Password=abianfikri");
        DataTable dt;
        DataRow dr;
        string code;
        public Form1()
        {
            InitializeComponent();
        }

        // Button Save
        private void save_Click(object sender, EventArgs e)
        {
            tambah.Enabled = true;
            delete.Enabled = true;
            update.Enabled = true;
            save.Enabled = false;

            // memanggil class tambah data
            addData();
            con.Close();
        }

        // class tambah data
        void addData()
        {
            con.Open();
            SqlCommand insert = new SqlCommand("exec insertPemain_SP '" + pemainID.Text + "', '" + namaPemain.Text + "', '" + umurPemain.Text + "', '" + posisiPemain.Text + "', '" + gajiPemain.Text + "' ", con);
            insert.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes Menambahkan Data....");
            getData();

            
        }

        // class menampilkan data
        void getData()
        {
            SqlCommand show = new SqlCommand("Exec selectPemain_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(show);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // class Update data
        void updateData()
        {
            con.Open();
            SqlCommand update = new SqlCommand("exec updatePemain_SP '" + pemainID.Text + "', '" + namaPemain.Text + "', '" + umurPemain.Text + "', '" + posisiPemain.Text + "', '" + gajiPemain.Text + "' ", con);
            update.ExecuteNonQuery();
            MessageBox.Show("Succes Mengedit Data....");
            con.Close();
            getData();
        }
        
        // class delete data
        void deleteData()
        {
            if(MessageBox.Show("Are you sure to delete data?" + pemainID.Text, "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("exec deletePemain_SP '" + pemainID.Text + "'", con);
                delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes Delete Data....");
                getData();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet.PemainBola' table. You can move, or remove it, as needed.
            this.pemainBolaTableAdapter.Fill(this.cRUD_PABDDataSet.PemainBola);

            getData();

        }

        // Button Update
        private void update_Click(object sender, EventArgs e)
        {
            save.Enabled = true;
            delete.Enabled = true;
            update.Enabled = false;

            updateData();
        }

        // Button delete
        private void delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void add_Click(object sender, EventArgs e)
        {
        

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            TampilanData data = new TampilanData();

            data.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            data.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            data.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            data.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            data.textBox5.Text = "Rp. " + dataGridView1.CurrentRow.Cells[4].Value.ToString();

            data.textBox1.Enabled = false;
            data.textBox2.Enabled = false;
            data.textBox3.Enabled = false;
            data.textBox4.Enabled = false;
            data.textBox5.Enabled = false;

            data.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            save.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                pemainID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                namaPemain.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                umurPemain.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                posisiPemain.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                gajiPemain.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            update.Enabled = false;
            delete.Enabled = false;
            tambah.Enabled = false;
            save.Enabled = true;

            pemainID.Text = "";
            namaPemain.Text = "";
            umurPemain.Text = "";
            posisiPemain.Text = "";
            gajiPemain.Text = "";

            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pemainID_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaPemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void umurPemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void posisiPemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void gajiPemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void pemainBolaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
