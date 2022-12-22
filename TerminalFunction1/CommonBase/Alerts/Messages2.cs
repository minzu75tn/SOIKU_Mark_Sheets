using System;
using System.Windows.Forms;

using CommonBase.Logs;

namespace CommonBase.Alerts
{
    public class Messages9
    {
        /// <summary>
        /// システムエラーを表示します。(Exception)
        /// </summary>
        /// <param name="error">発生した例外です。</param>
        public static DialogResult ShowSystemError(Exception Error)
        {
            var result = ShowSystemError(Error.ToString());
            return result;
        }

        /// <summary>
        /// システムエラーを表示します。(Log Output)
        /// </summary>
        /// <param name="text">表示するテキストです。</param>
        public static DialogResult ShowSystemError(Control Items, string Messages, Logger1 LOGGER)
        {
            LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, $"{Items.Name} {Messages}");
            var result = ShowSystemError(Messages);
            return result;
        }

        /// <summary>
        /// システムエラーを表示します。
        /// </summary>
        /// <param name="text">表示するテキストです。</param>
        public static DialogResult ShowSystemError(string Messages)
        {
            var result = MessageBox.Show(Messages, "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

        /// <summary>
        /// 確認ダイアログを表示します (Ok/Cancel)。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirmOkCancel(string text)
        {
            var result = MessageBox.Show(text, "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            return result;
        }

        /// <summary>
        /// 確認ダイアログを表示します (Yes/No)。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirmYesNo(string text)
        {
            var result = MessageBox.Show(text, "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            return result;
        }

        /// <summary>
        /// 確認ダイアログを表示します (Yes/No/Cancel)。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirmYesNoCancel(string text)
        {
            var result = MessageBox.Show(text, "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            return result;
        }

        /// <summary>
        /// 警告メッセージを表示します。
        /// </summary>
        /// <param name="text">表示するテキストです。</param>
        public static DialogResult ShowWarningMessages(string text)
        {
            var result = MessageBox.Show(text, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// 通知メッセージを表示します。
        /// </summary>
        /// <param name="text">表示するテキストです。</param>
        public static DialogResult ShowInfoMessages(string text)
        {
            var result = MessageBox.Show(text, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

        /// <summary>
        /// 入力エラーを表示します。
        /// </summary>
        /// <param name="text">表示するテキストです。</param>
        public static DialogResult ShowInputError(string text)
        {
            var result = MessageBox.Show(text, "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

    }
}
