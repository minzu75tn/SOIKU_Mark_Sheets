using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace CommonBase.Alerts

{    /// <summary>
     /// messages definition class
     /// </summary>
    public class Messages1
    {
        private static JArray messages = null;

        private string caption = string.Empty;
        private string contents = string.Empty;
        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        private MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;
        private MessageBoxIcon icon = MessageBoxIcon.Error;

        public string Caption
        {
            get { return caption; }
        }

        public string Contents
        {
            get { return contents; }
        }

        public MessageBoxButtons Buttons
        {
            get { return buttons; }
        }

        public MessageBoxDefaultButton DefaultButton
        {

            get { return defaultButton; }
        }

        public MessageBoxIcon Icon
        {
            get { return icon; }
        }

        public static void Load(string path)
        {
            StreamReader reader = new StreamReader(path);
            string messageJson = reader.ReadToEnd();
            messageJson = messageJson.Replace(Environment.NewLine, string.Empty);
            messageJson = messageJson.Replace("\t", string.Empty);
            messages = JArray.Parse(messageJson);
        }

        private Messages1() { }

        public static Messages1 Get(string code)
        {
            Messages1 result = new Messages1();
            result.caption = string.Empty;
            result.contents = "該当するメッセージが見つかりません。" + Environment.NewLine + "Code：" + code;

            if (messages != null)
            {
                foreach (JObject message in messages)
                {
                    string id = message.GetValue("Code").ToString();
                    string type = message.GetValue("Type").ToString();
                    if (id == code)
                    {
                        if (type.Equals("information"))
                        {
                            result.icon = MessageBoxIcon.Information;
                            result.buttons = MessageBoxButtons.OK;
                        }
                        if (type.Equals("question"))
                        {
                            result.icon = MessageBoxIcon.Question;
                            result.buttons = (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), message.GetValue("ButtonType").ToString());
                            result.defaultButton = (MessageBoxDefaultButton)Enum.Parse(typeof(MessageBoxDefaultButton), message.GetValue("DefaultButton").ToString());

                        }
                        if (type.Equals("warning"))
                        {
                            result.icon = MessageBoxIcon.Warning;
                            result.buttons = MessageBoxButtons.OK;
                        }
                        if (type.Equals("error"))
                        {
                            result.icon = MessageBoxIcon.Error;
                            result.buttons = MessageBoxButtons.OK;
                        }
                        result.caption = message.GetValue("Caption").ToString() + " (" + id + ")";
                        result.contents = message.GetValue("Message").ToString();
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Show Message
        /// </summary>
        /// <param name="MessagesCode">メッセージコード</param>
        /// <param name="parameter">埋込み文字列</param>
        /// <returns>none</returns>
        public static DialogResult ShowMessage(string messageCode, string[] parameter = null)
        {
            Messages1 message = Get(messageCode);
            string contents = message.Contents;
            if (parameter != null && 0 < parameter.Length)
            {
                string[] strArray = new string[10];
                Array.Copy(parameter, strArray, Math.Min(parameter.Length, strArray.Length));
                contents = string.Format(contents, strArray);
            }
            DialogResult result = MessageBox.Show(contents, message.Caption, message.Buttons, message.Icon, message.DefaultButton);
            return result;
        }

    }
}
