﻿using System;
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
        public ErrorDto() { }
        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }
        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}