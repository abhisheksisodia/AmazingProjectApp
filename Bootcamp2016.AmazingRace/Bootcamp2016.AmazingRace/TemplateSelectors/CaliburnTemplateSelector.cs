using System;
using System.Collections.Generic;
using Bootcamp2016.AmazingRace.ViewModels;
using Bootcamp2016.AmazingRace.Views;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.TemplateSelectors
{
    /// <summary>
    /// DataTemplateSelector that leverages Caliburn.Micro's viewModel -> view strategy
    /// </summary>
    public class CaliburnTemplateSelector : DataTemplateSelector
    {
        private readonly Dictionary<Type, DataTemplate> _selectorDict;

        public CaliburnTemplateSelector()
        {
            _selectorDict = new Dictionary<Type, DataTemplate>();
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Type vmType = item.GetType();

            DataTemplate dataTemplate;

            if (!_selectorDict.TryGetValue(vmType, out dataTemplate))
            {
                Type viewType = ViewLocator.LocateTypeForModelType(vmType, null, null);

                dataTemplate = new DataTemplate(viewType);

                _selectorDict.Add(vmType, dataTemplate);
            }

            return dataTemplate;
        }
    }
}
