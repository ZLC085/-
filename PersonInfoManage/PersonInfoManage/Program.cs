using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new LoginForm());
            //Application.Run(new PersonDetailForm());
            //Application.Run(new UpdatFileNameForm());
            //Application.Run(new CostApplyDetailForm());
            //Application.Run(new CostPlanForm());
            //Application.Run(new PersonBasicForm());
            //Application.Run(new CostApplyForm());
            //Application.Run(new AddCostDetailForm());
            //Application.Run(new ProgressForm());
        }
    }
}
