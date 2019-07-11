using PersonInfoManage.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cp = new EFModel())
            {
                //cp.cost_planning.Add(
                //    new cost_planning
                //    {
                //        cost_id = 2,
                //        cost_type = "test"
                //    });


                //var en = new cost_planning
                //{
                //    cost_id = 2,
                //    cost_type = "test1111111"
                //};
                //cp.cost_planning.Attach(en);
                //cp.Entry(en).State = EntityState.Modified;

                cost_planning cc = cp.cost_planning.Find(2);
                if (cc != null)
                {
                    cc.cost_type = "11111111111111";
                }


                //var clist = cp.cost_planning.ToList<cost_planning>();

                
                //cost_planning c = clist.Where(s => s.cost_id == 2).FirstOrDefault<cost_planning>();

                //c.cost_type = "qqqqqqqq";
                int i = cp.SaveChanges();
                label1.Text = i.ToString();
                var query = from b in cp.cost_planning
                            select b;

                foreach (var item in query)
                {
                    label1.Text += item.cost_type;
                }
            }
        }
    }
}
