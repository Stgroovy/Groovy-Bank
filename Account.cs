using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groovy_Bank
{
    class Account
    {
        public double totalBalance;
        public double interest;
        public double existingBalance;
        public double deposit;
        public double daysSaved;


        public double Balance()
        {

            double totalAmount = existingBalance + deposit;
            
                if ( daysSaved < 1)
            {
                interest = 0; // if days saved is less than 1
            }
                else if (daysSaved >= 1 && daysSaved <= 10)
            {
                interest = (existingBalance * 0.5) / 100; // if days saved is between 1 and 10
            }
                else if (daysSaved > 10 || daysSaved <= 30)  
            {
                interest = (existingBalance * 1) / 100; // if days saved is between 11 and 30
            }
            return totalAmount + interest;
        }

        public double Loan()
        {

        }

        public double Transfer()
        {

        }
    }
}
