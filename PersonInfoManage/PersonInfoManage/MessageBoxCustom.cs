using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public class MessageBoxCustom
    {
        private static Form FormContent(string text, string caption, Form ownerForm)
        {
            Form form = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                BackColor = Color.White,
                Opacity = 0.8,
                Owner = ownerForm,
                ShowIcon = false,
                StartPosition = FormStartPosition.CenterParent,
                Height = 200,
                Text = caption,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                AutoSize = true
            };
            Label label = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = form.Width
            };
            label.Location = new Point(form.Left, form.Height / 2 - label.Height * 2);

            form.Controls.Add(label);

            return form;
        }

        private static Button CreateButton(string text, int x, int y)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            return button;
        }

        public static DialogResult Show(string text, string caption, Form ownerForm)
        {
            Form form = FormContent(text, caption, ownerForm);


            int x = form.Right - 120;
            int y = form.Bottom - 80;
            Button button = CreateButton("确定", x, y);

            button.Click += (sender, e) => form.Close();
            form.Controls.Add(button);

            return form.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, Form ownerForm)
        {
            Form form = FormContent(text, caption, ownerForm);
            switch (buttons)
            {
                case MessageBoxButtons.YesNo:
                    int x = form.Right - 120;
                    int y = form.Bottom - 80;
                    Button buttonCancel = CreateButton("取消", x, y);

                    buttonCancel.Click += (sender, e) =>
                    {
                        form.DialogResult = DialogResult.Cancel;
                        form.Close();
                    };
                    form.Controls.Add(buttonCancel);


                    x = form.Right - 200;
                    y = form.Bottom - 80;
                    Button buttonOK = CreateButton("确定", x, y);

                    buttonOK.Click += (sender, e) => form.DialogResult = DialogResult.OK;
                    form.Controls.Add(buttonOK);

                    break;
                default:
                    break;
            }

            return form.ShowDialog();
        }
    }
}
