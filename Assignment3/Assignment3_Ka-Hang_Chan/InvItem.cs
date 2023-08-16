using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment3_Ka_Hang_Chan
{
    public class InvItem
    {
        public InvItem()
        {
        }

        public InvItem(int ItemNo, string Description, decimal Price) =>
        (this.ItemNo, this.Description, this.Price) = (ItemNo, Description, Price);

        public int ItemNo { get; set; }

        public string Description { get; set; }
        
        public decimal Price { get; set; }

        public string GetDisplayText() => ItemNo.ToString() + ", " + Description + ", " + Price.ToString();
    }

    
}
