using Xamarin.Forms;

namespace XamarinHelper
{
    public class DisableablePage : ContentPage
    {
        public static BindableProperty IsDisabledProperty = BindableProperty.Create(
            nameof(IsDisabled), typeof(bool), typeof(DisableablePage), default(bool), propertyChanged: OnIsDisabledPropertyChanged);

        public bool IsDisabled
        {
            get { return (bool)GetValue(IsDisabledProperty); }
            set { SetValue(IsDisabledProperty, value); }
        }

        private static void OnIsDisabledPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var content = ((ContentPage)bindable).Content;
            if (content == null)
                return;

            // do not disable Page.Content (top view) property
            BaseChangeNextChild(content, !(bool)newvalue);
        }

        #region private methods

        private static void ChangeNextChild(Element view, bool isEnabled)
        {
            // do not disable scroll
            var scrollView = view as ScrollView;
            if (scrollView == null)
                ChangeChild(view, isEnabled);

            BaseChangeNextChild(view, isEnabled);
        }

        private static void BaseChangeNextChild(Element view, bool isEnabled)
        {
            var layout = view as ILayoutController;
            if (layout == null)
                return;

            foreach (var child in layout.Children)
                ChangeNextChild(child, isEnabled);
        }

        private static void ChangeChild(Element view, bool isEnabled)
        {
            ((VisualElement)view).IsEnabled = isEnabled;
        }

        #endregion
    }
}
