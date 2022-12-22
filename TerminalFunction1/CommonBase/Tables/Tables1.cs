using NPOI.Util;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommonBase.Tables
{
	/// <summary>
	/// Table Definition Class
	/// </summary>
	public class Tables1
    {
		/// <summary>
		/// Connection HOLD
		/// </summary>
		private static SqlConnection SQL_CONNECTION;

		/// <summary>
		/// DB Connection
		/// </summary>
		/// <param name="Values">none</param>
		/// <returns>SqlConnection</returns>
		public static SqlConnection DB_Connection(string ConectionString)
		{
			SqlConnection functionReturnValue = null;
			SQL_CONNECTION = new SqlConnection();

			try
			{
				SQL_CONNECTION.ConnectionString = ConectionString;
				SQL_CONNECTION.Open();
				if (SQL_CONNECTION.State == ConnectionState.Open)
				{
					return SQL_CONNECTION;
				}
				else
				{
					MessageBox.Show("ＤＢへの接続を確立できませんでした。" + "\n" + "(State:" + SQL_CONNECTION.State + ")", "DB_Connection");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ＤＢへの接続を確立できませんでした。" + "\n" + ex.ToString(), "DB_Connection");
			}
			return functionReturnValue;
		}

		/// <summary>
		/// DB DisConnection
		/// </summary>
		/// <param name="Values">none</param>
		/// <returns>object</returns>
		public static object DB_DisConnection()
		{
			object functionReturnValue = null;

			if (SQL_CONNECTION == null)
			{
			}
			else
			{
				if (SQL_CONNECTION.State == ConnectionState.Open)
				{
					SQL_CONNECTION.Close();
				}
				SQL_CONNECTION.Dispose();
			}
			return functionReturnValue;
		}

		/// <summary>
		/// SQLを実行する。例外が発生した場合はメッセージボックスを表示します。
		/// </summary>
		/// <typeparam name="TResult">SQLを実行する関数の戻り値の型です。</typeparam>
		/// <param name="func">SQLを実行する関数です。</param>
		/// <returns>SQLを実行する関数の戻り値、もしくは戻り値の型のデフォルト値です。</returns>
		public static TResult ExecuteSql<TResult>(Func<SqlConnection, TResult> func)
        {
            var (result, error) = TryExecuteSql(func);
            if (error != null)
            {
                Alerts.Messages9.ShowSystemError(error);
            }
            return result;
        }

		/// <summary>
		/// SQLを実行します。
		/// </summary>
		/// <typeparam name="TResult">SQLを実行する関数の戻り値の型です。</typeparam>
		/// <param name="func">SQLを実行する関数です。</param>
		/// <returns>SQLを実行する関数の戻り値と例外です。</returns>
		public static (TResult, Exception) TryExecuteSql<TResult>(Func<SqlConnection, TResult> func)
        {
            try
            {
                TResult result = func(SQL_CONNECTION);
                return (result, null);
            }
            catch (Exception error)
            {
                return (default(TResult), error);
            }
        }

		/// <summary>
		/// NULLを許容するSQLパラメータを生成します。
		/// </summary>
		/// <param name="name">名前です。</param>
		/// <param name="value">値です。</param>
		/// <param name="type">型です。</param>
		/// <returns>SQLパラメータです。</returns>
		public static SqlParameter NullableSqlParameter(string name, object value, SqlDbType type = SqlDbType.VarChar)
			=> new SqlParameter(name, type) {
				Value = value ?? DBNull.Value
		};

        /// <summary>
        ///  参照系のSQLコマンドを実行し、検索された件数を返却する。(count文)
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>検索件数</returns>
        /// <remarks></remarks>
        public static int GetSelectCount(string SqlCommandText)
        {
            int results = -1;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    command.ExecuteNonQuery();
                    results = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  参照系のSQLコマンドを実行し、検索された件数を返却する。（行数より取得）
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>bool</returns>
        /// <remarks></remarks>
        public static int GetSelectRowCount(string SqlCommandText)
        {
            int results = -1;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                using (var adapter = new SqlDataAdapter(command))
                {
                    command.ExecuteNonQuery();
                    var table = new DataTable();
                    adapter.Fill(table);
                    results = table.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  参照系のSQLコマンドを実行し、存在するかどうかを返却する。
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>bool</returns>
        /// <remarks></remarks>
        public static bool GetSelectHasRows(string SqlCommandText)
        {
            bool results = false;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    SqlDataReader sdr = command.ExecuteReader();
                    results = sdr.HasRows;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  参照系のSQLコマンドを実行し、検索された行を返却する。（DataTable）
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>DataTable</returns>
        /// <remarks></remarks>
        public static DataTable GetSelectRowsDataTable(string SqlCommandText)
        {
            DataTable results = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                using (var adapter = new SqlDataAdapter(command))
                {
                    command.ExecuteNonQuery();
                    var table = new DataTable();
                    adapter.Fill(table);
                    results = table;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  参照系のSQLコマンドを実行し、検索された行を返却する。（ArrayList）
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>ArrayList</returns>
        /// <remarks></remarks>
        public static ArrayList GetSelectRowsArrayList(string SqlCommandText)
        {
            ArrayList results = new ArrayList();

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    SqlDataReader sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        ArrayList arrays = new ArrayList();
                        int rows = (short)(sdr.FieldCount - 1);
                        for (int ii = 0; ii <= rows; ii++)
                        {
                            arrays.Add(sdr.GetValue(ii));
                        }
                        results.Add(arrays);
                    }
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  参照系の「Stored Procedure」を実行し、検索された行を返却する。（DataTable）
        ///  </summary>
        /// <param name="StoredName"></param>
        /// <param name="Parameters"></param>
        /// <returns>DataTable</returns>
        /// <remarks></remarks>
        public static DataTable GetSelectRowsStored(string StoredName, SqlParameter[] Parameters)
        {
            DataTable results = null;

            try
            {
                using (var command = new SqlCommand(StoredName, SQL_CONNECTION))
                using (var adapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Adding Parameter in command
                    for (int ii = 0; ii < Parameters.Length; ii++)
                    {
                        command.Parameters.Add(Parameters[ii].ToString());
                    }
                    command.ExecuteNonQuery();
                    var table = new DataTable();
                    adapter.Fill(table);
                    results = table;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
		///  参照系のSQLコマンドをExecuteScalarで実行する。
		///  （１行目の１列目を返却）
        ///  </summary>
		/// <param name="SqlCommandText"></param>
		/// <returns>object</returns>
        /// <remarks></remarks>
		public static object GetSelectExecuteScalar(string SqlCommandText)
        {
            object results = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                using (var adapter = new SqlDataAdapter(command))
                {
                    results = command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        ///  更新系のSQLコマンドを実行し、影響を与えた行数を判定し、結果のみ返却する。
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>DataTable</returns>
        /// <remarks></remarks>
        public static bool ExecuteModify(string SqlCommandText)
        {
            bool returns = false;
            SqlTransaction trans = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    trans = SQL_CONNECTION.BeginTransaction();
                    command.Transaction = trans;
                    var results = command.ExecuteNonQuery();
                    if (results >= 0)
                    {
                        trans.Commit();
                        returns = true;
                    }
                    else
                    {
                        trans.Rollback();
                        returns = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
            return returns;
        }

        /// <summary>
        ///  更新系のSQLコマンドを実行し、影響を与えた行数を判定し、結果のみ返却する。
        ///  （影響のあった行数のチェックあり）
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>bool</returns>
        /// <remarks></remarks>
        public static bool ExecuteModifyWithCheck(string SqlCommandText, bool checks, int numbers)
        {
            bool returns = false;
            SqlTransaction trans = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    trans = SQL_CONNECTION.BeginTransaction();
                    command.Transaction = trans;
                    var results = command.ExecuteNonQuery();
                    if (checks)
                    {
                        if (results == numbers)
                        {
                            trans.Commit();
                            returns = true;
                        }
                        else
                        {
                            trans.Rollback();
                            returns = false;
                        }
                    }
                    else
                    {
                        if (results >= 0)
                        {
                            trans.Commit();
                            returns = true;
                        }
                        else
                        {
                            trans.Rollback();
                            returns = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
            return returns;
        }

        /// <summary>
        ///  更新系のSQLコマンドを実行し、影響を与えた行数を判定し、結果のみ返却する。
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>bool</returns>
        /// <remarks></remarks>
        public static bool ExecuteModifyMultiple(ArrayList SqlCommandList)
        {
            bool returns = true;
            SqlTransaction trans = null;

            try
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = SQL_CONNECTION;
                    trans = SQL_CONNECTION.BeginTransaction();
                    command.Transaction = trans;

                    var rows = SqlCommandList.Count - 1;
                    for (int ii = 0; ii <= rows; ii++)
                    {
                        command.CommandText = Convert.ToString(SqlCommandList[ii]);
                        var results = command.ExecuteNonQuery();
                        if (results < 0)
                        {
                            returns = false;
                            break;
                        }
                    }
                    if (returns)
                    {
                        trans.Commit();
                    }
                    else
                    {
                        trans.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
            return returns;
        }

        /// <summary>
        ///  削除系のSQLコマンドを実行し、影響を与えた行数を判定し、件数を返却する。
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>bool</returns>
        /// <remarks></remarks>
        public static bool ExecuteDelete(string SqlCommandText)
        {
            bool returns = false;
            SqlTransaction trans = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    trans = SQL_CONNECTION.BeginTransaction();
                    command.Transaction = trans;
                    var results = command.ExecuteNonQuery();
                    if (results >= 0)
                    {
                        trans.Commit();
                        returns = true;
                    }
                    else
                    {
                        trans.Rollback();
                        returns = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
            return returns;
        }

        /// <summary>
        ///  削除系のSQLコマンドを実行し、影響を与えた行数を判定し、件数を返却する。
        ///  （影響のあった行数のチェックあり）
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>DataTable</returns>
        /// <remarks></remarks>
        public static int ExecuteDeleteWithCheck(string SqlCommandText, bool checks, int numbers)
        {
            int returns = -1;
            SqlTransaction trans = null;

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                {
                    trans = SQL_CONNECTION.BeginTransaction();
                    command.Transaction = trans;
                    var results = command.ExecuteNonQuery();
                    if (checks)
                    {
                        if (results == numbers)
                        {
                            trans.Commit();
                        }
                        else
                        {
                            trans.Rollback();
                        }
                    }
                    else
                    {
                        if (results >= 0)
                        {
                            trans.Commit();
                        }
                        else
                        {
                            trans.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
            return returns;
        }

        /// <summary>
        ///  テーブルのカラム情報を取得する。
        ///  </summary>
        /// <param name="SqlCommandText"></param>
        /// <returns>DataTable</returns>
        /// <remarks></remarks>
        public static DataTable GetColumnInformations(string SqlCommandText)
        {
            DataTable results = new DataTable();

            try
            {
                using (var command = new SqlCommand(SqlCommandText, SQL_CONNECTION))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.FillSchema(results, SchemaType.Source);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

    }
}
