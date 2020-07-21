using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class CodeCategoryData : EntityData<CodeCategory>
    {
        public CodeCategory Get(int codecategoryId)
        {
            LNTKEntities context = CreateContext();

            return context.CodeCategories.FirstOrDefault(a => a.CodeCategoryId == codecategoryId);
        }

    }
}
