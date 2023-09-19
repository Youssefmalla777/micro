using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // the programm of the exit click
            Application.Exit();
        }
       
        private void btnadd_Click(object sender, EventArgs e)
        {

            // this gorthims show how we find a fimilar data and solve it...

            if (txtid.Text.Contains("@,#,%"))
            {
                MessageBox.Show("please full your id not your sympol!!");
            }
            //the programm of the add click
            // here we see if the textboxses are empty ..show message that says the next sentence
            if (txtid.Text.Trim() == "" || txtaddress.Text.Trim() == "" || txtname.Text.Trim() == "" || txtnumber.Text.Trim() == "")
            {
                MessageBox.Show("please full all the textboxses..!");
                return;
            }
            

            // this one see if there is any familiar data ..and if there was show this next message
            // and this one read the data that we added it before to the data file..
            // this (sr) means read all the data in the data file..
            StreamReader sr = new StreamReader("data.txt");
            // read all the data that we login
            // read all the data til the end..
            string strcheck = sr.ReadToEnd();
            // close the streamreader function..
            sr.Close();
            // the condition..means if there is any same id ..form one that already added.
            // and if there was any same numbers..do it like the last one..
            if (strcheck.Contains(txtid.Text + ";") || strcheck.Contains(txtnumber.Text))
            {  
                MessageBox.Show("this data has been already added..please try again!..and the same number!!");
                // sign the sentence
                txtid.Focus();
                txtid.SelectAll();
            }
            // this gorthims show how to write the code and data adn save it in folder


            // if the first condition did not work ..move to the second
            else
            {
                // this one explain how to write the code like data
                // write all the data that we login adn save it in one file and make the abbend true             
                StreamWriter sw = new StreamWriter("data.txt", true);
                string strperson = txtid.Text + ";"
                                  + txtname.Text + ";"
                                  + txtaddress.Text + ";"
                                  + txtnumber.Text;
                // printin the data .. the strperson means the data..
                sw.WriteLine(strperson);
                sw.Close();
                // if there was not any files ..create one
                // we can write in two ways..this one and the other one
                if (Directory.Exists("images") == false)
                    Directory.CreateDirectory("images");
                // save all the pic in one file
                // save this onw with the file name and his id number and the picture format..
                picperson.Image.Save("images/" + txtid.Text + ".jpg");
                
                MessageBox.Show("the name is added..");
                // empty all the textboxses after full and store the data 
                //txtaddress.Text = "";
                //txtid.Text = "";
                //txtname.Text = "";
                //txtnumber.Text = "";

                // this one show us the textboxses rolin around it one by one
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
                // empty the picbox after pick one picture..
                picperson.Image = new PictureBox().Image;
                
                txtid.Focus();
                picperson.Focus();
                

            }

            
        }


        private void btnfind_Click(object sender, EventArgs e)
        {
            // full the textbox first..
            if(txtid.Text.Trim() == "")
            {
                MessageBox.Show("please enter the id first!!");
            }

            if(txtid.Text.Contains("@,#,%"))
            {
                MessageBox.Show("please full your id not your sympol!!");
            }
            // the programm of the find click...

            // if the textbox was not empty
            if (txtid.Text.Trim() != "")
            {
                // read all the id container
                StreamReader sr = new StreamReader("data.txt");
                // define A variable from sort string 
                string line;
                // the first value of found ..and not to forget define from sort bool
                bool found = false;

                // here we use do while loop cause the first code output of this programm is always true and we run it if it was right or wrong for one time
                // and cause we are gonna roll around ..     
                do
                {
                    // read all the data
                    line = sr.ReadLine();
                    // if the line is not equal null(we mean nothing)
                    if (line != null)
                    {
                        // define an array from sort string
                        // this one of this mark (;) makes the array define thier name sand address and id..
                        // and this array means the data and every one of it takes a value one by one..
                        string[] arrdata = line.Split(';');
                        // if the first index was equal the first code
                        if (arrdata[0] == txtid.Text)
                        {
                            // so print the fowlloin data of this code
                            txtid.Text = arrdata[0];
                            txtname.Text = arrdata[1];
                            txtaddress.Text = arrdata[2];
                            txtnumber.Text = arrdata[3];


                            // define a new variable from sort string 
                            string mypath = ("images/" + txtid.Text + ".jpg");
                            // if you find the picture so print too..
                            if (File.Exists(mypath))
                                picperson.Image = Image.FromFile(mypath);
                            // return the value true
                            found = true;
                            // out of the loop
                            break;
                        }
                    }
                    // the condition
                } while (line != null);
                
                sr.Close();


                // if the first condition did not work ..go to the second condition
                if (found==false)
                {
                    // print this message
                    MessageBox.Show("not found!");
                    txtid.Focus();
                    txtid.SelectAll();
                }


                
                //else
                //{
                //    MessageBox.Show("enter the id and try again!");
                //    txtid.Focus();
                //}


            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // the programm of the showall click
            
            Form1 frm = new Form1();
            frm.StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show("welcome sir please provid us your information..","notebad",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            Form frmshow = new Form();
            TextBox txtshow = new TextBox();
            frmshow.StartPosition = FormStartPosition.CenterScreen;
            frmshow.Font = this.Font;
            frmshow.Icon = this.Icon;
            frmshow.Size = this.Size;
            frmshow.Text = "all data";
            txtshow.Multiline = true;
            txtshow.Dock = DockStyle.Fill;

            frmshow.Controls.Add(txtshow);
            try
            {
                StreamReader sr = new StreamReader("data.txt");
                string strall = sr.ReadToEnd();
                sr.Close();
                txtshow.Text = strall;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frmshow.ShowDialog();

            

        }


        private void btnselect_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "images|*.jpg;*.png;*.cr2;*.gif";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(of.ShowDialog() == DialogResult.OK)
            {
                picperson.Image = Image.FromFile(of.FileName);
            }
        }

        private void btnshowallimages_Click(object sender, EventArgs e)
        {
            
            Form frmshow = new Form();
            
            frmshow.StartPosition = FormStartPosition.CenterScreen;
            frmshow.Font = this.Font;
            frmshow.Icon = this.Icon;
            frmshow.Size = this.Size;
            frmshow.Height += 300;
            frmshow.Text = "all data";
            frmshow.AutoScroll = true;
            frmshow.BackColor = this.BackColor;
            int mytop = 10;
            

            //frmshow.Controls.Add(txtshow);
            try
            {
                StreamReader sr = new StreamReader("data.txt");
                string line = "";
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        TextBox txt = new TextBox();
                        PictureBox pic = new PictureBox();
                        txt.Width = 300;
                        txt.Top = mytop;
                        txt.Text = line;
                        pic.Left = 305;
                        pic.Top = mytop;
                        pic.BorderStyle = BorderStyle.FixedSingle;
                        pic.Size = new Size(150, 150);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        string imgpath = "images/" + line.Split(';')[0] + ".jpg";
                        if (File.Exists(imgpath))
                            pic.Image = Image.FromFile(imgpath);
                        frmshow.Controls.Add(txt);
                        frmshow.Controls.Add(pic);
                        mytop += 155;
                    }
                } while (line != null);
                sr.Close();
                //txtshow.Text = strall;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frmshow.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnfind_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtid.Text = "";
            txtname.Text = "";
            txtnumber.Text = "";
        }
    }
}
