using System;
using System.Collections.Generic;

using Android.App;
using Android.Runtime;
using Caliburn.Micro;
using System.Reflection;
using Bootcamp2016.AmazingRace.Services;
using Bootcamp2016.AmazingRace.ViewModels;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.Droid
{
    public class Application : CaliburnApplication
    {
        private SimpleContainer _container;

        public Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();

            AppDomain appDomain = AppDomain.CurrentDomain;

            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Instance(_container);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[]
            {
                GetType().Assembly,
                typeof (DummyViewModel).Assembly
            };
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }
    }
}