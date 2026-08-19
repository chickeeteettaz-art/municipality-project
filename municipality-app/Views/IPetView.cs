using System;
using System.Collections.Generic;
using System.Text;

namespace municipality_app.Views
{
    public interface IPetView
    {

        string PetId { get; set; }
        string PetName { get; set; }
        string PetType {  get; set; }
        string PetColour {  get; set; }

        string searchValue { get; set; }
        bool isEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
