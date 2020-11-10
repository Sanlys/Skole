using System;
using System.Security.Cryptography.X509Certificates;

namespace TextRPG
{
    class Program
    {
        static public void inventoryPrinter(int[] x)
        {
            string line1 = "Empty";
            string line2 = "Empty";
            string line3 = "Empty";
            string line4 = "Empty";
            string line5 = "Empty";
            string line6 = "Empty";
            string line7 = "Empty";
            string line8 = "Empty";

            for(int i = 0; i > 7; i++)
            {
                if(x[i] != 0)
                {
                    
                }
            }
        }

        static void Main(string[] args)
        {

            #region Quests
            Quest.SingleActionQuest[] QSR = new Quest.SingleActionQuest[20];
            QSR[0] = new Quest.SingleActionQuest();
            QSR[0].x = 11;
            #endregion

            #region Items
            Item.Weapon[] IWR = new Item.Weapon[1];
            IWR[0] = new Item.Weapon();
            IWR[0].name = "Iron Sword";
            IWR[0].type = 0;
            IWR[0].damage = 10;
            IWR[0].leveling = false;
            #endregion

            int[] inventory = { 0, 0, 0, 0, 0, 0, 0, 0 };
            
            Random rnd = new Random();
            inventoryPrinter(inventory);
        }
    }
}