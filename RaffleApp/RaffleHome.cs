using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RaffleApp
{
    public partial class RaffleHome : DevExpress.XtraEditors.XtraForm
    {
        private List<string> participants;

        public RaffleHome()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void BtnFileUpload_Click(object sender, EventArgs e)
        { 
            gridControl1.DataSource = null; 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Lütfen Excel Dosyası seç Melih Berşah !!!";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable dataTable = ImportExcelToDataTable(filePath);
                gridControl1.DataSource = dataTable;
                button1.Text = "Çekilişe Katılacak Kişi Sayısı : " + dataTable.Rows.Count;


            }
        }


        private DataTable ImportExcelToDataTable(string filePath)
        {
            DataTable dt = new DataTable();
            participants = new List<string>();
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;

                for (int col = 1; col <= colCount; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Value?.ToString());

                }

                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {
                        var customer = worksheet.Cells[row, col].Value?.ToString();
                        dataRow[col - 1] = customer;
                        participants.Add(customer);
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int numberOfWinners;
            int numberOfReserves;

            // Katılımcı ve yedek sayısını al
            if (int.TryParse(txtParticipants.Text, out numberOfWinners) && int.TryParse(txtReserves.Text, out numberOfReserves))
            {
                if (participants == null || participants.Count == 0)
                {
                    MessageBox.Show("Katılımcı listesi boş. Lütfen önce bir Excel dosyasını içe aktarın.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                // Rastgele seçilecek kişileri belirle
                var result = DrawParticipants(numberOfWinners, numberOfReserves);

                // Sonuçları listelere ekle
                lstWinners.Items.Clear();
                lstReserves.Items.Clear();

                foreach (var winner in result.Item1)
                {
                    lstWinners.Items.Add(winner);
                }

                foreach (var reserve in result.Item2)
                {
                    lstReserves.Items.Add(reserve);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private Tuple<List<string>, List<string>> DrawParticipants(int numberOfWinners, int numberOfReserves)
        {
            Random random = new Random();
            List<string> winners = new List<string>();
            List<string> reserves = new List<string>();

            List<string> allParticipants = new List<string>(participants);

            // Kazananları seç
            for (int i = 0; i < numberOfWinners; i++)
            {
                if (allParticipants.Count == 0) break;

                int index = random.Next(allParticipants.Count);
                winners.Add(allParticipants[index]);
                allParticipants.RemoveAt(index);
            }

            // Yedekleri seç
            for (int i = 0; i < numberOfReserves; i++)
            {
                if (allParticipants.Count == 0) break;

                int index = random.Next(allParticipants.Count);
                reserves.Add(allParticipants[index]);
                allParticipants.RemoveAt(index);
            }

            return Tuple.Create(winners, reserves);
        }

        private void btnSaveWinners_Click(object sender, EventArgs e)
        {
            SaveListBoxContent(lstWinners, "Kazananlar.txt");
        }

        private void btnSaveReserves_Click(object sender, EventArgs e)
        {
            SaveListBoxContent(lstReserves, "Yedekler.txt");
        }

        private void SaveListBoxContent(ListBoxControl listBox, string fileName)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = fileName;
                saveFileDialog.Filter = "Text Files|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
                    {
                        foreach (var item in listBox.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                }
            }
        } 
    }
}