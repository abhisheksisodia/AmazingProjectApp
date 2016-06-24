using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    public class BaseScreen : Screen
    {

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(field,value))
            {
                field = value;
                NotifyOfPropertyChange(propertyName);
                return true;
            }
            return false;
        }
    }
}
