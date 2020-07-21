﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class CodeData : EntityData<Code>
    {
        public Code Get(int codeId)
        {
            LNTKEntities context = CreateContext();

            return context.Codes.FirstOrDefault(a => a.CodeId == codeId);
        }

    }
}
