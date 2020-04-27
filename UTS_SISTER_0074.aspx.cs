using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

//By. Irfan_NA0074
public partial class UTS_SISTER_0074 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //isi dulu dataTable
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id"), new DataColumn("pdp_positif"), 
                new DataColumn("pdp_negatif"), new DataColumn("pdp_meniggal")});

            dt.Rows.Add("Data Baru", "", "", "");
            dt.Rows.Add("Total Data", "", "", "");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    static int total_data_pdp_positif;
    protected void btnPDPPositif_Click(object sender, EventArgs e)
    {
        //kirim data ke web service
        webService.Service objek = new webService.Service();

        int jmlPDP_Positif = objek.PDP_Positif(Convert.ToInt32(txtPDPPositif.Text));
        pesan.Text = "jumlah PDP Positif : " + jmlPDP_Positif.ToString() + " Telah di input";

        //method isi ke tabel
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                //input ke tabel kolom databaru pdp_positif
                if (row.RowIndex == 0)
                {
                    Label lb11 = (Label)row.FindControl("Label1");
                    lb11.Text = txtPDPPositif.Text;

                }
                //input ke tabel kolom databaru total_data_pdp_positif
                if (row.RowIndex == 1)
                {
                    Label lb12 = (Label)row.FindControl("Label1");

                    int data_baru = Convert.ToInt32(txtPDPPositif.Text);
                    total_data_pdp_positif = data_baru + total_data_pdp_positif;
                    lb12.Text = Convert.ToString(total_data_pdp_positif);
                }
            }

        }
        txtPDPPositif.Text = ""; //untuk clear textbox
    }


    static int total_data_pdp_negatif;
    protected void btnPDPnegatif_Click(object sender, EventArgs e)
    {

        //kirim data ke web service
        webService.Service objek = new webService.Service();
        int jmlPDP_Sembuh = objek.PDP_Sembuh(Convert.ToInt32(txtPDPnegatif.Text));
        pesan.Text = "jumlah PDP Sembuh : " + jmlPDP_Sembuh.ToString() + " Telah di input";

        //method isi ke tabel
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                //input ke tabel kolom databaru
                if (row.RowIndex == 0)
                {
                    Label lb11 = (Label)row.FindControl("Label2");
                    lb11.Text = txtPDPnegatif.Text;

                }
                //input ke tabel kolom total_data_pdp_negatif
                if (row.RowIndex == 1)
                {
                    Label lb12 = (Label)row.FindControl("Label2");

                    int data_baru = Convert.ToInt32(txtPDPnegatif.Text);
                    total_data_pdp_negatif = data_baru + total_data_pdp_negatif;
                    lb12.Text = Convert.ToString(total_data_pdp_negatif);
                }
            }

        }
        txtPDPnegatif.Text = ""; //untuk clear textbox
    }


    static int total_data_pdp_meninggal;
    protected void btnPDPmeninggal_Click(object sender, EventArgs e)
    {

        //kirim data ke web service
        webService.Service objek = new webService.Service();
        int jmlPDPmeninggal = objek.PDP_Meninggal(Convert.ToInt32(txtPDPmeninggal.Text));
        pesan.Text = "jumlah PDP Meninggal : " + jmlPDPmeninggal.ToString() + " Telah di input";

        //method isi ke tabel
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                //input ke tabel kolom databaru
                if (row.RowIndex == 0)
                {
                    Label lb11 = (Label)row.FindControl("Label3");
                    lb11.Text = txtPDPmeninggal.Text;

                }
                //input ke tabel kolom total data
                if (row.RowIndex == 1)
                {
                    Label lb12 = (Label)row.FindControl("Label3");

                    int data_baru = Convert.ToInt32(txtPDPmeninggal.Text);
                    total_data_pdp_meninggal = data_baru + total_data_pdp_meninggal;
                    lb12.Text = Convert.ToString(total_data_pdp_meninggal);
                }
            }

        }
        txtPDPmeninggal.Text = ""; //untuk clear textbox
    }
}