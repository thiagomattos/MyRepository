using SQLite;
using System;

namespace CarWash3.Modelos
{
    public class CarWash
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }


        public override bool Equals(object obj)
        {
            return !(obj is CarWash carWash) ? false : Id.Equals(carWash.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Contains(String texto)
        {
            return Nome.ToLower().Contains(texto.ToLower()) || CPF.ToLower().Contains(texto.ToLower()) || Endereço.ToLower().Contains(texto.ToLower()) || Email.ToLower().Contains(texto.ToLower()) || Senha.ToLower().Contains(texto.ToLower());
        }
    }
}
