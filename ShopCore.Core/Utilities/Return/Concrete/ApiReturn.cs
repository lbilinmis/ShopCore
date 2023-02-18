using ShopCore.Core.Utilities.Return.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Utilities.Return.Concrete
{
    public class ApiReturn<T> : ApiReturnBase where T : class
    {

        public T Entity;
        public List<T> EntityList;

        public ApiReturn()
        {
            this.Retcode = EN_Retcode.Null;
            //this.HttpStatusCode = HttpStatusCode.OK;

            this.Entity = null;
            this.EntityList = new List<T>();

            this.Data = null;
            this.Tag = null;
            this.Errors = new List<string>();
            this.Sql = "";
            this.Message = "-";
        }
    }

    public class ApiReturn : ApiReturnBase
    {
        public ApiReturn()
        {
            this.Retcode = EN_Retcode.Null;
            //this.HttpStatusCode = HttpStatusCode.OK;

            this.Data = null;
            this.Tag = null;
            this.Errors = new List<string>();
            this.Sql = "";
            this.Message = "-";
        }

    }

    public abstract class ApiReturnBase
    {
        public EN_Retcode Retcode { get; set; }
        //public HttpStatusCode HttpStatusCode { get; set; }

        public object Data { get; set; }
        public object Tag { get; set; }

        public List<string> Errors { get; set; }
        public string Message { get; set; }
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

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}
