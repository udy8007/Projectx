using System;
using System.Collections.Generic;
using System.Text;

namespace BA.DTO
{
    public class ResponseWithObject<T>
    {
        public string Status { get; set; }
        public T Response { get; set; }
        public List<ErrorDetails> Errors { get; set; }

        public ResponseWithObject()
        {
            Errors = new List<ErrorDetails>();
        }

        /// <summary>
        /// Use this constructor to initialize the API Response object for a success response
        /// </summary>
        /// <param name="status">Status of the API execution</param>
        /// <param name="response">Actual API response</param>
        public ResponseWithObject(string status, T response)
        {
            Status = status;
            Response = response;
            Errors = new List<ErrorDetails>();
        }

        /// <summary>
        /// Use this constructor to initialise the API Response object for an error response
        /// </summary>
        /// <param name="status">Status of the API execution</param>
        /// <param name="errors">List of errors encountered during API execution</param>
        public ResponseWithObject(string status, List<ErrorDetails> errors)
        {
            Status = status;
            Errors = errors;
        }
    }
    public class ErrorDetails
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ErrorType { get; set; }
    }
}
