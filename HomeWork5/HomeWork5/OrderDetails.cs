﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class OrderDetails
    {
        public string GoodName { get; set; }
        public double CostPerGood { get; set; }
        private int numOfGood;
        public int NumOfGood { 
            get { return numOfGood; } 
            set 
            { 
                numOfGood = value < 0 ? 0 : value;

            } 
        }

        public double CostSum { get { return CostPerGood * NumOfGood; } }

        public OrderDetails(string name,double price,int num)
        {
            GoodName = name;
            CostPerGood = price;
            NumOfGood = num;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(GoodName + "  " + CostPerGood + "元/个  " + NumOfGood + "个" + '\n');
            return str.ToString();
            
        }

        
    }
}
