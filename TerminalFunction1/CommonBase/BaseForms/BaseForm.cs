using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using CommonBase.Logs;

namespace CommonBase.BaseForms
{
    public class BaseForm : Form
    {
        /// <summary>
        /// Logger 
        /// </summary>
        public Logger1 LOGGER { get; set; } = null;

        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(273, 113);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
        }

        protected bool IsClosed { get; set; }

        protected BaseForm()
        {
            Load += (sender, e) =>
            {
                Text = Name + " (" + Text + ")";
            };
            FormClosed += (sender, e) =>
            {
                IsClosed = true;
            };
        }

        /// <summary>
        /// 「TextBox」を初期化します。
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        protected TextBox Reset(TextBox textBox, string text = "")
        {
            textBox.ReadOnly = false;
            textBox.TabStop = true;
            textBox.Text = text;
            return textBox;
        }

        /// <summary>
        /// 「TextBox」を非活性化します。
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        protected TextBox ReadOnly(TextBox textBox)
        {
            textBox.ReadOnly = true;
            textBox.TabStop = false;
            return textBox;
        }

        /// <summary>
        /// 「ComboBox」を初期化します。
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        protected ComboBox Reset(ComboBox comboBox, string text = "")
        {
            if (comboBox.DataSource is DataTable table)
            {
                table.Clear();
            }
            comboBox.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox.Text = text;
            return comboBox;
        }

        /// <summary>
        /// フォーカスを移動します。
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        protected Control FocusToNext(Control current)
        {
            bool CanTabStop(Control control)
            {
                return (control != current)
                    && control.TabStop
                    && control.Enabled
                    && (!(control is TextBox text) || !text.ReadOnly);
            };
            var next = Controls.Cast<Control>()
                .Where(CanTabStop)
                .Where(control => control.TabIndex >= current.TabIndex)
                .OrderBy(control => control.TabIndex)
                .FirstOrDefault();
            if (next == null)
            {
                next = Controls.Cast<Control>()
                    .Where(CanTabStop)
                    .OrderBy(control => control.TabIndex)
                    .FirstOrDefault();
            }
            next?.Focus();
            return next;
        }

        /// <summary>
        /// ボタンが活性化の時の配色です。
        /// </summary>
        protected void ButtonColorEnabled(Button name)
        {
            name.FlatAppearance.BorderSize = 1;
            name.FlatAppearance.BorderColor = Color.Black;
            name.BackColor = Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
        }

        /// <summary>
        /// ボタンが非活性の時の配色です。
        /// </summary>
        protected void ButtonColorDisabled(Button name)
        {
            name.FlatAppearance.BorderSize = 1;
            name.FlatAppearance.BorderColor = Color.Black;
            name.BackColor = Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
        }

        /// <summary>
        /// ボタンにフォーカスした時の配色です。
        /// </summary>
        protected void ButtonFocusEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            button.BackColor = Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(187)))), ((int)(((byte)(230)))));
        }

        /// <summary>
        /// ボタンからフォーカスが外れた時の配色です。
        /// </summary>
        protected void ButtonFocusLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Black;
            button.BackColor = Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
        }

        /// <summary>
        /// 「入力文字列」をすべて選択状態とする。
        /// </summary>
        protected void SetSelectALL(Control Target)
        {

            if (Target.GetType().Equals(typeof(TextBox)))
            {
                TextBox element = (TextBox)Target;
                element.SelectAll();
            }
            else if (Target.GetType().Equals(typeof(ComboBox)))
            {
                ComboBox element = (ComboBox)Target;
                element.SelectAll();

            }
            else if (Target.GetType().Equals(typeof(RichTextBox)))
            {
                RichTextBox element = (RichTextBox)Target;
                element.SelectAll();

            }
        }

    }
}
