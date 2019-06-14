using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;


namespace Toogood_Test_Kashyap
{
    class Type_Collection
    {
        // class to read and fetch xmls for currency and account type. xml can further be modified without changing the class.
   
        public string Get_Account_Type(string type)
        {
            string acc_type = "";
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Type.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "code";
            int index = dv.Find(type);

            if (index == -1)
            {
                dv.Sort = "account_type";
                int index1 = dv.Find(type);
                if(index1 >= 0)
                {
                    acc_type = dv[index]["code"].ToString();
                }
            }
            else
            {
                 acc_type = dv[index]["type"].ToString();
               
            }

            return acc_type;
        }
        public string Get_Currency(string cur)
        {
            string cur_type = "";
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Type.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);

            dv = new DataView(ds.Tables[1]);
            dv.Sort = "ccode";
            int index = dv.Find(cur);

            if (index == -1)
            {
                dv.Sort = "ctype";
                int index1 = dv.Find(cur);
                if (index1 >= 0)
                {
                    cur_type = dv[index]["ctype"].ToString();
                }
            }
            else
            {
                cur_type = dv[index]["ctype"].ToString();
            }
            return cur_type;
        }
    }
}
