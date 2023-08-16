namespace Assignment3_Ka_Hang_Chan
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private List<InvItem> inventories = null;

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            inventories = InventoryDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            var i = from InvItem inventory in inventories
                    select inventory.GetDisplayText();

            foreach (var inventory in i)
            {
                lstItems.Items.Add(inventory);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmNewInventory newInventoryForm = new frmNewInventory();
            InvItem inventory = newInventoryForm.GetNewItem();
            if (inventory != null)
            {
                inventories.Add(inventory);
                InventoryDB.SaveItems(inventories);
                FillItemListBox();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i != -1)
            {
                var selectedInventory = inventories[i];
                var item = from InvItem inventoryDelete in inventories.ToList()
                        where inventoryDelete == selectedInventory
                        select inventoryDelete;


                foreach (var inventory in item)
                {
                    string message = "Are you sure you want to delete "
                    + inventory.ItemNo+ "?";

                    DialogResult button = MessageBox.Show(message, "Confirm Delete",
                        MessageBoxButtons.YesNo);

                    if (button == DialogResult.Yes)
                    {
                        inventories.Remove(inventory);
                        InventoryDB.SaveItems(inventories);
                        FillItemListBox();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}