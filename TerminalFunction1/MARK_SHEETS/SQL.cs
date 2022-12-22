using System;

namespace MARK_SHEETS
{
    internal class SQL
    {
        // BASE KAITOU DATA
        private const string BASE_TABLE = "t05d_tokuten_data";

        /// <summary>
        /// 号数の取得
        /// </summary>
        internal class GET_LIST
        {
            /// 「号数」一覧の取得
            internal static readonly string GET_GOUID_LIST = $@"
SELECT 0 as gou_id, '' as gou_id_display
  UNION ALL
SELECT gou_id, FORMAT(gou_id, '000') as gou_id_display FROM t01m_gou ORDER BY gou_id
";

            /// 「教科」一覧の取得
            internal static readonly string GET_KYOUKAID_LIST = $@"
SELECT 0 as kyouka_id, '' as kyouka_name
  UNION ALL
SELECT kyouka_id, kyouka_name FROM t14m_kyouka
 WHERE kyouka_id IN(10, 20, 30, 40, 50)
";

            /// 「領域選択」一覧の取得
            internal static readonly string GET_RYOUIKI_SENTAKU_LIST = $@"
SELECT CAST('' as varchar) as ryouiki_sentaku_id
  UNION ALL
SELECT CAST(ryouiki_sentaku_id as varchar) as ryouiki_sentaku_id FROM t36d_setumonbetu
 WHERE gou_id=@gou_id AND kyouka_id=@kyouka_id AND ryouiki_sentaku_id != -1
 GROUP BY gou_id, kyouka_id, ryouiki_sentaku_id
";
}

        /// <summary>
        /// 名称の取得
        /// </summary>
        internal class GET_NAME
        {
            /// 「号数」名の取得
            internal static readonly string GET_GOUID_NAME = $@"
SELECT gou_id, test_name FROM t01m_gou WHERE gou_id = @gou_id
";

            /// 「団体コード」名の取得
            internal static readonly string GET_GROUPID_NAME = $@"
SELECT group_id, name FROM t03m_group WHERE group_id=@group_id
";
        }

        /// <summary>
        /// 〔301〕マーク位置データ
        /// </summary>
        internal class REGIST_T301D
        {
            internal static readonly string DELETE_301D = $@"
DELETE 
  FROM t301d_mark_locate_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
";

            internal static readonly string INSERT_301D = $@"
INSERT INTO t301d_mark_locate_data ( 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , number_of_marks
  , mark_default_value
) 
VALUES ( 
    @gou_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @field_id
  , @number_of_marks
  , @mark_default_value
)
";
        }

    }
}
