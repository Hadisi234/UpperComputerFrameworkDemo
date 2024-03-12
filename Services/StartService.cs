using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上位机框架Demo.Services
{
    static class StartService:LogicalStep
    {

    }
    /// <summary>
    /// 抽象共用的流程步
    /// </summary>
    public abstract class LogicalStep
    {
        public virtual void Start()
        {

        }
    }
}
