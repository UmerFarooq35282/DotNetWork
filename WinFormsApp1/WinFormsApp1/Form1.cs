using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server= DESKTOP-UNV1KV7; integrated security = true; database = DbUmer");

        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentInfo", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Clr()
        {
            TxtRno.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtFName.Text = string.Empty;
            TxtAge.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO StudentInfo(SName , FName , Age) VALUES('{TxtName.Text}' , '{TxtFName.Text}' , {TxtAge.Text})", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OKCancel);
            LoadData();
            Clr();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TxtRno.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter($"UPDATE StudentInfo SET SName = '{TxtName.Text}' , FName = '{TxtFName.Text}', Age = '{TxtAge.Text}' WHERE Id = '{TxtRno.Text}'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Data Updated Sucessfully", "Updated", MessageBoxButtons.OKCancel);
                LoadData();
                Clr();

            }
            else
            {
                MessageBox.Show("Select Data First", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtRno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtFName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtAge.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(TxtRno.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter($"DELETE StudentInfo WHERE Id = '{TxtRno.Text}'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Data Deleted Successfully", "Delete", MessageBoxButtons.OKCancel);
                LoadData();
                Clr();
            }
            else
            {
                MessageBox.Show("Select Data First", "Error", MessageBoxButtons.OKCancel);
            }
            
        }
    }
}
