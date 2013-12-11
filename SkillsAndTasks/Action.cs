using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasks
{
    interface Action
    {
        bool save();
        bool update();
        bool delete();
    }
}
