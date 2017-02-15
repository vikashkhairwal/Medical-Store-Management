using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Shared;
using MongoDB.Driver;

namespace MedicalStoreApp
{
    public partial class loginform : MetroForm
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void regemailtxtbox_Click(object sender, EventArgs e)
        {
            
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (regemailtxtbox.Text.Length > 0)
            {
                //rEMail is object of Regex class located in System.Text.RegularExpressions
                if (!rEMail.IsMatch(regemailtxtbox.Text))
                {
                    hiddenmetroLabel.Text = "*Wrong Email";
                }
                else if (regpasstxtbox.Text.Length < 6)
                {
                    registerProgressBar.Increment(33);
                    hiddenpassLabel.Text = "*PasswordLength >= 6";
                }
                else if (regmobilenotxtbox.Text.Length < 10)
                {
                    registerProgressBar.Increment(66);
                    hiddenmobileLabel.Text = "*MobileNo not correct";
                }
                else
                {
                    hiddenmetroLabel.Text = "";
                    hiddenpassLabel.Text = "";
                    hiddenmobileLabel.Text = "";


                    var connectionstring = "mongodb://localhost:27017";
                    var mongoClient = new MongoClient(connectionstring);
                    var db = mongoClient.GetDatabase("MedicalStoreApp");
                    var col = db.GetCollection<BsonDocument>("users");
                    var emailfilter = new BsonDocument
                    {
                        {"Email",regemailtxtbox.Text}
                    };
                    var mobilenofilter = new BsonDocument
                    {
                        {"Mobile No",regmobilenotxtbox.Text}
                    };
                    var temp1 = col.CountAsync(emailfilter);
                    var temp2 = col.CountAsync(mobilenofilter); 
                    Int32 x = (Int32)temp1.Result;
                    Int32 y = (Int32)temp2.Result;
                    if (x == 0 && y == 0)
                    {
                        var doc = new BsonDocument
                        {
                           {"Email",regemailtxtbox.Text},
                           {"Password",regpasstxtbox.Text},
                           {"Mobile No",regmobilenotxtbox.Text},
                           {"Created",DateTime.Now.TimeOfDay.ToString()}
                        };
                        col.InsertOneAsync(doc);
                        registerProgressBar.Increment(34);
                        hiddenregsuccess.Text = "Successfully Registered";
                      
                    }
                    else
                    {
                        if(x==1)
                            hiddenregsuccess.Text = "Email Already Registered......GO TO LOGIN";
                        if (y == 1)
                            hiddenregsuccess.Text = "Mobile No Already Registered........GO TO LOGIN";
                    }
                }

            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           if(usernametextbox.Text.Length!=0 && passwordtextbox.Text.Length!=0)
           {
               if (usernametextbox.Text == "Admin" && passwordtextbox.Text == "khairwal")
               {
                   new Admin().Show();
                   this.Hide();
               }
               else
               {
                   var connectionstring = "mongodb://localhost:27017";
                   var mongoClient = new MongoClient(connectionstring);
                   var db = mongoClient.GetDatabase("MedicalStoreApp");
                   var col = db.GetCollection<BsonDocument>("users");
                   if (usernametextbox.Text.Length == 10)
                   {
                       var mobilenofilter = new BsonDocument
                   {
                       {"Mobile No",usernametextbox.Text},
                       {"Password",passwordtextbox.Text}
                   };
                       var temp = col.CountAsync(mobilenofilter);
                       Int32 x = (Int32)temp.Result;
                       if (x == 1)
                       {
                           loginlabel.Text = "LOGIN SUCCESSFUL";
                           new MedicalStoreApp(usernametextbox.Text).Show();
                           System.IO.File.AppendAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\log.txt", "\r\n" + usernametextbox.Text + "\t\t\t\t\t\t\t" + passwordtextbox.Text + "\t\t\t\t\t" + DateTime.Now);
                           this.Hide();
                           x = 0;
                       }
                       else
                           loginlabel.Text = "UNAUTHORIZED USER";
                   }
                   else
                   {
                       var emailfilter = new BsonDocument
                   {
                      {"Email",usernametextbox.Text},
                      {"Password",passwordtextbox.Text}
                   };
                       var temp = col.CountAsync(emailfilter);
                       Int32 x = (Int32)temp.Result;
                       if (x == 1)
                       {
                           loginlabel.Text = "LOGIN SUCCESSFUL";
                           new MedicalStoreApp(usernametextbox.Text).Show();
                           System.IO.File.AppendAllText(@"C:\Users\VIKASH KHAIRWAL\Desktop\MedicalStoreApp\MedicalStoreApp\log.txt", "\r\n" + usernametextbox.Text + "\t\t\t" + passwordtextbox.Text + "\t\t\t\t\t" + DateTime.Now);
                           this.Hide();
                           x = 0;
                       }
                       else
                           loginlabel.Text = "UNAUTHORIZED USER";

                   }
               }
           }
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void tmrcounter_Tick(object sender, EventArgs e)
        {
            i++;
            startProgressBar.Increment(i);
            if (startProgressBar.ProgressTotalValue == 1) 
            {
                startmetroTile.Hide();
            }
        }
    }
}
