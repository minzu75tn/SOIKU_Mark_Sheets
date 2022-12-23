﻿using System;

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
        /// 〔36〕設問別データ
        /// </summary>
        internal class RELATED_T36D
        {
            internal static readonly string SELECT_T36D = $@"
SELECT *
  FROM t36d_setumonbetu 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY mondai_id
";

        internal static readonly string SELECT_T36D_FM01030 = $@"
SELECT 
    ROW_NUMBER() OVER(ORDER BY mondai_id ASC) as t36d_seq
  , mondai_id as t36d_mondai_id
  , daimon as t36d_daimon
  , syoumon as t36d_syoumon
  , auto_saiten as t36d_auto_saiten
  FROM t36d_setumonbetu 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY mondai_id
";
        }

        /// <summary>
        /// 〔301〕マーク位置データ
        /// </summary>
        internal class RELATED_T301D
        {
            internal static readonly string SELECT_T301D = $@"
SELECT *
  FROM t301d_mark_locate_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string SELECT_T301D_FM01030 = $@"
SELECT
    ROW_NUMBER() OVER(ORDER BY field_id ASC) as t301d_seq
  , field_id as t301d_field_id
  , number_of_marks as t301d_number_of_marks
  FROM t301d_mark_locate_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string INSERT_T301D = $@"
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

            internal static readonly string DELETE_T301D = $@"
DELETE 
  FROM t301d_mark_locate_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
";
        }

        /// <summary>
        /// 〔302〕マーク紐付けデータ
        /// </summary>
        internal class RELATED_T302D
        {
            internal static readonly string SELECT_T302D = $@"
SELECT *
  FROM t302d_mark_link_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY mondai_id, mondai_sub_no
";

            internal static readonly string SELECT_T302D_FM01030 = $@"
SELECT
    ROW_NUMBER() OVER(ORDER BY field_id ASC) as t302d_seq
  , field_id as t302d_field_id
  , mondai_id as t302d_mondai_id
  , mondai_sub_no as t302d_mondai_sub_no
  , auto_scoring_disable as t302d_auto_scoring_disable
  FROM t302d_mark_link_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string INSERT_T302D = $@"
INSERT INTO t302d_mark_link_data ( 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , mondai_id
  , mondai_sub_no
  , field_id
  , auto_scoring_disable
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

            internal static readonly string INSERT_T302D_FROM_T301D = $@"
INSERT INTO t302d_mark_link_data (
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
)
SELECT 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  FROM t301d_mark_locate_data as target
 WHERE target.gou_id=@gou_id
   AND target.kyouka_id=@kyouka_id
   AND target.ryouiki_sentaku_id=@ryouiki_sentaku_id
";

            internal static readonly string DELETE_T302D = $@"
DELETE 
  FROM t302d_mark_link_data 
 WHERE gou_id=@gou_id
   AND kyouka_id=@kyouka_id
   AND ryouiki_sentaku_id=@ryouiki_sentaku_id
";
        }

    }
}
