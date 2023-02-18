using Microsoft.VisualBasic;
using ShopCore.Core.Utilities.Return.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Utilities.Return.Concrete
{
    [Serializable()]
    public class AppReturn<T> : AppReturnBase where T : class
    {
        public T Entity;
        public List<T> EntityList;
        public BindingList<T> EntityBList;

        public AppReturn()
        {
            this.Success = false;
            this.Retcode = EN_Retcode.Null;
            this.HttpStatusCode = HttpStatusCode.NoContent;

            this.Entity = null;
            this.EntityList = new List<T>();
            this.EntityBList = new BindingList<T>();

            this.Data = null;
            this.Tag = null;
            this.Errors = new List<string>();
            this.Sql = "";
            this.RedirectUrl = "-";
            this.PostUrl = "-";
            this.PostData = new List<string>();
            this.Message = "-";
            this.Message_SignalR = "-";
            this.CloseWindow = false;
            this.ReloadWindow = false;
            this.OpenerButton = "-";
            this.PageButton = "-";
        }
    }


    [Serializable()]
    public class AppReturn : AppReturnBase
    {
        public AppReturn()
        {
            this.Success = false;
            this.Retcode = EN_Retcode.Null;
            this.HttpStatusCode = HttpStatusCode.NoContent;

            this.Data = null;
            this.Tag = null;
            this.Errors = new List<string>();
            this.Sql = "";
            this.RedirectUrl = "-";
            this.PostUrl = "-";
            this.PostData = new List<string>();
            this.Message = "-";
            this.Message_SignalR = "-";
            this.CloseWindow = false;
            this.ReloadWindow = false;
            this.OpenerButton = "-";
            this.PageButton = "-";
        }

        public DataTable ToTable()
        {
            if (Data != null && Data is DataTable)
                return (DataTable)Data;
            else if (Data != null && Data is DataSet)
            {
                if (((System.Data.DataSet)Data).Tables.Count > 0)
                    return ((System.Data.DataSet)Data).Tables[0];
                else
                    return null/* TODO Change to default(_) if this is not a reference type */;
            }
            else
                return null/* TODO Change to default(_) if this is not a reference type */;
        }

        public DataSet ToDataset()
        {
            if (Data != null && Data is System.Data.DataSet)
                return (DataSet)Data;
            else
                return null/* TODO Change to default(_) if this is not a reference type */;
        }

        public override string ToString()
        {
            if (Data != null && Data is string)
                return System.Convert.ToString(Data);
            else
                return null;
        }

        public ArrayList ToArraylist()
        {
            if (Data != null && Data is ArrayList)
                return (ArrayList)Data;
            else
                return null/* TODO Change to default(_) if this is not a reference type */;
        }

        public int ToInt()
        {
            if (Data != null && Information.IsNumeric(Data) == true)
                return System.Convert.ToInt32(Data);
            else
                return -1;
        }

    }

    [Serializable()]
    public abstract class AppReturnBase
    {
        public bool Success { get; set; }
        public EN_Retcode Retcode { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }

        public object Data;
        public object Tag;

        public List<string> Errors { get; set; }
        public string Message { get; set; }
        public string Message_SignalR { get; set; }
        public string RedirectUrl { get; set; }
        public string PostUrl { get; set; }
        public List<string> PostData { get; set; }
        public bool CloseWindow { get; set; }
        public bool ReloadWindow { get; set; }
        public string OpenerButton { get; set; }
        public string PageButton { get; set; }
        public string Sql { get; set; }

        public string GetErrMsg()
        {
            string sRetval = "";

            if (this.Errors != null)
            {
                if (this.Errors.Count > 0)
                {
                    for (int iCnt = 0; iCnt <= this.Errors.Count - 1; iCnt++)
                    {
                        sRetval += this.Errors[iCnt].ToString() + Environment.NewLine;
                    }
                }
            }
            sRetval = sRetval.TrimEnd(Environment.NewLine.ToCharArray()).TrimStart(Environment.NewLine.ToCharArray());

            if (sRetval.Trim().Length <= 0)
            {
                sRetval = "-";
            }

            if (sRetval == "-" && this.Message != null && this.Message.Trim().Length > 0 && this.Message.Trim() != "-")
            {
                sRetval = this.Message;
            }

            return sRetval;
        }

        [Obsolete("CommonMethods.Convert_AppReturn_To_WebReturn veya CommonMethods.Convert_AppReturn_To_WebReturn<T> kullanılacak")]
        public WebReturn Convert_WebReturn()
        {
            WebReturn WebRetval = new WebReturn();
            WebRetval.Retcode = this.Retcode;
            if (this.Message == "-")
            {
                WebRetval.Message = this.GetErrMsg();
            }
            else
            {
                WebRetval.Message = this.Message;
            }
            WebRetval.Message_SignalR = this.Message_SignalR;
            WebRetval.RedirectUrl = this.RedirectUrl;
            WebRetval.PostUrl = this.PostUrl;
            this.PostData.ForEach(x => WebRetval.PostData.Add(x));
            WebRetval.CloseWindow = this.CloseWindow;
            WebRetval.ReloadWindow = this.ReloadWindow;
            WebRetval.OpenerButton = this.OpenerButton;
            WebRetval.PageButton = this.PageButton;
            return WebRetval;
        }

        [Obsolete("CommonMethods.Convert_AppReturn_To_ApiReturn kullanılacak")]
        public ApiReturn Convert_ApiReturn()
        {
            ApiReturn ApiRetval = new ApiReturn();

            ApiRetval.Retcode = this.Retcode;

            if (this.Message == "-")
            {
                ApiRetval.Message = this.GetErrMsg();
            }
            else
            {
                ApiRetval.Message = this.Message;
            }

            ApiRetval.Data = this.Data;

            ApiRetval.Tag = this.Tag;

            return ApiRetval;
        }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }

}
