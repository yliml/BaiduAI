using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.Model.ImageClassify
{
    public class ObjectModel
    {
        public long log_id { get; set; }

        public long result_num { get; set; }

        public  List<ObjectData> result { get; set; }
    }

    public class ObjectData
    {
        public string keyword { get; set; }

        public double score { get; set; }

        public string root { get; set; }
    }
}
