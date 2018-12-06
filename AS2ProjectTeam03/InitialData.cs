using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    public class InitialData
    {
        public List<Datum> GetInitialData()
        {
            //initial coin data
            JavaScriptSerializer js = new JavaScriptSerializer();
            //deserializes the contents of InitialJsonString.cs into a rootObject
            RootObject rootObject = js.Deserialize<RootObject>(new InitialJson().InitialJsonString);
            //puts the data portion of the json into a Datum list
            List<Datum> jsonList = rootObject.data;
            return jsonList;
        }
    }
}
