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
    public partial class Official : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=CRUD_PABD;User ID=sa;Password=abianfikri");
        public Official()
        {
            InitializeComponent();
        }

        // class tambah data
        void addData()
        {
            con.Open();
            SqlCommand insert = new SqlCommand("exec insertOfficial_SP '" + pemainID.Text + "', '" + namaPemain.Text + "', '" + noTlp.Text + "' ", con);
            insert.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes Menambahkan Data....");
            getData();


        }

        // class menampilkan data
        void getData()
        {
            SqlCommand show = new SqlCommand("Exec selectOfficial_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(show);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // class Update data
        void updateData()
        {
            con.Open();
            SqlCommand update = new SqlCommand("exec updateOfficial_SP '" + pemainID.Text + "', '" + namaPemain.Text + "', '" + noTlp.Text + "' ", con);
            update.ExecuteNonQuery();
            MessageBox.Show("Succes Mengedit Data....");
            con.Close();
            getData();
        }

        // class delete data
        void deleteData()
        {
            if (MessageBox.Show("Are you sure to delete data?" + pemainID.Text, "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand delete = new SqlCommand("exec deleteOfficial_SP '" + pemainID.Text + "'", con);
                delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes Delete Data....");
                getData();
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
            noTlp.Text = "";
        }

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

        private void update_Click(object sender, EventArgs e)
        {
            save.Enabled = true;
            delete.Enabled = true;
            update.Enabled = false;

            updateData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Official_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet4.Official' table. You can move, or remove it, as needed.
            this.officialTableAdapter2.Fill(this.cRUD_PABDDataSet4.Official);
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet1.PemainBola' table. You can move, or remove it, as needed.
            this.pemainBolaTableAdapter1.Fill(this.cRUD_PABDDataSet1.PemainBola);
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet3.Official' table. You can move, or remove it, as needed.
            this.officialTableAdapter1.Fill(this.cRUD_PABDDataSet3.Official);
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet1.selectOfficial_SP' table. You can move, or remove it, as needed.
            this.selectOfficial_SPTableAdapter.Fill(this.cRUD_PABDDataSet1.selectOfficial_SP);
            // TODO: This line of code loads data into the 'cRUD_PABDDataSet2.Official' table. You can move, or remove it, as needed.
            this.officialTableAdapter.Fill(this.cRUD_PABDDataSet2.Official);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


            data.textBox1.Enabled = false;
            data.textBox2.Enabled = false;
            data.textBox3.Enabled = false;
            data.textBox4.Enabled = false;
            data.textBox5.Enabled = false;

            data.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            save.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                pemainID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                namaPemain.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                noTlp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

            }
        }
    }
}
