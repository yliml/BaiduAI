using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.Model.ImageClassify
{
    public class PlantModel
    {
        public long log_id { get; set; }

        public List<PlantData> result { get; set; }

    }
    public class PlantData
    {
        public string name { get; set; }

        public double score { get; set; }
    }

    public class PlantModel1
    {
        public long log_id { get; set; }

        public PlantData result { get; set; }
    }
}
