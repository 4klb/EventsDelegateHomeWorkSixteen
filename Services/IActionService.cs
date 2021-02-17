using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IActionService
    {
        public void ActionService<T>(params T[] values);
    }
}
