using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2ProjectTeam03
{
    public class XmlToDataGridView
    {
        public DataSet GetDataSet()
        {
            DataSet seedData = new DataSet();
            try
            {
                seedData.ReadXml(Path.GetFullPath(Application.StartupPath + "\\..\\..\\Books.xml"));
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return seedData;
        }
    }
}
