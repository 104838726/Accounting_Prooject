using System.ComponentModel;
using System.Text;

namespace CSVAccounting_Project
{
    public partial class Form1 : Form
    {
        private BindingList<Item> items = new BindingList<Item>();
        public Form1()
        {
            InitializeComponent();

            //將enum型態轉換成combox可以讀取的型態
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
            dgvItems.DataSource = items;

            //建立資料表
            DbHelper.InitDb();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == string.Empty)
            {
                MessageBox.Show("輸入不能為空", "警告");
                return;
            }
            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("金額輸入不正確!", "警告");
                return;
            }

            Item item = new Item();
            item.Date = dtpDate.Value;
            item.Note = txtNote.Text;
            item.Amount = nudAmount.Value;
            item.IsIncome = cbxIncome.Checked;
            item.CategoryType = (Category)cmbCategory.SelectedItem!;


            DbHelper.InsertItem(item);
            items.Add(item);
            CalcTotal();
        }






        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }

            //取得DataGridView選擇到的位置
            int index = dgvItems.CurrentRow.Index;


            if (MessageBox.Show("確定刪除?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                items.RemoveAt(index);
            }

            Console.WriteLine(items[index]);
            items.RemoveAt(index);
        }



        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);

            MessageBox.Show($"點選到第{e.RowIndex + 1}列資料，進入編輯模式");

            Item item = items[e.RowIndex];
            txtNote.Text = item.Note;
            nudAmount.Value = item.Amount;
            cbxIncome.Checked = item.IsIncome;
            cmbCategory.SelectedItem = item.CategoryType;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }

            //取得DataGridView選擇到的位置
            int index = dgvItems.CurrentRow.Index;


            if (MessageBox.Show("確定更新?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Item item = new Item();
                item.Date = dtpDate.Value;
                item.Note = txtNote.Text;
                item.Amount = nudAmount.Value;
                item.IsIncome = cbxIncome.Checked;
                item.CategoryType = (Category)cmbCategory.SelectedItem!;
                items[index] = item;

            }
            CalcTotal();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (items.Count == 0) { return; }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV檔案|*.csv";
            dialog.FileName = "accounting.csv";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            //寫入檔案
            using (StreamWriter sw = new StreamWriter(
                dialog.FileName, false, Encoding.UTF8))
            {
                sw.WriteLine("日期,事項,金額,分類,收入");
                foreach (Item item in items)
                {
                    string line = string.Format(
                        "{0},{1},{2},{3},{4}",
                        item.Date.ToString("yyyy/MM/dd hh:mm"),
                        item.Note,
                        item.Amount,
                        item.CategoryType,
                        item.IsIncome ? "是" : "否"
                        );

                    sw.WriteLine(line);



                }
                CalcTotal();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            items.Clear();
            var itemLList = DbHelper.GetAllItems();

            foreach(var item in items)
            {
                items.Add(item);
            }
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "CSV檔案|*.csv";

            //if (dialog.ShowDialog() != DialogResult.OK) return;
            //{
            //    items.Clear();
            //    try
            //    {
            //        string[] lines = File.ReadAllLines(dialog.FileName, Encoding.UTF8);

            //        for (int i = 1; i < lines.Length; i++)
            //        {
            //            string[] cols = lines[i].Split(",");
            //            if (cols.Length != 5) continue;

            //            Item item = new Item();

            //            item.Date = DateTime.Parse(cols[0]);
            //            item.Note = cols[1];
            //            item.Amount = decimal.Parse(cols[2]);
            //            item.CategoryType = (Category)Enum.Parse(typeof(Category), cols[3]);
            //            item.IsIncome = cols[4] == "是" ? true : false;


            //            items.Add(item);

            //        }
            //        CalcTotal();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"檔案格式不正確:{ex.ToString()}", "錯誤");
            //    }
        }
        
        public void CalcTotal()
        {
            decimal incoming = 0, outgoing = 0;
            foreach (var item in items)
            {
                if (item.IsIncome)
                {
                    incoming += item.Amount;
                }
                else
                {
                    outgoing += item.Amount;
                }
            }
            lblIncoming.Text = $"收入:{incoming}";
            lblOutgoing.Text = $"支出:{outgoing}";
            lblTotal.Text = $"結餘:{incoming - outgoing}";
        }

        
    }
}