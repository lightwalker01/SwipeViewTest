using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PianistApp
{

    public partial class MainPage : ContentPage
    {
        public ICommand TestCommand { get; set; }

        #region Items   
        public static readonly BindableProperty ItemsProperty =
          BindableProperty.Create("Items", typeof(IList<string>), typeof(MainPage), null, propertyChanged: OnItemsChanged);

        public IList<string> Items
        {
            get { return (IList<string>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        static void OnItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // Property changed implementation goes here
        }
        #endregion


        public MainPage()
        {
            Items = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            TestCommand = new Command<string>(s => 
            { 
            });
            InitializeComponent();
        }
    }
}
