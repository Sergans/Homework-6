using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_2
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {

        }
        public ToDo(string title_1, bool IsDone_1)

        {
            Title = title_1;
            IsDone = IsDone_1;
        }
        public string Info()
        {

            return ($"{Title}{(IsDone ? "" : "[x]")}");
        }
    }
}
