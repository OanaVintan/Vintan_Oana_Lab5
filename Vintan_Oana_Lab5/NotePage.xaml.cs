using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vintan_Oana_Lab5.Models;

namespace Vintan_Oana_Lab5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Agenda)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Agenda)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}