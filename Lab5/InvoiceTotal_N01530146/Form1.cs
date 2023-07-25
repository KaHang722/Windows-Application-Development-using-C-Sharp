namespace InvoiceTotal_N01530146
{
    public partial class Form1 : Form
    {
        //array
        decimal[] invTotalArray = new decimal[5];
        
        //list
        List<decimal> invTotalList = new List<decimal>();

        //queue
        Queue<decimal> invTotalQueue = new Queue<decimal>();

        //stack
        Stack<decimal> invTotalStack = new Stack<decimal>();

        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //array
            string message = ""; //Display into message box
            string title = " Order Totals (Array)"; //title of the message box
            foreach (decimal total in invTotalArray)
            {
                if (total != 0)
                {
                   message += total.ToString("c") + "\n";
                }
            }
            DialogResult arrayResult = MessageBox.Show(message, title);

            //list
            string listMessage = "";
            string listTitle = " Order Totals (List)";
            foreach (decimal total in invTotalList)
            {
                if (total != 0)
                {
                    listMessage += total.ToString("c") + "\n";
                }
            }
            DialogResult listResult = MessageBox.Show(listMessage, listTitle);

            //queue
            string queueMessage = "";
            string queueTitle = " Order Totals (Queue)";
            foreach (decimal total in invTotalQueue)
            {
                if (total != 0)
                {
                    queueMessage += total.ToString("c") + "\n";
                }
            }
            DialogResult queueResult = MessageBox.Show(queueMessage, queueTitle);

            //stack
            string stackMessage = "";
            string stackTitle = " Order Totals (Stack)";
            foreach (decimal total in invTotalStack)
            {
                if (total != 0)
                {
                    stackMessage += total.ToString("c") + "\n";
                }
            }
            DialogResult stackResult = MessageBox.Show(stackMessage, stackTitle);

            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {    
            decimal st = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;
            discountPercent = getDiscountPercent(subtotal: st);

            decimal discountAmount = discountPercent * st;
            decimal invoicetotal = st - discountAmount;

            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p");
            txtTotal.Text = invoicetotal.ToString("c");
            invTotalArray[index]=invoicetotal; //array
            invTotalList.Insert(index, invoicetotal); //list
            invTotalQueue.Enqueue(invoicetotal); //queue
            invTotalStack.Push(invoicetotal); //stack
            index++;
        }
        private decimal getDiscountPercent(decimal subtotal = 100.0M)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }
            return discountPercent;
        }
    }
}