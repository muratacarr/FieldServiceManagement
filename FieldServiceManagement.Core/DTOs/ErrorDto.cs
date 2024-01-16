using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class ErrorDto
    {
        public List<string> Errors { get; private set; }

        public bool IsShow { get; private set; }
        public ErrorDto() 
        {
            Errors = new List<string>();
        }
        public ErrorDto(string error, bool isShow)
        {
            if(Errors is null) Errors = new List<string>();
            Errors.Add(error);
            IsShow = isShow;
        }
        public ErrorDto(List<string> errors, bool isShow)
        {
            if (Errors is null) Errors = new List<string>();
            Errors = errors;
            IsShow = isShow;
        }
    }
}
