using System;
using System.Collections.Generic;
using System.Text;

namespace municipality_app.Models
{
    public interface IPetRepository
    {
        void Add(PetModel pet);
        void Edit(PetModel pet);
        void Delete(int id);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue();
    }
}
