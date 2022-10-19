using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
     public class Cliente
    {
        #region Atributos

        private Guid _idCliente;
        private string _nome;
        private string _cpf;
        private string _email;

        #endregion

        #region propriedades

        public Guid IdCliente 
        {   
            get { return _idCliente; } 
            set 
            { 
                if(value == Guid.Empty) throw new ArgumentException("O ID do cliente é obrigatório.");

                _idCliente = value; 
            
            } 
        
        }
        public string Nome
        {
            get { return _nome; }
            set 
            {
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,150}$");

                if (!regex.IsMatch(value)) throw new ArgumentException("O Nome do cliente não é válido.");

                _nome = value;
            }
        }
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                var regex = new Regex("^[0-9]{11}$");

                if (!regex.IsMatch(value)) throw new ArgumentException("O CPF do cliente não é válido");

                _cpf = value;

            }
        }
        public string Email { 
            get { return _email; } 
            set 
            {
                var regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(value)) throw new ArgumentException("O email do cliente não é válido");

                _email = value;
            }
        }

        #endregion


    }
}
