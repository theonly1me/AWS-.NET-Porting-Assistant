using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web.UI.WebControls;

using System.Data;

using System.Collections;
using BusinessBlock.HR;
using BusinessBlock.Accounts;
namespace DataTransmission
{
    public static class CommonUtility
    {
        #region HRConvertDateFormatForDBinStringFormat
        /*
		 *********************************************************************
		 * Created By	:                                      *
		 * Created Date	:   									 *
		 *********************************************************************
		 */
        /// <summary>
        /// first convert dd/mmm/yy to dd/mm/yyyy then
        /// Converts Format of Date from dd/mm/yyyy to yyyy-mm-dd
        /// and vice-versa
        /// </summary>
        /// <param name="strDate">Date Value</param>
        /// <returns>reversed formatted date</returns>
        //public static DateTime ConvertDateFormatForDB(string strDate)
        public static string HRConvertDateFormatForDB(string strDate)
        {
            // added by jatinder to return null if date textbox is empty/not required (dt 17 06 11
            if (strDate.Length == 0)
            {
                return null;
            }
            //************************************************************************************
            else
            {
              return  DateTime.Parse(strDate, System.Globalization.CultureInfo.CreateSpecificCulture("en-AU").DateTimeFormat).ToString();
            }
        }
        #endregion 

        #region HRConvertDateFormatForDBinDateFormat
        /*
		 *********************************************************************
		 * Created By	:                                      *
		 * Created Date	:   									 *
		 *********************************************************************
		 */
        /// <summary>
        /// first convert dd/mmm/yy to dd/mm/yyyy then
        /// Converts Format of Date from dd/mm/yyyy to yyyy-mm-dd
        /// and vice-versa
        /// </summary>
        /// <param name="strDate">Date Value</param>
        /// <returns>reversed formatted date</returns>
        //public static DateTime ConvertDateFormatForDB(string strDate)
        public static DateTime? HRConvertDateFormatForDBasDate(string strDate)
        {
            // added by jatinder to return null if date textbox is empty/not required (dt 17 06 11
            if (strDate.Length == 0)
            {
                return null;
            }
            //************************************************************************************
            else
            {
                return DateTime.Parse(strDate, System.Globalization.CultureInfo.CreateSpecificCulture("en-AU").DateTimeFormat);
            }
        }

        public static string getDBDateFormat(string strDate)
        {
            if (strDate.Length == 0)
            {
                return null;
            }
            return (strDate.Substring(3, 3) + strDate.Substring(0, 3) + strDate.Substring(6, 4));
        }
        #endregion 


        #region ConvertDateFormatForDB
        /*
		 *********************************************************************
		 * Created By	:                                      *
		 * Created Date	:   									 *
		 *********************************************************************
		 */
        /// <summary>
        /// first convert dd/mmm/yy to dd/mm/yyyy then
        /// Converts Format of Date from dd/mm/yyyy to yyyy-mm-dd
        /// and vice-versa
        /// </summary>
        /// <param name="strDate">Date Value</param>
        /// <returns>reversed formatted date</returns>
        //public static DateTime ConvertDateFormatForDB(string strDate)
        public static string ConvertDateFormatForDB(string strDate)
        {
            // added by jatinder to return null if date textbox is empty/not required (dt 17 06 11
            if (strDate.Length == 0)    
            {
                return null;
            }
            //************************************************************************************
            else
            {
                DateTime fd = Convert.ToDateTime(strDate);
                string newdate = fd.ToString("dd-MM-yyyy HH:mm");
                string[] arr = newdate.Split('-');
                string strReturn = "";

                strReturn = arr[2].Substring(0, 4) + "-" + arr[1] + "-" + arr[0];
                strReturn = strReturn.TrimEnd('-');
                //return   Convert.ToDateTime(strReturn);
                return strReturn;
            }
        }
        #endregion 
        #region ConvertDateFormatForUI
        /*
		 *********************************************************************
		 * Created By	:                                      *
		 * Created Date	:   									 *
		 *********************************************************************
		 */
        /// <summary>
        /// first convert yyyy-MM-dd to dd-mm-yyyy then
        /// Converts Format of Date from dd-mm-yyyy to dd/mmm/yy
        /// and vice-versa
        /// </summary>
        /// <param name="strDate">Date Value</param>
        /// <returns>reversed formatted date</returns>
        /// 
        public static String ConvertDateFormatForUI(string strDate)
        {
            DateTime fd = Convert.ToDateTime(strDate);
            string newdate = fd.ToString("dd-MMM-yy HH:mm");
            string[] arr = newdate.Split('-');
            string strReturn = "";

            strReturn = arr[0] + " " + arr[1] + " " + arr[2].Substring(0, 2);
            return strReturn.TrimEnd('-');
        }
      
        #endregion 
        #region ConvertDateFormatForUIComperison
        /*
		 *********************************************************************
		 * Created By	:                                      *
		 * Created Date	:   									 *
		 *********************************************************************
		 */
        /// <summary>
        /// first convert yyyy-MM-dd to dd-mm-yyyy then
        /// Converts Format of Date from dd-mm-yyyy to dd mmm yyyy
        /// and vice-versa
        /// </summary>
        /// <param name="strDate">Date Value</param>
        /// <returns>reversed formatted date</returns>
        /// 
        public static String ConvertDateFormatForUIComp(string strDate)
        {
            DateTime fd = Convert.ToDateTime(strDate);
            string newdate = fd.ToString("dd-MMM-yyyy HH:mm");
            string[] arr = newdate.Split('-');
            string strReturn = "";

            strReturn = arr[0] + "/" + arr[1] + "/" + arr[2].Substring(0, 4);
            return strReturn.TrimEnd('-');
        }
        #endregion 
        #region FormatString
        /*
		 *********************************************************************
		 * Created By	: 
		 * Created Date	: 
		 *********************************************************************
		 */
        /// <summary>
        /// This FN Formats a string i.e., replaces the spl characters
        /// from it, to skip any error while inserting into the
        /// database.
        /// </summary>
        /// <param name="strValue">Unformatted String</param>
        /// <returns>Formatted String</returns>
        public static string FormatString(string strValue)
        {
            //strValue=strValue.Replace("/","&#47;").Trim();
            strValue = strValue.Replace("*", "&#42;").Trim();
            strValue = strValue.Replace("--", "&#45;&#45;").Trim();
            strValue = strValue.Replace(";", "&#59;").Trim();
            strValue = strValue.Replace("%", "&#37;").Trim();
            strValue = strValue.Replace("'", "''").Trim();
            strValue = strValue.Replace("<", "&lt;");
            strValue = strValue.Replace(">", "&gt;");

            //Check for reserved words
            //string[] arrText = new string[50];
            //arrText = strValue.Split(' ');
            //for (int j = 0; j < arrText.Length; j++)
            //{
            //    if (arrText[j].ToUpper() == "DROP" || arrText[j].ToUpper() == "CREATE" || arrText[j].ToUpper() == "SELECT" || arrText[j].ToUpper() == "ALTER")
            //    {
            //       // IsSqlInserted = true;
            //    }
            //}
            return strValue;
        }
        #endregion
        #region ReverseFormatString
        /*
		*********************************************************************
		* Created By	: 
		* Createdd Date	: 
		*********************************************************************
		*/
        /// <summary>
        /// This re formats a formatted string to its original value
        /// </summary>
        /// <param name="strValue">Formatted String</param>
        /// <returns>Original Value</returns>		
        public static string ReverseFormatString(string strValue)
        {
            strValue = strValue.Replace("&#47;", "/");
            strValue = strValue.Replace("&#42;", "*");
            strValue = strValue.Replace("&#45;&#45;", "--");
            strValue = strValue.Replace("&#59;", ";");
            strValue = strValue.Replace("&#37;", "%");
            strValue = strValue.Replace("''", "'");
            strValue = strValue.Replace("&lt;", "<");
            strValue = strValue.Replace("&gt;", ">");
            return strValue;
        }
        #endregion
        #region FormatQueryString
        /*
 		 *********************************************************************
 		 * Created By	: 
		 * Created Date : 
		 *********************************************************************
		 */
        /// <summary>
        /// This FN formats QueryString i.e., if a string containing 
        /// spl value is sent through QueryString then it formats the
        /// string in appropriate manner
        /// </summary>
        /// <param name="strValue">Value of QueryString</param>
        /// <returns>Formatted String</returns>
        public static string FormatQueryString(string strValue)
        {
            strValue = strValue.Replace("'", "''").Trim();
            strValue = strValue.Replace("&lt;", "_lt;");
            strValue = strValue.Replace("&gt;", "_gt;");
            return strValue;
        }
        #endregion

        #region getObjectArrayFromClsObject
        public static object[] getObjectArrayFromClsObject(object obj)
        {
             object[] objArr = new object[obj.GetType().GetProperties().Count()];
            Int32 i = 0;

            foreach (PropertyInfo param in obj.GetType().GetProperties())
            {
                if (i < obj.GetType().GetProperties().Count())
                {
                    objArr[i] = param.GetValue(obj, null);
                    i = i + 1;
                }

            }
            return objArr;
        }
        #endregion
        # region getObjectArrayFromMultipleClsObjectWithNullValues
        public static object[] getObjectArrayFromMultipleClsObjectWithNullValues(params object[] obj)
        {
            int cnt = 0;
            for (int i = 0; i < obj.Length; i++)
            {
                cnt = cnt + obj[i].GetType().GetProperties().Count();
            }
            object[] objArr = new object[cnt];
            Int32 k = 0;
            for (int i = 0; i < obj.Length; i++)
            {

                foreach (PropertyInfo param in obj[i].GetType().GetProperties())
                {
                    if (i < obj[i].GetType().GetProperties().Count())
                    {
                        objArr[k] = param.GetValue(obj[i], null);
                        k = k + 1;
                    }

                }

            }
            return objArr;

        }
        #endregion
        #region getObjectArrayFromSingleOrMultipleClsObjectWithRemoveNull
        /// <summary>
        /// Provide True to Keep null member varibale of the object  or False to remove them e.g getObjectArrayFromSingleOrMultipleClsObjectWithRemoveNull(obj,false) will remove all nulleble variables from the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object[] getObjectArrayFromSingleOrMultipleClsObjectWithRemoveNull(params object[] obj)
        {
            object[] objArr = new object[0];
            int cnta = 0;

            Int32 k = 0;
            for (int i = 0; i < obj.Length; i++)
            {
                if ((i + 1 < obj.Length) && (obj[i + 1].ToString() == "True"))
                {
                    foreach (PropertyInfo param in obj[i].GetType().GetProperties())
                    {
                       // if (i < obj[i].GetType().GetProperties().Count())
                        {
                            cnta = cnta + 1;
                        }

                    }
                    if (i < obj.Length)
                    {
                        i = i + 1;
                    }
                }
                else if ((i + 1 < obj.Length) && (obj[i + 1].ToString() == "False"))
                {
                    foreach (PropertyInfo param in obj[i].GetType().GetProperties())
                    {
                       // if (i < obj[i].GetType().GetProperties().Count())
                        {
                            if (param.GetValue(obj[i], null) != null)
                            {
                                cnta = cnta + 1;

                            }
                        }

                    }
                    if (i < obj.Length)
                    {
                        i = i + 1;
                    }
                }
            }
            objArr = new object[cnta];
            for (int i = 0; i < obj.Length; i++)
            {
                if ((i + 1 < obj.Length))
                {
                    if ((i + 1 < obj.Length) && (obj[i + 1].ToString() == "True"))
                    {
                        foreach (PropertyInfo param in obj[i].GetType().GetProperties())
                        {
                           // if (i < obj[i].GetType().GetProperties().Count())
                            {
                                //if (param.GetValue(obj[i], null) != null)
                                //{

                                objArr[k] = param.GetValue(obj[i], null);
                                k = k + 1;
                                //}
                            }

                        }
                        if (i < obj.Length)
                        {
                            i = i + 1;
                        }
                    }
                    else if ((i + 1 < obj.Length) && (obj[i + 1].ToString() == "False"))
                    {
                        foreach (PropertyInfo param in obj[i].GetType().GetProperties())
                        {
                           // if (i < obj[i].GetType().GetProperties().Count())
                            {
                                if (param.GetValue(obj[i], null) != null)
                                {

                                    objArr[k] = param.GetValue(obj[i], null);
                                    k = k + 1;
                                }
                            }

                        }
                        if (i < obj.Length)
                        {
                            i = i + 1;
                        }
                    }
                }
                //i = i + 1;
            }
            return objArr;

        }
        #endregion
        #region getCity
        public static DropDownList getCity(DropDownList DDL, string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getCity(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            DDL.DataSource = dt;
            DDL.DataValueField = dt.Columns[DataValueField].ToString();
            DDL.DataTextField = dt.Columns[DataTextField].ToString();
            DDL.DataBind();
            return DDL;
        }
        #endregion
        #region getCityGrid
        public static DataTable getCityList(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getCity(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }
        #endregion
        #region getDDLData
        public static DropDownList getDDLData(DropDownList DDL, string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getDDLData(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            DDL.DataSource = dt;
            DDL.DataValueField = dt.Columns[DataValueField].ToString();
            DDL.DataTextField = dt.Columns[DataTextField].ToString();
            DDL.DataBind();
            return DDL;
        }
        #endregion

        #region getListBoxData
        public static CheckBoxList getCheckListBoxData(CheckBoxList chkBoxList, string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getDDLData(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            chkBoxList.DataSource = dt;
            chkBoxList.DataValueField = dt.Columns[DataValueField].ToString();
            chkBoxList.DataTextField = dt.Columns[DataTextField].ToString();
            chkBoxList.DataBind();
            return chkBoxList;
        }
        #endregion

        #region getListForDataControls
        public static DataTable getListForDataControls(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getDDLData(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }
        #endregion 

       


        #region getLBData
        public static ListBox getLBData(ListBox lb, string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getDDLData(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            lb.DataSource = dt;
            lb.DataValueField = dt.Columns[DataValueField].ToString();
            lb.DataTextField = dt.Columns[DataTextField].ToString();
            lb.DataBind();
            return lb;
        }
        #endregion

        #region getDDLDataFor Mulit where
        public static DropDownList getDDLMultiWhereth(DropDownList DDL, string DataTextField, string DataValueField, string TableName, string varWhereClause)
        {
            AccBlock Acc = new AccBlock();
            DataTable dt = Acc.getDTForComboMultiWhere(DataTextField, DataValueField, TableName, varWhereClause);
            DDL.DataSource = dt;
            DDL.DataValueField = dt.Columns[0].ToString();
            DDL.DataTextField = dt.Columns[1].ToString();
            DDL.DataBind();
            return DDL;
        }
        #endregion

        #region getDDLDataFor Mulit where
        public static RadioButtonList getRBLMultiWhereth(RadioButtonList rbl, string DataTextField, string DataValueField, string TableName, string varWhereClause)
        {
            AccBlock Acc = new AccBlock();
            DataTable dt = Acc.getDTForComboMultiWhere(DataTextField, DataValueField, TableName, varWhereClause);
            rbl.DataSource = dt;
            rbl.DataValueField = dt.Columns[0].ToString();
            rbl.DataTextField = dt.Columns[1].ToString();
            rbl.DataBind();
            return rbl;
        }
        #endregion

        #region Check for Null  added by jatinder
        public static object chkNull(object inputValue, string defaultValue)
        {
            if (inputValue.Equals(DBNull.Value))
                return defaultValue;
            else
                return inputValue;
        }
        #endregion


        #region getchklistData
        public static CheckBoxList getchklistData(CheckBoxList chklist, string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            HRUnit hrunit = new HRUnit();
            DataTable dt = hrunit.getDDLData(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            chklist.DataSource = dt;
            chklist.DataValueField = dt.Columns[DataValueField].ToString();
            chklist.DataTextField = dt.Columns[DataTextField].ToString();
            chklist.DataBind();
            return chklist;
        }
        #endregion
       
        #region Function to convert Romann to Number & Vice Versha (Ashish) 
        public static string NumberToRoman(int number)
        {
            // Validate
            if (number < 0 || number > 3999)
                throw new ArgumentException("Value must be in the range 0 - 3,999.");

            if (number == 0) return "N";

            // Set up key numerals and numeral pairs
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            // Initialise the string builder
            StringBuilder result = new StringBuilder();

            // Loop through each of the values to diminish the number
            for (int i = 0; i < 13; i++)
            {
                // If the number being converted is less than the test value, append
                // the corresponding numeral or numeral pair to the resultant string
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            // Done
            return result.ToString();
        }
        private enum RomanDigit
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
        public static int RomanToNumber(string roman)
        {
            // Rule 7
            roman = roman.ToUpper().Trim();
            if (roman == "N") return 0;

            // Rule 4
            if (roman.Split('V').Length > 2 ||
                roman.Split('L').Length > 2 ||
                roman.Split('D').Length > 2)
                throw new ArgumentException("Rule 4");

            // Rule 1
            int count = 1;
            char last = 'Z';
            foreach (char numeral in roman)
            {
                // Valid character?
                if ("IVXLCDM".IndexOf(numeral) == -1)
                    throw new ArgumentException("Invalid numeral");

                // Duplicate?
                if (numeral == last)
                {
                    count++;
                    if (count == 4)
                        throw new ArgumentException("Rule 1");
                }
                else
                {
                    count = 1;
                    last = numeral;
                }
            }

            // Create an ArrayList containing the values
            int ptr = 0;
            ArrayList values = new ArrayList();
            int maxDigit = 1000;
            while (ptr < roman.Length)
            {
                // Base value of digit
                char numeral = roman[ptr];
                int digit = (int)Enum.Parse(typeof(RomanDigit), numeral.ToString());

                // Rule 3
                if (digit > maxDigit)
                    throw new ArgumentException("Rule 3");

                // Next digit
                int nextDigit = 0;
                if (ptr < roman.Length - 1)
                {
                    char nextNumeral = roman[ptr + 1];
                    nextDigit = (int)Enum.Parse(typeof(RomanDigit), nextNumeral.ToString());

                    if (nextDigit > digit)
                    {
                        if ("IXC".IndexOf(numeral) == -1 ||
                            nextDigit > (digit * 10) ||
                            roman.Split(numeral).Length > 3)
                            throw new ArgumentException("Rule 3");

                        maxDigit = digit - 1;
                        digit = nextDigit - digit;
                        ptr++;
                    }
                }

                values.Add(digit);

                // Next digit
                ptr++;
            }

            // Rule 5
            for (int i = 0; i < values.Count - 1; i++)
                if ((int)values[i] < (int)values[i + 1])
                    throw new ArgumentException("Rule 5");

            // Rule 2
            int total = 0;
            foreach (int digit in values)
                total += digit;

            return total;
        }
        #endregion
    }
}
