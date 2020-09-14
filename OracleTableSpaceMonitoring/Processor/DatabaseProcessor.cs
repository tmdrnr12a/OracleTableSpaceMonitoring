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

        /// <summary>
        /// Get TableSpace infomation
        /// </summary>
        /// <returns></returns>
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
