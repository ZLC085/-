﻿using DevComponents.AdvTree;
using PersonInfoManage.BLL;
using PersonInfoManage.BLL.Cost;
using PersonInfoManage.BLL.Logs;
using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        private List<view_sys_u2g> UserInfo = new SysUserBLL().SelectAll();
        private List<sys_group> GroupInfo;
        private List<int> UserId;
        private List<int> list;
        private List<int> list2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Start();
            metroShell1.SelectedTab = MenuHome;
            //List<cost> costs = ShowMessage();
            //if (costs.Count == 0)
            //{
            //    this.PnlMessage.Visible = false;
            //}
            //else
            //{
            //    this.LblMessageCount.Text = costs.Count.ToString();
            //}

        }
        #region 王继能
        //<王继能_1>
        //
        //</王继能_1>
        #endregion

        #region 毛宇航
        //<毛宇航_1>
        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm personBasicForm = new PersonBasicForm
            {
                Text = "人员信息录入"
            };
            personBasicForm.ShowDialog();
        }

        private void DgvPerson_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPerson.IsCurrentCellDirty)
            {
                dgvPerson.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void BtnQueryPerson_Click(object sender, EventArgs e)
        {
            List<string> vs = DGVOperations.SelectPersonBasic(dgvPerson);
            if (vs.Count > 1)
            {
                MessageBoxCustom.Show("只能选择一条记录！", "提示", this);
                return;
            }
            else if (vs.Count < 1)
            {
                MessageBoxCustom.Show("需要选择一条记录！", "提示", this);
                return;
            }

            person_basic personBasic = DGVOperations.GetSelectPersonBasic(vs[0]);
            if (personBasic != null)
            {
                PersonDetailForm personDetailForm = new PersonDetailForm(personBasic);
                personDetailForm.ShowDialog();
            }
        }

        private void BtnUpdatePerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm personBasicForm = new PersonBasicForm
            {
                Text = "人员信息修改"
            };
            personBasicForm.ShowDialog();
        }

        private void BtnDelPerson_Click(object sender, EventArgs e)
        {

        }

        private void CmbPersonType_DropDown(object sender, EventArgs e)
        {
            List<string> personTypeList = new List<string>();
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.Person))
            {
                personTypeList.Add(item.category_name);
            }
            CmbPersonType.DataSource = personTypeList;
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            dgvPerson.AutoGenerateColumns = false;
            person_basic pb = new person_basic()
            {
                user_id = UserInfoBLL.UserId,
                isdel = 0,
                name = TxtPersonName.Text,
                identity_number = TxtIdentityNum.Text,
                native_place = TxtPersonNation.Text
            };
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.Person))
            {
                if (item.category_name.Equals(CmbPersonType.Text))
                {
                    pb.person_type_id = item.id;
                }
            }
            dgvPerson.DataSource = new PersonBasicDAL().Query(pb);
        }

        private void BtnRecycle_Click(object sender, EventArgs e)
        {

        }


        private void BtnComdelPerson_Click(object sender, EventArgs e)
        {

        }
        //</毛宇航_1>
        #endregion 毛宇航

        #region 李鸽鸽
        //<李鸽鸽_1>
        //
        //</李鸽鸽_1>
        #endregion

        #region 坤吉心
        //<坤吉心_1>
        private void BtnDelUserlog_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnSearchUserlog_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelSyslog_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnSearchSyslog_Click(object sender, EventArgs e)
        {

        }
        //</坤吉心_1>
        #endregion

        #region 苏文杰
        //<苏文杰_2>
        //首页timer控件tick事件
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lableTime.Text = DateTime.Now.ToString("yyyy年MM月dd日-HH:mm:ss");
        }

        //首页退出按钮点击事件
        private void BtnEsc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 消息提示方法
        /// </summary>
        /// <returns></returns>
        //private List<cost_approval> ShowMessage()
        //{
        //    int localUserid = UserInfoBLL.UserId;
        //    CostApprovalBLL costApprovalBLL = new CostApprovalBLL();
        //    Dictionary<string, object> conditions = new Dictionary<string, object>();
        //    conditions.Add(nameof(cost_approval.approval_id), localUserid);
        //    conditions.Add(nameof(cost_main.status), 0);
        //    return costApprovalBLL.Query(conditions);
        //}

        //消息框"下次再说"linklable
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PnlMessage.Visible = false;
        }

        //消息框"点击查看"linklable
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            metroShell1.SelectedTab = MenuCost;
            TabControlCost.SelectedTab = TabCostAudit;
        }

        //主页切换事件

        private void MenuHome_Click(object sender, EventArgs e)
        {
            //List<cost> costs = ShowMessage();
            //if (costs.Count == 0)
            //{
            //    this.PnlMessage.Visible = false;
            //}
            //else
            //{
            //    this.LblMessageCount.Text = costs.Count.ToString();
            //}
        }

        //基本信息管理Tab页点击事件（二级）
        private void TabPersonBasic_Click(object sender, EventArgs e)
        {
            DGVOperations.DGVPersonBasicNotDelDataSource(dgvPerson);
        }
        //人员信息管理菜单Tab页切换事件（一级）
        private void MenuPersoninfo_Click(object sender, EventArgs e)
        {
            DGVOperations.DGVPersonBasicNotDelDataSource(dgvPerson);
        }

        //回收站Tab页点击事件（二级）
        private void TabPersonRecycle_Click(object sender, EventArgs e)
        {
            DGVOperations.DGVPersonBasicDelDataSource(dgvPerson);
        }

        //日志管理菜单Tab页切换事件（一级）
        
        private void MenuLog_Click(object sender, EventArgs e)
        {
            TabControlLog.SelectedTab = TabUserLog;
            DgvUserLog.AutoGenerateColumns = false;
            DgvUserLog.DataSource = new LogUserBLL().Query();
        }

        //用户日志Tab页点击事件（二级）
        private void TabUserLog_Click(object sender, EventArgs e)
        {
            DgvUserLog.AutoGenerateColumns = false;
            DgvUserLog.DataSource = new LogUserBLL().Query();
        }

        //系统日志Tab页点击事件（二级）
        private void TabSysLog_Click(object sender, EventArgs e)
        {
            DgvSysLog.AutoGenerateColumns = false;
            DgvSysLog.DataSource = new LogSysBLL().Query();
        }

        //费用管理菜单Tab页切换事件（一级）
        private void MenuCost_Click(object sender, EventArgs e)
        {                    
            TabControlCost.SelectedTab = TabCostApply;
            //设置时间为截至目前10天
            TimeApplyStart.Value = DateTime.Now.AddDays(-10);
            TimeApplyEnd.Value = DateTime.Now;
            DgvCostApply.AutoGenerateColumns = false;
            BtnSearchCostApply_Click(null, null);
        }

        //费用申请Tab页点击事件（二级）
        private void TabCostApply_Click(object sender, EventArgs e)
        {
            DgvCostApply.AutoGenerateColumns = false;
            TimeApplyStart.Value = DateTime.Now.AddDays(-10);
            TimeApplyEnd.Value = DateTime.Now;
            BtnSearchCostApply_Click(null, null);
        }

        //费用审批Tab页点击事件（二级）
        private void TabCostAudit_Click(object sender, EventArgs e)
        {
            DgvCostApprove.AutoGenerateColumns = false;
            TimeApproveStart.Value = DateTime.Now.AddDays(-10);
            TimeApproveEnd.Value = DateTime.Now;
            BtnSearchApprove_Click(null, null);
        }

        //费用规划Tab页点击事件（二级）
        private void TabCostPlan_Click(object sender, EventArgs e)
        {
            DgvCostPlan.AutoGenerateColumns = false;
            Dictionary<string, object> dic = new Dictionary<string, object>();
            DgvCostPlan.DataSource = new CostPlanBLL().Query(dic);
            
        }
        
        //系统设置菜单Tab页切换事件（一级）
        private void MenuSys_Click(object sender, EventArgs e)
        {
            TabControlSys.SelectedTab = TabUserMan;
            DgvUserMan.AutoGenerateColumns = false;
            DgvUserMan.DataSource = new SysUserBLL().Select(new sys_user());
        }

        //用户管理Tab页点击事件(二级)
        private void TabUserMan_Click(object sender, EventArgs e)
        {
            DgvUserMan.AutoGenerateColumns = false;
            DgvUserMan.DataSource = new SysUserBLL().Select(new sys_user());
        }

        //用户组管理Tab页点击事件（二级）
        private void TabGroupMan_Click(object sender, EventArgs e)
        {
            DgvGroupMan.AutoGenerateColumns = false;
            DgvGroupMan.DataSource = new PermBLL().SelectGroup(new sys_group());
        }

        //系统设置Tab页点击事件（二级）
        private void TabSysSet_Click(object sender, EventArgs e)
        {
            DgvSysSet.AutoGenerateColumns = false;
            var ds = new SysSettingBLL().SeleteAll();
            foreach (var item in ds)
            {
                if (item.dict_name.Equals(sys_dict_type.Cost.ToString()))
                {
                    item.dict_name = "费用类别";
                }
                else if (item.dict_name.Equals(sys_dict_type.Person.ToString()))
                {
                    item.dict_name = "重点人员类别";
                }
                else if (item.dict_name.Equals(sys_dict_type.BelongPlace.ToString()))
                {
                    item.dict_name = "归属地";
                }
            }
            DgvSysSet.DataSource = ds;
        }


        private void MenuOperation_Click(object sender, EventArgs e)
        {

        }

        //组织机构管理Tab页点击事件（二级）
        private void TabOrgMan_Click(object sender, EventArgs e)
        {
        //    //从数据库获取数据，得到结果为DataTable
        //    sys_org org = new sys_org();
        //    OrganizationBLL orgBLL = new OrganizationBLL();
        //    DataTable dt = new DataTable();
        //    List<sys_org> list = new List<sys_org>();
        //    list = orgBLL.SelectByparentid(0);
        //    foreach (sys_org item in list)
        //    {
        //        dt.Columns.Add(item.org_name);
        //    }
        //    InitModuleTree(dt);
        }
        ////绑定TrreView
        //private void InitModuleTree(DataTable dt)
        //{
        //    //清空treeview上所有节点
        //    this.TreeOrg.Nodes.Clear();
        //    int[] gen = new int[dt.Rows.Count]; //用于存储父节点Tag
        //    int[] zi = new int[dt.Rows.Count];  //用于存储子节点Tag
        //    for (int i = 0; i < gen.Length; i++)
        //    {
        //        string zhi = dt.Rows[i][3].ToString();//获取节点Tag值   eg：1-2
        //        if (zhi.Length > 1)   //表示是子节点   eg：1-2
        //        {
        //            gen[i] = int.Parse(zhi.Substring(0, zhi.IndexOf('-')));
        //            zi[i] = int.Parse(zhi.Substring(zhi.IndexOf('-') + 1));
        //        }
        //        else    //表示是根节点   eg：2
        //        {
        //            //将所有父节点加到treeview上
        //            zi[i] = int.Parse(zhi);
        //            Node nodeParent = new Node();
        //            nodeParent.Tag = (zi[i]).ToString();
        //            nodeParent.Text = dt.Rows[i][1].ToString();
        //            TreeOrg.Nodes.Add(nodeParent);
        //        }
        //    }
        //    bindChildNote(dt, gen, zi);
        //}

        //private void bindChildNote(DataTable dt, int[] gen, int[] zi)
        //{
        //    for (int i = 0; i < gen.Length; i++)
        //    {
        //        if (gen[i] != 0 && zi[i] != 0)        //便利所有节点，找到所有子节点
        //        {
        //            Node childNode = new Node();
        //            foreach (Node item in TreeOrg.Nodes)   //便历treeview上所有父节点
        //            {
        //                if (item.Tag.ToString() == gen[i].ToString())  //找到当前子节点的父节点
        //                {
        //                    childNode.Tag = zi[i].ToString();
        //                    childNode.Text = dt.Rows[i][1].ToString();
        //                    item.Nodes.Add(childNode);
        //                }
        //            }
        //        }
        //    }
        //    TreeOrg.ExpandAll();      //展开整棵树
        //}
        //</苏文杰_2>
        #endregion

        #region 王尔沛
        //<王尔沛_2>
        private List<int> selectid()
        {
            UserId = new List<int>();
            for (int i = 0; i < DgvUserMan.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DgvUserMan.Rows[i].Cells["Column36"].Value))
                {
                    int id = int.Parse(DgvUserMan.Rows[i].Cells["user_id"].Value.ToString());
                    UserId.Add(id);
                }
            }
            return UserId;
        }
        private void DgvUserMan_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.DgvUserMan.IsCurrentCellDirty) //有未提交的更改
            {
                this.DgvUserMan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void BtnQueryUser_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm(selectid());
            userDetailForm.ShowDialog();
        }
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUserForm UpdateUserForm = new UpdateUserForm(selectid());
            UpdateUserForm.ShowDialog();
        }
        private void BtnGroupManage_Click(object sender, EventArgs e)
        {
            GroupManageForm groupManageForm = new GroupManageForm();
            groupManageForm.ShowDialog();
        }
        private void BtnRoleManage_Click(object sender, EventArgs e)
        {
            GroupRoleManageForm groupRoleManageForm = new GroupRoleManageForm();
            groupRoleManageForm.ShowDialog();
        }
        private void BtnResetPsw_Click(object sender, EventArgs e)
        {
            if (selectid() == null)
            {
                MessageBox.Show("请勾选用户");
            }
            else
            {
                DialogResult = MessageBoxCustom.Show("确认重置？", "操作确认", MessageBoxButtons.YesNo, this);
                if (DialogResult == DialogResult.Yes)
                {
                    new SysUserBLL().RePassword(selectid());
                    DgvUserMan.DataSource = null;
                    DgvUserMan.DataSource = new SysUserBLL().Select(new sys_user());
                }
            }
        }
        private void BtnDelUser_Click(object sender, EventArgs e)
        {
            if (selectid() == null)
            {
                MessageBox.Show("请勾选用户");
            }
            else
            {
                DialogResult = MessageBoxCustom.Show("确认删除？", "操作确认", MessageBoxButtons.YesNo, this);
                if (DialogResult == DialogResult.Yes)
                {
                    new SysUserBLL().Del(selectid());
                    DgvUserMan.DataSource = null;
                    DgvUserMan.DataSource = new SysUserBLL().Select(new sys_user());
                }
            }
        }
        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            sys_user user = new sys_user();
            user.name = TxtUserName.Text;
            user.username = TxtLoginName.Text;
            user.gender = CmbUserSex.Text;
            user.job = txtUserJob.Text;
            DgvUserMan.DataSource = null;
            DgvUserMan.DataSource = new SysUserBLL().Select(user);
        }
        //</王尔沛_2>
        #endregion

        #region 曾丽川
        //<曾丽川_2>
        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            AddUserGroupForm addUserGroupForm = new AddUserGroupForm(new List<int>());
            addUserGroupForm.ShowDialog();
            DgvGroupMan.DataSource = null;
            DgvGroupMan.DataSource = new PermBLL().SelectGroup(new sys_group());
        }
        private List<int> SelectId()
        {
            list = new List<int>();
            for (int i = 0; i < DgvGroupMan.Rows.Count; i++)
            {

                if (Convert.ToBoolean(DgvGroupMan.Rows[i].Cells["Column45"].Value))
                {
                    int id = int.Parse(DgvGroupMan.Rows[i].Cells["groupid"].Value.ToString());
                    list.Add(id);
                }
            }
            return list;
        }
        private List<int> SelectSettingId()
        {
            list2 = new List<int>();
            for (int i = 0; i < DgvSysSet.Rows.Count; i++)
            {

                if (Convert.ToBoolean(DgvSysSet.Rows[i].Cells["Column51"].Value))
                {
                    int id = int.Parse(DgvSysSet.Rows[i].Cells["settingid"].Value.ToString());
                    list2.Add(id);
                }
            }
            return list2;
        }
        private void BtnUpdateRole_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list = SelectId();
            if (list.Count == 0)
            {
                MessageBox.Show("请勾选用户组");
            }
            else
            {
                AddUserGroupForm addUserGroupForm = new AddUserGroupForm(list);
                addUserGroupForm.Text = "修改用户组";
                addUserGroupForm.ShowDialog();
                DgvGroupMan.DataSource = null;
                DgvGroupMan.DataSource = new PermBLL().SelectGroup(new sys_group());
            }       
        }

        private void BtnAddKind_Click(object sender, EventArgs e)
        {
            List<int> list4 = new List<int>();
            list4 = SelectSettingId();
            if (CmbDictType.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个数据字典");
            }
            else
            {
                string selectStr = CmbDictType.SelectedItem.ToString();
                AddCategoreTypeForm addCategoreTypeForm = new AddCategoreTypeForm(selectStr, list4);
                addCategoreTypeForm.ShowDialog();
                CmbDictType_SelectedValueChanged_1(sender, e);
            }
        }

        private void BtnUpdateKind_Click(object sender, EventArgs e)
        {
            List<int> list4 = new List<int>();
            list4 = SelectSettingId();
            if (CmbDictType.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个数据字典");
            }
            else
            {
                string selectStr = CmbDictType.SelectedItem.ToString();
                AddCategoreTypeForm addCategoreTypeForm = new AddCategoreTypeForm(selectStr, list4);
                if (list4.Count == 0)
                {
                    MessageBox.Show("请勾选数据字典");
                }
                else
                {
                    addCategoreTypeForm.Text = "修改数据字典";
                    addCategoreTypeForm.ShowDialog();
                    CmbDictType_SelectedValueChanged_1(sender, e);
                }
            }
          
            
        }


        private void BtnDelGroup_Click(object sender, EventArgs e)
        {
           List<int> list = new List<int>();
            list = SelectId();
            if (list.Count == 0)
            {
                MessageBox.Show("请勾选用户组");
            }
            else
            {
                DialogResult = MessageBoxCustom.Show("确认删除？", "操作确认", MessageBoxButtons.YesNo, this);
                if (DialogResult == DialogResult.Yes)
                {
                   
                    PermBLL perm = new PermBLL();
                    Result result = new Result();
                    result = perm.DelAll(list);
                    if (result.Code == RES.OK)
                    {
                        MessageBoxCustom.Show("删除成功", "提示", this);
                    }
                    else
                    {
                        MessageBoxCustom.Show("删除失败", "提示", this);
                    }
                    DgvGroupMan.DataSource = null;
                    DgvGroupMan.DataSource = new PermBLL().SelectGroup(new sys_group());
                }
            }
        }

        private void BtnsearchGroup_Click(object sender, EventArgs e)
        {
            sys_group group = new sys_group();
            group.group_name = TxtGroupName.Text;
            group.create_time = TimeStartGroup.Value;
            group.modify_time = TimeEditGroup.Value;
            DgvGroupMan.DataSource = null;
            DgvGroupMan.DataSource = new PermBLL().SelectGroupBy(group);
        }


        private void BtnDelType_Click(object sender, EventArgs e)
        {
            if (CmbDictType.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个数据字典");
            }
            else
            {
                List<int> list3 = new List<int>();
                list3 = SelectSettingId();
                if (list3.Count == 0)
                {
                    MessageBox.Show("请勾选数据字典");
                }
                else
                {
                    DialogResult = MessageBoxCustom.Show("已经使用的数据字典系统自动保留,确认删除？", "操作确认", MessageBoxButtons.YesNo, this);
                    if (DialogResult == DialogResult.Yes)
                    {

                        SysSettingBLL set = new SysSettingBLL();
                        Result result = new Result();
                        result = set.DelAll(list3);
                        if (result.Code == RES.OK)
                        {
                            MessageBoxCustom.Show("删除成功", "提示", this);
                        }
                        else
                        {
                            MessageBoxCustom.Show("删除失败", "提示", this);
                        }

                        CmbDictType_SelectedValueChanged_1(sender, e);

                    }
                }
            }
        }

        private void CmbDictType_SelectedValueChanged_1(object sender, EventArgs e)
        {
          
              
                string a = CmbDictType.SelectedItem.ToString();
                var ds = new SysSettingBLL().SelectByDictName(SysDictTypeConvert.Change(a));
                foreach (var item in ds)
                {
                    if (item.dict_name.Equals(sys_dict_type.Cost.ToString()))
                    {
                        item.dict_name = "费用类别";
                    }
                    else if (item.dict_name.Equals(sys_dict_type.Person.ToString()))
                    {
                        item.dict_name = "重点人员类别";
                    }
                    else if (item.dict_name.Equals(sys_dict_type.BelongPlace.ToString()))
                    {
                        item.dict_name = "归属地";
                    }
                }
                DgvSysSet.AutoGenerateColumns = false;
                DgvSysSet.DataSource = ds;
            
        }
        private void DgvGroupMan_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.DgvGroupMan.IsCurrentCellDirty) //有未提交的更改
            {
                this.DgvGroupMan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DgvSysSet_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.DgvSysSet.IsCurrentCellDirty) //有未提交的更改
            {
                this.DgvSysSet.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //</曾丽川_2>
        #endregion

        #region 张乐
        //<张乐_3>
        private void BtnAddBusiness_Click(object sender, EventArgs e)
        {

        }


        private void BtnBusinessDetail_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateBusiness_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelBusiness_Click(object sender, EventArgs e)
        {

        }
        private void BtnApproveBus_Click(object sender, EventArgs e)
        {

        }
        //</张乐_3>
        #endregion

        #region 陈波
        //<陈波_3>
        //
        private void BtnAddCost_Click(object sender, EventArgs e)
        {
            CostApplyForm costApplyForm = new CostApplyForm();
            costApplyForm.ShowDialog();
            BtnSearchCostApply_Click(null, null);
        }

        private void BtnQueryCost_Click(object sender, EventArgs e)
        {
            if (DgvCostApply.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择一行记录进行查看");
                return;
            }
            int costId =(int) DgvCostApply.SelectedRows[0].Cells["cost_id"].Value;
            CostApplyDetailForm costApplyDetailForm = new CostApplyDetailForm(costId);
            costApplyDetailForm.ShowDialog();
        }

        private void BtnUpdateCost_Click(object sender, EventArgs e)
        {
            if (DgvCostApply.SelectedRows.Count != 1)
            {
                MessageBox.Show("请仅选择一个费用单进行修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int costId = (int)DgvCostApply.SelectedRows[0].Cells["cost_id"].Value;
            List<cost> costList = new CostApplyBLL().Query(new Dictionary<string, object> { { "id", costId } });
            if (costList.Count != 0)
            {
                if (costList[0].Main.status != 0)
                {
                    MessageBox.Show("该费用单已审核，不可修改", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            CostApplyForm costApplyForm = new CostApplyForm(costId);
            costApplyForm.Text = "费用单修改";
            costApplyForm.ShowDialog();
            BtnSearchCostApply_Click(null, null);
        }

        private void BtnQueryAudit_Click(object sender, EventArgs e)
        {
            if (DgvCostApprove.SelectedRows.Count != 1)
            {
                MessageBox.Show("请仅选择一个费用单查看详情！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int costId = (int)DgvCostApprove.SelectedRows[0].Cells["ApprCostId"].Value;
            CostApplyDetailForm costApplyDetailForm = new CostApplyDetailForm(costId);
            costApplyDetailForm.ShowDialog();
        }

        private void BtnAudit_Click(object sender, EventArgs e)
        {
            if (DgvCostApprove.SelectedRows.Count != 1)
            {
                MessageBox.Show("请仅选择一个费用单进行审批！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int costId = (int)DgvCostApprove.SelectedRows[0].Cells["ApprCostId"].Value;
            cost cost = new CostApplyBLL().Query(new Dictionary<string, object>
            {
                {"id",costId }
            })[0];
            foreach(cost_approval approval in cost.ApprovalList)
            {
                if (approval.result != null && approval.approval_id==UserInfoBLL.UserId)
                {
                    MessageBox.Show("该费用单已审批！不可再次审批", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }            
            CostApprovalForm costApprovalForm = new CostApprovalForm(costId);
            costApprovalForm.ShowDialog();
            BtnSearchCostApply_Click(null, null);
        }


        private void BtnRepealCost_Click(object sender, EventArgs e)
        {
            if (DgvCostApply.SelectedRows.Count != 1)
            {
                MessageBox.Show("请仅选择一个费用单进行撤销！", "信息意识", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int costId = (int)DgvCostApply.SelectedRows[0].Cells["cost_id"].Value;
            List<cost> costList = new CostApplyBLL().Query(new Dictionary<string, object> { { "id", costId } });
            if (costList.Count != 0)
            {
                if (costList[0].Main.status != 0)
                {
                    MessageBox.Show("该费用单已审核，不可撤销", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            DialogResult dialogResult = MessageBox.Show("您确定要撤销费用单" + costId + "吗？", "撤销提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Result res = new CostApplyBLL().Del(costId);
                MessageBox.Show(res.Message, "撤销结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            BtnSearchCostApply_Click(null, null);

        }


        private void BtnSearchCostApply_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> conditions = new Dictionary<string, object>();
            conditions.Add("apply_id", UserInfoBLL.UserId);
            int status = -1;
            if (CmbApplyStatus.SelectedItem != null)
            {
                if(!CmbApplyStatus.SelectedItem.ToString().Trim().Equals(" "))
                {
                    switch (CmbApplyStatus.SelectedItem.ToString())
                    {
                        case "未审核": status = 0; break;
                        case "正在审核": status = 1; break;
                        case "审核通过": status = 2; break;
                        case "审核驳回": status = 3; break;

                    }
                }
                
            }
            if (status >= 0)
            {
                conditions.Add("status", status);
            }
            conditions.Add("start_time", TimeApplyStart.Value);
            conditions.Add("end_time", TimeApplyEnd.Value);
            List<cost> ListCost = new CostApplyBLL().Query(conditions);
            List<CostApplyData> DataList = new List<CostApplyData>();
            foreach (cost cost in ListCost)
            {
                string applicant = new SysUserDAL().SelectById(cost.Main.apply_id)[0].name;
                string statusStr = null;
                switch (cost.Main.status)
                {
                    case 0: statusStr = "未审核"; break;
                    case 1: statusStr = "正在审核"; break;
                    case 2: statusStr = "审核通过"; break;
                    case 3: statusStr = "审核驳回"; break;
                }
                DataList.Add(new CostApplyData
                {
                    Number = 1,
                    cost_id = cost.Main.id,
                    applicant = applicant,
                    apply_money = cost.Main.apply_money,
                    apply_time = cost.Main.apply_time,
                    status = statusStr
                });
            }
            DgvCostApply.DataSource = DataList;

        }


        private void BtnDelApprove_Click(object sender, EventArgs e)
        {
            if (DgvCostApprove.SelectedRows.Count != 1)
            {
                MessageBox.Show("请仅选择一个费用单进行撤销！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int costId = (int)DgvCostApprove.SelectedRows[0].Cells["ApprCostId"].Value;
            DialogResult dialogResult = MessageBox.Show("您确定要撤销费用单" + costId + "吗？", "撤销提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Result res = new CostApprovalBLL().Del(costId);
                MessageBox.Show(res.Message, "撤销结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BtnSearchCostApply_Click(null, null);
        }


        private void BtnSearchApprove_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> conditions = new Dictionary<string, object>();
            conditions.Add("start_time", TimeApproveStart.Value);
            conditions.Add("end_time", TimeApproveEnd.Value);
            int result = -1;
            switch (CmbApporveStatus.Text.ToString().Trim())
            {
                case "通过":result = 0;break;
                case "驳回":result = 1;break;
                case "未审核":result = 2;break;
            }
            List<CostApprovalData> ListData = new List<CostApprovalData>();
            List<cost> CostList = new CostApplyBLL().Query(conditions);
            foreach(cost cost in CostList)
            {
                foreach(cost_approval approval in cost.ApprovalList)
                {
                    if (result == 0 &&( approval==null || approval.result==false)) { continue; }
                    if(result == 1&&(approval==null || approval.result == true)) { continue; }
                    if (result == 2 && (approval != null)) { continue; }
                    if (approval.approval_id != UserInfoBLL.UserId) { continue; }
                    CostApprovalData data = new CostApprovalData
                    {
                        ApprNumber = 1,
                        ApprCostId=cost.Main.id,
                        ApprApplicant = new SysUserDAL().SelectById(cost.Main.apply_id)[0].name,
                        ApprApplyMoney = cost.Main.apply_money,
                        ApprApplyTime = cost.Main.apply_time,
                        ApprApprovalTime = approval.time,
                        ApprOpinion = approval.opinion

                    };
                    if (approval.result == null)
                    {
                        data.ApprResult = "未审批";
                    }
                    else
                    {
                        data.ApprResult = (bool)approval.result ? "通过" : "驳回";
                    }
                    ListData.Add(data);
                }
            }
            DgvCostApprove.DataSource = ListData;
        }
        
        private void BtnSearchBus1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchBus2_Click(object sender, EventArgs e)
        {

        }
        //</陈波_3>
        #endregion

        #region 蒋媛
        //<蒋媛_3>
        private void BtnUpdatePlan_Click(object sender, EventArgs e)
        {
            CostPlanForm costPlanForm = new CostPlanForm();
            costPlanForm.Text = "修改费用规划";
            costPlanForm.ShowDialog();
        }

        private void BtnPlanCost_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCheckStats_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelCostPlan_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddCostPlan_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateCostPlan_Click(object sender, EventArgs e)
        {

        }


        //</蒋媛_3>
        #endregion

      
    }
}
