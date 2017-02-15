using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;
using MetroFramework;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedicalStoreApp
{
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
            userdeatailsmetroTextBox.Text = System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\log.txt");
            stockanalysismetroTextBox.Text = System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\stockanalysis.txt");
            admintypevspricemetroTextBox.Text = System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis.txt") + System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis1.txt");
        }

        private void logoutTile_Click(object sender, EventArgs e)
        {
            new loginform().Show();
            this.Hide();
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void udersdatabasemetroTile_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("users");
            var x = col.CountAsync(new BsonDocument { });
            Int32 count = (Int32)x.Result;
            DialogResult res = MessageBox.Show("Items Found : " + count + "\nAre you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                db.DropCollectionAsync("users");

                deletedbLabel.Text = "Users Database deleted successfully";
            }
            else
            {
                deletedbLabel.Text = "Users Database not Deleted";
            }
        }

        private void deletemedicineTile_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
            var x = col.CountAsync(new BsonDocument { });
            Int32 count = (Int32)x.Result;
            DialogResult res = MessageBox.Show("Items Found : " + count + "\nAre you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                db.DropCollectionAsync("medicinedetails");

                deletedbLabel.Text = "Medicine Database deleted successfully";
            }
            else
            {
                deletedbLabel.Text = "Medicine Database not Deleted";
            }
        }
    }
}
