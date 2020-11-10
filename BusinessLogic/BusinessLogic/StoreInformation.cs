using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessLogic
{
    public class StoreInformation
    {
        private string _storeAddress { get; set; }
        private int _storeNum { get; set; }
        public Dictionary<string, string> store { get; set; }


        public void StoreInfo(string storeAddress, int storeNum)
        {
            _storeAddress = storeAddress;
            _storeNum = storeNum;

        }

        public void StoreDictionary()
        {
            //putting the store names into a dictionary
            //Dictionary<string, string>
            store = new Dictionary<string, string>
            {
                { "Flowerworks - Dallas", "0001" },
                { "Flowerworks - Fort Worth", "0002" },
                { "Flowerworks - Addison", "0003" }
            };
            

           
        }
     
    }
}

