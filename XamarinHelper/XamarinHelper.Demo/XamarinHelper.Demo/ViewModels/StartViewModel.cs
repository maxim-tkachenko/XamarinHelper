using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHelper.Demo.Models;
using XamarinHelper.Demo.Pages;

namespace XamarinHelper.Demo.ViewModels
{
    class StartViewModel
    {
        public IEnumerable<PageName> Pages { get; set; }

        public ICommand ItemTappedCommand { get; }

        public StartViewModel()
        {
            Pages = GetType()
                .GetTypeInfo()
                .Assembly
                .DefinedTypes
                .Where(x => typeof(ContentPage).GetTypeInfo().IsAssignableFrom(x))
                .Select(x => new PageName(x.Name, x.FullName))
                .Where(x => x.ShortName != nameof(StartPage));

            ItemTappedCommand = new Command<PageName>(async typeName =>
            {
                var page = Activator.CreateInstance(Type.GetType(typeName.FullName)) as Page;
                await Application.Current.MainPage.Navigation.PushAsync(page);
            });
        }
    }
}
