using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogood_Test_Kashyap
{
    class User_Account
    {
        // class to perform get and set properties operation.
        
            private string name;
            private string account_code;
            private string account_type;
            private string account_opened;
            private string currency;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                        name = value;
                }
            }
            public string Account_Code
            {
                get
                {
                    return account_code;
                }
                set
                {
                    account_code = value;
                }
            }
            public string Account_Type
            {
                get
                {
                    return account_type;
                }
                set
                {
                    account_type = value;
                }
            }
            public string Account_Opened
            {
                get
                {
                    return account_opened;
                }
                set
                {
                    account_opened = value;
                }
            }
            public string Currency
            {
                get
                {
                    return currency;
                }
                set
                {
                    currency = value;
                }
            }

        
    }
}
