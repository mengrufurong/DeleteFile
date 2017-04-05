using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFiles
{
    public class RedisDiagnostic
    {   
        public string FarmSerialnum { get; set; }
        public List<RedisFacility> RedisFacilitys { get; set; }

        public RedisDiagnostic()
        {
            RedisFacilitys = new List<RedisFacility>();
        }
    }
    //站点下的各个设施
    public class RedisFacility
    {
        public string FacilitySerialnum { get; set; }
        public List<RedisFacilityInfo> RedisFacilityInfos { get; set; }

        public RedisFacility()
        {
            RedisFacilityInfos = new List<RedisFacilityInfo>();
        }
    }

    public class RedisFacilityInfo
    {
        public string FacilityInfoSerialnum { get; set; }
        public string DeviceTypeSerialnum { get; set; }
        public string AgrProductObjectSerialnum { get; set; }
        public string DiagnosticModelSerialnum { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<RedisDiagnosticGrade> RedisDiagnosticGrades { get; set; }

        public RedisFacilityInfo()
        {
            RedisDiagnosticGrades = new List<RedisDiagnosticGrade>();
        }
    }

    //诊断模型等级
    public class RedisDiagnosticGrade
    {
        public string DiagnosticGradeSerialnum { get; set; }
        public string Name { get; set; }
        public string MaxValue { get; set; }
        public string MinValue { get; set; }
        public string DisplayColor { get; set; }
        public string Effect { get; set; }
        public string Advise { get; set; }
        public char IsNotice { get; set; }
        public int Sort { get; set; }
        public string Remark { get; set; }
       
    

    }

}
