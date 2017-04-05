using NewLife.Agent;
using NewLife.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeleteFiles
{
    public class SMTS : AgentServiceBase<SMTS>
    {
        private Timer _timer;

        public override void StartWork()
        {
            if (_timer == null)
            {
                _timer = new Timer(obj =>
                {
                    //ProcessProtected.Watch();
                    //ServiceProtected.ServiceRun();
                    Works.StartWork();
                }, null, 1000, FileXmlManage.Current.TimeSpan * 1000 * 60);
            }

            base.StartWork();
            XTrace.WriteLine("文件定时删除删除服务已启动");
        }

        public override void StopWork()
        {
            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
            base.StopWork();
            XTrace.WriteLine("守护服务已停止");
        }
    }
}
