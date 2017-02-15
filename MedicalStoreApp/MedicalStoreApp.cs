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
    public partial class MedicalStoreApp : MetroForm
    {
        public MedicalStoreApp(string user)
        {
            InitializeComponent();

            stocktypemetroTextBox.Text = System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\stockanalysis.txt");
            typevspricemetroTextBox.Text = System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis.txt") + System.IO.File.ReadAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis1.txt");

            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
            var x = col.CountAsync(new BsonDocument{});
            Int32 count = (Int32)x.Result;
            countLabel.Text = count.ToString();
            usernametab.Text = user;
            if (detail1label.Text == "" || detail1label.Text == "Detail 1")
            {
                detail1label.Hide();
                detail1TextBox.Hide();
            }
            if (detail2label.Text == "" || detail2label.Text == "Detail 2")
            {
                detail2label.Hide();
                detail2TextBox.Hide();
            }
            if (detail3label.Text == "" || detail3label.Text == "Detail 3")
            {
                detail3label.Hide();
                detail3TextBox.Hide();
            }
            if (detail4label.Text == "" || detail4label.Text == "Detail 4")
            {
                detail4label.Hide();
                detail4TextBox.Hide();
            }
            //aggregate({$group:{_id:"$Type",Sum:{$sum:"$Quantity"}}})
            //aggregate({$group:{_id:"$Type",Price:{$sum:"$Price"}}})
            //aggregate({$group:{_id:true,"Total":{$sum:"$Price"}}})
            //System.IO.File.Delete(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\stockanalysis.txt");
            //System.IO.File.Delete(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis.txt");
            //System.IO.File.Delete(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis1.txt");
            var aggregate = col.Aggregate().Group(new BsonDocument { { "_id", "$Type" }, { "Total", new BsonDocument("$sum", 1) } });
            aggregate.ForEachAsync(doc => System.IO.File.AppendAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\stockanalysis.txt", "\t" + doc[0] + "\t:\t" + doc[1] + "\r\n"));
            System.IO.File.Delete(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis.txt");
            var aggregate1 = col.Aggregate().Group(new BsonDocument { { "_id", "$Type" }, { "Price", new BsonDocument("$sum", "$Price") } });
            aggregate1.ForEachAsync(doc => System.IO.File.AppendAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis.txt", "\t" + doc[0] + "\t:\t" + doc[1] + "\r\n"));
            var aggregate2 = col.Aggregate().Group(new BsonDocument { { "_id", true }, { "Total", new BsonDocument("$sum", "$Price") } });
            aggregate2.ForEachAsync(doc => System.IO.File.AppendAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\typevspriceanalysis1.txt", "\t" + "Total" + "\t=>\t" + doc[1] + "\r\n"));
            
        }

        private void existingdbtile_Click(object sender, EventArgs e)
        {

        }

        private void newdbtile_Click(object sender, EventArgs e)
        {

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
        
        private void okbtn_Click(object sender, EventArgs e)
        {

            if (noofdetailsTextBox.Text != "")
            {
                var keys = noofdetailsTextBox.Text;
                if (keys == "1" || keys == "2" || keys == "3" || keys == "4" || keys == "4")
                {
                    detailsnameTile.Show();
                    switch (keys)
                    {
                        case "1": d2Label.Hide();
                            d2TextBox.Hide();
                            d3Label.Hide();
                            d3TextBox.Hide();
                            d4Label.Hide();
                            d4TextBox.Hide();
                            break;
                        case "2": d3Label.Hide();
                            d3TextBox.Hide();
                            d4Label.Hide();
                            d4TextBox.Hide();
                            break;
                        case "3": d4Label.Hide();
                            d4TextBox.Hide();
                            break;
                        case "4":
                            break;
                    }

                }
                else
                    noofdetailsLabel.Text = "not between 1-4";
            }
            else
                noofdetailsLabel.Text = "Enter a number";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new MedicalStoreApp(usernametab.Text).Show();
            this.Dispose();
        }

        private void clralldetailsutton_Click(object sender, EventArgs e)
        {
            noofdetailsTextBox.Text = "";
            medidTextBox.Text = "";
            mednameTextBox.Text = "";
            typeComboBox.Text = "";
            medpriceTextBox.Text = "";
            detail1TextBox.Text = "";
            detail2TextBox.Text = "";
            detail3TextBox.Text = "";
            detail4TextBox.Text = "";
        }

        private void rmvalldetailsButton_Click(object sender, EventArgs e)
        {
            detail1label.Text = "";
            detail1label.Hide();
            detail1TextBox.Text = "";
            detail1TextBox.Hide();
            detail2label.Text = "";
            detail2label.Hide();
            detail2TextBox.Text = "";
            detail2TextBox.Hide();
            detail3label.Text = "";
            detail3label.Hide();
            detail3TextBox.Text = "";
            detail3TextBox.Hide();
            detail4label.Text = "";
            detail4label.Hide();
            detail4TextBox.Text = "";
            detail4TextBox.Hide();
        }

        private void adddetailsnameButton_Click(object sender, EventArgs e)
        {
            var keys = noofdetailsTextBox.Text;
            if (keys == "1" || keys == "2" || keys == "3" || keys == "4" || keys == "4")
            {
                detailsnameTile.Show();
                switch (keys)
                {
                    case "1": if (d1TextBox.Text.Length!=0)
                        {
                            detail1label.Show();
                            detail1TextBox.Show();
                            detail1label.Text = d1TextBox.Text;
                        }
                        break;
                    case "2": if (d1TextBox.Text.Length != 0 && d2TextBox.Text.Length !=0 )
                        {
                            detail1label.Show();
                            detail1TextBox.Show();
                            detail1label.Text = d1TextBox.Text;
                            detail2label.Show();
                            detail2TextBox.Show();
                            detail2label.Text = d2TextBox.Text;
                        }
                        break;
                    case "3": if (d1TextBox.Text.Length!=0 && d2TextBox.Text.Length!=0 && d3TextBox.Text.Length!=0)
                        {
                            detail1label.Show();
                            detail1TextBox.Show();
                            detail1label.Text = d1TextBox.Text;
                            detail2label.Show();
                            detail2TextBox.Show();
                            detail2label.Text = d2TextBox.Text;
                            detail3label.Show();
                            detail3TextBox.Show();
                            detail3label.Text = d3TextBox.Text;
                        }
                        break;
                    case "4": if (d1TextBox.Text.Length != 0 && d2TextBox.Text.Length != 0 && d3TextBox.Text.Length != 0 && d4TextBox.Text.Length != 0)
                        {
                            detail1label.Show();
                            detail1TextBox.Show();
                            detail1label.Text = d1TextBox.Text;
                            detail2label.Show();
                            detail2TextBox.Show();
                            detail2label.Text = d2TextBox.Text;
                            detail3label.Show();
                            detail3TextBox.Show();
                            detail3label.Text = d3TextBox.Text;
                            detail4label.Show();
                            detail4TextBox.Show();
                            detail4label.Text = d4TextBox.Text;
                        }
                        break;
                }
            }
            detailsnameTile.Dispose();
        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            var connectionstring = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionstring);
            var db = client.GetDatabase("MedicalStoreApp");
            db.CreateCollectionAsync("medicinedetails");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
            
            if(detail1label.Text == "" || detail1label.Text == "Detail 1")
            {
                
                 var doc = new BsonDocument { 
                                                 {medIdlabel.Text,medidTextBox.Text},
                                                 {mednameLabel.Text,mednameTextBox.Text},
                                                 {typelabel.Text,typeComboBox.Text},
                                                 {medpriceLabel.Text,Int32.Parse(medpriceTextBox.Text)},
                                                 {expirydateLabel.Text,dateTimePickeradd.Value},
                                                 {quantityLabel.Text,Int32.Parse(quantityTextBox.Text)}
                                                };
                 if (medidTextBox.Text.Length != 0 && mednameTextBox.Text.Length != 0 && typeComboBox.Text.Length != 0 && medpriceTextBox.Text.Length != 0)
                 {
                     col.InsertOneAsync(doc);
                     addedsuccessLabel.Text = "Added Successfully";
                 }
                 else
                     addsuccess.Text = "Please Enter Medicine ID,Medicine Name,Type,Price First";
            }
                
            else if ((detail1label.Text != "" || detail1label.Text != "Detail 1") && (detail2label.Text=="" || detail2label.Text =="Detail 2"))
            {
                 var doc1 = new BsonDocument { 
                                                 {medIdlabel.Text,medidTextBox.Text},
                                                 {mednameLabel.Text,mednameTextBox.Text},
                                                 {typelabel.Text,typeComboBox.Text},
                                                 {medpriceLabel.Text,Int32.Parse(medpriceTextBox.Text)},
                                                 {expirydateLabel.Text,dateTimePickeradd.Value},
                                                 {quantityLabel.Text,Int32.Parse(quantityTextBox.Text)},
                                                 {detail1label.Text,detail1TextBox.Text}
                                              };
                 if (medidTextBox.Text.Length != 0 && mednameTextBox.Text.Length != 0 && typeComboBox.Text.Length != 0 && medpriceTextBox.Text.Length != 0)
                 {
                     col.InsertOneAsync(doc1);
                     addedsuccessLabel.Text = "Added Successfully";
                 }
                 else
                     addedsuccessLabel.Text = "Please Enter Medicine ID,Medicine Name,Type,Price First";

            }

            else if ((detail2label.Text != "" || detail2label.Text != "Detail 2")&&(detail3label.Text == "" || detail3label.Text == "Detail 3"))
            {
                var doc2 = new BsonDocument { 
                                                 {medIdlabel.Text,medidTextBox.Text},
                                                 {mednameLabel.Text,mednameTextBox.Text},
                                                 {typelabel.Text,typeComboBox.Text},
                                                 {medpriceLabel.Text,Int32.Parse(medpriceTextBox.Text)},
                                                 {expirydateLabel.Text,dateTimePickeradd.Value},
                                                 {quantityLabel.Text,Int32.Parse(quantityTextBox.Text)},
                                                 {detail1label.Text,detail1TextBox.Text},
                                                 {detail2label.Text,detail2TextBox.Text},
                                                };
                if (medidTextBox.Text.Length != 0 && mednameTextBox.Text.Length != 0 && typeComboBox.Text.Length != 0 && medpriceTextBox.Text.Length != 0)
                {
                    col.InsertOneAsync(doc2);
                    addedsuccessLabel.Text = "Added Successfully";
                }
                else
                    addedsuccessLabel.Text = "Please Enter Medicine ID,Medicine Name,Type,Price First";
            }
              
            else if ((detail3label.Text != "" || detail3label.Text != "Detail 3")&& (detail4label.Text == "" || detail4label.Text == "Detail 4") )
            {
                var doc3 = new BsonDocument { 
                                                 {medIdlabel.Text,medidTextBox.Text},
                                                 {mednameLabel.Text,mednameTextBox.Text},
                                                 {typelabel.Text,typeComboBox.Text},
                                                 {medpriceLabel.Text,Int32.Parse(medpriceTextBox.Text)},
                                                 {expirydateLabel.Text,dateTimePickeradd.Value},
                                                 {quantityLabel.Text,Int32.Parse(quantityTextBox.Text)},
                                                 {detail1label.Text,detail1TextBox.Text},
                                                 {detail2label.Text,detail2TextBox.Text},
                                                 {detail3label.Text,detail3TextBox.Text}
                                                };
                if (medidTextBox.Text.Length != 0 && mednameTextBox.Text.Length != 0 && typeComboBox.Text.Length != 0 && medpriceTextBox.Text.Length != 0)
                {
                    col.InsertOneAsync(doc3);
                    addedsuccessLabel.Text = "Added Successfully";
                }
                else
                    addedsuccessLabel.Text = "Please Enter Medicine ID,Medicine Name,Type,Price First";
            }
                
            else
            {
                 var doc4 = new BsonDocument { 
                                                 {medIdlabel.Text,medidTextBox.Text},
                                                 {mednameLabel.Text,mednameTextBox.Text},
                                                 {typelabel.Text,typeComboBox.Text},
                                                 {medpriceLabel.Text,Int32.Parse(medpriceTextBox.Text)},
                                                 {expirydateLabel.Text,dateTimePickeradd.Value},
                                                 {quantityLabel.Text,Int32.Parse(quantityTextBox.Text)},
                                                 {detail1label.Text,detail1TextBox.Text},
                                                 {detail2label.Text,detail2TextBox.Text},
                                                 {detail3label.Text,detail3TextBox.Text},
                                                 {detail4label.Text,detail4TextBox.Text}
                                                };
                 if (medidTextBox.Text.Length != 0 && mednameTextBox.Text.Length != 0 && typeComboBox.Text.Length != 0 && medpriceTextBox.Text.Length != 0)
                 {
                     col.InsertOneAsync(doc4);
                     addedsuccessLabel.Text = "Added Successfully";
                 }
                 else
                     addedsuccessLabel.Text = "Please Enter Medicine ID,Medicine Name,Type,Price First";
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            detailTextBoxSearch.Text = "";
            ContentTextBoxSearch.Text = "";
            LimitTextBoxSearch.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {        
                var connectionString = "mongodb://192.168.190.96:27017";
                var client = new MongoClient(connectionString);
                var db = client.GetDatabase("MedicalStoreApp");
                var col = db.GetCollection<BsonDocument>("medicinedetails");
                var filter = new BsonDocument{
                {detailTextBoxSearch.Text,ContentTextBoxSearch.Text}
                };
                var x = col.CountAsync(filter);
                Int32 count = (Int32)x.Result;
                int lt = Int32.Parse(LimitTextBoxSearch.Text);
                
                Int32 i = 0;
                if(count == 0)
                {
                    searchsuccessLabel.Text = "Sorry No Item Found in Database";
                }
                else
                {
                    searchsuccessLabel.Text = "Successfully searched " + count + " Items";
                    col.Find(filter).Limit(lt).Project("{_id:0}").ForEachAsync(doc => MessageBox.Show("Total Items : " + count + "\n" + "Items Searched : " + lt + "\n" + doc, "Medicine : " + ++i, MessageBoxButtons.OK));
                }
         }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
            var filter = new BsonDocument{
                {deletedetailTextBox.Text,deletecontentTextBox.Text}
                };
            var x = col.CountAsync(filter);
            Int32 count = (Int32)x.Result;
       
            if (count == 0)
            {
                deletesuccessLabel.Text = "Sorry No Item Found in Database";
            }
            else
            {
                deletesuccessLabel.Text = "Successfully searched " + count + " Items";
                DialogResult res = MessageBox.Show("Successfully Searched : " + count + "Items\n" + "Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    deletesuccessLabel.Text = "Successfully searched " + count + " Items" + "\n" + "Deleted : Yes";
                    col.DeleteManyAsync(filter);
                }
                else
                    deletesuccessLabel.Text = searchsuccessLabel.Text = "Successfully searched " + count + ""+"Items" + "\n" + "Deleted : No";
            }
        }

        private void deleteclearButton_Click(object sender, EventArgs e)
        {
            deletecontentTextBox.Text = "";
            deletedetailTextBox.Text = "";
        }

        private void deleteTile_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
                var x = col.CountAsync(new BsonDocument{});
            Int32 count = (Int32)x.Result;
            DialogResult res =  MessageBox.Show("Items Found : " + count + "\nAre you sure ?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            { 
                db.DropCollectionAsync("medicinedetails");
                deletesuccessLabel.Text = "Medicine Database deleted successfully";
            }
            else
            {
                deletesuccessLabel.Text = "Database not Deleted";
            }
        }

        private void updateclearButton_Click(object sender, EventArgs e)
        {
            updateolddetailTextBox.Text = "";
            updateoldcontentTextBox.Text = "";
            updatenewdetailTextBox.Text = "";
            updatenewcontentTextBox.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updatenewdetailTextBox.Text.Length != 0 && updateoldcontentTextBox.Text.Length != 0 && updatenewdetailTextBox.Text.Length != 0 && updatenewcontentTextBox.Text.Length != 0)
            {
                var connectionstring = "mongodb://192.168.190.96:27017";
                var client = new MongoClient(connectionstring);
                var db = client.GetDatabase("MedicalStoreApp");
                var col = db.GetCollection<BsonDocument>("medicinedetails");
                var filter = new BsonDocument
                {
                    {updateolddetailTextBox.Text,updateoldcontentTextBox.Text}
                };
                
                var x = col.CountAsync(filter);
                Int32 count = (Int32)x.Result;
                col.UpdateManyAsync(filter,new BsonDocument("$set",new BsonDocument(updatenewdetailTextBox.Text,updatenewcontentTextBox.Text)));
                updatesuccessLabel.Text = "Successfully Updated " + count + " Medicine's Details";
            }
            else
                updatesuccessLabel.Text = "Please specify all Details";

        }

        private void metroProgressSpinnerhome_Click(object sender, EventArgs e)
        {
            new MedicalStoreApp(usernametab.Text).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void sellmetroButton_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://192.168.190.96:27017";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("MedicalStoreApp");
            var col = db.GetCollection<BsonDocument>("medicinedetails");
         
            var filter = new BsonDocument{
                {selldetailmetroTextBox.Text,sellcontentmetroTextBox.Text},
                {selltypemetroLabel.Text,selltypemetroComboBox.Text}
                };
            var x = col.CountAsync(filter);
            Int32 count = (Int32)x.Result;
            int lt = Int32.Parse(quantitymetroTextBox.Text);

            Int32 i = 0;
            if (count == 0)
            {
                searchsuccessLabel.Text = "Sorry No Item Found in Database";
            }
            else
            {
                searchsuccessLabel.Text = "Successfully searched " + count + " Items";
                col.UpdateManyAsync(filter, new BsonDocument("$inc", new BsonDocument("Quantity", -Int32.Parse(quantitymetroTextBox.Text))));
                updatesuccessLabel.Text = "Successfully Updated " + count + " Medicine's Details";
                col.Find(filter).Limit(lt).Project("{_id:0}").ForEachAsync(doc => MessageBox.Show("Available Items : " + count + "\n" + "\nAvailable Quantity : " + "\t" + doc["Quantity"] + "\n" + "Quantity Sold : " + lt + "\n" + doc, "Medicine : " + ++i, MessageBoxButtons.OK));
            }
        }
    }
}
