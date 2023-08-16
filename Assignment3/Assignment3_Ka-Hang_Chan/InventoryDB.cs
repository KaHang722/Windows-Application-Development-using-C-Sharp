using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Ka_Hang_Chan
{
    public static class InventoryDB
    {
        private const string dir = @"C:\C#\Files\";
        private const string path = dir + "InventoryItems.dat";
        public static void SaveItems(List<InvItem> inventories)
        {
            using BinaryWriter binaryOut =
                new BinaryWriter(
                new FileStream(
                    path, FileMode.Create, FileAccess.Write));

            foreach (InvItem inventory in inventories)
            {
                binaryOut.Write(inventory.ItemNo);
                binaryOut.Write(inventory.Description);
                binaryOut.Write(inventory.Price);
            }

            binaryOut.Close();

        }

        public static List<InvItem> GetItems()
        {
            List<InvItem> inventories = new List<InvItem>();

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using BinaryReader binaryIn =
                new BinaryReader(
                new FileStream(
                    path, FileMode.OpenOrCreate, FileAccess.Read));

            while (binaryIn.PeekChar() != -1)
            {
                InvItem inventory = new InvItem();
                inventory.ItemNo = binaryIn.ReadInt32();
                inventory.Description = binaryIn.ReadString();
                inventory.Price = binaryIn.ReadDecimal();
                inventories.Add(inventory);
            }
            binaryIn.Close();

            return inventories;
        }
    }
}
