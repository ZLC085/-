using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.Utils
{
    public class Result
    {
        public string Message { get; set; }
        public RES Code { get; set; }
    }
    public enum RES
    {
        OK,ERROR
    }
}
