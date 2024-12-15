using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GymMembershipManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymMembershipDataSet.Memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.gymMembershipDataSet.Memberships);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            try
            {
                membershipsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you trying to delete nothing");
            }
        }

        private void pdfBT_Click(object sender, EventArgs e)
        {
            pdf();

        }

        public void pdf()
        {
            if (dataGridView1.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "File1.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to ride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }
        }
        private void saveBT_Click(object sender, EventArgs e)
        {
            alreadyexist();

        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void alreadyexist()
        {
            if (dataGridView1.Equals(nameTB.Text))
            {
                MessageBox.Show("y");
            }

            else if (!membershipsBindingSource.Equals(nameTB.Text))
            {
                membershipsBindingSource.EndEdit();
                membershipsTableAdapter.Update(gymMembershipDataSet);
            }
        }

        private void addBT_Click_1(object sender, EventArgs e)
        {
            membershipsBindingSource.AddNew();
        }

        private void occupationCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
