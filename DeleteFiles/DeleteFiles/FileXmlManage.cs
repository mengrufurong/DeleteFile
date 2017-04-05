using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLife.Xml;

namespace DeleteFiles
{
    [XmlConfigFile(@"FileXMLManage.xml", 15000)]
    public class FileXmlManage:XmlConfig<FileXmlManage>
    {
        public List<FileInfos> FileInfoes { get; set; } 
        //没隔多久运行一次程序,单位是分钟
        public int TimeSpan { get; set; }
        //保留多长时间的文件内容，单位是毫秒
        public int DayTimeSpan { get; set; }

        public int SleepTime { get; set; }
        public FileXmlManage()
        {
            SleepTime = 200;
            DayTimeSpan = 10;
            TimeSpan = 7200;
            var FileInfoes2=new List<FileInfos>();
            FileInfos file=new FileInfos();
            file.FilePath = "E:\\诊断模型图片";
            
            FileInfoes = FileInfoes2;
           // Current.Save();
        }
    }

    public class FileInfos
    {
      //  public string FileName { get; set; }
        public string FilePath { get; set; }

    }
}
