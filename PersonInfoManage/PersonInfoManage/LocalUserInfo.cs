using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage
{
    public class LocalUserInfo
    {
        /// <summary>
        /// 获取或设置本地用户信息
        /// </summary>
        public static User LoginInfo
        {
            get
            {
                FileStream fileStream = new FileStream("data.bin", FileMode.OpenOrCreate);
                User user = null;

                try
                {
                    if (fileStream.Length > 0)
                    {
                        BinaryFormatter binary = new BinaryFormatter();
                        user = (User)binary.Deserialize(fileStream);
                    }
                }
                catch
                {
                    user = null;
                }
                finally
                {
                    fileStream.Close();
                }
                
                return user;
            }
            set
            {
                FileStream fileStream = new FileStream("data.bin", FileMode.OpenOrCreate);

                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fileStream, value);

                fileStream.Close();
            }
        }

        /// <summary>
        /// 本地二进制文件存储的用户信息
        /// </summary>
        [Serializable]
        public class User
        {
            /// <summary>
            /// 用户名
            /// </summary>
            public string UserName { get; set; }
            
            /// <summary>
            /// 是否记住用户名
            /// </summary>
            public bool IsChecked { get; set; }
        }
    }
}
