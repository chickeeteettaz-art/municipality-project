using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace municipality_app.Views
{
    public partial class PetView : Form,IPetView
    {
        public PetView()
        {
            InitializeComponent();
        }

        public string PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get;set; }
        public string PetColour { get; set; }
        public string searchValue { get; set; }
        public bool isEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            throw new NotImplementedException();
        }
    }
}
