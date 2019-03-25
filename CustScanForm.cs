﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using Capture = Emgu.CV.Capture;

namespace MultiFaceRec
{
	public partial class CustScanForm : Form
	{
        //for face recognition
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        public CustScanForm()
		{
            /*if (beenCalledBy == "EmployeeLogInForm")
                 groupBox1.Visible = true;
             else if (beenCalledBy == "CustomerTypeForm")
                 groupBox1.Visible = false;*/
 
            InitializeComponent();

            grpBoxEmployee.Visible = false;

            try
            {
				this.KeyPreview = true; //Needed to enable Keypress function
										//Load haarcascades for face detection
				face = new HaarCascade("haarcascade_frontalface_default.xml");    //this file is missing the repos
																				  //eye = new HaarCascade("haarcascade_eye.xml");
																				  //Load of previous trainned faces and labels for each image
				string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");  //this file is missing the repos
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces)); //this file is missing the repos
                    labels.Add(Labels[tf]);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                // MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //end for race recog
        }
   
        //face recog functions
        private void detect_reocgnize()
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }

        private void add_newFace()
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;
                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            NamePersons.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);

                    name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    try
                    {
                        //MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                    catch { }
                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");
                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();
            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            add_newFace();
        }
        //face rcog func end

        private void CustForm1_Load(object sender, EventArgs e)
		{
			cartGrid.Columns["deleteCol"].DefaultCellStyle.NullValue = "🗑️"; //Set up the grid
																			  //Format: Null, int qty, string UPC, string item name, $price
			barcodeInputTextbox.Select();

			cartGrid.Rows.Add(null, 1, "01052843", "Chocolate Bar", "$2.00"); //RM testing only
			updateTotals();
			grpBoxEmployee.Visible = false;
		}


		private void addToCart(string barcode) //TODO: add DB connection to items
		{
			bool createNew = true; //To see if a new entry is needed

			foreach (DataGridViewRow r in cartGrid.Rows) //If a duplicate item is scanned it increases the amount of items
			{
				if (r.Cells[2].Value.ToString() == barcode)
				{
					r.Cells[1].Value = Convert.ToInt32(r.Cells[1].Value) + 1;

					createNew = false; //Don't create new entry
				}
			}

			if (createNew == true)//DB connection CHANGE VALUES PLS 
			{
				string connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
				var con = new OleDbConnection();
				con.ConnectionString = connectionStr;
				con.Open();


				string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=eyePOS_DB_.accdb;";
				string sqlstr = "SELECT upc_code, item_name, item_price FROM items";
				DataTable vt = new DataTable();

				try
				{
					OleDbDataAdapter dad = new OleDbDataAdapter(sqlstr, constr);
					dad.Fill(vt);
					dad.Dispose();
					dad = null;
					//cartGrid.DataSource = vt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Database error! Please use a different checkout.");
					this.Close();
				}
				//cartGrid.Rows.Add(null, 1, barcode, "ItemName", "$1.11");
			}
		}

		private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((e.ColumnIndex == cartGrid.Columns["deleteCol"].Index) && !(e.RowIndex < 0 || e.RowIndex == this.cartGrid.NewRowIndex)) //Ensures value isnt header or new row.
			{
				string message = "Are you sure you want to remove this item from the cart?";
				string caption = "Remove Item";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;

				var result = MessageBox.Show(message, caption, buttons);

				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					cartGrid.Rows.RemoveAt(e.RowIndex);
				}
			}
		}

		private void updateTotals()
		{
			decimal sum = 0m;
			decimal tax = 0m;
			decimal total = 0m;
			string temp;

			foreach (DataGridViewRow r in cartGrid.Rows)
			{
				temp = (r.Cells[4].Value).ToString().Replace("$", String.Empty);
				sum += decimal.Round(Convert.ToDecimal(temp) * Convert.ToInt32(r.Cells[1].Value), 2, MidpointRounding.AwayFromZero);
			}

			tax = decimal.Round((sum * (decimal)0.15), 2, MidpointRounding.AwayFromZero);
			total = decimal.Round((sum + tax), 2, MidpointRounding.AwayFromZero);
        
			subLabel.Text = "$" + sum.ToString();
			taxLabel.Text = "$" + tax.ToString();
			totalLabel.Text = "$" + total.ToString();

		}

		private void barcodeInputTextbox_KeyDown(object sender, KeyEventArgs e) //gets barcode entries
		{
			if (e.KeyCode == Keys.Enter) //Reads for specific button to send to cart, i.e tab, enter
			{
				addToCart(barcodeInputTextbox.Text);
				barcodeInputTextbox.Clear();
			}
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            detect_reocgnize();
        }

		private void empButton_Click(object sender, EventArgs e)
		{
			EmployeeLogInForm employeeLogInForm = new EmployeeLogInForm("CustScanForm");
			employeeLogInForm.Show();
		}

		private void CustForm1_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
			{
				barcodeInputTextbox.Select();
			}
		}

		private void cartGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			updateTotals();
		}

		private void checkOutButton_Click(object sender, EventArgs e)
		{
			updateTotals();
			//payGB.Visible = true;
			//go to results screen
		}

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}