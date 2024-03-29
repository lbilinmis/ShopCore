﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Utilities.Return.Enums
{

    [Serializable()]
    public enum EN_Retcode
    {

        Null = 0,
        Ok = 200,
        NoContent = 204,
        Error = 600,

        //
        // Informational 1xx
        //
        Continue = 100,
        SwitchingProtocols = 101,
        //
        // Successful 2xx
        //
        Created = 201,
        Accepted = 202,
        NonAuthoritativeInformation = 203,
        ResetContent = 205,
        PartialContent = 206,
        //
        // Redirection 3xx
        //
        MultipleChoices = 300,
        /// <summary>
        /// Çift kayıt gibi
        /// </summary>
        Ambiguous = 300,
        MovedPermanently = 301,
        Moved = 301,
        Found = 302,
        Redirect = 302,
        SeeOther = 303,
        RedirectMethod = 303,
        NotModified = 304,
        UseProxy = 305,
        Unused = 306,
        TemporaryRedirect = 307,
        RedirectKeepVerb = 307,

        //
        // Client Error 4xx
        //
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        RequestEntityTooLarge = 413,
        RequestUriTooLong = 414,
        UnsupportedMediaType = 415,
        RequestedRangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        UpgradeRequired = 426,

        //
        // Server Error 5xx
        //
        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HttpVersionNotSupported = 505,


        DuplicateKey = 601,
        DatabaseTimeOut = 602,
        DatabaseConflictKey = 603
    }

}
