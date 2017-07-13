﻿using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Ruby
{
    public partial class Form : MetroForm

    {

        PunaMeDB ObjPunaDB = new PunaMeDB();


        #region Initialization

        //----------Qekjo osht e ndreqme MIRE
        public Form()
        {

            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            dtpData.Value = DateTime.Today.AddDays(-1); //Yesterday for Historia


            string queryPerdgvShitja = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";

            string queryPerdgvFurdeSot = "SELECT * FROM TblFurde WHERE DATEDIFF(day, TblFurde.Data_blerjes , GETDATE()) = 0";

            //Try Catch Nr. 1 qe e kom shtu
            try
            {
                //qeky osht rreshti i kodit qe e kom shkru qe me vyn me bo
                dgvShitja.DataSource = ObjPunaDB.LexoShenimet(queryPerdgvShitja).Tables[0];

                dgvFurde.DataSource = ObjPunaDB.LexoShenimet(queryPerdgvFurdeSot).Tables[0];

                string QueryPerdgvHistoriaDje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1";

                //Query per insertim ne vend te TRY qe osht qetash
                ObjPunaDB.InsUpdDel(QueryPerdgvHistoriaDje);
                //qeky osht rreshti i kodit qe e kom shkru qe me vyn me bo
                dgvHistoria.DataSource = ObjPunaDB.LexoShenimet(QueryPerdgvHistoriaDje).Tables[0];

                //QUERY NE FILLIM TE INICIALIZIMIT (ME PROVU ME HEK NESE NUK OST I NEVOJSHEM)
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }

#endregion


        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubyDBDataSet3.TblShpenzimet' table. You can move, or remove it, as needed.


            // 1 here nuk po me vyn te inicializume meniher muj me bo kur te hi ne pjesen e vet me u inicializu
          //  this.tblShpenzimetTableAdapter.Fill(this.rubyDBDataSet3.TblShpenzimet);
          //  this.tblMalliTableAdapter1.Fill(this.rubyDBDataSet_Malli.TblMalli);
          //  this.tblFurdeTableAdapter.Fill(this.rubyDBDataSet_furde.TblFurde);
          //  this.tblMalliTableAdapter.Fill(this.rubyDBDataSet1.TblMalli);
        }

        //Ta Mshel formen----------Qekjo osht e ndreqme MIRE
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login objforma1 = new Login();
            //this.Hide();
            //objforma1.Show(); 
            //Fix this to completly close app.

            this.Close(); //temporarily use this
        }

        #region Funksionet per Date Query


        string FunksioniPerDate(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select * from TblMalli Where Data_Shitjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_Shitjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }

        string FunksioniPerShum(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select SUM(Malli_Cmimi) from TblMalli Where Data_Shitjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_Shitjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }

        string FunksioniPerFurde(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select * from TblFurde Where Data_blerjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_blerjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }

        #endregion


        //Funksioni qe e mer daten edhe bon query per me qit qat dat ne DGV----------Qekjo osht e ndreqme MIRE
        //Nuk po e preki qeto se osht pak e modifikume ne veti e nxjer pune pak me shti ne qat klass
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

            dgvHistoria.Visible = true; //Grid visible if there's data
            string theDate = dtpData.Value.ToShortDateString();
            
            lblDataSot.Text = theDate.ToString();
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            try
            {
               
                string queryPerHistorialbl = FunksioniPerShum(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));

                string queryPerdgvHistoria = FunksioniPerDate(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));


                SqlCommand objKomanda3 = new SqlCommand(queryPerHistorialbl, objKonektimi);
                objKonektimi.Open();
                SqlDataAdapter objAdapteri = new SqlDataAdapter(queryPerdgvHistoria, objKonektimi);
                DataSet Shenimet = new DataSet();
                double mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                objAdapteri.Fill(Shenimet);
                dgvHistoria.DataSource = Shenimet.Tables[0];
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                
            }
            catch (Exception)
            {
                lblHistoriaShitje.Text = "N/A";
                dgvHistoria.Visible = false; //Not visible i there is no data in gridview
            }
            finally
            {
                objKonektimi.Close();
            }
        }

        //Funksioni qe shton te dhanat te Pjesa e Shitjeve(kryesore)----------Qekjo osht e ndreqme MIRE
        private void btnShto_Click_1(object sender, EventArgs e)
        {
            //qeky try osht bo sa per me i hek numrat ose shkronjat qe qiten ne vend gabim po osht i perkoshem
            try
            {
                //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 
                string queryPerInsertim = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtbmPershkrimi.Text + "')";

                string queryPerShitje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";



                //Query per insertim ne vend te TRY qe osht qetash
                ObjPunaDB.InsUpdDel(queryPerInsertim);
                //qeky osht rreshti i kodit qe e kom shkru qe me vyn me bo
                dgvShitja.DataSource = ObjPunaDB.LexoShenimet(queryPerShitje).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ka nje Gabim ju lutem Korrigjoni!!!");
                //Sa per test
                MessageBox.Show(ex.Message);

            }

        }

        //E mbush me te dhana DGV Malli----------Qekjo osht e ndreqme MIRE
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblMalliTableAdapter.FillBy(this.rubyDBDataSet1.TblMalli);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Shton Furde te tabela e furdeve----------Qekjo osht e ndreqme MIRE
        private void btShtoFurde_Click(object sender, EventArgs e) //Shto Furde buttoni per query 
        {

            try
            {
                double total = double.Parse(txtSasiaFurde.Text) * double.Parse(txtGramFurde.Text);

                string queryPerInsertimFurde = "insert into dbo.tblFurde(Sasia_gr_furde,Cmimi_per_gr_furde,Cmimi_total_furde,Data_blerjes,Pershkrimi) values('" + float.Parse(txtSasiaFurde.Text) + "','" + float.Parse(txtGramFurde.Text) + "','" + total.ToString() + "','" + dtpFurde.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtPershkrimiFurde.Text + "')";

                string queryPerShfaqjeFurde = "SELECT * FROM TblFurde WHERE DATEDIFF(day, TblFurde.Data_blerjes , GETDATE()) = 0";

                //Funksioni per insertim
                ObjPunaDB.InsUpdDel(queryPerInsertimFurde);
                //Funksioni per Shfaqjen e shenimeve
                dgvFurde.DataSource = ObjPunaDB.LexoShenimet(queryPerShfaqjeFurde).Tables[0];

                txtSasiaFurde.Clear();
                txtGramFurde.Clear();
                txtPershkrimiFurde.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ka nje Gabim ju lutem permirsoni!");
            }


        }


        //I shton Shpenzimet ne Databaze edhe i paraqet ne tabele----------Qekjo osht e ndreqme MIRE
        private void btShtoShpenzime_Click(object sender, EventArgs e) //Query per shpenzime
        {
            // SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string queryPerInsertimShpenzime = "Insert into TblShpenzimet(Rryma_fat,Uji_fat,Tatimi_fat,Data_fatures,Pershkrimi) values ('" +
                txtShpenzimeRryma.Text +
                "','" + txtShpenzimeUji.Text +
                "','" + txtShpenzimeTatimi.Text + 
                "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtShpenzimePershkrimi.Text + "')";

            string queryPerShfaqjeShpenzime = "SELECT * FROM TblShpenzimet";

            //Funksioni per insertim
            ObjPunaDB.InsUpdDel(queryPerInsertimShpenzime);
            //Funksioni per Shfaqjen e shenimeve
            dgvShpenzimet.DataSource = ObjPunaDB.LexoShenimet(queryPerShfaqjeShpenzime).Tables[0];

            txtShpenzimeRryma.Clear();
            txtShpenzimeUji.Clear();
            txtShpenzimeTatimi.Clear();
            txtShpenzimePershkrimi.Clear();

        }


        //Me mar daten per furde edhe me e paraqit ne tabele si histori----------Qekjo osht e ndreqme MIRE
        private void dtpFurde_ValueChanged(object sender, EventArgs e)
        {
            dgvFurde.Visible = true; //Grid visible if there's data

            string QueryPerFurde = FunksioniPerFurde(dtpFurde.Value.ToString("yyyy - MM - dd  HH: mm:ss"));

            //Funksioni per Shfaqjen e shenimeve
            dgvFurde.DataSource = ObjPunaDB.LexoShenimet(QueryPerFurde).Tables[0];
        }


        //BACKUP DATABAZA----------Qekjo osht e ndreqme MIRE
        private void historikuToolStripMenuItem_Click(object sender, EventArgs e) //Backup database to .bak
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            
            objKonektimi.Open();

            string DatabaseName = Application.StartupPath + @"\RubyDB.mdf";

            SqlCommand BackupDB = new SqlCommand("BACKUP DATABASE [" + DatabaseName + "] to DISK='Desktop\\RubyDatabase.bak' ", objKonektimi);


            try
            {
                BackupDB.ExecuteNonQuery();
                MessageBox.Show("Databaza u ruajt me sukses.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("'" + Ex.ToString() + "'");
            }
            finally
            {
                objKonektimi.Close();
            }
                
        }
    }
}
