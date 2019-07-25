using PersonInfoManage.BLL.PersonInfo;
using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
using PersonInfoManage.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class PersonBasicForm : Form
    {
        private List<string> Provinces;
        private List<string> Cities;
        private List<string> Places;
        private List<string> Marry;
        private List<string> Nation;
        private List<sys_dict> PersonType;
        private List<sys_dict> BelongPlace;

        private string province = "选择省";
        private string city = "选择市";
        private string place = "选择县/区";

        public PersonBasicForm()
        {
            InitializeComponent();

            #region 初始选项
            // 省
            Provinces = new List<string> { province };
            CmbProvince.DataSource = Provinces;
            // 市
            Cities = new List<string> { city };
            CmbCity.DataSource = Cities;
            // 县/区
            Places = new List<string> { place };
            CmbPlace.DataSource = Places;

            // 初始查询（优化卡顿）
            Provinces = new NativePlaceBLL().QueryProvince();

            // 婚姻状况
            Marry = new List<string>
            {
                "未婚",
                "已婚"
            };
            CmbMarry.DataSource = Marry;

            // 名族
            Nation = new List<string>
            {
                "汉族","蒙古族","满族","朝鲜族","赫哲族",
                "达斡尔族","鄂温克族","鄂伦春族","回族","东乡族",
                "土族","撒拉族","保安族","裕固族","维吾尔族",
                "哈萨克族","柯尔克孜族","锡伯族","塔吉克族","乌孜别克族",
                "俄罗斯族","塔塔尔族","藏族","门巴族","珞巴族",
                "羌族","彝族","白族","哈尼族","傣族",
                "僳僳族","佤族","拉祜族","纳西族","景颇族",
                "布朗族","阿昌族","普米族","怒族","德昂族",
                "独龙族","基诺族","苗族","布依族","侗族",
                "水族","仡佬族","壮族","瑶族","仫佬族",
                "毛南族","京族","土家族","黎族","畲族",
                "高山族"
            };
            CmbNation.DataSource = Nation;

            // 人员类别
            PersonType = new SysSettingBLL().SelectByDictName(sys_dict_type.Person);
            CmbPersonType.DataSource = PersonType;

            // 归属地
            BelongPlace = new SysSettingBLL().SelectByDictName(sys_dict_type.NativePlace);
            CmbBelongPlace.DataSource = BelongPlace;


            //PersonType = new TypeBLL().GetTheType("重点人员类别");
            //List<string> ptList = new List<string>();
            //foreach(var item in PersonType)
            //{
            //    ptList.Add(item.category_name);
            //}
            //CmbPersonType.DataSource = ptList;
            //// 归属地
            //BelongPlace = new TypeBLL().GetTheType("归属地");
            //List<string> bpList = new List<string>();
            //foreach (var item in BelongPlace)
            //{
            //    bpList.Add(item.category_name);
            //}
            //CmbBelongPlace.DataSource = bpList;

            //string cc = "ss";

            //foreach (var item in PersonType)
            //{
            //    if (item.category_name.Equals(cc))
            //    {
            //        item.id;
            //    }
            //}
            #endregion

            LblName.Hide();
            LblFormerName.Hide();
            LblIdentityNumber.Hide();
            LblAddress.Hide();
            LblNativePlace.Hide();
            LblIncome.Hide();
            LblPhone.Hide();



        }

        #region 籍贯相关控件
        /// <summary>
        /// 点击下拉并查询省
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbProvince_DropDown(object sender, EventArgs e)
        {
            CmbProvince.DataSource = Provinces;
        }

        /// <summary>
        /// 点击下拉并查询市
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCity_DropDown(object sender, EventArgs e)
        {
            Cities = new NativePlaceBLL().QueryCity(CmbProvince.Text);
            CmbCity.DataSource = Cities;
        }

        /// <summary>
        /// 点击下拉并查询县/区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbPlace_DropDown(object sender, EventArgs e)
        {
            Places = new NativePlaceBLL().QueryPlace(CmbCity.Text);
            CmbPlace.DataSource = Places;
        }

        /// <summary>
        /// 关闭下拉重置子集市、县/区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbProvince_DropDownClosed(object sender, EventArgs e)
        {
            Cities = new List<string>();
            CmbCity.DataSource = Cities;
            Places = new List<string>();
            CmbPlace.DataSource = Places;
        }

        /// <summary>
        /// 关闭下拉重置子集县/区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCity_DropDownClosed(object sender, EventArgs e)
        {
            Places = new List<string>();
            CmbPlace.DataSource = Places;
        }
        #endregion

        /// <summary>
        /// 确认提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            person_basic pb = new person_basic();

            #region 姓名
            string name = TxtName.Text.Replace(" ", "");
            if (RegexComm.IsValidName(name))
            {
                LblName.Hide();
                pb.name = name;
            }
            else
            {
                LblName.Show();
                return;
            }
            #endregion

            #region 曾用名
            if (!string.IsNullOrWhiteSpace(TxtFormerName.Text))
            {
                string formerName = TxtName.Text.Replace(" ", "");
                if (RegexComm.IsValidName(formerName))
                {
                    LblName.Hide();
                    pb.former_name = formerName;
                }
                else
                {
                    LblName.Show();
                    return;
                }
            }
            #endregion

            #region 性别
            if (RdoMale.Checked)
            {
                pb.gender = RdoMale.Name;
            }
            if (RdoFemale.Checked)
            {
                pb.gender = RdoFemale.Name;
            }
            #endregion

            #region 身份证号
            if (RegexComm.IsValidIdNum(TxtIdentityNumber.Text))
            {
                LblIdentityNumber.Hide();
                pb.identity_number = TxtIdentityNumber.Text;
            }
            else
            {
                LblIdentityNumber.Show();
                return;
            }
            #endregion

            #region 出生日期
            pb.birth_date = TimeBirthDate.Value;
            #endregion

            #region 籍贯
            if (CmbProvince.Text.Equals(province) || CmbCity.Text.Equals(city) || CmbPlace.Text.Equals(place))
            {
                LblNativePlace.Show();
            }
            else
            {
                LblNativePlace.Hide();
                pb.native_place = CmbProvince.Text + CmbCity.Text + CmbPlace.Text;
            }
            #endregion

            #region 婚姻状况
            if (CmbMarry.Text.Equals("已婚"))
            {
                pb.marry_status = true;
            }
            if (CmbMarry.Text.Equals("未婚"))
            {
                pb.marry_status = false;
            }
            #endregion

            #region 工作状况
            pb.job_status = TxtJob.Text;
            #endregion

            #region 收入状况
            if (!string.IsNullOrEmpty(TxtIncome.Text))
            {
                pb.income = Convert.ToDecimal(TxtIncome.Text);
            }
            #endregion

            #region 性格特征
            pb.temper = TxtTemper.Text;
            #endregion

            #region 家庭成员
            pb.family = TxtFamily.Text;
            #endregion

            #region 人员类型
            //pb.person_type = CmbPersonType.Text;
            #endregion

            #region QQ
            pb.qq = TxtQQ.Text;
            #endregion

            #region 住址
            if (string.IsNullOrEmpty(TxtAddress.Text))
            {
                LblAddress.Show();
            }
            else
            {
                LblAddress.Hide();
                pb.address = TxtAddress.Text;
            }
            #endregion

            #region 电话
            if (!string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                string phone = TxtPhone.Text.Replace(" ", "");
                if (RegexComm.IsValidPhone(phone))
                {
                    LblPhone.Hide();
                    pb.phone = phone;
                }
                else
                {
                    LblPhone.Show();
                    return;
                }
            }
            else
            {
                LblPhone.Show();
                return;
            }
            #endregion

            //pb.belong_place = 1;

            #region 民族
            pb.nation = CmbNation.Text;
            #endregion

            #region 添加日期
            pb.input_time = DateTime.Now;
            #endregion

            //pb.user_id = 1001;

            #region 删除标记
            pb.isdel = 1;
            #endregion

            // 判断结果
            Result r = new PersonBasicBLL().Add(pb);
            if (r.Code == RES.OK)
            {
                MessageBox.Show(r.Message);
                this.Close();
            }
            else
            {
                MessageBox.Show(r.Message);
            }
        }















        //private bool IsRightNum(string content, int len, NumType type)
        //{
        //    switch (type)
        //    {
        //        case NumType.ID:
        //            if (len != 18) return false;

        //            foreach(char c in content)
        //            {
        //                if (c < '0' || c > '9') return false;
        //            }
        //            return true;
        //            break;
        //        case NumType.Income:
        //            return false;
        //            break;
        //        case NumType.Phone:
        //            return false;
        //            break;
        //        case NumType.QQ:
        //            return false;
        //            break;
        //        default:
        //            return false;
        //            break;
        //    }
        //}

        //private enum NumType
        //{
        //    ID,Phone,QQ,Income
        //}

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}