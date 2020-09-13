using OracleTableSpaceMonitoring.Etc;
using OracleTableSpaceMonitoring.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleTableSpaceMonitoring.Processor
{
    public class DatabaseProcessor : Singleton<DatabaseProcessor>
    {
        #region " Variables "




        #endregion " Variables End"

        #region " Create & Load & Shown "

        #endregion " Create & Load & Shown End "

        #region " Methods "

        public DataSet GetTableSpaceList()
        {
            string query =
@"
SELECT    
    A.TABLESPACE_NAME AS NAME,
    (SUM(A.BYTES) - SUM(B.FREE)) AS USAGE,
    SUM(B.FREE) AS FREE_SIZE,
    SUM(A.BYTES) AS TOTAL_SIZE,
    ROUND(((SUM(A.BYTES) -SUM(B.FREE)) / SUM(A.BYTES) * 100), 0) AS PERCENTAGE
FROM
(
    SELECT FILE_ID,  TABLESPACE_NAME, SUM(BYTES) BYTES
    FROM DBA_DATA_FILES
    GROUP BY FILE_ID,TABLESPACE_NAME,FILE_NAME,SUBSTR(FILE_NAME, 1, 200)
) A,
(
    SELECT TABLESPACE_NAME, FILE_ID, SUM(NVL(BYTES, 0)) FREE
    FROM DBA_FREE_SPACE
    GROUP BY TABLESPACE_NAME,FILE_ID
) B
WHERE 1=1
AND A.TABLESPACE_NAME = B.TABLESPACE_NAME
AND A.FILE_ID = B.FILE_ID
GROUP BY A.TABLESPACE_NAME
ORDER BY 1
";
            query =
@"
SELECT 
    NAME, USAGE, FREE_SIZE, TOTAL_SIZE, PERCENTAGE
FROM
(
    SELECT 'SYSAUX' AS NAME, 523960320 AS USAGE, 42270720 AS FREE_SIZE, 566231040 AS TOTAL_SIZE, 93 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'SYSTEM' AS NAME, 733151232 AS USAGE, 851968 AS FREE_SIZE, 734003200 AS TOTAL_SIZE, 100 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'PSK_TBS' AS NAME, 3538944 AS USAGE, 311033856 AS FREE_SIZE, 314572800 AS TOTAL_SIZE, 1 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'ADMIN_TBS' AS NAME, 8975024128 AS USAGE, 462159872 AS FREE_SIZE, 9437184000 AS TOTAL_SIZE, 95 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'USER01_TBS' AS NAME, 19577684480 AS USAGE, 8104721920 AS FREE_SIZE, 27682406400 AS TOTAL_SIZE, 71 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'USER02_TBS' AS NAME, 806092800 AS USAGE, 137625600 AS FREE_SIZE, 943718400 AS TOTAL_SIZE, 85 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'USER03_TBS' AS NAME, 82968576 AS USAGE, 231604224 AS FREE_SIZE, 314572800 AS TOTAL_SIZE, 26 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'USER04_TBS' AS NAME, 12910592 AS USAGE, 301662208 AS FREE_SIZE, 314572800 AS TOTAL_SIZE, 14 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'UNDOTBS1' AS NAME, 150339584 AS USAGE, 5910429696 AS FREE_SIZE, 6060769280 AS TOTAL_SIZE, 2 AS PERCENTAGE FROM DUAL UNION ALL
    SELECT 'USERS' AS NAME, 1376256 AS USAGE, 3866624 AS FREE_SIZE, 5242880 AS TOTAL_SIZE, 26 AS PERCENTAGE FROM DUAL 
)
";
            DataSet ds = new DataSet();

            try
            {
                OracleManager.Instance.ExecuteDsQuery(ds, query);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }

        #endregion " Methods End "

        #region " Events "

        #endregion " Events End "


    }
}
