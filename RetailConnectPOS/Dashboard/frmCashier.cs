using RetailConnectPOS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace RetailConnectPOS.Dashboard
    {
    /* Author :    Moreheahs Inc, Indore, MP, India.
       Email:      info@moreyeahs.Com
       Advance POS : http://www.moreyeahs.com  
   */

    public partial class frmCashier : Form
        {
        DBModelContext db = new DBModelContext();



        public frmCashier()
            {            
            InitializeComponent();
            timer1.Start();
            }   

        private void timer1_Tick(object sender, EventArgs e)
            {
            DateTime showDateTime = DateTime.Now;
            this.lalbelDateTime.Text = showDateTime.ToString();
            }

        private void frmCashier_Load(object sender, EventArgs e)
            {
            
            string ScreenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string ScreenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            lblReso.Text = (ScreenWidth + "X" + ScreenHeight);

            //gridItemMaster.Columns["ProductCode"].Width =20;
            //gridItemMaster.Columns["ProductName"].Width =200;
            //gridItemMaster.Columns["UnitPrice"].Width = 20;
            //gridItemMaster.Columns["Quantity"].Width =20;
            //gridItemMaster.Columns["Total"].Width =20 ;

            //gridSKU.Columns["ProductCode"].Width = 20;
            //gridSKU.Columns["ProductName"].Width = 200;
            //gridSKU.Columns["GSTPrice"].Width = 35;
            //gridSKU.Columns["AltCode"].Width = 35;
            //gridSKU.Columns["GSTCode"].Width = 35;

            var List = (from a in db.STOCKs
                        select new
                            {
                            ProductCode = a.PRDCODE,
                            ProductName = a.PRDNAME,
                            GSTPrice = a.REGPRICE,
                            AltCode = a.ALTCODE,
                            GSTCode = a.VATIN

                            }).ToList();

            gridSKU.DataSource = List;
            }
        private void btnAppClose_Click(object sender, EventArgs e)
            {
            if
               (
                   MessageBox.Show
                   (
                       "Quit the Application",
                       "Exit Application Dialog",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2 // hit Enter == No !
                   )
                   == DialogResult.Yes
               )
                {
                Application.Exit();
                }
            }

        private void btnPay_Click(object sender, EventArgs e)
            {
            if (lblTotal.Text == "00" || lblTotal.Text == "0.00")
                {
                MessageBox.Show("Sorry ! You don't have enough product in Item cart \n  Please Add to cart", "Yes or No", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }

            }

        private void btnPay_MouseEnter(object sender, EventArgs e)
            {
            btnPay.BackColor = Color.MediumSeaGreen;
            btnPay.ForeColor = Color.White;
            }

        private void btnPay_MouseLeave(object sender, EventArgs e)
            {
            btnPay.BackColor = Color.Gold;
            btnPay.ForeColor = Color.Black;
            }

        private void btnCancelOrder_Click(object sender, EventArgs e)
            {
            gridItemMaster.Refresh();
            gridItemMaster.Rows.Clear();
            lblqty.Text = "00";
            lblTotal.Text = "0.00";
            txtBarcodeReaderBox.Text = "";

            }
        private void btnCancelOrder_MouseEnter(object sender, EventArgs e)
            {
            btnCancelOrder.BackColor = Color.MediumSeaGreen;
            btnCancelOrder.ForeColor = Color.White;
            }

        private void btnCancelOrder_MouseLeave(object sender, EventArgs e)
            {
            btnCancelOrder.BackColor = Color.Gold;
            btnCancelOrder.ForeColor = Color.Black;
            }

        private void btnNewOrder_Click(object sender, EventArgs e)
            {

            }

        private void btnNewOrder_MouseEnter(object sender, EventArgs e)
            {
            btnNewOrder.BackColor = Color.MediumSeaGreen;
            btnNewOrder.ForeColor = Color.White;
            }

        private void btnNewOrder_MouseLeave(object sender, EventArgs e)
            {
            btnNewOrder.BackColor = Color.Gold;
            btnNewOrder.ForeColor = Color.Black;
            }

        private void btnSKU_Click(object sender, EventArgs e)
            {
            panelSKU.Show();
            panelBottom2.Hide();
            txtBarcodeReaderBox.Text = "";
            }

        private void btnSKU_MouseEnter(object sender, EventArgs e)
            {
            btnSKU.BackColor = Color.MediumSeaGreen;
            btnSKU.ForeColor = Color.White;
            }

        private void btnSKU_MouseLeave(object sender, EventArgs e)
            {
            btnSKU.BackColor = Color.Gold;
            btnSKU.ForeColor = Color.Black;
            }
        private void btnSKUClose_Click(object sender, EventArgs e)
            {
            panelSKU.Hide();
            panelBottom2.Show();
            }


        private void btnPOSReport_Click(object sender, EventArgs e)
            {
            Options.frmPOSReport POSReport = new Options.frmPOSReport();
            POSReport.Show();
            }

        private void btnPOSReport_MouseEnter(object sender, EventArgs e)
            {
            btnPOSReport.BackColor = Color.MediumSeaGreen;
            btnPOSReport.ForeColor = Color.White;
            }

        private void btnPOSReport_MouseLeave(object sender, EventArgs e)
            {
            btnPOSReport.BackColor = Color.Gold;
            btnPOSReport.ForeColor = Color.Black;
            }

        private void btnCheckPrice_Click(object sender, EventArgs e)
            {
            Options.frmCheckPrice CheckPrice = new Options.frmCheckPrice();
            CheckPrice.Show();
            }

        private void btnCheckPrice_MouseEnter(object sender, EventArgs e)
            {
            btnCheckPrice.BackColor = Color.MediumSeaGreen;
            btnCheckPrice.ForeColor = Color.White;
            }

        private void btnCheckPrice_MouseLeave(object sender, EventArgs e)
            {
            btnCheckPrice.BackColor = Color.Gold;
            btnCheckPrice.ForeColor = Color.Black;
            }

        private void btnSeekResume_Click(object sender, EventArgs e)
            {
            Options.frmSeekResume SeeRkResume = new Options.frmSeekResume();
            SeeRkResume.Show();
            }

        private void btnSeekResume_MouseEnter(object sender, EventArgs e)
            {
            btnSeekResume.BackColor = Color.MediumSeaGreen;
            btnSeekResume.ForeColor = Color.White;
            }

        private void btnSeekResume_MouseLeave(object sender, EventArgs e)
            {
            btnSeekResume.BackColor = Color.Gold;
            btnSeekResume.ForeColor = Color.Black;
            }

        private void btnOpenDrawer_Click(object sender, EventArgs e)
            {

            }

        private void btnOpenDrawer_MouseEnter(object sender, EventArgs e)
            {
            btnOpenDrawer.BackColor = Color.MediumSeaGreen;
            btnOpenDrawer.ForeColor = Color.White;
            }

        private void btnOpenDrawer_MouseLeave(object sender, EventArgs e)
            {
            btnOpenDrawer.BackColor = Color.Gold;
            btnOpenDrawer.ForeColor = Color.Black;
            }

        private void btnPWP_Click(object sender, EventArgs e)
            {

            }

        private void btnPWP_MouseEnter(object sender, EventArgs e)
            {
            btnPWP.BackColor = Color.MediumSeaGreen;
            btnPWP.ForeColor = Color.White;
            }

        private void btnPWP_MouseLeave(object sender, EventArgs e)
            {
            btnPWP.BackColor = Color.Gold;
            btnPWP.ForeColor = Color.Black;
            }

        private void btnCash_Click(object sender, EventArgs e)
            {

            }

        private void btnCash_MouseEnter(object sender, EventArgs e)
            {
            btnCash.BackColor = Color.MediumSeaGreen;
            btnCash.ForeColor = Color.White;
            }

        private void btnCash_MouseLeave(object sender, EventArgs e)
            {
            btnCash.BackColor = Color.Gold;
            btnCash.ForeColor = Color.Black;
            }

        private void btnChnagePrice_Click(object sender, EventArgs e)
            {

            }

        private void btnChnagePrice_MouseEnter(object sender, EventArgs e)
            {
            btnChnagePrice.BackColor = Color.MediumSeaGreen;
            btnChnagePrice.ForeColor = Color.White;
            }

        private void btnChnagePrice_MouseLeave(object sender, EventArgs e)
            {
            btnChnagePrice.BackColor = Color.Gold;
            btnChnagePrice.ForeColor = Color.Black;
            }

        private void btnCreditSales_Click(object sender, EventArgs e)
            {
            Options.frmCreditSales CreditSales = new Options.frmCreditSales();
            CreditSales.Show();
            }

        private void btnCreditSales_MouseEnter(object sender, EventArgs e)
            {
            btnCreditSales.BackColor = Color.MediumSeaGreen;
            btnCreditSales.ForeColor = Color.White;
            }

        private void btnCreditSales_MouseLeave(object sender, EventArgs e)
            {
            btnCreditSales.BackColor = Color.Gold;
            btnCreditSales.ForeColor = Color.Black;
            }

        private void btnReprintInvoice_Click(object sender, EventArgs e)
            {
            Options.frmPrintInvoice ReprintInvoice = new Options.frmPrintInvoice();
            ReprintInvoice.Show();
            }

        private void btnReprintInvoice_MouseEnter(object sender, EventArgs e)
            {
            btnReprintInvoice.BackColor = Color.MediumSeaGreen;
            btnReprintInvoice.ForeColor = Color.White;
            }

        private void btnReprintInvoice_MouseLeave(object sender, EventArgs e)
            {
            btnReprintInvoice.BackColor = Color.Gold;
            btnReprintInvoice.ForeColor = Color.Black;
            }

        private void btnSalesReturn_Click(object sender, EventArgs e)
            {
            Options.frmSalesReturn SalesReturn = new Options.frmSalesReturn();
            SalesReturn.Show();
            }

        private void btnSalesReturn_MouseEnter(object sender, EventArgs e)
            {
            btnSalesReturn.BackColor = Color.MediumSeaGreen;
            btnSalesReturn.ForeColor = Color.White;
            }

        private void btnSalesReturn_MouseLeave(object sender, EventArgs e)
            {
            btnSalesReturn.BackColor = Color.Gold;
            btnSalesReturn.ForeColor = Color.Black;
            }


        private void btnCancelItem_Click(object sender, EventArgs e)
            {
            int selectedCount = gridItemMaster.SelectedRows.Count;
            while (selectedCount > 0)
                {
                if (!gridItemMaster.SelectedRows[0].IsNewRow)
                    gridItemMaster.Rows.RemoveAt(gridItemMaster.SelectedRows[0].Index);
                selectedCount--;
                }
            }

        private void btnCancelItem_MouseEnter(object sender, EventArgs e)
            {
            btnCancelItem.BackColor = Color.MediumSeaGreen;
            btnCancelItem.ForeColor = Color.White;
            }

        private void btnCancelItem_MouseLeave(object sender, EventArgs e)
            {
            btnCancelItem.BackColor = Color.Gold;
            btnCancelItem.ForeColor = Color.Black;
            }

        private void btnSettings_Click(object sender, EventArgs e)
            {
            SettingsDebug.frmSettings Setting = new SettingsDebug.frmSettings();
            Setting.Show();

            }


        private void btnPanelPayShow_Click(object sender, EventArgs e)
            {
            panelPay.Width = 373;
            btnPanelPayHide.Show();
            btnPanelPayShow.Hide();
            }

        private void btnPanelPayHide_Click(object sender, EventArgs e)
            {
            panelPay.Width = 35;
            btnPanelPayHide.Hide();
            btnPanelPayShow.Show();
            }

        private int a = 1;
        private void btnQuanIncrease_Click(object sender, EventArgs e)
            {
            a++;
            pbError.Hide();
            lblQuantError.Hide();
            txtQuantity.Text = a.ToString();
            }

        private void btnQuantityDecrease_Click(object sender, EventArgs e)
            {
            if (a >= 2)
                {
                a--;
                txtQuantity.Text = a.ToString();
                }
            else
                {
                pbError.Show();
                lblQuantError.Show();
                lblQuantError.Text = "Quantity cannot be less than one";
                }
            }

        public int Finditem(string item)
            {
            int k = -1;
            if (gridItemMaster.Rows.Count > 0)
                {
                foreach (DataGridViewRow row in gridItemMaster.Rows)
                    {
                    if (row.Cells[0].Value != null)
                        {
                        if (row.Cells[0].Value.ToString().Equals(item))
                            {
                            k = row.Index;
                            break;
                            }
                        }
                    }
                }
            return k;
            }
        private void txtBarcodeReaderBox_Enter(object sender, EventArgs e)
            {
                {
                if (txtBarcodeReaderBox.Text == "Please Enter Barcode To Add Item In Cart")
                    {
                    txtBarcodeReaderBox.Text = "";
                    txtBarcodeReaderBox.ForeColor = SystemColors.WindowText;
                    }
                }
            }

        private void txtBarcodeReaderBox_Leave(object sender, EventArgs e)
            {
                {
                if (txtBarcodeReaderBox.Text.Length == 0)
                    {
                    txtBarcodeReaderBox.Text = "Please Enter Barcode To Add Item In Cart";
                    txtBarcodeReaderBox.ForeColor = SystemColors.GrayText;
                    }
                }
            }

        private void txtBarcodeReaderBox_TextChanged(object sender, EventArgs e)
            {            
                {

                //if (txtBarcodeReaderBox.Text == "")
                    //{
                    //MessageBox.Show("Please Insert Items BarCode.");
                    //}
                //else
                    {
                    var List = (from a in db.STOCKs
                                where a.PRDCODE == txtBarcodeReaderBox.Text
                                select new
                                    {
                                    ProductCode = a.PRDCODE,
                                    ProductName = a.PRDNAME,
                                    UnitPrice = a.PRICE,
                                    Quantity = txtQuantity.Text,
                                    }).SingleOrDefault();
                    if (List != null)
                        {

                        int n = Finditem(List.ProductCode);
                        if (n == -1)  //If new item
                            {

                            double TotalAmountProduct = Convert.ToDouble(List.UnitPrice) * Convert.ToDouble(List.Quantity);
                            gridItemMaster.Rows.Add(List.ProductCode, List.ProductName, List.UnitPrice, List.Quantity, TotalAmountProduct);
                            }
                        else
                            {
                            int QtyInc = Convert.ToInt32(gridItemMaster.Rows[n].Cells["Quantity"].Value);
                            double UnitP = Convert.ToDouble(gridItemMaster.Rows[n].Cells["UnitPrice"].Value);
                            gridItemMaster.Rows[n].Cells["Quantity"].Value = (QtyInc + 1);  //Qty Increase by MinOrderQty....as needed...
                            gridItemMaster.Rows[n].Cells["Total"].Value = (UnitP * Convert.ToDouble(gridItemMaster.Rows[n].Cells["Quantity"].Value));
                            }
                        }
                    //txtBarcodeReaderBox.Clear();
                    decimal tot = 0;

                    for (int i = 0; i <= gridItemMaster.RowCount - 1; i++)
                        {
                        tot += Convert.ToDecimal(gridItemMaster.Rows[i].Cells["Total"].Value);
                        }
                    if (tot == 0)
                        {

                        }
                    lblTotal.Text = tot.ToString();

                    int qty = 0;
                    for (int x = 0; x < gridItemMaster.Rows.Count; x++)
                        {
                        qty += Convert.ToInt32(gridItemMaster.Rows[x].Cells["Quantity"].Value);
                        }
                    if (qty == 0)
                        {

                        }
                    lblqty.Text = qty.ToString();

                    }
                gridItemMaster.ClearSelection();
                }
            }

        private void gridSKU_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = gridSKU.Rows[index];
            txtBarcodeReaderBox.Text = selectedRow.Cells[0].Value.ToString();
            panelSKU.Hide();
            panelBottom2.Show();
            }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == (Keys.Escape))
                {
                btnAppClose.PerformClick(); //Closes the Applicat
                }
            if (keyData == (Keys.Enter))
                {
                btnPay.PerformClick();  //Shift+P for Open Payment Page 
                }
            else if (keyData == (Keys.F5))
                {
                btnCancelOrder.PerformClick(); // Shift+S -> Suspen
                }
            else if (keyData == (Keys.Shift | Keys.Up))
                {
                btnQuanIncrease.PerformClick(); //Increase Quantity Value 
                }
            else if (keyData == (Keys.Shift | Keys.Down))
                {
                btnQuantityDecrease.PerformClick(); //Increase Quantity Value 
                }

            return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }












