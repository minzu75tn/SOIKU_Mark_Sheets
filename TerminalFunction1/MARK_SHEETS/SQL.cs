using System;
using System.ComponentModel.DataAnnotations;

namespace MARK_SHEETS
{
    internal class SQL
    {
        /// <summary>
        /// 号数の取得
        /// </summary>
        internal class GET_LIST
        {
            /// 「号数」一覧の取得（すべて）
            internal static readonly string GET_GOUID_LIST_ALL = $@"
SELECT 0 as gou_id, '' as gou_id_display
  UNION ALL
SELECT gou_id, FORMAT(gou_id, '000') as gou_id_display FROM t01m_gou
 GROUP BY gou_id ORDER BY gou_id
";

            /// 「号数」一覧の取得（解答データ系を除外）
            internal static readonly string GET_GOUID_LIST_EXCLUDE = $@"
SELECT 0 as gou_id, '' as gou_id_display
  UNION ALL
SELECT gou_id, FORMAT(gou_id, '000') as gou_id_display FROM t01m_gou
 WHERE gou_id NOT IN (@exclude)
 GROUP BY gou_id ORDER BY gou_id
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
 WHERE gou_id = @gou_id AND kyouka_id = @kyouka_id AND ryouiki_sentaku_id ! =  -1
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
SELECT group_id, name FROM t03m_group WHERE group_id = @group_id
";

            /// 「会場コード」名の取得
            internal static readonly string GET_KAIJYOUID_NAME = $@"
SELECT kaijyou_id, kaijyou_name FROM t07m_kaijyou_name WHERE kaijyou_id = @kaijyou_id
";
        }

        /// <summary>
        /// 〔36〕設問別データ
        /// </summary>
        internal class RELATED_T36D
        {
            internal static readonly string SELECT_T36D_COUNT = $@"
SELECT COUNT(*)
  FROM t36d_setumonbetu 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";

            internal static readonly string SELECT_T36D = $@"
SELECT *
  FROM t36d_setumonbetu 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
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
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY mondai_id
";

            internal static readonly string SELECT_T36D_SAITEN = $@"
SELECT
    mondai_id
  , daimon
  , syoumon
  , haiten
  , auto_saiten
  FROM t36d_setumonbetu 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
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
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string SELECT_T301D_FM01030 = $@"
SELECT
    ROW_NUMBER() OVER(ORDER BY field_id ASC) as t301d_seq
  , field_id as t301d_field_id
  , field_name as t301d_field_name
  , number_of_marks as t301d_number_of_marks
  FROM t301d_mark_locate_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string INSERT_T301D = $@"
INSERT INTO t301d_mark_locate_data ( 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
  , number_of_marks
) 
VALUES ( 
    @gou_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @field_id
  , @field_name
  , @number_of_marks
)
";

            internal static readonly string DELETE_T301D = $@"
DELETE 
  FROM t301d_mark_locate_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";
        }

        /// <summary>
        /// 〔302〕マーク紐付けデータ
        /// </summary>
        internal class RELATED_T302D
        {
            internal static readonly string SELECT_T302D_COUNT = $@"
SELECT COUNT(*)
  FROM t302d_mark_link_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";

            internal static readonly string SELECT_T302D = $@"
SELECT *
  FROM t302d_mark_link_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY mondai_id
";

            internal static readonly string SELECT_T302D_SAITEN = $@"
SELECT 
    mondai_id
  , field_id
  , field_name
  , auto_scoring_disable
  FROM t302d_mark_link_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY mondai_id
";

            internal static readonly string SELECT_T302D_FM01030 = $@"
SELECT
    ROW_NUMBER() OVER(ORDER BY field_id ASC) as t302d_seq
  , field_id as t302d_field_id
  , field_name as t302d_field_name
  , mondai_id as t302d_mondai_id
  , auto_scoring_disable as t302d_auto_scoring_disable
  FROM t302d_mark_link_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string INSERT_T302D = $@"
INSERT INTO t302d_mark_link_data ( 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , mondai_id
  , field_id
  , field_name
  , auto_scoring_disable
) 
VALUES ( 
    @gou_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @mondai_id
  , @field_id
  , @field_name
  , @auto_scoring_disable
)
";

            internal static readonly string INSERT_T302D_FROM_T301D = $@"
INSERT INTO t302d_mark_link_data (
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
)
SELECT 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
  FROM t301d_mark_locate_data as target
 WHERE target.gou_id = @gou_id
   AND target.kyouka_id = @kyouka_id
   AND target.ryouiki_sentaku_id = @ryouiki_sentaku_id
";
           
            internal static readonly string UPDATE_T302D = $@"
UPDATE t302d_mark_link_data
   SET
    mondai_id = @mondai_id
  , auto_scoring_disable = @auto_scoring_disable
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
   AND field_name = @field_name
";

            internal static readonly string DELETE_T302D = $@"
DELETE 
  FROM t302d_mark_link_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";


        internal static readonly string EXCEPT_T301D_T302D = $@"
SELECT field_name
  FROM t301d_mark_locate_data
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
  EXCEPT
SELECT field_name
  FROM t302d_mark_link_data
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";

        }
        /// <summary>
        /// 〔303〕マーク模範データ
        /// </summary>
        internal class RELATED_T303D
        {
            internal static readonly string SELECT_T303D_COUNT = $@"
SELECT COUNT(*)
  FROM t303d_mark_mohan_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";

            internal static readonly string SELECT_T303D = $@"
SELECT *
  FROM t303d_mark_mohan_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string SELECT_T303D_SAITEN = $@"
SELECT 
    field_id
  , field_name
  , mark_value
  FROM t303d_mark_mohan_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
 ORDER BY field_id
";

            internal static readonly string INSERT_T303D = $@"
INSERT INTO t303d_mark_mohan_data ( 
    gou_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
  , mark_value
) 
VALUES ( 
    @gou_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @field_id
  , @field_name
  , @mark_value
)
";

            internal static readonly string DELETE_T303D = $@"
DELETE 
  FROM t303d_mark_mohan_data 
 WHERE gou_id = @gou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";
        }

        /// <summary>
        /// 〔304〕マーク解答データ
        /// </summary>
        internal class RELATED_T304D
        {
            internal static readonly string SELECT_T304D_LIST_KAIJYOU = $@"
SELECT DISTINCT
    target.nendo, target.gou_id, target.kaijyou_id
  , target.kyouka_id, target.ryouiki_sentaku_id
  , target.juken_id
  FROM t304d_mark_answer_data as target
  RIGHT JOIN (    SELECT nendo, gou_id, kaijyou_id, kyouka_id, ryouiki_sentaku_id
      FROM t304d_mark_answer_data 
     WHERE nendo = @nendo
       AND gou_id = @gou_id
       AND kaijyou_id = @kaijyou_id
       AND kyouka_id = @kyouka_id
       AND ryouiki_sentaku_id = @ryouiki_sentaku_id
     GROUP BY nendo, gou_id, kaijyou_id, kyouka_id, ryouiki_sentaku_id
  ) as subject ON
       target.nendo = subject.nendo    
   AND target.gou_id = subject.gou_id
   AND target.kaijyou_id = subject.kaijyou_id
   AND target.kyouka_id = subject.kyouka_id
   AND target.ryouiki_sentaku_id = subject.ryouiki_sentaku_id
 ORDER BY juken_id
";

            internal static readonly string SELECT_T304D_LIST_GROUP = $@"
SELECT DISTINCT 
    target.nendo, target.gou_id, target.group_id
  , target.kyouka_id, target.ryouiki_sentaku_id
  , target.juken_id
  FROM t304d_mark_answer_data as target
  RIGHT JOIN (
    SELECT nendo, gou_id, group_id, kyouka_id, ryouiki_sentaku_id
      FROM t304d_mark_answer_data 
     WHERE nendo = @nendo
       AND gou_id = @gou_id
       AND group_id = @group_id
       AND kyouka_id = @kyouka_id
       AND ryouiki_sentaku_id = @ryouiki_sentaku_id
     GROUP BY nendo, gou_id, group_id, kyouka_id, ryouiki_sentaku_id
  ) as subject ON
       target.nendo = subject.nendo    
   AND target.gou_id = subject.gou_id
   AND target.group_id = subject.group_id
   AND target.kyouka_id = subject.kyouka_id
   AND target.ryouiki_sentaku_id = subject.ryouiki_sentaku_id
 ORDER BY juken_id
";

            internal static readonly string SELECT_T304D_SAITEN = $@"
SELECT 
    field_id
  , field_name
  , mark_value
  , status
  FROM t304d_mark_answer_data as target
 WHERE nendo = @nendo
   AND gou_id = @gou_id
   AND kaijyou_id = @kaijyou_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
   AND juken_id = @juken_id
 ORDER BY nendo, gou_id, kaijyou_id, kyouka_id, ryouiki_sentaku_id
";

            internal static readonly string INSERT_T304D_KAIJYOU = $@"
INSERT 
INTO t304d_mark_answer_data( 
    nendo
  , gou_id
  , kaijyou_id
  , juken_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
  , mark_value
  , status
) 
VALUES ( 
    @nendo
  , @gou_id
  , @kaijyou_id
  , @juken_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @field_id
  , @field_name
  , @mark_value
  , @status
)
";

            internal static readonly string INSERT_T304D_GROUP = $@"
INSERT 
INTO t304d_mark_answer_data ( 
    nendo
  , gou_id
  , group_id
  , class_id
  , grade
  , kubun
  , siwake
  , juken_id
  , kyouka_id
  , ryouiki_sentaku_id
  , field_id
  , field_name
  , mark_value
  , status
) 
VALUES ( 
    @nendo
  , @gou_id
  , @group_id
  , @class_id
  , @grade
  , @kubun
  , @siwake
  , @juken_id
  , @kyouka_id
  , @ryouiki_sentaku_id
  , @field_id
  , @field_name
  , @mark_value
  , @status
)
";

            internal static readonly string DELETE_T304D_KAIJYOU = $@"
DELETE 
  FROM t304d_mark_answer_data 
 WHERE nendo = @nendo
   AND gou_id = @gou_id
   AND kaijyou_id = @kaijyou_id
   AND juken_id = @juken_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";

            internal static readonly string DELETE_T304D_GROUP = $@"
DELETE 
  FROM t304d_mark_answer_data 
 WHERE nendo = @nendo
   AND gou_id = @gou_id
   AND group_id = @group_id
   AND juken_id = @juken_id
   AND kyouka_id = @kyouka_id
   AND ryouiki_sentaku_id = @ryouiki_sentaku_id
";
        }

        /// <summary>
        /// 〔155〕プレ得点データ
        /// </summary>
        internal class RELATED_T155D
        {
            internal static readonly string SELECT_T155D_KAIJYOU = $@"
SELECT *
  FROM t155d_pre_tokuten
 WHERE gou_id = @gou_id
   AND kaijyou_id = @kaijyou_id
   AND kyouka_id = @kyouka_id
   AND sentaku = @sentaku
   AND juken_id = @juken_id
";

            internal static readonly string SELECT_T155D_GROUP = $@"
SELECT *
  FROM t155d_pre_tokuten
 WHERE gou_id = @gou_id
   AND group_id = @group_id
   AND kyouka_id = @kyouka_id
   AND sentaku = @sentaku
   AND juken_id = @juken_id
";

            internal static readonly string INSERT_T155D_ALL = $@"
INSERT 
INTO t155d_pre_tokuten (
    gou_id
  , jissi_kubun
  , kaijyou_id
  , juken_id
  , group_id
  , class_id
  , grade
  , kubun
  , seito_id
  , sex
  , kyouka_id
  , sentaku
  , tokuten
  , syori_flag
  , seigo1, seigo2, seigo3, seigo4, seigo5, seigo6, seigo7, seigo8, seigo9, seigo10
  , seigo11, seigo12, seigo13, seigo14, seigo15, seigo16, seigo17, seigo18, seigo19, seigo20
  , seigo21, seigo22, seigo23, seigo24, seigo25, seigo26, seigo27, seigo28, seigo29, seigo30
  , seigo31, seigo32, seigo33, seigo34, seigo35, seigo36, seigo37, seigo38, seigo39, seigo40
  , seigo41, seigo42, seigo43, seigo44, seigo45, seigo46, seigo47, seigo48, seigo49, seigo50
  , seigo51, seigo52, seigo53, seigo54, seigo55, seigo56, seigo57, seigo58, seigo59, seigo60
  , seigo61, seigo62, seigo63, seigo64, seigo65, seigo66, seigo67, seigo68, seigo69, seigo70
  , seigo71, seigo72, seigo73, seigo74, seigo75, seigo76, seigo77, seigo78, seigo79, seigo80
  , seigo81, seigo82, seigo83, seigo84, seigo85, seigo86, seigo87, seigo88, seigo89, seigo90
  , seigo91, seigo92, seigo93, seigo94, seigo95, seigo96, seigo97, seigo98, seigo99
)
VALUES ( 
    @gou_id
  , @jissi_kubun
  , @kaijyou_id
  , @juken_id
  , @group_id
  , @class_id
  , @grade
  , @kubun
  , @seito_id
  , @sex
  , @kyouka_id
  , @sentaku
  , @tokuten
  , @syori_flag
  , @seigo1, @seigo2, @seigo3, @seigo4, @seigo5, @seigo6, @seigo7, @seigo8, @seigo9, @seigo10
  , @seigo11, @seigo12, @seigo13, @seigo14, @seigo15, @seigo16, @seigo17, @seigo18, @seigo19, @seigo20
  , @seigo21, @seigo22, @seigo23, @seigo24, @seigo25, @seigo26, @seigo27, @seigo28, @seigo29, @seigo30
  , @seigo31, @seigo32, @seigo33, @seigo34, @seigo35, @seigo36, @seigo37, @seigo38, @seigo39, @seigo40
  , @seigo41, @seigo42, @seigo43, @seigo44, @seigo45, @seigo46, @seigo47, @seigo48, @seigo49, @seigo50
  , @seigo51, @seigo52, @seigo53, @seigo54, @seigo55, @seigo56, @seigo57, @seigo58, @seigo59, @seigo60
  , @seigo61, @seigo62, @seigo63, @seigo64, @seigo65, @seigo66, @seigo67, @seigo68, @seigo69, @seigo70
  , @seigo71, @seigo72, @seigo73, @seigo74, @seigo75, @seigo76, @seigo77, @seigo78, @seigo79, @seigo80
  , @seigo81, @seigo82, @seigo83, @seigo84, @seigo85, @seigo86, @seigo87, @seigo88, @seigo89, @seigo90
  , @seigo91, @seigo92, @seigo93, @seigo94, @seigo95, @seigo96, @seigo97, @seigo98, @seigo99
)
";

            internal static readonly string INSERT_T155D_PARTS = $@"
INSERT 
INTO t155d_pre_tokuten (
    gou_id
  , juken_id
  , class_id
  , grade
  , kubun
  , seito_id
  , sex
  , kyouka_id
  , sentaku
  , tokuten
  , syori_flag
    @columns_define
)
VALUES ( 
    @gou_id
  , @juken_id
  , -1
  , -1
  , -1
  , -1
  , -1
  , @kyouka_id
  , @sentaku
  , @tokuten
  , null
    @values_define
)
";

            internal static readonly string DELETE_T155D_KAIJYOU = $@"
DELETE 
  FROM t155d_pre_tokuten 
 WHERE gou_id = @gou_id
   AND kaijyou_id = @kaijyou_id
   AND kyouka_id = @kyouka_id
   AND sentaku = @sentaku
   AND juken_id = @juken_id
";

            internal static readonly string DELETE_T155D_GROUP = $@"
DELETE 
  FROM t155d_pre_tokuten 
 WHERE gou_id = @gou_id
   AND group_id = @group_id
   AND kyouka_id = @kyouka_id
   AND sentaku = @sentaku
   AND juken_id = @juken_id
";
        }

        /// <summary>
        /// 相関情報の取得
        /// </summary>
        internal class GET_CORRELATION
        {
            /// 「相関」件数の取得
            internal static readonly string GET_CONSISTENCY_COUNT = $@"
SELECT
     target.gou_id, target.kyouka_id, target.ryouiki_sentaku_id
   , max(CASE WHEN target.type = 't36d'  THEN target.CT END) AS t36d_CT
   , max(CASE WHEN target.type = 't301d' THEN target.CT END) AS t301d_CT
   , max(CASE WHEN target.type = 't302d' THEN target.CT END) AS t302d_CT
   , max(CASE WHEN target.type = 't303d' THEN target.CT END) AS t303d_CT
  FROM (
    SELECT 't36d' as type, gou_id, kyouka_id, ryouiki_sentaku_id, COUNT(*) as CT
      FROM t36d_setumonbetu
     WHERE auto_saiten = 1 AND ryouiki_sentaku_id<>-1
     GROUP BY gou_id, kyouka_id, ryouiki_sentaku_id
      UNION ALL
    SELECT 't301d' as type, gou_id, kyouka_id, ryouiki_sentaku_id, COUNT(*) as CT
      FROM t301d_mark_locate_data
     GROUP BY gou_id, kyouka_id, ryouiki_sentaku_id
      UNION ALL
    SELECT 't302d' as type, gou_id, kyouka_id, ryouiki_sentaku_id, COUNT(*) as CT
      FROM t302d_mark_link_data
     GROUP BY gou_id, kyouka_id, ryouiki_sentaku_id
      UNION ALL
    SELECT 't303d' as type, gou_id, kyouka_id, ryouiki_sentaku_id, COUNT(*) as CT
      FROM t303d_mark_mohan_data
     GROUP BY gou_id, kyouka_id, ryouiki_sentaku_id
  ) as target
 @condition
 GROUP BY target.gou_id, target.kyouka_id, target.ryouiki_sentaku_id
";

            /// 「相関」データの取得
            internal static readonly string GET_CONSISTENCY_DATA = $@"
SELECT
    t304d.field_id    as t304d_field_id
  , t304d.field_name  as t304d_field_name
  , t304d.mark_value  as t304d_mark_value

  , t301d.field_id    as t303d_field_id
  , t301d.field_name  as t303d_field_name
  , t301d.number_of_marks

  , t302d.mondai_id   as t302d_mondai_id
  , t302d.field_id    as t302d_field_id
  , t302d.field_name  as t302d_field_name
  , t302d.auto_scoring_disable

  , t303d.field_id    as t303d_field_id
  , t303d.field_name  as t303d_field_name
  , t303d.mark_value  as t303d_mark_value

  , 0 as tmp_seigo_field_id
  , 0 as tmp_seigo_mondai_id

  FROM (
    SELECT * FROM t304d_mark_answer_data
     WHERE nendo = @nendo
       AND gou_id = @gou_id
       AND kyouka_id = @kyouka_id
       AND ryouiki_sentaku_id = @ryouiki_sentaku_id
       AND juken_id = @juken_id
       @conditions
  ) as t304d

      LEFT JOIN t301d_mark_locate_data t301d
        ON t304d.gou_id = t301d.gou_id
       AND t304d.kyouka_id = t301d.kyouka_id
       AND t304d.ryouiki_sentaku_id = t301d.ryouiki_sentaku_id
       AND t304d.field_id = t301d.field_id

      LEFT JOIN t302d_mark_link_data t302d
        ON t304d.gou_id = t302d.gou_id
       AND t304d.kyouka_id = t302d.kyouka_id
       AND t304d.ryouiki_sentaku_id = t302d.ryouiki_sentaku_id
       AND t304d.field_id = t302d.field_id

      LEFT JOIN t303d_mark_mohan_data t303d
        ON t304d.gou_id = t303d.gou_id
       AND t304d.kyouka_id = t303d.kyouka_id
       AND t304d.ryouiki_sentaku_id = t303d.ryouiki_sentaku_id
       AND t304d.field_id = t303d.field_id

 ORDER BY t304d.field_id
";
        }

    }
}
