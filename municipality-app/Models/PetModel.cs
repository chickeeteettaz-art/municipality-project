using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace municipality_app.Models
{
    public class PetModel
    {
        private int id;
        private string name;
        private string type;
        private string colour;

        [DisplayName("Pet Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet name is required")]
        [StringLength(50)]
        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage ="Pet type is required")]
        public string Type
        {
            get { return type; }
            set {  type = value; }
        }

        [DisplayName("Colour")]

        public string Colour
        {
            get { return colour; }
            set {  colour = value; }
        }
    }
}
