using NewLife.Log;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeleteFiles
{
    public class Works
    {
        public static void StartWork()
        {
            int dayTimeSpan = FileXmlManage.Current.DayTimeSpan;
            int timeSpan= FileXmlManage.Current.SleepTime;
            var YMD = DateTime.Now.AddDays(-dayTimeSpan).ToString("yyyyMMdd");
            //拼凑文件名称
            double fileNameTemp = Convert.ToDouble(YMD + "240000000");

            try
            {
                var fileInfos = FileXmlManage.Current.FileInfoes;
                if (fileInfos.Any())
                {
                    foreach (var fileInfose in fileInfos)
                    {
                        DirectoryInfo dir = new DirectoryInfo(fileInfose.FilePath);
                        var dirs = dir.GetFiles();

                        foreach (var fileInfo in dirs)
                        {
                            var fileInfoName = fileInfo.Name.Split('.')[0];

                            double fileName = Convert.ToDouble(fileInfoName);
                            if (fileName < fileNameTemp)
                            {
                                fileInfo.Delete();
                                Thread.Sleep(timeSpan);
                                Console.WriteLine(fileInfo.Name + "已经删除成功！");
                            }
                            //fileInfo.Delete();
                            //Console.WriteLine("删除"+fileInfo.Name+"成功！");
                        }
                    }
                }
                XTrace.WriteLine(fileNameTemp + "本次检索完毕！");
            }
            catch (Exception)
            {
                XTrace.WriteLine("请确保XML中的文件路径正确！");
            }
        }
    }
}
